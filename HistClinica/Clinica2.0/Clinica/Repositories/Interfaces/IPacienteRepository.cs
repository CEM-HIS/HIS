using Clinica2._0.DTO;
using Clinica2._0.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clinica2._0.Repositories.EntityRepositories.Interfaces
{
    public interface IPacienteRepository
    {
        Task<List<PACIENTE>> GetAllPacientes();
        Task<PersonaDTO> GetById(int? id);
        Task<PersonaDTO> GetByDnioNombresyApellidos(int? Dni, string nombres, string apellidos);
        //Operaciones Transaccionales
        Task<string> InsertPaciente(PersonaDTO Paciente, int idPersona);
        Task<string> UpdatePaciente(PersonaDTO Paciente);
        Task DeletePaciente(int PacienteID);
        Task<bool> PacienteExists(int? id);
        Task Save();
    }
}
