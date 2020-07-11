using Clinica2._0.Data;
using Clinica2._0.DTO;
using Clinica2._0.Models;
using Clinica2._0.Repositories.EntityRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Repositories.EntityRepositories.Repositories
{

	public class LicenciaRepository: ILicenciaRepository

	{
		private readonly ClinicaServiceContext _context;

		public LicenciaRepository(ClinicaServiceContext contexto)
		{
			_context = contexto;
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

		public async Task<string> insertLicencia(LICENCIA licencia)
		{
			try
			{

				await _context.LICENCIA.AddAsync(new LICENCIA() { 
					horaInicio = licencia.horaInicio,
					horaFin = licencia.horaFin,
					fechaInicio = licencia.fechaInicio,
					fechaFin = licencia.fechaFin,
					idMedico = licencia.idMedico,
					idEstado = 1
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
	}
}
