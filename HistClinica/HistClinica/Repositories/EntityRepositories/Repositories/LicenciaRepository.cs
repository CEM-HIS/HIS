using HistClinica.Data;
using HistClinica.Models;
using HistClinica.Repositories.EntityRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.EntityRepositories.Repositories
{
	public class LicenciaRepository: ILicenciaRepository
	{
		private readonly ClinicaServiceContext _context;

		public LicenciaRepository(ClinicaServiceContext contexto)
		{
			_context = contexto;
		}

		public async Task<List<LICENCIA>> getAll()
		{
			List<LICENCIA> licencia = await (from l in _context.LICENCIA
											 select l).ToListAsync();
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
