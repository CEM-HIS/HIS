using Clinica2._0.Data;
using Clinica2._0.DTO;
using Clinica2._0.Models;
using Clinica2._0.Repositories.EntityRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Clinica2._0.Core.Clinica.Models;

namespace Clinica2._0.Repositories.EntityRepositories.Repositories
{
	public class UtilRepository : IUtilRepository
	{
		private readonly ClinicaServiceContext _context;
		private readonly IHttpContextAccessor _httpContextAccessor;
		public UtilRepository(ClinicaServiceContext contexto,
			IHttpContextAccessor httpContextAccessor)
		{
			_context = contexto;
			_httpContextAccessor = httpContextAccessor;
		}

        //public async Task<List<CAJA>> getCajas()
        //{
        //	List<CAJA> caja = await (from c in _context.CAJA
        //								  select c).ToListAsync();

        //	return caja;
        //}

        public class Fecha
        {
            public int idprogramMed { get; set; }
            public string fecprogram { get; set; }
        }

        //public class Hora
        //{
        //	public int id { get; set; }
        //	public string hora { get; set; }
        //}

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

        //public async Task<object> GetCronograma()
        //{
        //	List<CRONOGRAMA_MEDICO> cronograma = await(from cro in _context.CRONOGRAMA_MEDICO
        //						   join med in _context.MEDICO on cro.idMedico equals med.idMedico
        //						   select cro
        //							).ToListAsync();

        //	return ObtenerFechaHora(cronograma);
        //}

        
		//public object GetHoras()
		//{
		//	var horas = new Collection();
		//	return horas;
		//}

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

		//public async Task<List<TABLA_DETALLE>> getServicios()
		//{
		//	List<TABLA_DETALLE> servicios = await (from s in _context.TABLA_DETALLE
		//											   where s.idTablaGeneral == 16
		//											   select s
		//											   ).ToListAsync();
		//	return servicios;
		//}
		public string GetUserApplication()
		{
			return _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier).ToString();
		}

        public async Task<PLAN_SALUD> getPlan(string numero)
        {
            PLAN_SALUD plan = await (from p in _context.PLAN_SALUD
                                     where p.codigoPlanSalud.Contains(numero)
                                     select p).FirstOrDefaultAsync();
            return plan;
        }

        public async Task<List<LABORATORIO>> getLaboratorio()
        {
            List<LABORATORIO> data = await (from p in _context.LABORATORIO select p).ToListAsync();
            return data;
        }

        public async Task<LABORATORIO> getLab(int id)
        {
            LABORATORIO dato = await (from p in _context.LABORATORIO where p.idLaboratorio == id select p).FirstOrDefaultAsync();
            return dato;
        }
    }
}
