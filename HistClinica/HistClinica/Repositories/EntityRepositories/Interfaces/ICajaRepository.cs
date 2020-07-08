using HistClinica.DTO;
using HistClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Interfaces
{
    public interface ICajaRepository
    {
        Task<List<CAJA>> GetAllCajas();
        Task<CAJA> GetById(int? Id);
        //Operaciones Transaccionales
        Task<string> InsertCaja(CajaDTO Caja);
        Task<string> AsignaCaja(CAJA_ASIGNADA cajaAsignada);
        Task DeleteCaja(int CajaID);
        Task<bool> CajaExists(int? id);
        Task Save();
    }
}
