using HistClinica.Data;
using HistClinica.DTO;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Repositories
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        private readonly ClinicaServiceContext _context;
        public EmpleadoRepository(ClinicaServiceContext context)
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

        public async Task<bool> EmpleadoExists(int? id)
        {
            return await _context.T120_EMPLEADO.AnyAsync(e => e.idEmpleado == id);
        }

        public async Task DeleteEmpleado(int EmpleadoID)
        {
            T120_EMPLEADO Empleado = await _context.T120_EMPLEADO.FindAsync(EmpleadoID);
            Empleado.estado = 2;
            Empleado.fechabaja = DateTime.Now.ToString();
            _context.Update(Empleado);
            await Save();
        }

        public async Task<string> InsertEmpleado(PersonaDTO persona, int idPersona)
        {
            try
            {
                T120_EMPLEADO Empleado = new T120_EMPLEADO
                {
                    idPersona = idPersona,
                    codEmpleado = persona.personal.codEmpleado,
                    descArea = persona.personal.descArea,
                    cargo = persona.personal.cargo,
                    fecIngreso = null,
                    salario = persona.personal.salario,
                    genero = null,
                    idtpEmpleado = persona.personal.idTipoEmpleado,
                    estado = 1,
                    fechabaja = null
                };
                if (persona.personal.genero != null) Empleado.genero = persona.personal.genero;
                if (persona.personal.fechaIngreso != null) Empleado.fecIngreso = DateTime.Parse(persona.personal.fechaIngreso);
                await _context.T120_EMPLEADO.AddAsync(Empleado);
                await Save();
                return "Ingreso Exitoso Empleado";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.Message;
            }
        }
        public async Task<string> UpdateEmpleado(PersonaDTO persona)
        {
            try
            {
                T120_EMPLEADO Empleado = new T120_EMPLEADO
                {
                    idPersona = persona.idPersona,
                    idEmpleado = (int)persona.personal.idEmpleado,
                    codEmpleado = persona.personal.codEmpleado,
                    descArea = persona.personal.descArea,
                    cargo = persona.personal.cargo,
                    fecIngreso = DateTime.Parse(persona.personal.fechaIngreso),
                    salario = persona.personal.salario,
                    genero = persona.personal.genero,
                    idtpEmpleado = persona.personal.idTipoEmpleado,
                    estado = persona.personal.estadoEmpleado,
                    fechabaja = persona.personal.fechaBaja
                };
                _context.Update(Empleado);
                await Save();
                return "Actualizacion Exitosa Empleado";
            }
            catch (Exception ex)
            {

                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task<int> GetIdEmpleado(int? id)
        {
            int idEmpleado = await (from p in _context.T120_EMPLEADO
                                    where p.idPersona == id
                                    select p.idEmpleado).FirstOrDefaultAsync();
            return idEmpleado;
        }

        public async Task<PersonaDTO> GetById(int? id)
        {
            PersonaDTO personaDTO = await (from p in _context.T000_PERSONA
                                     join e in _context.T120_EMPLEADO on p.idPersona equals e.idPersona
                                     where p.idPersona == id
                                     select new PersonaDTO
                                     {
                                         nombres = p.nombres,
                                         numeroDocumento = p.dniPersona,
                                         personal = new PersonalDTO
                                         {
                                             idEmpleado = e.idEmpleado,
                                             idTipoEmpleado = e.idtpEmpleado
                                         }
                                     }).FirstOrDefaultAsync(); 
            return personaDTO;
        }
    }
}
