﻿using HistClinica.Data;
using HistClinica.DTO;
using HistClinica.Models;
using HistClinica.Repositories.EntityRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Repositories.EntityRepositories.Repositories
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
            return await _context.MEDICO.AnyAsync(e => e.idMedico == id);
        }
        public async Task DeleteMedico(int MedicoID)
        {
            MEDICO Medico = await _context.MEDICO.FindAsync(MedicoID);
            Medico.idEstado = 2;
            Medico.fechaBaja = DateTime.Now.ToString();
            _context.Update(Medico);
            await Save();
        }
        public async Task<string> InsertMedico(PersonaDTO persona, int idPersona, int idEmpleado)
        {
            try
            {
                MEDICO Medico = new MEDICO()
                {
                    codigoMedico = persona.personal.codigoMedico,
                    numeroColegio = persona.personal.numeroColegio,
                    numeroRne = persona.personal.numeroRne,
                    numeroRuc = persona.personal.numeroRuc,
                    idTipoDocumento = persona.personal.idTipoEmpleado,
                    condicion = persona.personal.condicion,
                    idEmpleado = idEmpleado,
                    idEspecialidad = persona.personal.idEspecialidad,
                    idPersona = idPersona,
                    idEstado = 1,
                    fechaBaja = null
                };
                await _context.MEDICO.AddAsync(Medico);
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
                MEDICO Medico = new MEDICO()
                {
                    idMedico = (int)persona.personal.idMedico,
                    codigoMedico = persona.personal.codigoMedico,
                    numeroColegio = persona.personal.numeroColegio,
                    numeroRne = persona.personal.numeroRne,
                    numeroRuc = persona.personal.numeroRuc,
                    idTipoDocumento = persona.personal.idTipoEmpleado,
                    condicion = persona.personal.condicion,
                    idEmpleado = persona.personal.idEmpleado,
                    idEspecialidad = persona.personal.idEspecialidad,
                    idPersona = persona.idPersona,
                    idEstado = (int)persona.personal.idEstado,
                    fechaBaja = persona.personal.fechaBaja
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
            int idMedico = await (from p in _context.MEDICO
                                  where p.idPersona == id
                                  select p.idMedico).FirstOrDefaultAsync();
            return idMedico;
        }
    }
}
