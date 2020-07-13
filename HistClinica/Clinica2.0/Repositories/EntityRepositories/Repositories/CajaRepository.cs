using Clinica2._0.Data;
using Clinica2._0.DTO;
using Clinica2._0.Models;
using Clinica2._0.Repositories.EntityRepositories.Interfaces;
using HistClinica.Data;
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
        public CajaRepository(ClinicaServiceContext context)
        {
            _context = context;
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
        public async Task<List<CAJA>> GetAllCajas()
        {
            List<CAJA> Cajas = await (from c in _context.CAJA
                                           select c).ToListAsync();

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
                        montoSolesCierre = cajaAsignada.montoSolesCierre,
                        montoDolaresCierre = cajaAsignada.montoDolaresCierre,
                        montoEurosCierre = cajaAsignada.montoEurosCierre,
                        glosaApertura = cajaAsignada.glosaApertura,
                        glosaCierre = cajaAsignada.glosaCierre
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
            CAJA_ASIGNADA CajaAsignada =    await (from c in _context.CAJA_ASIGNADA
                                            where c.idCaja == cajaAsignada.idCaja
                                            && c.fechaApertura == cajaAsignada.fechaApertura
                                            && c.turno == cajaAsignada.turno
                                            select c).FirstOrDefaultAsync();
            _context.Update(CajaAsignada);
            await Save();
            return "Cierre de caja exitoso";
        }
    }
}
