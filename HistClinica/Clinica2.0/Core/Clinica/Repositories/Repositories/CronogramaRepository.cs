using Clinica2._0.Data;
using Clinica2._0.DTO;
using Clinica2._0.Models;
using Clinica2._0.Repositories.EntityRepositories.Interfaces;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Repositories.Repositories
{
	public class CronogramaRepository : ICronogramaRepository
	{
		private readonly ClinicaServiceContext _context;
		private readonly ICitaRepository _citaRepository;

		public CronogramaRepository(ClinicaServiceContext clinicaService, ICitaRepository citaRepository)
		{
			_context = clinicaService;
			_citaRepository = citaRepository;
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

		public async Task DeleteCronograma(int? CronoID)
		{
			CRONOGRAMA_MEDICO CRONOGRAMA_MEDICO = await _context.CRONOGRAMA_MEDICO.FindAsync(CronoID);
			_context.CRONOGRAMA_MEDICO.Remove(CRONOGRAMA_MEDICO);
			await Save();
		}

		public async Task<List<CronogramaDTO>> GetAllCronogramas()
		{
			List<CronogramaDTO> D012_CRONOMEDICOs = await (	from c in _context.CRONOGRAMA_MEDICO join med in _context.MEDICO
															on c.idMedico equals med.idMedico join per in _context.PERSONA on med.idPersona
															equals per.idPersona
															select new CronogramaDTO
															{
																idProgramMedica = c.idProgramMedica,
																fechaInicio = c.fechaInicio.Value.ToString("yyyy-MM-dd"),
																fechaFin = c.fechaFin.Value.ToString("yyyy-MM-dd"),
																horaInicio = c.horaInicio,
																horaFin = c.horaFin,
																intervalo = c.intervalo,
																medico = per.nombres + " " + per.apellidoPaterno + " " + per.apellidoMaterno,
																cmp = med.numeroColegio,
																descripcionEstado = (from det in _context.TABLA_DETALLE
																			 where det.idTablaDetalle == c.idEstado
																			 select det.descripcion).FirstOrDefault()
															}).ToListAsync();
			return D012_CRONOMEDICOs;
		}

		//guiate con esto y el interface? 
		public async Task<CronogramaDTO> GetByIdCrono(int CronoID)
		{
			CronogramaDTO D012_CRONOMEDICOs = await (from c in _context.CRONOGRAMA_MEDICO
											  where c.idProgramMedica == CronoID
											  select new CronogramaDTO() { 
												  idConsultorio = c.idConsultorio,
												  idEspecialidad = c.idEspecialidad,
												  idEstado = c.idEstado,
												  idProgramMedica = c.idProgramMedica,
												  fechaInicio = c.fechaInicio.Value.ToString("yyyy-MM-dd"),
												  fechaFin = c.fechaFin.Value.ToString("yyyy-MM-dd"),
												  horaInicio = c.horaInicio,
												  horaFin = c.horaFin,
												  intervalo = c.intervalo,
												  idMedico = c.idMedico
											  }).FirstOrDefaultAsync();
			return D012_CRONOMEDICOs;
		}

		public List<FechaHora> ObtenerFechaHora(List<CRONOGRAMA_MEDICO> cronograma)
		{
			int intervalofecha, intervalohora;
			List<FechaHora> fechas = new List<FechaHora>();

			foreach (var item in cronograma)
			{
				int horainicio = int.Parse(item.horaInicio.Split(":")[0]);
				int horafin = int.Parse(item.horaFin.Split(":")[0]);
				intervalofecha = item.fechaFin.Value.DayOfYear - item.fechaInicio.Value.DayOfYear;
				intervalohora = horafin - horainicio;
				for (int i = 0; i <= intervalofecha; i++)
				{
					for (int j = 0; j < intervalohora; j++)
					{
						fechas.Add(new FechaHora()
						{
							fecha = item.fechaInicio.Value.AddDays(i).ToShortDateString(),
							hora = (horainicio + j)
						});
					}
				}
			}
			return fechas;
		}

		public class FechaHora
		{
			public string fecha { get; set; }
			public int hora { get; set; }
		}

        public List<CitaDTO> GetCitas(int? id, int? idespecialidad,DateTime? fechaInicio
			//,string fechacro List<CITA> fechasocupadas
			)
        {
            string hora = "";
            List<FechaHora> horarios = new List<FechaHora>();
            CitaDTO cita = new CitaDTO();
            List<CitaDTO> citaDTOs = new List<CitaDTO>();
            DateTime fecha;
            List<CRONOGRAMA_MEDICO> cronograma = (from cro in _context.CRONOGRAMA_MEDICO
                                                  where cro.idMedico == id && cro.idEspecialidad == idespecialidad && cro.fechaInicio == fechaInicio
                                                  select cro).ToList();
            horarios = ObtenerFechaHora(cronograma);
            string minutos;
            foreach (var item in cronograma)
            {
                for (int j = 0; j < horarios.Count; j++)
                {
                    //if (String.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(horarios[j].fecha)) == String.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(fechacro)))
                    //{
                    int intervalo = 60 / item.intervalo;
                    for (int i = 0; i < intervalo; i++)
                    {

                        if (i == 0 || i == intervalo)
                        {
                            minutos = "00";
                        }
                        else
                        {
                            minutos = (i * item.intervalo).ToString();
                        }
                        //if (i != intervalo) 
							hora = horarios[j].hora.ToString();
                        //else hora = (horarios[j].hora + 1).ToString();
                        hora += ":" + minutos;
                        fecha = Convert.ToDateTime(horarios[j].fecha + " " + hora);
                        //if (fechasocupadas.Any(c => c.fechaCita == fecha))
                        //{
                        //	cita = await GetById(fechasocupadas.Find(c => c.fechaCita == fecha).idCita);
                        //}
                        //else
                        //{
                        cita = new CitaDTO()
                        {
                            fecha = horarios[j].fecha,
                            hora = hora,
                            consultorio = (from de in _context.TABLA_DETALLE
                                           where de.idTablaDetalle == item.idConsultorio
                                           select de.descripcion).FirstOrDefault(),
                            Medico = (from med in _context.MEDICO
                                      join per in _context.PERSONA on med.idPersona equals per.idPersona
                                      where med.idMedico == item.idMedico
                                      select (per.nombres + " " + per.apellidoPaterno + per.apellidoMaterno)).FirstOrDefault(),
							idProgramacionMedica = item.idProgramMedica,
                            CMP = (from med in _context.MEDICO where med.idMedico == item.idMedico select med.numeroColegio).FirstOrDefault()
                        };
                        //}
                        citaDTOs.Add(cita);
                    }
                    //}
                }
            }

            return citaDTOs;
        }

        public async Task<string> InsertCronograma(CRONOGRAMA_MEDICO cronograma)
		{
			try
			{
				await _context.CRONOGRAMA_MEDICO.AddAsync(new CRONOGRAMA_MEDICO()
				{
					idEspecialidad = cronograma.idEspecialidad,
					idMedico = cronograma.idMedico,
					horaInicio = cronograma.horaInicio,
					horaFin = cronograma.horaFin,
					idConsultorio = cronograma.idConsultorio,
					fechaInicio = cronograma.fechaInicio,
					fechaFin = cronograma.fechaFin,
					intervalo = cronograma.intervalo,
					idEstado = 171
				});
				await Save();
                foreach (var item in GetCitas(cronograma.idMedico, cronograma.idEspecialidad,cronograma.fechaInicio))
                {
					await _citaRepository.InsertCita(item);
				}
				return "Ingreso exitoso";
			}
			catch (Exception ex)
			{
				return "Error en el guardado " + ex.StackTrace;
			}
		}

		public async Task Save()
		{
			await _context.SaveChangesAsync();
		}

		public async Task<string> UpdateCronograma(CRONOGRAMA_MEDICO cronograma)
		{
			try
			{
				_context.Entry(cronograma).State = EntityState.Modified;
				await Save();
				return "Actualizacion exitosa";
			}
			catch (Exception ex)
			{
				return "Error en el guardado " + ex.Message;
			}
		}

		public async Task<List<CronogramaDTO>> GetCronogramaByMedico(string nombre,string apellido, int especialidad)
		{
			List<CronogramaDTO> cronogramas = await (from c in _context.CRONOGRAMA_MEDICO 
													 join td in _context.TABLA_DETALLE on c.idEstado equals td.idTablaDetalle
													 join tde in _context.TABLA_DETALLE on c.idEspecialidad equals tde.idTablaDetalle
													 join med in _context.MEDICO on c.idMedico equals med.idMedico
													 join pe in _context.PERSONA on med.idPersona equals pe.idPersona
													 where pe.nombres.Contains(nombre) || pe.apellidoPaterno.Contains(apellido) || tde.idTablaDetalle == especialidad
														select new CronogramaDTO {
															idProgramMedica = c.idProgramMedica,
															fechaInicio = c.fechaInicio.Value.ToString("yyyy-MM-dd"),
															fechaFin = c.fechaFin.Value.ToString("yyyy-MM-dd"),
															horaInicio = c.horaInicio,
															horaFin = c.horaFin,
															descripcionEstado = td.descripcion,
															medico = pe.nombres + ' ' + pe.apellidoPaterno + ' ' + pe.apellidoMaterno,
															especialidad = tde.descripcion
														}
														).ToListAsync();
			return cronogramas;
		}

		public async Task<List<CronogramaDTO>> GetAllCronogramasConsulta()
		{
			List<CronogramaDTO> D012_CRONOMEDICOs = await(from c in _context.CRONOGRAMA_MEDICO
														  join td in _context.TABLA_DETALLE on c.idEstado equals td.idTablaDetalle join med in _context.MEDICO 
														  on c.idMedico equals med.idMedico join pe in _context.PERSONA on med.idPersona equals pe.idPersona
														  join tde in _context.TABLA_DETALLE on c.idEspecialidad equals tde.idTablaDetalle
														  select new CronogramaDTO
														  {
															  idProgramMedica = c.idProgramMedica,
															  fechaInicio = c.fechaInicio.Value.ToString("yyyy-MM-dd"),
															  fechaFin = c.fechaFin.Value.ToString("yyyy-MM-dd"),
															  horaInicio = c.horaInicio,
															  horaFin = c.horaFin,
															  descripcionEstado = td.descripcion,
															  medico = pe.nombres + ' ' + pe.apellidoPaterno + ' ' + pe.apellidoMaterno,
															  especialidad = tde.descripcion
														  }).ToListAsync();
			return D012_CRONOMEDICOs;
		}
		public async Task<object> GetCronogramaByMedico(int id)
		{
			List<CRONOGRAMA_MEDICO> cronograma = await (from cro in _context.CRONOGRAMA_MEDICO
														join med in _context.MEDICO on cro.idMedico equals med.idMedico
														where med.idMedico == id
														select cro).ToListAsync();
			return ObtenerFechaHora(cronograma);
		}
	}
}
