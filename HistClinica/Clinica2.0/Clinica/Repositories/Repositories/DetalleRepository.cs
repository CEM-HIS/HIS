using Clinica2._0.Data;
using Clinica2._0.DTO;
using Clinica2._0.Models;
using Clinica2._0.Repositories.EntityRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Repositories.EntityRepositories.Repositories
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
            return await _context.TABLA_DETALLE.AnyAsync(e => e.idTablaDetalle == id);
        }

        public async Task<TABLA_DETALLE> GetById(int? Id)
        {
            TABLA_DETALLE listaDetalle = new TABLA_DETALLE();
            listaDetalle = await (from detalle in _context.TABLA_DETALLE
                                 where detalle.idTablaDetalle == Id
                                 select new TABLA_DETALLE
                                 {
                                     idTablaDetalle = detalle.idTablaDetalle,
                                     codigoTablaDetalle = detalle.codigoTablaDetalle,
                                     descripcion = detalle.descripcion,
                                     idTablaGeneral = detalle.idTablaGeneral
                                 }).FirstOrDefaultAsync();
            return listaDetalle;
        }

        public async Task<string> InsertDetalle(TABLA_DETALLE Detalle)
        {
            try
            {
                await _context.TABLA_DETALLE.AddAsync(new TABLA_DETALLE()
                {
                    codigoTablaDetalle = Detalle.codigoTablaDetalle,
                    descripcion = Detalle.descripcion,
                    idTablaGeneral = Detalle.idTablaGeneral
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
                _context.Entry(Detalle).Property(x => x.codigoTablaDetalle).IsModified = true;
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
            dto.idTablaGeneral = general.idTablaGeneral;
            dto.codigoTablaGeneral = general.codigoTablaGeneral;
            dto.detalles = await GetDetalleByIdGeneral(id);
            return dto;
        }

        public async Task<int> GetIdDetalleByDescripcion(string descripcion)
        {
            return await (from det in _context.TABLA_DETALLE
                          where det.descripcion == descripcion
                          select det.idTablaDetalle).FirstOrDefaultAsync();
        }

        public async Task<List<TABLA_DETALLE>> GetDetalleByIdGeneral(int? id)
        {
            List<TABLA_DETALLE> general = await (from p in _context.TABLA_DETALLE join g in _context.TABLA_GENERAL
                                           on p.idTablaGeneral equals g.idTablaGeneral where g.idTablaGeneral == id select p).ToListAsync();
            return general;
        }
    }
}
