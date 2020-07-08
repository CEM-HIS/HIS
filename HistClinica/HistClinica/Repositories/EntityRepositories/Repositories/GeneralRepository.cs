﻿using HistClinica.Data;
using HistClinica.Interfaces;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories
{
	public class GeneralRepository : IGeneralRepository
	{
		private readonly ClinicaServiceContext _context;

		public GeneralRepository(ClinicaServiceContext context)
		{
			_context = context;
		}
		public async Task<string> DeleteGeneral(TABLAGENERAL modelo)
		{
			try
			{
				TABLAGENERAL general = await _context.D00_TBGENERAL.FindAsync(modelo.idTab);
				_context.D00_TBGENERAL.Remove(general);
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
			return await _context.D00_TBGENERAL.AnyAsync(e => e.idTab == id);
		}

		public async Task<List<TABLAGENERAL>> GetAllGeneral()
		{

			List<TABLAGENERAL> general = await (from g in _context.D00_TBGENERAL
										   select g).ToListAsync();
			return general;
		}

		public async Task<List<TABLAGENERAL>> GetByCodigo(string codigo,string descripcion)
		{
			List<TABLAGENERAL> general = new List<TABLAGENERAL>();
			try
			{
				 general = await (from p in _context.D00_TBGENERAL
													 where p.codTab == codigo || p.descripcion.Contains(descripcion)
													 select p).ToListAsync();
			}
			catch (Exception ex)
			{
				var msj = ex.Message;
				throw;
			}
			return general;
		}

		public async Task<TABLAGENERAL> GetById(int? id)
		{

			TABLAGENERAL general = await (from p in _context.D00_TBGENERAL
										   where p.idTab == id
										   select p).FirstOrDefaultAsync();
			return general;
		}

		public async Task<string> InsertGeneral(TABLAGENERAL general)
		{
			try
			{
				await _context.D00_TBGENERAL.AddAsync(new TABLAGENERAL()
				{
					codTab = general.codTab,
					descripcion = general.descripcion,
					fechaCreate = DateTime.Now
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

		public async Task<string> UpdateGeneral(TABLAGENERAL general)
		{
			try
			{
				_context.Entry(general).Property(x => x.codTab).IsModified = true;
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
