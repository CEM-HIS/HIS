using HistClinica.Data;
using HistClinica.DTO;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Repositories
{
    public class CitaRepository : ICitaRepository
    {
        private readonly ClinicaServiceContext _context;
        public CitaRepository(ClinicaServiceContext context)
        {
            _context = context;
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<bool> CitaExists(int? id)
        {
            return await _context.CITA.AnyAsync(e => e.idCita == id);
        }

        public async Task DeleteCita(int CitaID)
        {
            CITA Cita = await _context.CITA.FindAsync(CitaID);
            _context.CITA.Remove(Cita);
            await Save();
        }
        public async Task<string> InsertCita(CitaDTO Cita)
        {
            int idCita = 0;
            try
            {
                await _context.CITA.AddAsync(new CITA()
                {
                    idEmpleado = Cita.idEmpleado,
                    idPaciente = Cita.idPaciente,
                    idProgramacionMedica = Cita.idProgramacionMedica,
                    fechaCita = DateTime.Parse(Cita.fecha + " " + Cita.hora),
                    idtipoCita = Cita.idTipoCita,
                    idEstadoCita = (from ec in _context.ESTADO_CITA
                                    where ec.estado == "RESERVADO"
                                    select ec.idEstadoCita).FirstOrDefault(),
                    idConsultorio = (from cm in _context.CRONOGRAMA_MEDICO
                                     where cm.idProgramMedica == Cita.idProgramacionMedica
                                     select cm.idConsultorio).FirstOrDefault(),
                    idServicioClinica = Cita.idServicioClinica
                });
                await Save();
                idCita = (from c in _context.CITA
                          where c.idPaciente == Cita.idPaciente
                          && c.idProgramacionMedica == Cita.idProgramacionMedica
                          select c.idCita).FirstOrDefault();
                await _context.PAGO.AddAsync(new PAGO()
                {
                    monto = Cita.total,
                    fechaRegistro = DateTime.Now,
                    idCita = idCita, 
                    estado = "Pendiente"
                });
                await Save();
                return "Se registro cita correctamente";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task<string> AnularCita(int? CitaID,string motivoAnula)
        {
            try
            {
                CITA Cita = (from c in _context.CITA
                                  where c.idCita == CitaID
                                  select c).FirstOrDefault();
                Cita.idEstadoCita = (from ec in _context.ESTADO_CITA
                                     where ec.estado ==  "ANULADO"
                                     select ec.idEstadoCita).FirstOrDefault();
                Cita.motivoAnulacion = motivoAnula;
                _context.Update(Cita);
                await Save();
                return "Se anulo la cita correctamente";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task<string> ReprogramarCita(CitaDTO cita)
        {
            try
            {
                CITA Cita = (from c in _context.CITA
                                  where c.idCita == cita.idCita
                                  select c).FirstOrDefault();
                Cita.idProgramacionMedica = cita.idProgramacionMedica;
                Cita.fechaCita = DateTime.Parse(cita.fecha + " " + cita.hora);
                Cita.idEstadoCita = (from ec in _context.ESTADO_CITA
                                     where ec.estado == "REPROGRAMADO"
                                     select ec.idEstadoCita).FirstOrDefault();
                Cita.motivoReprogramacion = cita.motivoReprogramacion;
                _context.Update(Cita);
                await Save();
                return "Se reprogramo la cita de forma correcta";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.StackTrace;
            }
        }

        public async Task<List<CitaDTO>> GetAllCitas()
        {
            List<CitaDTO> Citas = await (from c in _context.CITA
                                           select new CitaDTO
                                           {
                                               idCita = c.idCita,
                                               numeroCita = c.numeroCita,
                                               idTipoCita = c.idtipoCita,
                                               TipoCita = (from tb in _context.TABLA_DETALLE
                                                           where tb.idTablaDetalle == c.idtipoCita
                                                           select tb.descripcion).FirstOrDefault(),
                                               fecha = (c.fechaCita).Value.Date.ToString(),
                                               hora = (c.fechaCita).Value.ToString("H:mm"),
                                               consultorio = (from de in _context.TABLA_DETALLE
                                                              where de.idTablaDetalle == c.idConsultorio
                                                              select de.descripcion).FirstOrDefault(),
                                               descripcion = (from sc in _context.TABLA_DETALLE
                                                              where sc.idTablaDetalle == c.idServicioClinica
                                                              select sc.descripcion).FirstOrDefault(),
                                               Medico = (from cm in _context.CRONOGRAMA_MEDICO
                                                         join m in _context.MEDICO on cm.idMedico equals m.idMedico
                                                         join p in _context.PERSONA on m.idPersona equals p.idPersona
                                                         where cm.idProgramMedica == c.idProgramacionMedica
                                                         select (p.nombres + " " + p.apellidoPaterno + " " + p.apellidoMaterno)).FirstOrDefault(),
                                               especialidad = (from tb in _context.TABLA_DETALLE
                                                               join cm in _context.CRONOGRAMA_MEDICO on c.idProgramacionMedica equals cm.idProgramMedica
                                                               join m in _context.MEDICO on cm.idMedico equals m.idMedico
                                                               where tb.idTablaDetalle == m.idEspecialidad
                                                               select tb.descripcion).FirstOrDefault(),
                                               precio = c.precio,
                                               igv = c.igv,
                                               descripcionEstado = (from ec in _context.ESTADO_CITA where ec.idEstadoCita == c.idEstadoCita select ec.estado).FirstOrDefault(),
                                               descripcionEstadoPago = (from ep in _context.PAGO
                                                                 where ep.idCita == c.idCita
                                                                 select ep.estado).FirstOrDefault(),
                                               nombrePaciente = (from pac in _context.PACIENTE
                                                                 join ci in _context.CITA on pac.idPaciente equals ci.idPaciente
                                                                 join per in _context.PERSONA on pac.idPersona equals per.idPersona
                                                                 where pac.idPaciente == ci.idPaciente
                                                                 select (per.nombres + " " + per.apellidoPaterno + " " + per.apellidoMaterno)).FirstOrDefault()
                                           }).ToListAsync();

            return Citas;
        }
        public async Task<CitaDTO> GetById(int? Id)
        {
            CitaDTO Cita = await (from c in _context.CITA
                                    where c.idCita == Id
                                  select new CitaDTO
                                  {
                                      idCita = c.idCita,
                                      numeroCita = c.numeroCita,
                                      idTipoCita = c.idtipoCita,
                                      TipoCita = (from tb in _context.TABLA_DETALLE
                                                  where tb.idTablaDetalle == c.idtipoCita
                                                  select tb.descripcion).FirstOrDefault(),
                                      fecha = (c.fechaCita).Value.Date.ToString(),
                                      hora = (c.fechaCita).Value.ToString("H:mm"),
                                      consultorio = (from de in _context.TABLA_DETALLE
                                                     where de.idTablaDetalle == c.idConsultorio
                                                     select de.descripcion).FirstOrDefault(),
                                      idProgramacionMedica = c.idProgramacionMedica,
                                      idServicioClinica = (from sc in _context.TABLA_DETALLE
                                                       where sc.idTablaDetalle == c.idServicioClinica
                                                       select sc.idTablaDetalle).FirstOrDefault(),
                                      descripcion = (from sc in _context.TABLA_DETALLE
                                                     where sc.idTablaDetalle == c.idServicioClinica
                                                     select sc.descripcion).FirstOrDefault(),
                                      idMedico = (from cm in _context.CRONOGRAMA_MEDICO
                                                  join m in _context.MEDICO on cm.idMedico equals m.idMedico
                                                  join p in _context.PERSONA on m.idPersona equals p.idPersona
                                                  where cm.idProgramMedica == c.idProgramacionMedica
                                                  select m.idMedico).FirstOrDefault(),
                                      Medico = (from cm in _context.CRONOGRAMA_MEDICO
                                                join m in _context.MEDICO on cm.idMedico equals m.idMedico
                                                join p in _context.PERSONA on m.idPersona equals p.idPersona
                                                where cm.idProgramMedica == c.idProgramacionMedica
                                                select (p.nombres + " " + p.apellidoPaterno + " " + p.apellidoMaterno)).FirstOrDefault(),
                                      idEspecialidad = (from tb in _context.TABLA_DETALLE
                                                        join cm in _context.CRONOGRAMA_MEDICO on c.idProgramacionMedica equals cm.idProgramMedica
                                                        join m in _context.MEDICO on cm.idMedico equals m.idMedico
                                                        where tb.idTablaDetalle == m.idEspecialidad
                                                        select tb.idTablaDetalle).FirstOrDefault(),
                                      especialidad = (from tb in _context.TABLA_DETALLE
                                                      join cm in _context.CRONOGRAMA_MEDICO on c.idProgramacionMedica equals cm.idProgramMedica
                                                      join m in _context.MEDICO on cm.idMedico equals m.idMedico
                                                      where tb.idTablaDetalle == m.idEspecialidad
                                                      select tb.descripcion).FirstOrDefault(),
                                      precio = c.precio,
                                      igv = c.igv,
                                      descripcionEstado = (from ec in _context.ESTADO_CITA where ec.idEstadoCita == c.idEstadoCita select ec.estado).FirstOrDefault(),
                                      descripcionEstadoPago = (from ep in _context.PAGO
                                                        where ep.idCita == c.idCita
                                                        select ep.estado).FirstOrDefault(),
                                      dniPaciente = (from pac in _context.PACIENTE join ci in _context.CITA on pac.idPaciente equals ci.idPaciente
                                                     join per in _context.PERSONA on pac.idPersona equals per.idPersona where pac.idPaciente == ci.idPaciente select per.dniPersona).FirstOrDefault(),
                                      nombrePaciente = (from pac in _context.PACIENTE
                                                        join ci in _context.CITA on pac.idPaciente equals ci.idPaciente
                                                        join per in _context.PERSONA on pac.idPersona equals per.idPersona
                                                        where pac.idPaciente == ci.idPaciente
                                                        select (per.nombres + " " + per.apellidoPaterno + " " + per.apellidoMaterno)).FirstOrDefault()
                                  }).FirstOrDefaultAsync();
            return Cita;
        }

        public async Task<string> CambiarEstadoCita(CitaDTO cita)
        {
            try
            {
                CITA Cita = (from c in _context.CITA
                                  where c.idCita == cita.idCita
                                  select c).FirstOrDefault();
                Cita.idEstadoCita = cita.idEstado;
                Cita.motivoReprogramacion = cita.motivoReprogramacion;
                _context.Update(Cita);
                await Save();
                return "Se cambio el estado de la cita de forma correcta";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.StackTrace;
            }
        }
    }
}
