﻿using Clinica2._0.Data;
using Clinica2._0.DTO;
using Clinica2._0.Models;
using Clinica2._0.Repositories.EntityRepositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Clinica2._0.Repositories.EntityRepositories.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SignInManager<USER> _signInManager;
        private readonly UserManager<USER> _userManager;
        private readonly ILogger<USER> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ClinicaServiceContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UsuarioRepository(
            UserManager<USER> userManager,
            SignInManager<USER> signInManager,
            ILogger<USER> logger,
            IEmailSender emailSender,
            IHttpContextAccessor httpContextAccessor,
            ClinicaServiceContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _context = context;
            _httpContextAccessor = httpContextAccessor;
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
        #region Usuario
        public async Task<bool> UsuarioExists(int? id)
        {
            return await _context.USER.AnyAsync(e => e.idEmployee == id);
        }
        //public async Task DeleteUsuario(int? UsuarioID)
        //{
        //    USER Usuario = await _context.USER.FindAsync(UsuarioID);
        //    Usuario.idState = 2;
        //    Usuario.DropDate = DateTime.Now.ToString();
        //    _context.Update(Usuario);
        //    await Save();
        //}
        public async Task<string> InsertUsuario(PersonaDTO persona)
        {
            PERSONA _Persona = await (from p in _context.PERSONA
                                      join e in _context.EMPLEADO on p.idPersona equals e.idPersona
                                      where e.idEmpleado == persona.personal.idEmpleado
                                      select p).FirstOrDefaultAsync();
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            try
            {
                if (!await UsuarioExists(persona.personal.idEmpleado))
                {
                    string primeraletraapellido = _Persona.apellidoPaterno.Substring(0, 1).Trim();
                    string primernombre = "";
                    string diaNacimiento = "";
                    if (_Persona.nombres.Trim().IndexOf(" ") != -1)
                    {
                        int espacioencontrado = _Persona.nombres.Trim().IndexOf(" ");
                        int tamañocadena = _Persona.nombres.Length;
                        primernombre = _Persona.nombres.Substring(0, espacioencontrado).Trim();
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

                    var user = new USER()
                    {
                        UserName = (primeraletraapellido + primernombre + diaNacimiento).ToLower(),
                        Email = "userPrueba@gmail.com",
                        PhoneNumber = _Persona.celular ?? _Persona.telefono,
                        idEmployee = persona.personal.idEmpleado,
                        idState = 1,
                        creationUser = userId,
                        creationDate = DateTime.Now.ToString(),
                        modifyUser = null,
                        modifyDate = null,
                        DropDate = null
                    };

                    var result = await _userManager.CreateAsync(user, primeraletraapellido.ToUpper() + primernombre.ToLower()  +"_"+ _Persona.dniPersona.ToString());
                    if (result.Succeeded)
                    {
                        _logger.LogInformation("User created a new account with password.");
                        return "Se asigno usuario correctamente";
                    }
                    else
                    {
                        return "Error en registro de Usuario";
                    }
                }
                else
                {
                    USER Usuario = await (from u in _context.USER where u.idEmployee == persona.personal.idEmpleado select u).FirstOrDefaultAsync();
                    Usuario.modifyDate = DateTime.Now.ToString();
                    Usuario.modifyUser = userId;
                    _context.Update(Usuario);
                    await Save();
                    return "Usuario ya asignado";
                }
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.Message;
            }
        }
        #endregion Usuario
        #region Rol
        #endregion Rol
        #region Perfil
        #endregion Perfil
        #region Modulo
        #endregion Modulo
        #region Menu
        #endregion Menu
    }
}
