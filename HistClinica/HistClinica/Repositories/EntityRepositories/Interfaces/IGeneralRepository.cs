using HistClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Interfaces
{
	public interface IGeneralRepository
	{
		Task<List<TABLAGENERAL>> GetAllGeneral();
		Task<TABLAGENERAL> GetById(int? id);

		Task<List<TABLAGENERAL>> GetByCodigo(string codigo,string descripcion);
		Task<string> InsertGeneral(TABLAGENERAL general);
		Task<string> UpdateGeneral(TABLAGENERAL general);
		Task<string> DeleteGeneral(TABLAGENERAL general);
		Task<bool> GeneralExists(int? id);
		Task Save();
	}
}
