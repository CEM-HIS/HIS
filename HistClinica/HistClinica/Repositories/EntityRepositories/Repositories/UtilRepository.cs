using HistClinica.Data;
using HistClinica.DTO;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Repositories
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
				intervalofecha = item.fechaFin.Value.DayOfYear - item.fechaIni.Value.DayOfYear;
				intervalohora = int.Parse(item.hrFin.Split(":")[0]) - int.Parse(item.hrInicio.Split(":")[0]);
				for (int i = 0; i <= intervalofecha; i++)
				{
					Fecha fecha = new Fecha()
					{
						idprogramMed = item.idProgramMedica,
						fecprogram = item.fechaIni.Value.AddDays(i).ToShortDateString()
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
								on td.idDet equals med.idEspecialidad
								where med.idMedico == id
								select new
								{
									idtab = td.idDet,
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

        public async Task<object> GetHorasByCronograma(int id)
        {
			int intervalohora;
			Hora hora;
			List<Hora> horas = new List<Hora>();
			var cronograma = await (from cro in _context.CRONOGRAMA_MEDICO
                               where cro.idProgramMedica == id
                               select cro).FirstOrDefaultAsync();
			intervalohora = int.Parse(cronograma.hrFin.Split(":")[0]) - int.Parse(cronograma.hrInicio.Split(":")[0]);

			for (int j = 0; j < intervalohora; j++)
			{
				hora = new Hora{
					id = cronograma.idProgramMedica,
					hora = (int.Parse(cronograma.hrInicio.Split(":")[0]) + j).ToString() + ":00"
				};
				horas.Add(hora);
			}
			return horas;
        }

        public async Task<object> GetMedicoByEspecialidad(int id)
		{
			var medico = await (from td in _context.TABLA_DETALLE
								join med in _context.MEDICO
                                on td.idDet equals med.idEspecialidad
								join per in _context.PERSONA
                                on med.idPersona equals per.idPersona
								where td.idDet == id
								select new
								{
									idMedico = med.idMedico,
									nombres = per.nombres + " "  + per.apePaterno + " " + per.apeMaterno
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
							 nombres = per.nombres +  " " + per.apePaterno + " " + per.apeMaterno
						 }).ToListAsync();
			return medico;
		}

		public async Task<object> GetTipo(string nombretipo)
		{
			var combo = await (from tg in _context.TABLA_GENERAL
								 join td in _context.TABLA_DETALLE on tg.idTab equals td.idTab
								 where tg.descripcion == nombretipo
								 select new
								 {
									 idtab = td.idDet,
									 descripcion = td.descripcion
								 }).ToListAsync();
			return combo;
		}

		public async Task<List<TABLA_DETALLE>> getServicios()
		{
			List<TABLA_DETALLE> servicios = await (from s in _context.TABLA_DETALLE
													   where s.idTab == 16
													   select s
													   ).ToListAsync();
			return servicios;
		}
	}
}
