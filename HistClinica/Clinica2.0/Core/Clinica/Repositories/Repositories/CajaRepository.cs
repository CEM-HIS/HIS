﻿using Clinica2._0.Data;
using Clinica2._0.DTO;
using Clinica2._0.Models;
using Clinica2._0.Repositories.EntityRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Repositories.EntityRepositories.Repositories
{
    public class CajaRepository:ICajaRepository
    {
        private readonly ClinicaServiceContext _context;
        private readonly IUtilRepository _utilrepository;
        private readonly IEmpleadoRepository _empleadorepository;

        public CajaRepository(ClinicaServiceContext context,
            IUtilRepository utilRepository,
            IEmpleadoRepository empleadorepository)
        {
            _context = context;
            _utilrepository = utilRepository;
            _empleadorepository = empleadorepository;
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<bool> CajaExists(int? id)
        {
            return await _context.CAJA.AnyAsync(e => e.idCaja == id);
        }

        public async Task<bool> AsignaCajaExists(int? idcaja, string fechaApertura, string turno)
        {
            return await _context.CAJA_ASIGNADA.AnyAsync( e => e.idCaja == idcaja && 
                                                            e.fechaApertura == fechaApertura &&
                                                            e.turno == turno);
        }

        public async Task DeleteCaja(int CajaID)
        {
            CAJA Caja = await _context.CAJA.FindAsync(CajaID);
            Caja.idEstado = 2;
            _context.Update(Caja);
            await Save();
        }
        public async Task<string> InsertCaja(CAJA Caja)
        {
            try
            {
                await _context.CAJA.AddAsync(new CAJA()
                {
                    descripcion = Caja.descripcion,
                    idTipoCaja = Caja.idTipoCaja,
                    idEstado = Caja.idEstado
                });
                await Save();
                return "Ingreso Exitoso";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task<List<CajaDTO>> GetAllCajas()
        {
            List<CajaDTO> Cajas = await (from c in _context.CAJA
                                select new CajaDTO()
                                {
                                    fechaApertura = (from ca in _context.CAJA_ASIGNADA
                                                     where ca.idCaja == c.idCaja
                                                     select ca.fechaApertura).FirstOrDefault(),
                                    idCaja = c.idCaja,
                                    idEmpleado = (from ca in _context.CAJA_ASIGNADA
                                                  where ca.idCaja == c.idCaja
                                                  select ca.idEmpleado).FirstOrDefault(),
                                    empleado = (from ca in _context.CAJA_ASIGNADA
                                                join em in _context.EMPLEADO on ca.idEmpleado equals em.idEmpleado
                                                join p in _context.PERSONA on em.idPersona equals p.idPersona
                                                where ca.idCaja == c.idCaja
                                                select (p.nombres + " " + p.apellidoPaterno + " " + p.apellidoMaterno)
                                                ).FirstOrDefault(),
                                    tipo = "",
                                    turno = (from ca in _context.CAJA_ASIGNADA
                                                          where ca.idCaja == c.idCaja
                                                          select ca.turno).FirstOrDefault(),
                                    idEstado = c.idEstado,
                                    estado = ""
                                }
                                ).ToListAsync();
            return Cajas;
        }
        public async Task<CAJA> GetById(int? Id)
        {
            CAJA Caja = await (from c in _context.CAJA
                                  where c.idCaja == Id
                                  select c).FirstOrDefaultAsync();
            return Caja;
        }

        public string Calcularturno(DateTime ahora)
        {
            if (ahora.Hour >= 6)
            {
                return "Mañana";
            }
            else if (ahora.Hour >= 14)
            {
                return "Tarde";
            }
            else return "Noche";
        }

        public async Task<string> AperturaCaja(CAJA_ASIGNADA cajaAsignada)
        {
            try
            {
                //ToDO:Diferenciar usuario GAF de Usuario Principal de Caja
                if(!await AsignaCajaExists(cajaAsignada.idCaja, cajaAsignada.fechaApertura, cajaAsignada.turno))
                {
                    await _context.CAJA_ASIGNADA.AddAsync(new CAJA_ASIGNADA()
                    {
                        idEmpleado = cajaAsignada.idEmpleado,
                        idCaja = cajaAsignada.idCaja,
                        fechaApertura = DateTime.Now.ToShortDateString(),
                        horaApertura = DateTime.Now.ToShortTimeString(),
                        fechaCierre = null,
                        horaCierre = null,
                        turno = Calcularturno(DateTime.Now),
                        pos = cajaAsignada.pos,
                        montoSolesApertura = cajaAsignada.montoSolesApertura,
                        montoDolaresApertura = cajaAsignada.montoDolaresApertura,
                        montoEurosApertura = cajaAsignada.montoEurosApertura,
                        montoSolesCierre = null,
                        montoDolaresCierre = null,
                        montoEurosCierre = null,
                        glosaApertura = cajaAsignada.glosaApertura,
                        glosaCierre = null
                    });
                    await Save();
                    return "Ingreso Exitoso";
                }
                return "Caja ya asignada";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.Message;
            }
        }

        public async Task<string> CierreCaja(CAJA_ASIGNADA cajaAsignada)
        {
            CAJA_ASIGNADA CajaAsignada = await (from c in _context.CAJA_ASIGNADA
                                                where c.idCaja == cajaAsignada.idCaja
                                                && c.fechaApertura == cajaAsignada.fechaApertura
                                                && c.turno == cajaAsignada.turno
                                                select new CAJA_ASIGNADA()
                                                {
                                                    idEmpleado = c.idEmpleado,
                                                    idCaja = c.idCaja,
                                                    fechaApertura = c.fechaApertura,
                                                    horaApertura = c.horaApertura,
                                                    turno = c.turno,
                                                    pos = c.pos,
                                                    montoSolesApertura = c.montoSolesApertura,
                                                    montoDolaresApertura = c.montoDolaresApertura,
                                                    montoEurosApertura = c.montoEurosApertura,
                                                    //Datos de Cierre
                                                    fechaCierre = DateTime.Now.ToShortDateString(),
                                                    horaCierre = DateTime.Now.ToShortTimeString(),
                                                    montoSolesCierre = cajaAsignada.montoSolesCierre,
                                                    montoDolaresCierre = cajaAsignada.montoDolaresCierre,
                                                    montoEurosCierre = cajaAsignada.montoEurosCierre,
                                                    glosaCierre = cajaAsignada.glosaCierre,
                                                    //Datos de Cierre
                                                    glosaApertura = cajaAsignada.glosaApertura
                                                }).FirstOrDefaultAsync();
            
            _context.Update(CajaAsignada);
            await Save();
            return "Cierre de caja exitoso";
        }

        public CAJA_ASIGNADA getCajaAsignadabyIdCaja(int id)
        {
            return (from ca in _context.CAJA_ASIGNADA
                    where ca.idCaja == id
                    select ca).FirstOrDefault();
        }

        public async Task<List<CajaDTO>> GetAllCajasAsignadas()
        {
            return await (from c in _context.CAJA
                                        select new CajaDTO()
                                        {
                                            idCaja = c.idCaja,
                                            fechaApertura = getCajaAsignadabyIdCaja(c.idCaja).fechaApertura,
                                            horaApertura = getCajaAsignadabyIdCaja(c.idCaja).horaApertura,
                                            montoSolesApertura = getCajaAsignadabyIdCaja(c.idCaja).montoSolesApertura,
                                            montoDolaresApertura = getCajaAsignadabyIdCaja(c.idCaja).montoDolaresApertura,
                                            montoEurosApertura = getCajaAsignadabyIdCaja(c.idCaja).montoEurosApertura,
                                            montoSolesCierre = getCajaAsignadabyIdCaja(c.idCaja).montoSolesCierre,
                                            montoDolaresCierre = getCajaAsignadabyIdCaja(c.idCaja).montoDolaresCierre,
                                            montoEurosCierre = getCajaAsignadabyIdCaja(c.idCaja).montoEurosCierre,
                                            fechaCierre = getCajaAsignadabyIdCaja(c.idCaja).fechaCierre,
                                            horaCierre = getCajaAsignadabyIdCaja(c.idCaja).horaCierre,
                                            empleado = (from ca in _context.CAJA_ASIGNADA
                                                        join em in _context.EMPLEADO on ca.idEmpleado equals em.idEmpleado
                                                        join p in _context.PERSONA on em.idPersona equals p.idPersona
                                                        where ca.idCaja == c.idCaja
                                                        select (p.nombres + " " + p.apellidoPaterno + " " + p.apellidoMaterno)
                                                        ).FirstOrDefault(),
                                            turno = (from ca in _context.CAJA_ASIGNADA
                                                     where ca.idCaja == c.idCaja
                                                     select ca.turno).FirstOrDefault()
                                        }
                                ).ToListAsync();
        }

        public async Task<CajaDTO> GetCajaAsignadaxUsuario()
        {
            int idEmpleado = await _empleadorepository.GetIdEmpleadobyIdUser(_utilrepository.GetUserApplication());
            return await(from c in _context.CAJA
                         join ca in _context.CAJA_ASIGNADA on c.idCaja equals ca.idCaja
                         where ca.idEmpleado == idEmpleado
                         select new CajaDTO()
                         {
                             idCaja = c.idCaja,
                             fechaApertura = getCajaAsignadabyIdCaja(c.idCaja).fechaApertura,
                             horaApertura = getCajaAsignadabyIdCaja(c.idCaja).horaApertura,
                             montoSolesApertura = getCajaAsignadabyIdCaja(c.idCaja).montoSolesApertura,
                             montoDolaresApertura = getCajaAsignadabyIdCaja(c.idCaja).montoDolaresApertura,
                             montoEurosApertura = getCajaAsignadabyIdCaja(c.idCaja).montoEurosApertura,
                             montoSolesCierre = getCajaAsignadabyIdCaja(c.idCaja).montoSolesCierre,
                             montoDolaresCierre = getCajaAsignadabyIdCaja(c.idCaja).montoDolaresCierre,
                             montoEurosCierre = getCajaAsignadabyIdCaja(c.idCaja).montoEurosCierre,
                             fechaCierre = getCajaAsignadabyIdCaja(c.idCaja).fechaCierre,
                             horaCierre = getCajaAsignadabyIdCaja(c.idCaja).horaCierre,
                             empleado = (from ca in _context.CAJA_ASIGNADA
                                         join em in _context.EMPLEADO on ca.idEmpleado equals em.idEmpleado
                                         join p in _context.PERSONA on em.idPersona equals p.idPersona
                                         where ca.idCaja == c.idCaja
                                         select (p.nombres + " " + p.apellidoPaterno + " " + p.apellidoMaterno)
                                         ).FirstOrDefault(),
                             turno = (from ca in _context.CAJA_ASIGNADA
                                      where ca.idCaja == c.idCaja
                                      select ca.turno).FirstOrDefault()
                         }
                        ).FirstOrDefaultAsync();
        }
    }
}
