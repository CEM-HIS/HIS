using HistClinica.DTO;
using HistClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.EntityRepositories.Interfaces
{
    public interface ICajaRepository
    {
        Task<List<CAJA>> GetAllCajas();
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
