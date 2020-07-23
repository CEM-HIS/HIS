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
        #region usuario
        Task<string> InsertUsuario(PersonaDTO persona);
        //Task<string> UpdateUsuario(USUARIO usuario);
        Task<bool> UsuarioExists(int? id);
        //Task DeleteUsuario(int? UsuarioID);
        #endregion Usuario
        #region Rol
        #endregion Rol
        #region Perfil
        Task<string> InsertPerfil(PROFILE perfil);
        Task<string> UpdatePerfil(PROFILE perfil);
        Task<bool> PerfilExists(int? id);
        Task DeletePerfil(int? PerfilID);
        Task<List<PROFILE>> GetAllProfiles();
        #endregion Perfil
        #region Modulo
        #endregion Modulo
        #region Menu
        #endregion Menu
        Task Save();
    }
}
