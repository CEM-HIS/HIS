using HistClinica.Data;
<<<<<<< HEAD
using HistClinica.DTO;
=======
>>>>>>> master
using HistClinica.Models;
using HistClinica.Repositories.EntityRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.EntityRepositories.Repositories
{
<<<<<<< HEAD
	public class LicenciaRepository : ILicenciaRepository
=======
	public class LicenciaRepository: ILicenciaRepository
>>>>>>> master
	{
		private readonly ClinicaServiceContext _context;

		public LicenciaRepository(ClinicaServiceContext contexto)
		{
			_context = contexto;
		}

<<<<<<< HEAD
		public async Task<List<licenciaDTO>> getAll()
		{
			List<licenciaDTO> licencia = await (from l in _context.LICENCIA
												join det in _context.TABLA_DETALLE on l.estado equals det.idDet
												join med in _context.MEDICO on l.idMedico equals med.idMedico
												join per in _context.PERSONA on med.idPersona equals per.idPersona
												select new licenciaDTO
												{
													idLicencia = l.idLicencia,
													fechaIni = l.fechaIni.Value.ToShortDateString(),
													fechaFin = l.fechaFin.Value.ToShortDateString(),
													estado = det.descripcion,
													medico = per.nombres + " " + per.apePaterno + " " + per.apeMaterno
												}).ToListAsync();
=======
		public async Task<List<LICENCIA>> getAll()
		{
			List<LICENCIA> licencia = await (from l in _context.LICENCIA
											 select l).ToListAsync();
>>>>>>> master
			return licencia;
		}

		public async Task<string> insertLicencia(LICENCIA licencia)
		{
			try
			{
<<<<<<< HEAD
				await _context.LICENCIA.AddAsync(new LICENCIA()
				{
					horaIni = licencia.horaIni,
					horaFin = licencia.horaFin,
					fechaIni = licencia.fechaIni,
					fechaFin = licencia.fechaFin,
					idMedico = licencia.idMedico,
					estado = 173
=======
				await _context.LICENCIA.AddAsync(new LICENCIA() { 
					horaInicio = licencia.horaInicio,
					horaFin = licencia.horaFin,
					fechaInicio = licencia.fechaInicio,
					fechaFin = licencia.fechaFin,
					idMedico = licencia.idMedico,
					idEstado = 1
>>>>>>> master
				});
				await Save();
				return "Se registro licencia correctamente";
			}
			catch (Exception ex)
			{

				return "Error en el guardado" + ex.Message;
			}
		}

		public async Task Save()
		{
			await _context.SaveChangesAsync();
		}
	}
}
