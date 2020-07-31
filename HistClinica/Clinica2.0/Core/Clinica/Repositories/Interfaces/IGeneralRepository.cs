using Clinica2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Repositories.EntityRepositories.Interfaces
{
	public interface IGeneralRepository
	{
		Task<List<TABLA_GENERAL>> GetAllGeneral();
		Task<TABLA_GENERAL> GetById(int? id);
		Task<List<TABLA_GENERAL>> GetByCodigo(string codigo,string descripcion);
		Task<string> InsertGeneral(TABLA_GENERAL general);
		Task<string> UpdateGeneral(TABLA_GENERAL general);
		Task<string> DeleteGeneral(TABLA_GENERAL general);
		Task<bool> GeneralExists(int? id);
		Task Save();
	}
}
