using HistClinica.DTO;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Interfaces
{
    public interface IEmpleadoRepository
    {
        /*Task<List<PersonaDTO>> GetAllEmpleados();*/
        Task<int> GetIdEmpleado(int? id);
        Task<PersonaDTO> GetById(int? id);
        //Operaciones Transaccionales
        Task<string> InsertEmpleado(PersonaDTO Empleado, int idPersona);
        Task<string> UpdateEmpleado(PersonaDTO Empleado);
        Task DeleteEmpleado(int EmpleadoID);
        Task<bool> EmpleadoExists(int? id);
        Task Save();
    }
}
