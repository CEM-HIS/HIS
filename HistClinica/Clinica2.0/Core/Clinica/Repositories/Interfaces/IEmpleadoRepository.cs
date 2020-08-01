using Clinica2._0.DTO;
using System.Threading.Tasks;

namespace Clinica2._0.Repositories.EntityRepositories.Interfaces
{
    public interface IEmpleadoRepository
    {
        /*Task<List<PersonaDTO>> GetAllEmpleados();*/
        Task<int> GetIdEmpleadobyIdPersona(int? id);
        Task<int> GetIdEmpleadobyIdUser(string id);
        Task<PersonaDTO> GetById(int? id);
        //Operaciones Transaccionales
        Task<string> InsertEmpleado(PersonaDTO Empleado, int idPersona);
        Task<string> UpdateEmpleado(PersonaDTO Empleado);
        Task DeleteEmpleado(int EmpleadoID);
        Task<bool> EmpleadoExists(int? id);
        Task Save();
    }
}
