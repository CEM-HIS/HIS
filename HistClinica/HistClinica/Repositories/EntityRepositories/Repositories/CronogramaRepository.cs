using HistClinica.Data;
using HistClinica.DTO;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Repositories
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
			D012_CRONOMEDICO D012_CRONOMEDICO = await _context.D012_CRONOMEDICO.FindAsync(CronoID);
			_context.D012_CRONOMEDICO.Remove(D012_CRONOMEDICO);
			await Save();
		}

		public async Task<List<CronogramaDTO>> GetAllCronogramas()
		{
			List<CronogramaDTO> D012_CRONOMEDICOs = await (	from c in _context.D012_CRONOMEDICO
															select new CronogramaDTO
															{
																idProgramMedica = c.idProgramMedica,
																fechaIni = c.fechaIni.Value.ToString("yyyy-MM-dd"),
																fechaFin = c.fechaFin.Value.ToString("yyyy-MM-dd"),
																hrInicio = c.hrInicio,
																hrFin = c.hrFin,
																desEstado = (from det in _context.D00_TBDETALLE
																			 where det.idDet == c.idEstado
																			 select det.descripcion).FirstOrDefault()
															}).ToListAsync();
			return D012_CRONOMEDICOs;
		}

		//guiate con esto y el interface? 
		public async Task<CronogramaDTO> GetByIdCrono(int CronoID)
		{
			CronogramaDTO D012_CRONOMEDICOs = await (from c in _context.D012_CRONOMEDICO
											  where c.idProgramMedica == CronoID
											  select new CronogramaDTO() { 
												  idConsultorio = c.idConsultorio,
												  idEspecialidad = c.idEspecialidad,
												  idEstado = c.idEstado,
												  idProgramMedica = c.idProgramMedica,
												  fechaIni = c.fechaIni.Value.ToString("yyyy-MM-dd"),
												  fechaFin = c.fechaFin.Value.ToString("yyyy-MM-dd"),
												  hrInicio = c.hrInicio,
												  hrFin = c.hrFin,
												  idMedico = c.idMedico
											  }).FirstOrDefaultAsync();
			return D012_CRONOMEDICOs;
		}

		public async Task<string> InsertCronograma(D012_CRONOMEDICO cronograma)
		{
			try
			{
				await _context.D012_CRONOMEDICO.AddAsync(new D012_CRONOMEDICO()
				{
					idEspecialidad = cronograma.idEspecialidad,
					idMedico = cronograma.idMedico,
					hrInicio = cronograma.hrInicio,
					hrFin = cronograma.hrFin,
					idConsultorio = cronograma.idConsultorio,
					fechaIni = cronograma.fechaIni,
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

		public async Task<string> UpdateCronograma(D012_CRONOMEDICO cronograma)
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
			List<CronogramaDTO> cronogramas = await (from c in _context.D012_CRONOMEDICO 
													 join td in _context.D00_TBDETALLE on c.idEstado equals td.idDet
													 join med in _context.T212_MEDICO on c.idMedico equals med.idMedico
													 join pe in _context.T000_PERSONA on med.idPersona equals pe.idPersona
													 where c.idMedico == idmedico
														select new CronogramaDTO {
															idProgramMedica = c.idProgramMedica,
															fechaIni = c.fechaIni.Value.ToString("yyyy-MM-dd"),
															fechaFin = c.fechaFin.Value.ToString("yyyy-MM-dd"),
															hrInicio = c.hrInicio,
															hrFin = c.hrFin,
															desEstado = td.descripcion,
															medico = pe.nombres + ' ' + pe.apePaterno + ' ' + pe.apeMaterno
														}
														).ToListAsync();
			return cronogramas;
		}

		public async Task<List<CronogramaDTO>> GetAllCronogramasConsulta()
		{
			List<CronogramaDTO> D012_CRONOMEDICOs = await(from c in _context.D012_CRONOMEDICO
														  join td in _context.D00_TBDETALLE on c.idEstado equals td.idDet join med in _context.T212_MEDICO 
														  on c.idMedico equals med.idMedico join pe in _context.T000_PERSONA on med.idPersona equals pe.idPersona
														  select new CronogramaDTO
														  {
															  idProgramMedica = c.idProgramMedica,
															  fechaIni = c.fechaIni.Value.ToString("yyyy-MM-dd"),
															  fechaFin = c.fechaFin.Value.ToString("yyyy-MM-dd"),
															  hrInicio = c.hrInicio,
															  hrFin = c.hrFin,
															  desEstado = td.descripcion,
															  medico = pe.nombres + ' ' + pe.apePaterno + ' ' + pe.apeMaterno
														  }).ToListAsync();
			return D012_CRONOMEDICOs;
		}
	}
}
