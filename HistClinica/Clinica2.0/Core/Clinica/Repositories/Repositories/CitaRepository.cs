using Clinica2._0.Data;
using Clinica2._0.DTO;
using Clinica2._0.Models;
using Clinica2._0.Repositories.EntityRepositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Clinica2._0.Repositories.EntityRepositories.Repositories
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
        public async Task<string> InsertCita(CitaDTO CitaDTO)
        {
            int idCita = 0;
            try
            {
                await _context.CITA.AddAsync(new CITA()
                {
                    idEmpleado = CitaDTO.idEmpleado,
                    idPaciente = CitaDTO.idPaciente,
                    idProgramacionMedica = CitaDTO.idProgramacionMedica,
                    fechaCita = DateTime.Parse(CitaDTO.fecha + " " + CitaDTO.hora),
                    idtipoCita = CitaDTO.idTipoCita,
                    idEstadoCita = (from ec in _context.ESTADO_CITA
                                    where ec.estado == "RESERVADO"
                                    select ec.idEstadoCita).FirstOrDefault(),
                    idConsultorio = (from cm in _context.CRONOGRAMA_MEDICO
                                     where cm.idProgramMedica == CitaDTO.idProgramacionMedica
                                     select cm.idConsultorio).FirstOrDefault(),
                    idServicioClinica = CitaDTO.idServicioClinica
                });
                await Save();
                idCita = (from c in _context.CITA
                          where c.idPaciente == CitaDTO.idPaciente
                          && c.idProgramacionMedica == CitaDTO.idProgramacionMedica
                          select c.idCita).FirstOrDefault();
                await _context.PAGO.AddAsync(new PAGO()
                {
                    monto = CitaDTO.total,
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
        public async Task<string> ReservaCupoCita(CitaDTO CitaDTO)
        {
            try
            {
                CITA Cita = (from c in _context.CITA
                             where c.idCita == CitaDTO.idCita
                             select c).FirstOrDefault();
                Cita.idPaciente = CitaDTO.idPaciente;
                Cita.observacion = CitaDTO.observacion;
                Cita.observacionAfiliacion = CitaDTO.observacionAfiliacion;

                _context.Update(Cita);
                await Save();
                return "Se reservo la cita correctamente";
            }
            catch(Exception ex)
            {
                return "Error en la reserva de la cita";
            }
        }
        public async Task<string> AnularCita(int? CitaID,string motivoAnula)
        {
            try
            {
                CitaDTO citaact = await GetById(CitaID);

                CITA citaactual = new CITA()
                {
                    idCita = citaact.idCita,
                    idPaciente = null,
                    fechaCita = DateTime.Parse(citaact.fecha + " " + citaact.hora),
                    numeroCita = null,
                    ultCie10 = null,
                    codigoCita = null,
                    idServicioClinica = null,
                    idConsultorio = citaact.idconsultorio,
                    idEstadoCita = 1175,
                    idEmpleado = null,
                    idTipoAtencion = null,
                    idtipoCita = null,
                    igv = null,
                    coa = null,
                    descripcion = null,
                    descuento = null,
                    ejecutado = null,
                    estadoReprogramacion = null,
                    fechaBaja = null,
                    motivoAnulacion = motivoAnula,
                    motivoReprogramacion = null,
                    numeroHC = null,
                    precio = null,
                    prioridad = null,
                };
                _context.Update(citaactual);
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

        //public List<FechaHora> ObtenerFechaHora(List<CRONOGRAMA_MEDICO> cronograma)
        //{
        //    int intervalofecha, intervalohora;
        //    List<FechaHora> fechas = new List<FechaHora>();

        //    foreach (var item in cronograma)
        //    {
        //        int horainicio = int.Parse(item.horaInicio.Split(":")[0]);
        //        int horafin = int.Parse(item.horaFin.Split(":")[0]);
        //        intervalofecha = item.fechaFin.Value.DayOfYear - item.fechaInicio.Value.DayOfYear;
        //        intervalohora = horafin - horainicio;
        //        for (int i = 0; i <= intervalofecha; i++)
        //        {
        //            for (int j = 0; j < intervalohora; j++)
        //            {
        //                fechas.Add(new FechaHora()
        //                {
        //                    fecha = item.fechaInicio.Value.AddDays(i).ToShortDateString(),
        //                    hora = (horainicio + j)
        //                });
        //            }
        //        }
        //    }
        //    return fechas;
        //}

        //public class FechaHora
        //{
        //    public string fecha { get; set; }
        //    public int hora { get; set; }
        //}

        //public async Task<List<CitaDTO>> GetCitas(int? id, int idespecialidad, string fechacro, List<CITA> fechasocupadas)
        //{
        //    string hora = "";
        //    List<FechaHora> horarios = new List<FechaHora>();
        //    CitaDTO cita = new CitaDTO();
        //    List<CitaDTO> citaDTOs = new List<CitaDTO>();
        //    DateTime fecha;
        //    List<CRONOGRAMA_MEDICO> cronograma = (from cro in _context.CRONOGRAMA_MEDICO
        //                                          where cro.idMedico == id && cro.idEspecialidad == idespecialidad
        //                                          select cro).ToList();
        //    horarios = ObtenerFechaHora(cronograma);
        //    string minutos;
        //    foreach (var item in cronograma)
        //    {
        //        for (int j = 0; j < horarios.Count; j++)
        //        {
        //            if (String.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(horarios[j].fecha)) == String.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(fechacro)))
        //            {
        //                int intervalo = 60 / item.intervalo;
        //                for (int i = 0; i <= intervalo; i++)
        //                {

        //                    if (i == 0 || i == intervalo)
        //                    {
        //                        minutos = "00";
        //                    }
        //                    else
        //                    {
        //                        minutos = (i * item.intervalo).ToString();
        //                    }
        //                    if (i != intervalo) hora = horarios[j].hora.ToString();
        //                    else hora = (horarios[j].hora + 1).ToString();
        //                    hora += ":" + minutos;
        //                    fecha = Convert.ToDateTime(horarios[j].fecha + " " + hora);
        //                    if (fechasocupadas.Any(c => c.fechaCita == fecha))
        //                    {
        //                        cita = await GetById(fechasocupadas.Find(c => c.fechaCita == fecha).idCita);
        //                    }
        //                    else
        //                    {
        //                        cita = new CitaDTO()
        //                        {
        //                            fecha = horarios[j].fecha,
        //                            hora = hora,
        //                            consultorio = (from de in _context.TABLA_DETALLE
        //                                           where de.idTablaDetalle == item.idConsultorio
        //                                           select de.descripcion).FirstOrDefault(),
        //                            Medico = (from med in _context.MEDICO
        //                                      join per in _context.PERSONA on med.idPersona equals per.idPersona
        //                                      where med.idMedico == item.idMedico
        //                                      select (per.nombres + " " + per.apellidoPaterno + per.apellidoMaterno)).FirstOrDefault(),
        //                            CMP = (from med in _context.MEDICO where med.idMedico == item.idMedico select med.numeroColegio).FirstOrDefault()
        //                        };
        //                    }
        //                    citaDTOs.Add(cita);
        //                }
        //            }

        //        }
        //    }

        //    return citaDTOs;
        //}

        public async Task<List<CitaDTO>> GetAllCitas(int idmedico, int idespecialidad, string fecha)
        {
            List<CitaDTO> Citas = await (from c in _context.CITA join cro in _context.CRONOGRAMA_MEDICO on c.idProgramacionMedica equals cro.idProgramMedica
                                         where cro.idMedico == idmedico || cro.idEspecialidad == idespecialidad || c.fechaCita.Value.Date.ToString() == fecha
                                      //select c
                                      select new CitaDTO()
                                      {
                                          idCita = c.idCita,
                                          fecha = (c.fechaCita).Value.Date.ToString(),
                                          hora = (c.fechaCita).Value.ToString("H:mm"),
                                          consultorio = (from de in _context.TABLA_DETALLE
                                                         where de.idTablaDetalle == c.idConsultorio
                                                         select de.descripcion).FirstOrDefault(),
                                          Medico = (from cm in _context.CRONOGRAMA_MEDICO
                                                    join m in _context.MEDICO on cm.idMedico equals m.idMedico
                                                    join p in _context.PERSONA on m.idPersona equals p.idPersona
                                                    where cm.idProgramMedica == c.idProgramacionMedica
                                                    select (p.nombres + " " + p.apellidoPaterno + " " + p.apellidoMaterno)).FirstOrDefault(),
                                          nombrePaciente = (from pac in _context.PACIENTE
                                                            join per in _context.PERSONA on pac.idPersona equals per.idPersona
                                                            where pac.idPaciente == c.idPaciente
                                                            select (per.nombres + " " + per.apellidoPaterno + " " + per.apellidoMaterno)).FirstOrDefault(),
                                          CMP = (from cm in _context.CRONOGRAMA_MEDICO
                                                 join m in _context.MEDICO on cm.idMedico equals m.idMedico
                                                 where cm.idProgramMedica == c.idProgramacionMedica
                                                 select m.numeroColegio).FirstOrDefault(),
                                          horaregistro = c.horaregistro,
                                          numeroorden = c.nroorden,
                                          cuenta = c.cuenta,
                                          numeroHc = c.numeroHC,
                                          descripcionEstado = (from de in _context.TABLA_DETALLE
                                                               where de.idTablaDetalle == c.idEstadoCita
                                                               select de.descripcion).FirstOrDefault()
                                      }
                                        ).ToListAsync();
            //return await GetCitas(idmedico, idespecialidad, fecha, Citas);
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
                                      idconsultorio = (from de in _context.TABLA_DETALLE
                                                     where de.idTablaDetalle == c.idConsultorio
                                                     select de.idTablaDetalle).FirstOrDefault(),
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
                                                        select (per.nombres + " " + per.apellidoPaterno + " " + per.apellidoMaterno)).FirstOrDefault(),
                                      idPaciente = (from pac in _context.PACIENTE
                                                    join ci in _context.CITA on pac.idPaciente equals ci.idPaciente
                                                    join per in _context.PERSONA on pac.idPersona equals per.idPersona
                                                    where pac.idPaciente == ci.idPaciente
                                                    select pac.idPaciente).FirstOrDefault(),
                                      CMP = (from cm in _context.CRONOGRAMA_MEDICO
                                             join m in _context.MEDICO on cm.idMedico equals m.idMedico
                                             where cm.idProgramMedica == c.idProgramacionMedica
                                             select m.numeroColegio).FirstOrDefault(),
                                    //  idPaciente = c.idPaciente,
                                      observacion = c.observacion,
                                      observacionAfiliacion = c.observacionAfiliacion,
                                      horaregistro = c.horaregistro,
                                      cuenta = c.cuenta,
                                      numeroorden = c.nroorden,
                                      numeroHc = c.numeroHC
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

        public async Task<string> UpdateCita(CitaDTO model)
        {
            try
            {
                CITA cita = new CITA()
                {
                    idCita = model.idCita,
                    idPaciente = model.idPaciente,
                    fechaCita = DateTime.Parse(model.fecha + " " + model.hora),
                    numeroCita = model.numeroCita,
                    ultCie10 = null,
                    codigoCita = null,
                    idServicioClinica = null,
                    idConsultorio = model.idconsultorio,
                    idEstadoCita = 1174,
                    idProgramacionMedica = model.idProgramacionMedica,
                    idEmpleado = model.idEmpleado,
                    idTipoAtencion = null,
                    idtipoCita = model.idTipoCita,
                    igv = null,
                    coa = null,
                    descripcion = null,
                    descuento = null,
                    ejecutado = null,
                    estadoReprogramacion = null,
                    fechaBaja = null,
                    motivoAnulacion = null,
                    motivoReprogramacion = null,
                    numeroHC = model.numeroHc,
                    precio = null,
                    prioridad = null,
                    horaregistro = DateTime.Now.ToString("hh:mm:ss"),
                    nroorden = string.Format("{0:000011}", model.idCita),
                    cuenta = string.Format("{0:000001}", model.idCita)
                };
                _context.Update(cita);
                await Save();
                return "Se registro cita correctamente";
            }
            catch (Exception ex)
            {
                return "Error al guardado" + ex.InnerException.Message;
            }
        }

        public async Task<string> ReprogramarCupo(int paciente,CitaDTO citaahora, CitaDTO cita, int idcitaactual)
        {
            try
            {
                CITA nuevacita = new CITA()
                {
                    idCita = idcitaactual,
                    idPaciente = cita.idPaciente,
                    fechaCita = DateTime.Parse(citaahora.fecha + " " + citaahora.hora),
                    numeroCita = null,
                    ultCie10 = null,
                    codigoCita = null,
                    idServicioClinica = null,
                    idConsultorio = cita.idconsultorio,
                    idEstadoCita = 1176,
                    idProgramacionMedica = cita.idProgramacionMedica,
                    idEmpleado = cita.idEmpleado,
                    idTipoAtencion = null,
                    idtipoCita = null,
                    igv = null,
                    coa = null,
                    descripcion = null,
                    descuento = null,
                    ejecutado = null,
                    estadoReprogramacion = null,
                    fechaBaja = null,
                    motivoAnulacion = null,
                    motivoReprogramacion = null,
                    numeroHC = cita.numeroHc,
                    precio = null,
                    prioridad = null,
                    horaregistro = DateTime.Now.ToString("hh:mm:ss"),
                    nroorden = cita.numeroorden,
                    cuenta = cita.cuenta
                };
                _context.Update(nuevacita);
                await Save();

                CitaDTO citaact = await GetById(cita.idCita);
                CITA citaactual = new CITA()
                {
                    idCita = citaact.idCita,
                    idPaciente = null,
                    fechaCita = DateTime.Parse(citaact.fecha + " " + citaact.hora),
                    numeroCita = null,
                    ultCie10 = null,
                    codigoCita = null,
                    idServicioClinica = null,
                    idConsultorio = citaact.idconsultorio,
                    idEstadoCita = null,
                    idProgramacionMedica = citaact.idProgramacionMedica,
                    idEmpleado = citaact.idEmpleado,
                    idTipoAtencion = null,
                    idtipoCita = null,
                    igv = null,
                    coa = null,
                    descripcion = null,
                    descuento = null,
                    ejecutado = null,
                    estadoReprogramacion = null,
                    fechaBaja = null,
                    motivoAnulacion = null,
                    motivoReprogramacion = null,
                    numeroHC = null,
                    precio = null,
                    prioridad = null,
                    horaregistro = null,
                    nroorden = null,
                    cuenta = null
                };
                _context.Update(citaactual);
                await Save();


                return "Se reprogramo la cita correctamente";
            }
            catch (Exception ex)
            {
                return "Error al reprogramar" + ex.StackTrace;
            }
        }
        public async Task<List<ESTADO_CITA>> getEstadoCita()
        {

            List<ESTADO_CITA> estado = await (from e in _context.ESTADO_CITA
                                              select e).ToListAsync();
            return estado;
        }
    }
}
