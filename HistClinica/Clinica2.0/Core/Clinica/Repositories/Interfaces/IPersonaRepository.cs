using Clinica2._0.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clinica2._0.Repositories.EntityRepositories.Interfaces
{
    public interface IPersonaRepository
    {
        Task<List<PersonaDTO>> GetAllPersonal();
        Task<PersonaDTO> GetById(int? PersonaID);
        Task<List<PersonaDTO>> getPersonalxDnioNombresyApellidos(int? dni, string nombres, string apellidos);
        //Operaciones Transaccionales
        Task<string> InsertPersona(PersonaDTO Persona);
        Task<string> UpdatePersona(PersonaDTO Persona);
        Task DeletePersona(int? PersonaID);
        Task<bool> PersonaExists(int? id);
        Task Save();
    }
}
