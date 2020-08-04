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
        Task<D00_TBDETALLE> GetById(int? Id);
        //Operaciones Transaccionales
        Task<string> InsertDetalle(D00_TBDETALLE Detalle);
        Task<string> UpdateDetalle(D00_TBDETALLE Detalle);
        Task<string> DeleteDetalle(int DetalleID);
        Task<bool> DetalleExists(int? id);
        Task Save();

        Task<DetalleDTO> GetDetalle(int? id);
        Task<int> GetIdDetalleByDescripcion(string descripcion);
        Task<List<D00_TBDETALLE>> GetDetalleByIdGeneral(int? id);
    }
}
