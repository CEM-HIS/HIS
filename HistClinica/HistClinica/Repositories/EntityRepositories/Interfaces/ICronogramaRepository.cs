using HistClinica.DTO;
using HistClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Interfaces
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
		Task<List<CronogramaDTO>> GetCronogramaByMedico(int idmedico);
	}
}
