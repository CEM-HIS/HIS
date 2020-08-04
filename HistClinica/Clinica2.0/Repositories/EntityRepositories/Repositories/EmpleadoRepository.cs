using Clinica2._0.Data;
using Clinica2._0.DTO;
using Clinica2._0.Models;
using Clinica2._0.Repositories.EntityRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Repositories.EntityRepositories.Repositories
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
            return await _context.EMPLEADO.AnyAsync(e => e.idEmpleado == id);
        }

        public async Task DeleteEmpleado(int EmpleadoID)
        {
            EMPLEADO Empleado = await _context.EMPLEADO.FindAsync(EmpleadoID);
            Empleado.idEstado = 2;
            Empleado.fechaBaja = DateTime.Now.ToString();
            _context.Update(Empleado);
            await Save();
        }

        public async Task<string> InsertEmpleado(PersonaDTO persona, int idPersona)
        {
            try
            {
                EMPLEADO Empleado = new EMPLEADO
                {
                    idPersona = idPersona,
                    codigoEmpleado = persona.personal.codigoEmpleado,
                    descripcionArea = persona.personal.descripcionArea,
                    cargo = persona.personal.cargo,
                    fechaIngreso = null,
                    salario = persona.personal.salario,
                    idGenero = null,
                    idTipoEmpleado = persona.personal.idTipoEmpleado,
                    idEstado = 1,
                    fechaBaja = null
                };
                if (persona.personal.idGenero != null) Empleado.idGenero = persona.personal.idGenero;
                if (persona.personal.fechaIngreso != null) Empleado.fechaIngreso = DateTime.Parse(persona.personal.fechaIngreso);
                await _context.EMPLEADO.AddAsync(Empleado);
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
                EMPLEADO Empleado = new EMPLEADO
                {
                    idPersona = persona.idPersona,
                    idEmpleado = (int)persona.personal.idEmpleado,
                    codigoEmpleado = persona.personal.codigoEmpleado,
                    descripcionArea = persona.personal.descripcionArea,
                    cargo = persona.personal.cargo,
                    fechaIngreso = DateTime.Parse(persona.personal.fechaIngreso),
                    salario = persona.personal.salario,
                    idGenero = persona.personal.idGenero,
                    idTipoEmpleado = persona.personal.idTipoEmpleado,
                    idEstado = persona.personal.estadoEmpleado,
                    fechaBaja = persona.personal.fechaBaja
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
            int idEmpleado = await (from p in _context.EMPLEADO
                                    where p.idPersona == id
                                    select p.idEmpleado).FirstOrDefaultAsync();
            return idEmpleado;
        }

        public async Task<PersonaDTO> GetById(int? id)
        {
            PersonaDTO personaDTO = await (from p in _context.PERSONA
                                     join e in _context.EMPLEADO on p.idPersona equals e.idPersona
                                     where p.idPersona == id
                                     select new PersonaDTO
                                     {
                                         nombres = p.nombres,
                                         apellidoPaterno = p.apellidoPaterno,
                                         apellidoMaterno = p.apellidoPaterno,
                                         numeroDocumento = p.dniPersona,
                                         personal = new PersonalDTO
                                         {
                                             idEmpleado = e.idEmpleado,
                                             idTipoEmpleado = e.idTipoEmpleado
                                         }
                                     }).FirstOrDefaultAsync(); 
            return personaDTO;
        }
    }
}
