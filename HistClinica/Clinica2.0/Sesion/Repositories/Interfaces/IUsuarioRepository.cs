using Clinica2._0.DTO;
using Clinica2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Repositories.EntityRepositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<string> InsertUsuario(PersonaDTO persona);
        //Task<string> InsertUsuario(int id);
        //Task<string> UpdateUsuario(USUARIO usuario);
        Task<bool> UsuarioExists(int? id);
        Task DeleteUsuario(int? UsuarioID);
        Task Save();
    }
}
