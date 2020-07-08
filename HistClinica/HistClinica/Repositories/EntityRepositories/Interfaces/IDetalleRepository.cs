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
        Task<TABLADETALLE> GetById(int? Id);
        //Operaciones Transaccionales
        Task<string> InsertDetalle(TABLADETALLE Detalle);
        Task<string> UpdateDetalle(TABLADETALLE Detalle);
        Task<string> DeleteDetalle(int DetalleID);
        Task<bool> DetalleExists(int? id);
        Task Save();

        Task<DetalleDTO> GetDetalle(int? id);
        Task<int> GetIdDetalleByDescripcion(string descripcion);
        Task<List<TABLADETALLE>> GetDetalleByIdGeneral(int? id);
    }
}
