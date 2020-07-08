using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HistClinica.DTO;
using HistClinica.Models;

namespace HistClinica.Repositories.Interfaces
{
    public interface IDetalleRepository
    {
        Task<TABLA_DETALLE> GetById(int? Id);
        //Operaciones Transaccionales
        Task<string> InsertDetalle(TABLA_DETALLE Detalle);
        Task<string> UpdateDetalle(TABLA_DETALLE Detalle);
        Task<string> DeleteDetalle(int DetalleID);
        Task<bool> DetalleExists(int? id);
        Task Save();

        Task<DetalleDTO> GetDetalle(int? id);
        Task<int> GetIdDetalleByDescripcion(string descripcion);
        Task<List<TABLA_DETALLE>> GetDetalleByIdGeneral(int? id);
    }
}
