<<<<<<< HEAD
﻿using HistClinica.DTO;
using HistClinica.Models;
=======
﻿using HistClinica.Models;
>>>>>>> master
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
<<<<<<< HEAD
		Task<List<licenciaDTO>> getAll();
=======
		Task<List<LICENCIA>> getAll();
>>>>>>> master
	}
}
