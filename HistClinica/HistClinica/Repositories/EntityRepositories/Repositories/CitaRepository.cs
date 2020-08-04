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
            return await _context.T068_CITA.AnyAsync(e => e.idCita == id);
        }

        public async Task DeleteCita(int CitaID)
        {
            T068_CITA Cita = await _context.T068_CITA.FindAsync(CitaID);
            _context.T068_CITA.Remove(Cita);
            await Save();
        }
        public async Task<string> InsertCita(CitaDTO Cita)
        {
            int idCita = 0;
            try
            {
                await _context.T068_CITA.AddAsync(new T068_CITA()
                {
                    idEmpleado = Cita.idEmpleado,
                    idPaciente = Cita.idPaciente,
                    idProgramMedica = Cita.idProgramMedica,
                    fechaCita = DateTime.Parse(Cita.fecha + " " + Cita.hora),
                    tipoCita = Cita.idTipoCita,
                    estado = Cita.estado,
                    idEstadoCita = (from ec in _context.T109_ESTADOCITA
                                    where ec.estado == "RESERVADO"
                                    select ec.idEstadoCita).FirstOrDefault(),
                    idConsultorio = (from cm in _context.D012_CRONOMEDICO
                                     where cm.idProgramMedica == Cita.idProgramMedica
                                     select cm.idConsultorio).FirstOrDefault(),
                    idservicioCli = Cita.idServicioCli
                });
                await Save();
                idCita = (from c in _context.T068_CITA
                          where c.idPaciente == Cita.idPaciente
                          && c.idProgramMedica == Cita.idProgramMedica
                          select c.idCita).FirstOrDefault();
                await _context.D015_PAGO.AddAsync(new D015_PAGO()
                {
                    monto = Cita.total,
                    fecRegistro = DateTime.Now,
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
                T068_CITA Cita = (from c in _context.T068_CITA
                                  where c.idCita == CitaID
                                  select c).FirstOrDefault();
                Cita.idEstadoCita = (from ec in _context.T109_ESTADOCITA
                                     where ec.estado ==  "ANULADO"
                                     select ec.idEstadoCita).FirstOrDefault();
                Cita.motivoAnula = motivoAnula;
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
                T068_CITA Cita = (from c in _context.T068_CITA
                                  where c.idCita == cita.idCita
                                  select c).FirstOrDefault();
                Cita.idProgramMedica = cita.idProgramMedica;
                Cita.fechaCita = DateTime.Parse(cita.fecha + " " + cita.hora);
                Cita.idEstadoCita = (from ec in _context.T109_ESTADOCITA
                                     where ec.estado == "REPROGRAMADO"
                                     select ec.idEstadoCita).FirstOrDefault();
                Cita.motivoRepro = cita.motivoreprogramacion;
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
            List<CitaDTO> Citas = await (from c in _context.T068_CITA
                                           select new CitaDTO
                                           {
                                               idCita = c.idCita,
                                               nroCita = c.nroCita,
                                               idTipoCita = c.tipoCita,
                                               TipoCita = (from tb in _context.D00_TBDETALLE
                                                           where tb.idDet == c.tipoCita
                                                           select tb.descripcion).FirstOrDefault(),
                                               fecha = (c.fechaCita).Value.Date.ToString(),
                                               hora = (c.fechaCita).Value.ToString("H:mm"),
                                               consultorio = (from de in _context.D00_TBDETALLE
                                                              where de.idDet == c.idConsultorio
                                                              select de.descripcion).FirstOrDefault(),
                                               descripcion = (from sc in _context.D00_TBDETALLE
                                                              where sc.idDet == c.idservicioCli
                                                              select sc.descripcion).FirstOrDefault(),
                                               medico = (from cm in _context.D012_CRONOMEDICO
                                                         join m in _context.T212_MEDICO on cm.idMedico equals m.idMedico
                                                         join p in _context.T000_PERSONA on m.idPersona equals p.idPersona
                                                         where cm.idProgramMedica == c.idProgramMedica
                                                         select (p.nombres + " " + p.apePaterno + " " + p.apeMaterno)).FirstOrDefault(),
                                               especialidad = (from tb in _context.D00_TBDETALLE
                                                               join cm in _context.D012_CRONOMEDICO on c.idProgramMedica equals cm.idProgramMedica
                                                               join m in _context.T212_MEDICO on cm.idMedico equals m.idMedico
                                                               where tb.idDet == m.idEspecialidad
                                                               select tb.descripcion).FirstOrDefault(),
                                               precio = c.precio,
                                               igv = c.igv,
                                               descEstado = (from ec in _context.T109_ESTADOCITA where ec.idEstadoCita == c.idEstadoCita select ec.estado).FirstOrDefault(),
                                               descEstadoPago = (from ep in _context.D015_PAGO
                                                                 where ep.idCita == c.idCita
                                                                 select ep.estado).FirstOrDefault(),
                                               nombrePaciente = (from pac in _context.T001_PACIENTE
                                                                 join ci in _context.T068_CITA on pac.idPaciente equals ci.idPaciente
                                                                 join per in _context.T000_PERSONA on pac.idPersona equals per.idPersona
                                                                 where pac.idPaciente == ci.idPaciente
                                                                 select (per.nombres + " " + per.apePaterno + " " + per.apePaterno)).FirstOrDefault()
                                           }).ToListAsync();

            return Citas;
        }
        public async Task<CitaDTO> GetById(int? Id)
        {
            CitaDTO Cita = await (from c in _context.T068_CITA
                                    where c.idCita == Id
                                  select new CitaDTO
                                  {
                                      idCita = c.idCita,
                                      nroCita = c.nroCita,
                                      idTipoCita = c.tipoCita,
                                      TipoCita = (from tb in _context.D00_TBDETALLE
                                                  where tb.idDet == c.tipoCita
                                                  select tb.descripcion).FirstOrDefault(),
                                      fecha = (c.fechaCita).Value.Date.ToString(),
                                      hora = (c.fechaCita).Value.ToString("H:mm"),
                                      consultorio = (from de in _context.D00_TBDETALLE
                                                     where de.idDet == c.idConsultorio
                                                     select de.descripcion).FirstOrDefault(),
                                      idProgramMedica = c.idProgramMedica,
                                      idServicioCli = (from sc in _context.D00_TBDETALLE
                                                       where sc.idDet == c.idservicioCli
                                                       select sc.idDet).FirstOrDefault(),
                                      descripcion = (from sc in _context.D00_TBDETALLE
                                                     where sc.idDet == c.idservicioCli
                                                     select sc.descripcion).FirstOrDefault(),
                                      idmedico = (from cm in _context.D012_CRONOMEDICO
                                                  join m in _context.T212_MEDICO on cm.idMedico equals m.idMedico
                                                  join p in _context.T000_PERSONA on m.idPersona equals p.idPersona
                                                  where cm.idProgramMedica == c.idProgramMedica
                                                  select m.idMedico).FirstOrDefault(),
                                      medico = (from cm in _context.D012_CRONOMEDICO
                                                join m in _context.T212_MEDICO on cm.idMedico equals m.idMedico
                                                join p in _context.T000_PERSONA on m.idPersona equals p.idPersona
                                                where cm.idProgramMedica == c.idProgramMedica
                                                select (p.nombres + " " + p.apePaterno + " " + p.apeMaterno)).FirstOrDefault(),
                                      idEspecialidad = (from tb in _context.D00_TBDETALLE
                                                        join cm in _context.D012_CRONOMEDICO on c.idProgramMedica equals cm.idProgramMedica
                                                        join m in _context.T212_MEDICO on cm.idMedico equals m.idMedico
                                                        where tb.idDet == m.idEspecialidad
                                                        select tb.idDet).FirstOrDefault(),
                                      especialidad = (from tb in _context.D00_TBDETALLE
                                                      join cm in _context.D012_CRONOMEDICO on c.idProgramMedica equals cm.idProgramMedica
                                                      join m in _context.T212_MEDICO on cm.idMedico equals m.idMedico
                                                      where tb.idDet == m.idEspecialidad
                                                      select tb.descripcion).FirstOrDefault(),
                                      precio = c.precio,
                                      igv = c.igv,
                                      descEstado = (from ec in _context.T109_ESTADOCITA where ec.idEstadoCita == c.idEstadoCita select ec.estado).FirstOrDefault(),
                                      descEstadoPago = (from ep in _context.D015_PAGO
                                                        where ep.idCita == c.idCita
                                                        select ep.estado).FirstOrDefault(),
                                      dniPaciente = (from pac in _context.T001_PACIENTE join ci in _context.T068_CITA on pac.idPaciente equals ci.idPaciente
                                                     join per in _context.T000_PERSONA on pac.idPersona equals per.idPersona where pac.idPaciente == ci.idPaciente select per.dniPersona).FirstOrDefault(),
                                      nombrePaciente = (from pac in _context.T001_PACIENTE
                                                        join ci in _context.T068_CITA on pac.idPaciente equals ci.idPaciente
                                                        join per in _context.T000_PERSONA on pac.idPersona equals per.idPersona
                                                        where pac.idPaciente == ci.idPaciente
                                                        select (per.nombres + " " + per.apePaterno + " " + per.apePaterno)).FirstOrDefault()
                                  }).FirstOrDefaultAsync();
            return Cita;
        }

        public async Task<string> CambiarEstadoCita(CitaDTO cita)
        {
            try
            {
                T068_CITA Cita = (from c in _context.T068_CITA
                                  where c.idCita == cita.idCita
                                  select c).FirstOrDefault();
                Cita.idEstadoCita = cita.estado;
                Cita.motivoRepro = cita.motivoreprogramacion;
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
