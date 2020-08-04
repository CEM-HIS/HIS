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
        Task<List<D024_CAJA>> GetAllCajas();
        Task<D024_CAJA> GetById(int? Id);
        //Operaciones Transaccionales
        Task<string> InsertCaja(D024_CAJA Caja);
        Task<string> AsignaCaja(PersonaDTO persona);
        Task DeleteCaja(int CajaID);
        Task<bool> CajaExists(int? id);
        Task Save();
    }
}
