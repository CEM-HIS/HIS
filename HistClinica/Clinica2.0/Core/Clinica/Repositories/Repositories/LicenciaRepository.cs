using Clinica2._0.Data;
using Clinica2._0.DTO;
using Clinica2._0.Models;
using Clinica2._0.Repositories.EntityRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.EntityRepositories.Repositories
{
	public class LicenciaRepository : ILicenciaRepository
	{
		private readonly ClinicaServiceContext _context;

		public LicenciaRepository(ClinicaServiceContext contexto)
		{
			_context = contexto;
		}

		public async Task<string> deleteLicencia(LICENCIA modelo)
		{
			try
			{
				LICENCIA licencia = await _context.LICENCIA.FindAsync(modelo.idLicencia);
				_context.LICENCIA.Remove(licencia);
				await Save();
				return "Se anulo la licencia correctamente";
			}
			catch (Exception ex)
			{
				return "Error al anular" + ex.Message;
			}
		}

		public async Task<List<licenciaDTO>> getAll()
		{
			List<licenciaDTO> licencia = await (from l in _context.LICENCIA	
												join det in _context.TABLA_DETALLE on l.idEstado equals det.idTablaDetalle
												join med in _context.MEDICO on l.idMedico equals med.idMedico
												join per in _context.PERSONA on med.idPersona equals per.idPersona
												select new licenciaDTO
												{
													idLicencia = l.idLicencia,
													fechaIni = l.fechaInicio.Value.ToShortDateString(),
													fechaFin = l.fechaFin.Value.ToShortDateString(),
													estado = det.descripcion,
													medico = per.nombres + " " + per.apellidoPaterno + " " + per.apellidoMaterno
												}).ToListAsync();
			return licencia;
		}

		public async Task<LICENCIA> getLicencia(int id)
		{
			LICENCIA licencia = await (from l in _context.LICENCIA where l.idLicencia == id select l).FirstOrDefaultAsync();
			return licencia;
		}

		public async Task<string> insertLicencia(LICENCIA licencia)
		{
			try
			{
				await _context.LICENCIA.AddAsync(new LICENCIA()
				{
					horaInicio = licencia.horaInicio,
					horaFin = licencia.horaFin,
					fechaInicio = licencia.fechaInicio,
					fechaFin = licencia.fechaFin,
					idMedico = licencia.idMedico,
					idEstado = 1171
				});
				await Save();
				return "Se registro licencia correctamente";
			}
			catch (Exception ex)
			{

				return "Error en el guardado" + ex.Message;
			}
		}

		public async Task Save()
		{
			await _context.SaveChangesAsync();
		}

		public async Task<string> updateLicencia(LICENCIA licencia)
		{
			try
			{
				_context.Entry(licencia).State = EntityState.Modified;
				await Save();
				return "Actualizacion exitosa";
			}
			catch (Exception ex)
			{
				return "Error al actualizar" + ex.Message;
			}
		}
	}
}
