using Clinica2._0.Data;
using Clinica2._0.DTO;
using Clinica2._0.Models;
using Clinica2._0.Repositories.EntityRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Clinica2._0.Repositories.EntityRepositories.Repositories

{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly ClinicaServiceContext _context;
        private readonly IMedicoRepository _medicoRepository;
        private readonly IEmpleadoRepository _empleadoRepository;
        private readonly IPacienteRepository _pacienteRepository;
        private readonly IDetalleRepository _detalleRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        public PersonaRepository(ClinicaServiceContext context, IMedicoRepository medicorepository, 
            IEmpleadoRepository empleadoRepository, IPacienteRepository pacienteRepository, IDetalleRepository detalleRepository
            , IUsuarioRepository usuarioRepository)
        {
            _context = context;
            _medicoRepository = medicorepository;
            _empleadoRepository = empleadoRepository;
            _pacienteRepository = pacienteRepository;
            _detalleRepository = detalleRepository;
            _usuarioRepository = usuarioRepository;
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
        public async Task<bool> PersonaExists(int? id)
        {
            return await _context.PERSONA.AnyAsync(e => e.dniPersona == id);
        }
        public async Task<int> getIdTpEmpleado(string descripcion)
        {
            return await (from d in _context.TABLA_DETALLE
                          where d.descripcion == descripcion
                         select d.idTablaDetalle
                         ).FirstOrDefaultAsync();
        }
        public async Task DeletePersona(int? PersonaID)
        {
            PERSONA Persona = await _context.PERSONA.FindAsync(PersonaID);
            Persona.idEstado = 2;
            Persona.fechaBaja = DateTime.Now.ToString();
            _context.Update(Persona);
            await Save();
            int idEmpleado = (from e in _context.EMPLEADO
                              where e.idPersona == Persona.idPersona
                              select e.idEmpleado).FirstOrDefault();
            int idMedico = (from m in _context.MEDICO
                            where m.idPersona == Persona.idPersona
                            select m.idMedico).FirstOrDefault();

            await _empleadoRepository.DeleteEmpleado(idEmpleado);
            await _medicoRepository.DeleteMedico(idMedico);
        }
        public async Task<string> InsertPersona(PersonaDTO persona)
        {
            int idPersona = 0;
            int idEmpleado = 0;
            int idPaciente = 0;
            string mensaje;
            try
            {
                if (!await PersonaExists(persona.numeroDocumento))
                {
                    await _context.PERSONA.AddAsync(new PERSONA()
                    {
                        apellidoPaterno = persona.apellidoPaterno,
                        apellidoMaterno = persona.apellidoMaterno,
                        nombres = persona.nombres,
                        idTipoDocumento = persona.idTipoDocumento,
                        dniPersona = persona.numeroDocumento,
                        idSexo = persona.idSexo,
                        fechaNacimiento = persona.fechaNacimiento,
                        idEstadoCivil = persona.idEstadoCivil,
                        idOcupacion = persona.idOcupacion,
                        domicioFiscal = persona.domicioFiscal,
                        telefono = persona.telefono,
                        celular = persona.celular,
                        correo = persona.correo,
                        idEstado = 1,
                        centroEducativo = persona.centroEducativo,
                        condicionRuc = persona.condicionRuc,
                        edad = persona.edad,
                        estadoRuc = persona.estadoRuc,
                        fotografia = persona.fotografia,
                        idCompañiaSeguro = persona.idCompañiaSeguro,
                        idDatoSiteds = persona.idDatoSiteds,
                        idEmpresaConvenio = persona.idEmpresaConvenio,
                        idEtnico = persona.idEtnico,
                        idGradoInstruccion = persona.idGradoInstruccion,
                        idParentesco = persona.idParentesco,
                        idReligion = persona.idReligion,
                        idTipoIafa = persona.idTipoIafa,
                        idtipoVia = persona.idTipoVia,
                        idUbigeoNacimiento = persona.idUbigeoNacimiento,
                        idUbigeoResidencia = persona.idUbigeoResidencia,
                        interior = persona.interior,
                        manzana = persona.manzana,
                        nombreVia = persona.nombreVia,
                        numeroBloque = persona.numeroBloque,
                        numeroDepartamento = persona.numeroDepartamento,
                        numeroEtapa = persona.numeroEtapa,
                        numeroKilometro = persona.numeroKilometro,
                        numeroLote = persona.numeroLote,
                        numeroRuc = persona.numeroRuc,
                        numeroVia = persona.numeroVia,
                        razonSocial = persona.razonSocial,
                        fechaBaja = null
                    });
                    await Save();
                    mensaje = "Ingreso Exitoso Persona";
                }
                else
                {
                    mensaje = "Ya existe una Persona con ese dni";
                }
                idPersona = (await _context.PERSONA
                        .FirstOrDefaultAsync(p => p.dniPersona == persona.numeroDocumento)).idPersona;
                if (persona.personal != null || persona.paciente != null)
                {
                    if (persona.personal != null)
                    {
                        if(!await _empleadoRepository.EmpleadoExists(idPersona)) await _empleadoRepository.InsertEmpleado(persona, idPersona);
                        idEmpleado = await _empleadoRepository.GetIdEmpleado(idPersona);
                        if (persona.personal.idTipoEmpleado == (int)await _detalleRepository.GetIdDetalleByDescripcion("MEDICA/O"))
                        {
                            if (!await _medicoRepository.MedicoExists(idPersona)) await _medicoRepository.InsertMedico(persona, idPersona, idEmpleado);
                        }
                        persona.personal.idEmpleado = idEmpleado;
                    }
                    else
                    {
                        if (!await _pacienteRepository.PacienteExists(idPersona)) await _pacienteRepository.InsertPaciente(persona, idPersona);
                        idPaciente = await _pacienteRepository.GetIdPaciente(idPersona);
                        persona.paciente.idPaciente = idPaciente;
                    }
                    persona.idPersona = idPersona;
                    await _usuarioRepository.InsertUsuario(persona);
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error en el guardado " + ex.Message;
            }
            return mensaje;
        }
        public async Task<string> UpdatePersona(PersonaDTO persona)
        {
            try
            {
                _context.Update(new PERSONA()
                {
                    idPersona = (int)persona.idPersona,
                    apellidoPaterno = persona.apellidoPaterno,
                    apellidoMaterno = persona.apellidoMaterno,
                    nombres = persona.nombres,
                    idTipoDocumento = persona.idTipoDocumento,
                    dniPersona = persona.numeroDocumento,
                    idSexo = persona.idSexo,
                    fechaNacimiento = persona.fechaNacimiento,
                    idEstadoCivil = persona.idEstadoCivil,
                    idOcupacion = persona.idOcupacion,
                    domicioFiscal = persona.domicioFiscal,
                    telefono = persona.telefono,
                    celular = persona.celular,
                    correo = persona.correo,
                    idEstado = persona.idEstado,
                    centroEducativo = persona.centroEducativo,
                    condicionRuc = persona.condicionRuc,
                    edad = persona.edad,
                    estadoRuc = persona.estadoRuc,
                    fotografia = persona.fotografia,
                    idCompañiaSeguro = persona.idCompañiaSeguro,
                    idDatoSiteds = persona.idDatoSiteds,
                    idEmpresaConvenio = persona.idEmpresaConvenio,
                    idEtnico = persona.idEtnico,
                    idGradoInstruccion = persona.idGradoInstruccion,
                    idParentesco = persona.idParentesco,
                    idReligion = persona.idReligion,
                    idTipoIafa = persona.idTipoIafa,
                    idtipoVia = persona.idTipoVia,
                    idUbigeoNacimiento = persona.idUbigeoNacimiento,
                    idUbigeoResidencia = persona.idUbigeoResidencia,
                    interior = persona.interior,
                    manzana = persona.manzana,
                    nombreVia = persona.nombreVia,
                    numeroBloque = persona.numeroBloque,
                    numeroDepartamento = persona.numeroDepartamento,
                    numeroEtapa = persona.numeroEtapa,
                    numeroKilometro = persona.numeroKilometro,
                    numeroLote = persona.numeroLote,
                    numeroRuc = persona.numeroRuc,
                    numeroVia = persona.numeroVia,
                    razonSocial = persona.razonSocial,
                    fechaBaja = null
                });
                await Save();
                if (persona.personal != null)
                {
                    await _empleadoRepository.UpdateEmpleado(persona);
                    if (persona.personal.idTipoEmpleado == (int)await _detalleRepository.GetIdDetalleByDescripcion("MEDICA/O"))
                    {
                        await _medicoRepository.UpdateMedico(persona);
                    }
                }
                else
                {
                    await _pacienteRepository.UpdatePaciente(persona);
                }
                return "Actualizacion Exitosa Persona";
            }
            catch (Exception ex)
            {

                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task<List<PersonaDTO>> GetAllPersonal()
        {
            List<PersonaDTO> Personas = await (from p in _context.PERSONA
                                               join e in _context.EMPLEADO on p.idPersona equals e.idPersona
                                               where e.idTipoEmpleado != null
                                               select new PersonaDTO
                                               {
                                                   idPersona = p.idPersona,
                                                   nombres = p.nombres,
                                                   apellidoPaterno = p.apellidoPaterno,
                                                   apellidoMaterno = p.apellidoMaterno,
                                                   telefono = p.telefono
                                               }).ToListAsync();

            for (int i = 0; i < Personas.Count; i++)
            {
                Personas[i].personal = await (from e in _context.EMPLEADO
                                              where e.idPersona == Personas[i].idPersona
                                              select new PersonalDTO
                                              {
                                                  fechaIngreso = e.fechaIngreso.Value.ToString("yyyy-MM-dd"),
                                                  cargo = e.cargo
                                              }).FirstOrDefaultAsync();
            }
            return Personas;
        }
        public async Task<List<PersonaDTO>> getPersonalxDnioNombresyApellidos(int? dni,string nombres, string apellidos)
        {
            List<PersonaDTO> Personas;
            if (dni != null && dni != 0)
            {
                Personas = await (from p in _context.PERSONA
                                                   join e in _context.EMPLEADO on p.idPersona equals e.idPersona
                                                   where e.idTipoEmpleado != null && p.dniPersona == dni
                                                   select new PersonaDTO
                                                   {
                                                       idPersona = p.idPersona,
                                                       nombres = p.nombres,
                                                       apellidoPaterno = p.apellidoPaterno,
                                                       apellidoMaterno = p.apellidoMaterno,
                                                       telefono = p.telefono
                                                   }).ToListAsync();

                for (int i = 0; i < Personas.Count; i++)
                {
                    Personas[i].personal = await (from e in _context.EMPLEADO
                                                  where e.idPersona == Personas[i].idPersona
                                                  select new PersonalDTO
                                                  {
                                                      fechaIngreso = e.fechaIngreso.Value.ToString("yyyy-MM-dd"),
                                                      cargo = e.cargo
                                                  }).FirstOrDefaultAsync();
                }
            }
            else
            {
                Personas = await (from p in _context.PERSONA
                                  join e in _context.EMPLEADO on p.idPersona equals e.idPersona
                                  where e.idTipoEmpleado != null &&
                                  (p.apellidoPaterno + " " + p.apellidoMaterno).Trim().Contains(apellidos)
                                  select new PersonaDTO
                                  {
                                      idPersona = p.idPersona,
                                      nombres = p.nombres,
                                      apellidoPaterno = p.apellidoPaterno,
                                      apellidoMaterno = p.apellidoMaterno,
                                      telefono = p.telefono
                                  }).ToListAsync();

                for (int i = 0; i < Personas.Count; i++)
                {
                    Personas[i].personal = await (from e in _context.EMPLEADO
                                                  where e.idPersona == Personas[i].idPersona
                                                  select new PersonalDTO
                                                  {
                                                      fechaIngreso = e.fechaIngreso.Value.ToString("yyyy-MM-dd"),
                                                      cargo = e.cargo
                                                  }).FirstOrDefaultAsync();
                }
            }
            return Personas;
        }


        public async Task<PersonaDTO> GetById(int? id)
        {
            PersonaDTO Persona = new PersonaDTO();
            Persona = await (from p in _context.PERSONA
                             join e in _context.EMPLEADO on p.idPersona equals e.idPersona
                             where p.idPersona == id
                             select new PersonaDTO
                             {
                                 idPersona = p.idPersona,
                                 nombres = p.nombres,
                                 apellidoPaterno = p.apellidoPaterno,
                                 apellidoMaterno = p.apellidoMaterno,
                                 fechaNacimiento = p.fechaNacimiento,
                                 telefono = p.telefono,
                                 numeroDocumento = (int)p.dniPersona,
                                 numeroRuc = p.numeroRuc
                             }).FirstOrDefaultAsync();
            Persona.personal = await (from e in _context.EMPLEADO
                                      where e.idPersona == Persona.idPersona
                                      select new PersonalDTO
                                      {
                                          idEmpleado = e.idEmpleado,
                                          idTipoEmpleado = e.idTipoEmpleado,
                                          fechaIngreso = e.fechaIngreso.Value.ToString("yyyy-MM-dd"),
                                          cargo = e.cargo,
                                          descripcionArea = e.descripcionArea
                                      }).FirstOrDefaultAsync();
            //Tipo de Empleado verificar
            if (Persona.personal.idTipoEmpleado == (int)await _detalleRepository.GetIdDetalleByDescripcion("MEDICA/O"))
            {
                PersonalDTO personaTemporal = new PersonalDTO();
                personaTemporal = await (from m in _context.MEDICO
                                             where m.idEmpleado == Persona.personal.idEmpleado
                                             select new PersonalDTO
                                             {
                                                 idEspecialidad = (from tb in _context.TABLA_DETALLE
                                                                   where m.idEspecialidad == tb.idTablaDetalle
                                                                   select m.idEspecialidad).FirstOrDefault(),
                                                 idMedico = m.idMedico,
                                                 numeroColegio = m.numeroColegio
                                             }).FirstOrDefaultAsync();
                Persona.personal.idEspecialidad = personaTemporal.idEspecialidad;
                Persona.personal.idMedico = personaTemporal.idMedico;
                Persona.personal.numeroColegio = personaTemporal.numeroColegio;
            }
            return Persona;
        }
    }

}