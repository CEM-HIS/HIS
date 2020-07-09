using HistClinica.Data;
using HistClinica.DTO;
using HistClinica.Models;
using HistClinica.Repositories.EntityRepositories.Interfaces;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace HistClinica.Repositories.EntityRepositories.Repositories
{
	public class CronogramaRepository : ICronogramaRepository
	{
		private readonly ClinicaServiceContext _context;

		public CronogramaRepository(ClinicaServiceContext clinicaService)
		{
			_context = clinicaService;
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
			List<CronogramaDTO> D012_CRONOMEDICOs = await (	from c in _context.CRONOGRAMA_MEDICO
															select new CronogramaDTO
															{
																idProgramMedica = c.idProgramMedica,
																fechaInicio = c.fechaInicio.Value.ToString("yyyy-MM-dd"),
																fechaFin = c.fechaFin.Value.ToString("yyyy-MM-dd"),
																horaInicio = c.horaInicio,
																horaFin = c.horaFin,
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
												  idMedico = c.idMedico
											  }).FirstOrDefaultAsync();
			return D012_CRONOMEDICOs;
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
					idEstado = 171
				});
				await Save();
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

		public async Task<List<CronogramaDTO>> GetCronogramaByMedico(int idmedico)
		{
			List<CronogramaDTO> cronogramas = await (from c in _context.CRONOGRAMA_MEDICO 
													 join td in _context.TABLA_DETALLE on c.idEstado equals td.idTablaDetalle
													 join med in _context.MEDICO on c.idMedico equals med.idMedico
													 join pe in _context.PERSONA on med.idPersona equals pe.idPersona
													 where c.idMedico == idmedico
														select new CronogramaDTO {
															idProgramMedica = c.idProgramMedica,
															fechaInicio = c.fechaInicio.Value.ToString("yyyy-MM-dd"),
															fechaFin = c.fechaFin.Value.ToString("yyyy-MM-dd"),
															horaInicio = c.horaInicio,
															horaFin = c.horaFin,
															descripcionEstado = td.descripcion,
															medico = pe.nombres + ' ' + pe.apellidoPaterno + ' ' + pe.apellidoMaterno
														}
														).ToListAsync();
			return cronogramas;
		}

		public async Task<List<CronogramaDTO>> GetAllCronogramasConsulta()
		{
			List<CronogramaDTO> D012_CRONOMEDICOs = await(from c in _context.CRONOGRAMA_MEDICO
														  join td in _context.TABLA_DETALLE on c.idEstado equals td.idTablaDetalle join med in _context.MEDICO 
														  on c.idMedico equals med.idMedico join pe in _context.PERSONA on med.idPersona equals pe.idPersona
														  select new CronogramaDTO
														  {
															  idProgramMedica = c.idProgramMedica,
															  fechaInicio = c.fechaInicio.Value.ToString("yyyy-MM-dd"),
															  fechaFin = c.fechaFin.Value.ToString("yyyy-MM-dd"),
															  horaInicio = c.horaInicio,
															  horaFin = c.horaFin,
															  descripcionEstado = td.descripcion,
															  medico = pe.nombres + ' ' + pe.apellidoPaterno + ' ' + pe.apellidoMaterno
														  }).ToListAsync();
			return D012_CRONOMEDICOs;
		}
	}
}
