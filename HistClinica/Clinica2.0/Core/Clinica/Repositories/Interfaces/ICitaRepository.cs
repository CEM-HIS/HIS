using Clinica2._0.DTO;
using Clinica2._0.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clinica2._0.Repositories.EntityRepositories.Interfaces
{
    public interface ICitaRepository
    {
        Task<List<CitaDTO>> GetAllCitas(int idmedico, int idespecialidad, string fecha);
        Task<CitaDTO> GetById(int? Id);
        //Operaciones Transaccionales

        Task<string> InsertCita(CitaDTO Cita);
        Task<string> ReservaCupoCita(CitaDTO Cita);
        Task<string> AnularCita(int? CitaID,string motivoAnula);
        Task DeleteCita(int CitaID);
        Task<bool> CitaExists(int? id);
        Task Save();
        Task<string> UpdateCita(CitaDTO cita);
        Task<string> ReprogramarCupo(int paciente, CitaDTO cita,CitaDTO nuevacita, int citaactual);
        Task<string> CambiarEstadoCita(CitaDTO cita);
        Task<List<ESTADO_CITA>> getEstadoCita();
    }
}
