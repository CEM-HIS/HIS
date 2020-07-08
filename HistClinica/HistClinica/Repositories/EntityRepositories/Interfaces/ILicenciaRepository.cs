using HistClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.EntityRepositories.Interfaces
{
	public interface ILicenciaRepository
	{
		Task Save();
		Task<string> insertLicencia(LICENCIA licencia);
		Task<List<LICENCIA>> getAll();
	}
}
