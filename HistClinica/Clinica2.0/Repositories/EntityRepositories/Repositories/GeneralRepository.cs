using Clinica2._0.Data;
using Clinica2._0.Models;
using Clinica2._0.Repositories.EntityRepositories.Interfaces;
using HistClinica.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Clinica2._0.Repositories.EntityRepositories.Repositories
{
	public class GeneralRepository : IGeneralRepository
	{
		private readonly ClinicaServiceContext _context;

		public GeneralRepository(ClinicaServiceContext context)
		{
			_context = context;
		}
		public async Task<string> DeleteGeneral(TABLA_GENERAL modelo)
		{
			try
			{
				TABLA_GENERAL general = await _context.TABLA_GENERAL.FindAsync(modelo.idTablaGeneral);
				_context.TABLA_GENERAL.Remove(general);
				await Save();
				return "Registro eliminado correctamente";
			}
			catch (Exception ex)
			{
				return "Error al eliminar" + ex.Message;
			}
		}

		public async Task<bool> GeneralExists(int? id)
		{
			return await _context.TABLA_GENERAL.AnyAsync(e => e.idTablaGeneral == id);
		}

		public async Task<List<TABLA_GENERAL>> GetAllGeneral()
		{

			List<TABLA_GENERAL> general = await (from g in _context.TABLA_GENERAL
										   select g).ToListAsync();
			return general;
		}

		public async Task<List<TABLA_GENERAL>> GetByCodigo(string codigo,string descripcion)
		{
			List<TABLA_GENERAL> general = new List<TABLA_GENERAL>();
			try
			{
				 general = await (from p in _context.TABLA_GENERAL
													 where p.codigoTablaGeneral == codigo || p.descripcion.Contains(descripcion)
													 select p).ToListAsync();
			}
			catch (Exception ex)
			{
				var msj = ex.Message;
				throw;
			}
			return general;
		}

		public async Task<TABLA_GENERAL> GetById(int? id)
		{

			TABLA_GENERAL general = await (from p in _context.TABLA_GENERAL
										   where p.idTablaGeneral == id
										   select p).FirstOrDefaultAsync();
			return general;
		}

		public async Task<string> InsertGeneral(TABLA_GENERAL general)
		{
			try
			{
				await _context.TABLA_GENERAL.AddAsync(new TABLA_GENERAL()
				{
					codigoTablaGeneral = general.codigoTablaGeneral,
					descripcion = general.descripcion,
					fechaCreacion = DateTime.Now
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

		public async Task<string> UpdateGeneral(TABLA_GENERAL general)
		{
			try
			{
				_context.Entry(general).Property(x => x.codigoTablaGeneral).IsModified = true;
				_context.Entry(general).Property(x => x.descripcion).IsModified = true;
				await Save();
				return "Actualizacion Exitosa";
			}
			catch (Exception ex)
			{
				return "Error al actualizar " + ex.StackTrace;
			}
		}
	}
}
