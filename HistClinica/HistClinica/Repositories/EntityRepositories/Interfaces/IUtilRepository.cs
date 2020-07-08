﻿using HistClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Interfaces
{
	public interface IUtilRepository
	{
		Task<object> GetTipo(string nombretipo);
		Task<object> GetEspecialidad(int id);
		Task<object> GetMedicoByEspecialidad(int id);
		Task<object> GetMedicos();
		Task<object> GetCronogramaByMedico(int id);
		Task<object> GetHorasByCronograma(int id);
		object GetHoras();
		Task<object> GetCronograma();
		Task<List<ESTADO_CITA>> getEstadoCita();
		Task<List<CAJA>> getCajas();
		Task<List<TABLADETALLE>> getServicios();
	}
}
