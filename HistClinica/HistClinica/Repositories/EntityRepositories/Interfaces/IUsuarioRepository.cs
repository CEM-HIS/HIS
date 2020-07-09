using HistClinica.DTO;
using HistClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.EntityRepositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<string> InsertUsuario(PersonaDTO persona);
        //Task<string> UpdateUsuario(USUARIO usuario);
        Task<bool> UsuarioExists(int? id);
        Task DeleteUsuario(int? UsuarioID);
        Task Save();
    }
}
