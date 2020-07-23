﻿using Clinica2._0.Data;
using Clinica2._0.DTO;
using Clinica2._0.Models;
using Clinica2._0.Repositories.EntityRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Repositories.EntityRepositories.Repositories
{
	public class UtilRepository : IUtilRepository
	{
		private readonly ClinicaServiceContext _context;
		public UtilRepository(ClinicaServiceContext contexto)
		{
			_context = contexto;
		}

		public async Task<List<CAJA>> getCajas()
		{
			List<CAJA> caja = await (from c in _context.CAJA
										  select c).ToListAsync();

			return caja;
		}

		public class Fecha
        {
			public int idprogramMed { get; set; }
			public  string fecprogram { get; set; }
		}

		public class Hora
		{
			public int id { get; set; }
			public string hora { get; set; }
		}

		public List<Fecha> ObtenerFechaHora(List<CRONOGRAMA_MEDICO> cronograma)
        {
			int intervalofecha, intervalohora;
			List<Fecha> fechas = new List<Fecha>();

			foreach (var item in cronograma)
			{
				intervalofecha = item.fechaFin.Value.DayOfYear - item.fechaInicio.Value.DayOfYear;
				intervalohora = int.Parse(item.horaFin.Split(":")[0]) - int.Parse(item.horaInicio.Split(":")[0]);
				for (int i = 0; i <= intervalofecha; i++)
				{
					Fecha fecha = new Fecha()
					{
						idprogramMed = item.idProgramMedica,
						fecprogram = item.fechaInicio.Value.AddDays(i).ToShortDateString()
					};
					fechas.Add(fecha);
				}
			}
			return fechas;
		}

		public async Task<object> GetCronograma()
		{
			List<CRONOGRAMA_MEDICO> cronograma = await(from cro in _context.CRONOGRAMA_MEDICO
								   join med in _context.MEDICO on cro.idMedico equals med.idMedico
								   select cro
									).ToListAsync();
			
			return ObtenerFechaHora(cronograma);
		}

		public async Task<object> GetCronogramaByMedico(int id)
		{
			List<CRONOGRAMA_MEDICO> cronograma = await (from cro in _context.CRONOGRAMA_MEDICO
									join med in _context.MEDICO on cro.idMedico equals med.idMedico
									where med.idMedico == id
									select cro).ToListAsync();
			return ObtenerFechaHora(cronograma);
		}

		public async Task<object> GetEspecialidad(int id)
		{
			var combo = await(	from td in _context.TABLA_DETALLE
								join med in _context.MEDICO
								on td.idTablaDetalle equals med.idEspecialidad
								where med.idMedico == id
								select new
								{
									idtab = td.idTablaDetalle,
									descripcion = td.descripcion
								}).ToListAsync();
			return combo;
		}

		public async Task<List<ESTADO_CITA>> getEstadoCita()
		{

			List<ESTADO_CITA> estado = await (from e in _context.ESTADO_CITA
											select e).ToListAsync();
			return estado;
		}

		public object GetHoras()
		{
			var horas = new Collection();
			return horas;
		}


        public async Task<object> GetMedicoByEspecialidad(int id)
		{
			var medico = await (from td in _context.TABLA_DETALLE
								join med in _context.MEDICO
                                on td.idTablaDetalle equals med.idEspecialidad
								join per in _context.PERSONA
                                on med.idPersona equals per.idPersona
								where td.idTablaDetalle == id
								select new
								{
									idMedico = med.idMedico,
									nombres = per.nombres + " "  + per.apellidoPaterno + " " + per.apellidoMaterno
								}).ToListAsync();
			return medico;
		}

		public async Task<object> GetMedicos()
		{
			var medico = await (from per in _context.PERSONA
						 join e in _context.EMPLEADO on per.idPersona
						 equals e.idPersona
						 join med in _context.MEDICO on e.idPersona equals med.idPersona
						 select new
						 {
							 idMedico = med.idMedico,
							 nombres = per.nombres +  " " + per.apellidoPaterno + " " + per.apellidoMaterno
						 }).ToListAsync();
			return medico;
		}

		public async Task<object> GetTipo(string nombretipo)
		{
			var combo = await (from tg in _context.TABLA_GENERAL
								 join td in _context.TABLA_DETALLE on tg.idTablaGeneral equals td.idTablaGeneral
								 where tg.descripcion == nombretipo
								 select new
								 {
									 idtab = td.idTablaDetalle,
									 descripcion = td.descripcion
								 }).ToListAsync();
			return combo;
		}

		public async Task<List<TABLA_DETALLE>> getServicios()
		{
			List<TABLA_DETALLE> servicios = await (from s in _context.TABLA_DETALLE
													   where s.idTablaGeneral == 16
													   select s
													   ).ToListAsync();
			return servicios;
		}
	}
}