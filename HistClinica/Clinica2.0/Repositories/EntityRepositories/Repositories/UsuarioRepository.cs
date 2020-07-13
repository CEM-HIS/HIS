using Clinica2._0.Data;
using Clinica2._0.DTO;
using Clinica2._0.Models;
using Clinica2._0.Repositories.EntityRepositories.Interfaces;
using HistClinica.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Repositories.EntityRepositories.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ClinicaServiceContext _context;
        private readonly UsuarioContext _usuariocontext;
        public UsuarioRepository(ClinicaServiceContext context, UsuarioContext usuariocontext)
        {
            _context = context;
            _usuariocontext = usuariocontext;
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UsuarioExists(int? id)
        {
            return await _usuariocontext.USUARIO.AnyAsync(e => e.idEmpleado == id);
        }

        public async Task DeleteUsuario(int? UsuarioID)
        {
            USUARIO Usuario = await _usuariocontext.USUARIO.FindAsync(UsuarioID);
            Usuario.idEstado = 2;
          //  Usuario.fechaBaja = DateTime.Now.ToString();
            _context.Update(Usuario);
            await Save();
        }
        public async Task<string> InsertUsuario(PersonaDTO persona)
        {
            PERSONA _Persona = await (from p in _context.PERSONA
                                        join e in _context.EMPLEADO on p.idPersona equals e.idPersona
                                        where e.idEmpleado == persona.personal.idEmpleado
                                            select p).FirstOrDefaultAsync();
            try
            {
                if (await UsuarioExists(persona.personal.idEmpleado))
                {
                    USUARIO Usuario = await (from u in _usuariocontext.USUARIO where u.idEmpleado == persona.personal.idEmpleado select u).FirstOrDefaultAsync();
                    Usuario.fechaModifica = DateTime.Now.ToString();
                    Usuario.usuarioModifica = ""; //ToDo: Agregar usuario de sesiones
                    _context.Update(Usuario);
                    await Save();
                    return "Usuario ya asignado";
                }
                else
                {
                    string primeraletraapellido = _Persona.apellidoPaterno.Substring(0, 1).Trim();
                    string primernombre="";
                    string diaNacimiento = "";
                    if(_Persona.nombres.Trim().IndexOf(" ") != -1)
                    {
                        int espacioencontrado = _Persona.nombres.Trim().IndexOf(" ");
                        int tamañocadena = _Persona.nombres.Length;
                        primernombre = _Persona.nombres.Substring(0, tamañocadena - espacioencontrado).Trim();
                    }
                    else
                    {
                        primernombre = _Persona.nombres.Trim();
                    }
                    if (_Persona.fechaNacimiento != null)
                    {
                        diaNacimiento = Convert.ToDateTime(_Persona.fechaNacimiento).Day.ToString();
                    }
                    else return "No se pudo crear usuario por que falta fecha de nacimiento";
                    await _usuariocontext.USUARIO.AddAsync(new USUARIO()
                    {
                        idEmpleado = persona.personal.idEmpleado,
                        UserName = (primeraletraapellido + primernombre + diaNacimiento).ToLower(),
                        fechaCreacion = DateTime.Now.ToString(),
                        PasswordHash = persona.numeroDocumento.ToString(), //ToDo: Encriptar clave de usuario
                        usuarioCreacion = "",//ToDo: Agregar usuario de sesiones
                        idEstado = 1,
                        usuarioModifica = "",
                        fechaModifica = ""
                    });
                    await Save();
                    return "Se asigno usuario correctamente";   
                }
            }
            catch (Exception ex)
            {
                  return "Error en el guardado " + ex.Message;
            }
        }
    }
}
