using HistClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Interfaces
{
	public interface IGeneralRepository
	{
		Task<List<D00_TBGENERAL>> GetAllGeneral();
		Task<D00_TBGENERAL> GetById(int? id);

		Task<List<D00_TBGENERAL>> GetByCodigo(string codigo,string descripcion);
		Task<string> InsertGeneral(D00_TBGENERAL general);
		Task<string> UpdateGeneral(D00_TBGENERAL general);
		Task<string> DeleteGeneral(D00_TBGENERAL general);
		Task<bool> GeneralExists(int? id);
		Task Save();
	}
}
