using HistClinica.Data;
using HistClinica.DTO;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ClinicaServiceContext _context;
        public UsuarioRepository(ClinicaServiceContext context)
        {
            _context = context;
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
            return await _context.D001_USUARIO.AnyAsync(e => e.idEmpleado == id);
        }

        public async Task DeleteUsuario(int? UsuarioID)
        {
            D001_USUARIO Usuario = await _context.D001_USUARIO.FindAsync(UsuarioID);
            Usuario.estado = "2";
          //  Usuario.fechaBaja = DateTime.Now.ToString();
            _context.Update(Usuario);
            await Save();
        }
        public async Task<string> InsertUsuario(PersonaDTO persona)
        {
            T000_PERSONA _Persona = await (from p in _context.T000_PERSONA
                                        join e in _context.T120_EMPLEADO on p.idPersona equals e.idPersona
                                        where e.idEmpleado == persona.personal.idEmpleado
                                            select p).FirstOrDefaultAsync();
            try
            {
                if (await UsuarioExists(persona.personal.idEmpleado))
                {
                    D001_USUARIO Usuario = await (from u in _context.D001_USUARIO where u.idEmpleado == persona.personal.idEmpleado select u).FirstOrDefaultAsync();
                    Usuario.fechaMod = DateTime.Now.ToString();
                    Usuario.usuMod = ""; //ToDo: Agregar usuario de sesiones
                    _context.Update(Usuario);
                    await Save();
                    return "Usuario ya asignado";
                }
                else
                {
                    string primeraletraapellido = _Persona.apePaterno.Substring(0, 1).Trim();
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
                    if (_Persona.fecNace != null)
                    {
                        diaNacimiento = Convert.ToDateTime(_Persona.fecNace).Day.ToString();
                    }
                    else return "No se pudo crear usuario por que falta fecha de nacimiento";
                    await _context.D001_USUARIO.AddAsync(new D001_USUARIO()
                    {
                        idEmpleado = persona.personal.idEmpleado,
                        loginUser = (primeraletraapellido + primernombre + diaNacimiento).ToLower(),
                        fechaCrea = DateTime.Now.ToString(),
                        claveUser = persona.numeroDocumento.ToString(),
                        usuCrea = "",//ToDo: Agregar usuario de sesiones
                        estado = "1",
                        usuMod = "",
                        fechaMod = ""
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
