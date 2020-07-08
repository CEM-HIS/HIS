using HistClinica.Data;
using HistClinica.DTO;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Repositories
{
    public class DetalleRepository:IDetalleRepository
    {
        private readonly ClinicaServiceContext _context;
        private readonly IGeneralRepository generalRepository;
        public DetalleRepository(ClinicaServiceContext context, IGeneralRepository repository)
        {
            _context = context;
            generalRepository = repository;
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

        public async Task<bool> DetalleExists(int? id)
        {
            return await _context.TABLA_DETALLE.AnyAsync(e => e.idDet == id);
        }

        public async Task<TABLA_DETALLE> GetById(int? Id)
        {
            TABLA_DETALLE listaDetalle = new TABLA_DETALLE();
            listaDetalle = await (from detalle in _context.TABLA_DETALLE
                                 where detalle.idDet == Id
                                 select new TABLA_DETALLE
                                 {
                                     idDet = detalle.idDet,
                                     coddetTab = detalle.coddetTab,
                                     descripcion = detalle.descripcion,
                                     idTab = detalle.idTab
                                 }).FirstOrDefaultAsync();
            return listaDetalle;
        }

        public async Task<string> InsertDetalle(TABLA_DETALLE Detalle)
        {
            try
            {
                await _context.TABLA_DETALLE.AddAsync(new TABLA_DETALLE()
                {
                    coddetTab = Detalle.coddetTab,
                    descripcion = Detalle.descripcion,
                    idTab = Detalle.idTab
            });
                await Save();
                return "Ingreso Exitoso";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.StackTrace;
            }
        }

        public async Task<string> DeleteDetalle(int DetalleID)
        {
            try
            {
                TABLA_DETALLE Detalle = await _context.TABLA_DETALLE.FindAsync(DetalleID);
                _context.TABLA_DETALLE.Remove(Detalle);
                await Save();
                return "Registro eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar" + ex.Message;
            }
        }

        public async Task<string> UpdateDetalle(TABLA_DETALLE Detalle)
        {
            try
            {
                _context.Entry(Detalle).Property(x => x.coddetTab).IsModified = true;
                _context.Entry(Detalle).Property(x => x.descripcion).IsModified = true;
                await Save();
                return "Actualizacion Exitosa";
            }
            catch (Exception ex)
            {
                return "Error al actualizar " + ex.StackTrace;
            }
        }


        public async Task<DetalleDTO> GetDetalle(int? id)
        {
            DetalleDTO dto = new DetalleDTO();
            TABLA_GENERAL general = await generalRepository.GetById(id);
            dto.idTab = general.idTab;
            dto.codTab = general.codTab;
            dto.ldetalle = await GetDetalleByIdGeneral(id);
            return dto;
        }

        public async Task<int> GetIdDetalleByDescripcion(string descripcion)
        {
            return await (from det in _context.TABLA_DETALLE
                          where det.descripcion == descripcion
                          select det.idDet).FirstOrDefaultAsync();
        }

        public async Task<List<TABLA_DETALLE>> GetDetalleByIdGeneral(int? id)
        {
            List<TABLA_DETALLE> general = await (from p in _context.TABLA_DETALLE join g in _context.TABLA_GENERAL
                                           on p.idTab equals g.idTab where g.idTab == id select p).ToListAsync();
            return general;
        }
    }
}
