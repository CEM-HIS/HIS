using Clinica2._0.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clinica2._0.Repositories.EntityRepositories.Interfaces
{
    public interface IMedicoRepository
    {
        /*Task<List<PersonaDTO>> GetAllMedicos();*/
        Task<int> GetIdMedico(int? id);
        //Operaciones Transaccionales
        Task<string> InsertMedico(PersonaDTO Medico, int idPersona, int idEmpleado);
        Task<string> UpdateMedico(PersonaDTO Medico);
        Task DeleteMedico(int MedicoID);
        Task<bool> MedicoExists(int? id);

        Task<List<MedicoDTO>> getAllMedico();
        Task Save();
    }
}
