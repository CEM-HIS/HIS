using HistClinica.Data;
using HistClinica.DTO;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Repositories
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
            return await _context.D024_CAJA.AnyAsync(e => e.idCaja == id);
        }

        public async Task<bool> AsignaCajaExists(int? idcaja, int? idEmpleado, DateTime fechaApertura, string turno)
        {
            return await _context.D025_ASIGNACAJA.AnyAsync( e => e.idCaja == idcaja && 
                                                            e.idEmpleado == idEmpleado && 
                                                            e.fechaApertura == fechaApertura &&
                                                            e.turno == turno);
        }

        public async Task DeleteCaja(int CajaID)
        {
            CAJA Caja = await _context.D024_CAJA.FindAsync(CajaID);
            Caja.estado = 2;
            _context.Update(Caja);
            await Save();
        }
        public async Task<string> InsertCaja(CajaDTO CajaDTO)
        {
            try
            {
                await _context.D024_CAJA.AddAsync(new CAJA()
                {
                    descripcion = CajaDTO.descripcion,
                    tipo = CajaDTO.tipo,
                    estado = CajaDTO.estado
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
            List<CAJA> Cajas = await (from c in _context.D024_CAJA
                                           select c).ToListAsync();

            return Cajas;
        }
        public async Task<CAJA> GetById(int? Id)
        {
            CAJA Caja = await (from c in _context.D024_CAJA
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

        public async Task<string> AsignaCaja(CAJA_ASIGNADA cajaAsignada)
        {
            try
            {
                //ToDO:Diferenciar usuario GAF de Usuario Principal de Caja
                if(!await AsignaCajaExists(cajaAsignada.idCaja, cajaAsignada.idEmpleado, cajaAsignada.fechaApertura, cajaAsignada.turno))
                {
                    await _context.D025_ASIGNACAJA.AddAsync(new CAJA_ASIGNADA()
                    {
                        idEmpleado = cajaAsignada.idEmpleado,
                        idCaja = cajaAsignada.idCaja,
                        fechaApertura = DateTime.Now,
                        fechaCierre = null,
                        turno = Calcularturno(DateTime.Now),
                        pos = cajaAsignada.pos,
                        montoSolesApertura = cajaAsignada.montoSolesApertura,
                        montoDolaresApertura = cajaAsignada.montoDolaresApertura,
                        montoEurosApertura = cajaAsignada.montoEurosApertura,
                        montoSolesCierre = cajaAsignada.montoSolesCierre,
                        montoDolaresCierre = cajaAsignada.montoDolaresCierre,
                        montoEurosCierre = cajaAsignada.montoEurosCierre,
                        glosa = cajaAsignada.glosa
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
    }
}
