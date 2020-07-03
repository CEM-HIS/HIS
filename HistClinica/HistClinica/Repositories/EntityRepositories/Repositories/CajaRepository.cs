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

        public async Task<bool> AsignaCajaExists(int? idcaja, int? idEmpleado)
        {
            return await _context.D025_ASIGNACAJA.AnyAsync(e => e.idCaja == idcaja && e.idEmpleado == idEmpleado);
        }

        public async Task DeleteCaja(int CajaID)
        {
            D024_CAJA Caja = await _context.D024_CAJA.FindAsync(CajaID);
            Caja.estado = "2";
            _context.Update(Caja);
            await Save();
        }
        public async Task<string> InsertCaja(D024_CAJA Caja)
        {
            try
            {
                await _context.D024_CAJA.AddAsync(Caja);
                await Save();
                return "Ingreso Exitoso";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task<List<D024_CAJA>> GetAllCajas()
        {
            List<D024_CAJA> Cajas = await (from c in _context.D024_CAJA
                                           select c).ToListAsync();

            return Cajas;
        }
        public async Task<D024_CAJA> GetById(int? Id)
        {
            D024_CAJA Caja = await (from c in _context.D024_CAJA
                                  where c.idCaja == Id
                                  select c).FirstOrDefaultAsync();
            return Caja;
        }

        public async Task<string> AsignaCaja(PersonaDTO persona)
        {
            try
            {
                if(!await AsignaCajaExists(persona.asignacion.idCaja, persona.personal.idEmpleado))
                {
                    await _context.D025_ASIGNACAJA.AddAsync(new D025_ASIGNACAJA()
                    {
                        idEmpleado = (int)persona.personal.idEmpleado,
                        idCaja = (int)persona.asignacion.idCaja
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
