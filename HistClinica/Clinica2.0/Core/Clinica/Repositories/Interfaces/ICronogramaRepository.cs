using Clinica2._0.DTO;
using Clinica2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Repositories.EntityRepositories.Interfaces
{
	public interface ICronogramaRepository
	{
		Task<string> InsertCronograma(CRONOGRAMA_MEDICO cronograma);
		Task<string> UpdateCronograma(CRONOGRAMA_MEDICO cronograma);
		Task<CronogramaDTO> GetByIdCrono(int CronoID);
		Task<List<CronogramaDTO>> GetAllCronogramas();

		Task<List<CronogramaDTO>> GetAllCronogramasConsulta();
		Task DeleteCronograma(int? CronoID);
		Task Save();
		Task<List<CronogramaDTO>> GetCronogramaByMedico(string nombre,string apellido, int especialidad);
		Task<object> GetCronogramaByMedico(int id);
	}
}
