using Clinica2._0.DTO;
using Clinica2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Repositories.EntityRepositories.Interfaces
{
    public interface ICajaRepository
    {
        Task<List<CajaDTO>> GetAllCajas();
        Task<List<CajaDTO>> GetAllCajasAsignadas();
        Task<List<CajaDTO>> GetCajaAsignadaxUsuario();
        Task<CAJA> GetById(int? Id);
        //Operaciones Transaccionales
        Task<string> InsertCaja(CAJA Caja);
        Task<string> AperturaCaja(CAJA_ASIGNADA cajaAsignada);
        Task<string> CierreCaja(CAJA_ASIGNADA cajaAsignada);
        Task DeleteCaja(int CajaID);
        Task<bool> CajaExists(int? id);
        Task Save();
    }
}
