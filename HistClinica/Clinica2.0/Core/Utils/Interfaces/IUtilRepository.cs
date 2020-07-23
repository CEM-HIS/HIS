using Clinica2._0.Core.Clinica.Models;
using Clinica2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Clinica2._0.Repositories.EntityRepositories.Repositories.UtilRepository;

namespace Clinica2._0.Repositories.EntityRepositories.Interfaces
{
	public interface IUtilRepository
	{
		Task<object> GetTipo(string nombretipo);
		//Task<object> GetEspecialidad(int id);
		//Task<object> GetMedicoByEspecialidad(int id);
		//Task<object> GetMedicos();
		//Task<object> GetCronogramaByMedico(int id);
		string GetUserApplication();
		//Task<object> GetHorasByCronograma(int id);
		//object GetHoras();
		//Task<object> GetCronograma();
		//Task<List<ESTADO_CITA>> getEstadoCita();
		//Task<List<CAJA>> getCajas();
		//Task<List<TABLA_DETALLE>> getServicios();
		List<Fecha> ObtenerFechaHora(List<CRONOGRAMA_MEDICO> cronograma);
		Task<PLAN_SALUD> getPlan(string numero);
		Task<List<LABORATORIO>> getLaboratorio();
		Task<LABORATORIO> getLab(int id);
	}
}
