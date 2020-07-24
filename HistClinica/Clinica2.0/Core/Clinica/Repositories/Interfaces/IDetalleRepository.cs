using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinica2._0.DTO;
using Clinica2._0.Models;

namespace Clinica2._0.Repositories.EntityRepositories.Interfaces
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
        Task<object> GetEspecialidad(int id);
    }
}
