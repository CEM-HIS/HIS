using Clinica2._0.Core.Clinica.DTO;
using Clinica2._0.Core.Clinica.Models;
using Clinica2._0.Core.Clinica.Repositories.Interfaces;
using Clinica2._0.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Core.Clinica.Repositories.Repositories
{
	public class OrdenRepository : IOrdenRepository
	{
		private readonly ClinicaServiceContext _context;

		public OrdenRepository(ClinicaServiceContext context)
		{
			_context = context;
		}

		public async Task Save()
		{
			await _context.SaveChangesAsync();
		}

		public async Task<OrdenDTO> AddOrden(OrdenDTO modelo, int idorden)
		{
			OrdenDTO data = new OrdenDTO();
			Random rnd = new Random();
			int nroorden = rnd.Next(1, 100);
			try
			{
				ORDEN_ATENCION orden = new ORDEN_ATENCION()
				{
					nroOrden = string.Format("{0:000000}", nroorden),
					idPaciente = modelo.idPaciente,
					numeroHC = modelo.numeroHC,
					idMedico = modelo.idMedico,
					cuenta = modelo.cuenta,	
				};
				await _context.ORDEN_ATENCION.AddAsync(orden);
				await Save();
			}
			catch (Exception ex)
			{
			 string msg = ex.Message;
			}
			idorden = (await _context.ORDEN_ATENCION.FirstOrDefaultAsync(o => o.idPaciente == modelo.idPaciente)).idOrden;
			data = await GetOrden(idorden);
			return data;
		}

		public async Task<OrdenDTO> GetOrden(int orden)
		{
			OrdenDTO dto = await (from o in _context.ORDEN_ATENCION
								  join pe in _context.PACIENTE on o.idPaciente equals pe.idPaciente
								  join per in _context.PERSONA on pe.idPersona equals per.idPersona
								  join pla in _context.PLAN_SALUD on pe.codigoPlanSalud equals pla.codigoPlanSalud
								  where o.idOrden == orden
								  select new OrdenDTO
								  {
									  idorden = o.idOrden,
									  numeroorden = o.nroOrden,
									  idPaciente = o.idPaciente,
									  nombrepaciente = per.nombres + " " + per.apellidoPaterno + " " + per.apellidoMaterno,
									  codigoplan = pla.codigoPlanSalud,
									  aseguradora = pla.asegurado,
									  contratante = pla.contratante,
									  contrato = pla.numeroContrato,
									  numeroHC = pe.numeroHc,
									  idMedico = o.idMedico,
									  cuenta = pe.cuenta
								  }).FirstOrDefaultAsync();
			return dto;
		}

		public async Task<string> AddDetalleOrden(int orden, LABORATORIO lab)
		{
			try
			{
				OrdenDTO model = await GetOrden(orden);
				ORDEN_ATE_DETALLE detalle = new ORDEN_ATE_DETALLE()
				{
					nroOrden = model.numeroorden,
					tarifa = lab.descripcion,
					PrecioUnitario = lab.precio,
					cantidad = 1,
					descuento = "0.00",
					importe = lab.precio,
					seguro = lab.precio,
					paciente = "0.00",
					interviniente = ""
				};
				await _context.ORDEN_ATE_DETALLE.AddAsync(detalle);
				await Save();
				return "";
			}
			catch (Exception ex)
			{
				return "error" + ex.Message; 
			}
			
		}
	}
}
