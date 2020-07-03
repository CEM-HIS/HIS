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
    public class MedicoRepository : IMedicoRepository
    {
        private readonly ClinicaServiceContext _context;
        public MedicoRepository(ClinicaServiceContext context)
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

        public async Task<bool> MedicoExists(int? id)
        {
            return await _context.T212_MEDICO.AnyAsync(e => e.idMedico == id);
        }
        public async Task DeleteMedico(int MedicoID)
        {
            T212_MEDICO Medico = await _context.T212_MEDICO.FindAsync(MedicoID);
            Medico.estado = 2;
            Medico.fechabaja = DateTime.Now.ToString();
            _context.Update(Medico);
            await Save();
        }
        public async Task<string> InsertMedico(PersonaDTO persona, int idPersona, int idEmpleado)
        {
            try
            {
                T212_MEDICO Medico = new T212_MEDICO()
                {
                    codMedico = persona.personal.codMedico,
                    nroColegio = persona.personal.numeroColegio,
                    nroRne = persona.personal.nroRne,
                    nroRuc = persona.personal.nroRucMedico,
                    idtpDocumento = persona.personal.idTipoEmpleado,
                    condicion = persona.personal.condicion,
                    idEmpleado = idEmpleado,
                    idEspecialidad = persona.personal.idEspecialidad,
                    idPersona = idPersona,
                    estado = 1,
                    fechabaja = null
                };
                await _context.T212_MEDICO.AddAsync(Medico);
                await Save();
                return "Ingreso Exitoso Medico";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.Message;
            }
        }
        public async Task<string> UpdateMedico(PersonaDTO persona)
        {
            try
            {
                T212_MEDICO Medico = new T212_MEDICO()
                {
                    idMedico = (int)persona.personal.idMedico,
                    codMedico = persona.personal.codMedico,
                    nroColegio = persona.personal.numeroColegio,
                    nroRne = persona.personal.nroRne,
                    nroRuc = persona.personal.nroRucMedico,
                    idtpDocumento = persona.personal.idTipoEmpleado,
                    condicion = persona.personal.condicion,
                    idEmpleado = persona.personal.idEmpleado,
                    idEspecialidad = persona.personal.idEspecialidad,
                    idPersona = persona.idPersona,
                    estado = (int)persona.personal.estadoMedico,
                    fechabaja = persona.personal.fechaBaja
                };
                _context.Update(Medico);
                await Save();
                return "Actualizacion Exitosa Medico";
            }
            catch (Exception ex)
            {

                return "Error en el guardado " + ex.StackTrace;
            }
        }

        public async Task<int> GetIdMedico(int? id)
        {
            int idMedico = await (from p in _context.T212_MEDICO
                                  where p.idPersona == id
                                  select p.idMedico).FirstOrDefaultAsync();
            return idMedico;
        }
    }
}
