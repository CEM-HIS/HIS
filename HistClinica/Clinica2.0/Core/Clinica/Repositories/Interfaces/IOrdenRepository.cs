using Clinica2._0.Core.Clinica.DTO;
using Clinica2._0.Core.Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Core.Clinica.Repositories.Interfaces
{
	public interface IOrdenRepository
	{
		Task<OrdenDTO> AddOrden(OrdenDTO dto, int idorden);
		Task<string> AddDetalleOrden(int idorden, LABORATORIO model);
		Task Save();
		Task<OrdenDTO> GetOrden(int orden);
	}
}
