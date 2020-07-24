
﻿using Clinica2._0.DTO;
using Clinica2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Repositories.EntityRepositories.Interfaces
{
	public interface ILicenciaRepository
	{
		Task Save();
		Task<string> insertLicencia(LICENCIA licencia);
		Task<string> updateLicencia(LICENCIA licencia);
		Task<List<licenciaDTO>> getAll();

		Task<LICENCIA> getLicencia(int id);
		Task<string> deleteLicencia(LICENCIA licencia);
	}
}
