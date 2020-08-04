using HistClinica.Data;
using HistClinica.DTO;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace HistClinica.Repositories.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly ClinicaServiceContext _context;
        private readonly IMedicoRepository _medicoRepository;
        private readonly IEmpleadoRepository _empleadoRepository;
        private readonly IPacienteRepository _pacienteRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IDetalleRepository _detalleRepository;
        public PersonaRepository(ClinicaServiceContext context, IMedicoRepository medicorepository, 
            IEmpleadoRepository empleadoRepository, IPacienteRepository pacienteRepository,
            IUsuarioRepository usuarioRepository, IDetalleRepository detalleRepository)
        {
            _context = context;
            _medicoRepository = medicorepository;
            _empleadoRepository = empleadoRepository;
            _pacienteRepository = pacienteRepository;
            _usuarioRepository = usuarioRepository;
            _detalleRepository = detalleRepository;
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
            return await _context.T000_PERSONA.AnyAsync(e => e.idPersona == id);
        }
        public async Task<int> getIdTpEmpleado(string descripcion)
        {
            return await (from d in _context.D00_TBDETALLE
                          where d.descripcion == descripcion
                         select d.idDet
                         ).FirstOrDefaultAsync();
        }
        public async Task DeletePersona(int? PersonaID)
        {
            T000_PERSONA Persona = await _context.T000_PERSONA.FindAsync(PersonaID);
            Persona.estado = "2";
            Persona.fechabaja = DateTime.Now.ToString();
            _context.Update(Persona);
            await Save();
            int idEmpleado = (from e in _context.T120_EMPLEADO
                              where e.idPersona == Persona.idPersona
                              select e.idEmpleado).FirstOrDefault();
            int idMedico = (from m in _context.T212_MEDICO
                            where m.idPersona == Persona.idPersona
                            select m.idMedico).FirstOrDefault();

            await _empleadoRepository.DeleteEmpleado(idEmpleado);
            await _medicoRepository.DeleteMedico(idMedico);
            await _usuarioRepository.DeleteUsuario(idEmpleado);
        }
        public async Task<string> InsertPersona(PersonaDTO persona)
        {
            int idPersona = 0;
            int idEmpleado = 0;
            try
            {
                await _context.T000_PERSONA.AddAsync(new T000_PERSONA()
                {
                    apePaterno = persona.apellidoPaterno,
                    apeMaterno = persona.apellidoMaterno,
                    nombres = persona.nombres,
                    idtpDocumento = persona.idTipoDocumento,
                    dniPersona = persona.numeroDocumento,
                    idSexo = persona.idSexo,
                    fecNace = persona.fecNacimiento,
                    idEstCivil = persona.idEstCivil,
                    idOcupacion = persona.idOcupacion,
                    domiFiscal = persona.domiFiscal,
                    telefono = persona.telefono,
                    celular = persona.celular,
                    correo = persona.correo,
                    estado = "1",
                    centroEduca = persona.centroEduca,
                    condicionRuc = persona.condicionRuc,
                    edad = persona.edad,
                    estadoRuc = persona.estadoRuc,
                    fotografia = persona.fotografia,
                    idciaSeguro = persona.idciaSeguro,
                    iddatoSiteds = persona.iddatoSiteds,
                    idemprConvenio = persona.idemprConvenio,
                    idEtnico = persona.idEtnico,
                    idFactorrh = persona.idFactorrh,
                    idgpoSangre = persona.idgpoSangre,
                    idGrdInstruc = persona.idGradoInstruccion,
                    idParentesco = persona.idParentesco,
                    idReligion = persona.idReligion,
                    idtipoIafa = persona.idtipoIafa,
                    idtipoVia = persona.idtipoVia,
                    idUbigeoNace = persona.idUbigeoNace,
                    idUbigeoResi = persona.idUbigeoResi,
                    interior = persona.interior,
                    manzana = persona.manzana,
                    nombreVia = persona.nombreVia,
                    nroBlock = persona.nroBlock,
                    nroDpto = persona.nroDpto,
                    nroEtapa = persona.nroEtapa,
                    nroKm = persona.nroKm,
                    nroLote = persona.nroLote,
                    nroRuc = persona.ruc,
                    nroVia = persona.nroVia,
                    razonSocial = persona.razonSocial,
                    tpPersona = persona.tpPersona
                });
                await Save();
                idPersona = (await _context.T000_PERSONA
                    .FirstOrDefaultAsync(p => p.dniPersona == persona.numeroDocumento)).idPersona;
                if (persona.personal != null)
                {
                    await _empleadoRepository.InsertEmpleado(persona, idPersona);
                    idEmpleado = await _empleadoRepository.GetIdEmpleado(idPersona);
                    if (persona.personal.idTipoEmpleado == (int)await _detalleRepository.GetIdDetalleByDescripcion("MEDICA/O"))
                    {
                        await _medicoRepository.InsertMedico(persona, idPersona, idEmpleado);
                    }
                }
                else
                {
                    await _pacienteRepository.InsertPaciente(persona, idPersona);
                }
                return "Ingreso Exitoso Persona";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.Message;
            }
        }
        public async Task<string> UpdatePersona(PersonaDTO persona)
        {
            try
            {
                _context.Update(new T000_PERSONA()
                {
                    idPersona = (int)persona.idPersona,
                    apePaterno = persona.apellidoPaterno,
                    apeMaterno = persona.apellidoMaterno,
                    nombres = persona.nombres,
                    idtpDocumento = persona.idTipoDocumento,
                    dniPersona = persona.numeroDocumento,
                    idSexo = persona.idSexo,
                    fecNace = persona.fecNacimiento,
                    idEstCivil = persona.idEstCivil,
                    idOcupacion = persona.idOcupacion,
                    domiFiscal = persona.domiFiscal,
                    telefono = persona.telefono,
                    celular = persona.celular,
                    correo = persona.correo,
                    estado = "1",
                    centroEduca = persona.centroEduca,
                    condicionRuc = persona.condicionRuc,
                    edad = persona.edad,
                    estadoRuc = persona.estadoRuc,
                    fotografia = persona.fotografia,
                    idciaSeguro = persona.idciaSeguro,
                    iddatoSiteds = persona.iddatoSiteds,
                    idemprConvenio = persona.idemprConvenio,
                    idEtnico = persona.idEtnico,
                    idFactorrh = persona.idFactorrh,
                    idgpoSangre = persona.idgpoSangre,
                    idGrdInstruc = persona.idGradoInstruccion,
                    idParentesco = persona.idParentesco,
                    idReligion = persona.idReligion,
                    idtipoIafa = persona.idtipoIafa,
                    idtipoVia = persona.idtipoVia,
                    idUbigeoNace = persona.idUbigeoNace,
                    idUbigeoResi = persona.idUbigeoResi,
                    interior = persona.interior,
                    manzana = persona.manzana,
                    nombreVia = persona.nombreVia,
                    nroBlock = persona.nroBlock,
                    nroDpto = persona.nroDpto,
                    nroEtapa = persona.nroEtapa,
                    nroKm = persona.nroKm,
                    nroLote = persona.nroLote,
                    nroRuc = persona.ruc,
                    nroVia = persona.nroVia,
                    razonSocial = persona.razonSocial,
                    tpPersona = persona.tpPersona
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
            List<PersonaDTO> Personas = await (from p in _context.T000_PERSONA
                                               join e in _context.T120_EMPLEADO on p.idPersona equals e.idPersona
                                               where e.idtpEmpleado != null
                                               select new PersonaDTO
                                               {
                                                   idPersona = p.idPersona,
                                                   nombres = p.nombres,
                                                   apellidoPaterno = p.apePaterno,
                                                   apellidoMaterno = p.apeMaterno,
                                                   telefono = p.telefono
                                               }).ToListAsync();

            for (int i = 0; i < Personas.Count; i++)
            {
                Personas[i].personal = await (from e in _context.T120_EMPLEADO
                                              where e.idPersona == Personas[i].idPersona
                                              select new PersonalDTO
                                              {
                                                  fechaIngreso = e.fecIngreso.Value.ToString("yyyy-MM-dd"),
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
                Personas = await (from p in _context.T000_PERSONA
                                                   join e in _context.T120_EMPLEADO on p.idPersona equals e.idPersona
                                                   where e.idtpEmpleado != null && p.dniPersona == dni
                                                   select new PersonaDTO
                                                   {
                                                       idPersona = p.idPersona,
                                                       nombres = p.nombres,
                                                       apellidoPaterno = p.apePaterno,
                                                       apellidoMaterno = p.apeMaterno,
                                                       telefono = p.telefono
                                                   }).ToListAsync();

                for (int i = 0; i < Personas.Count; i++)
                {
                    Personas[i].personal = await (from e in _context.T120_EMPLEADO
                                                  where e.idPersona == Personas[i].idPersona
                                                  select new PersonalDTO
                                                  {
                                                      fechaIngreso = e.fecIngreso.Value.ToString("yyyy-MM-dd"),
                                                      cargo = e.cargo
                                                  }).FirstOrDefaultAsync();
                }
            }
            else
            {
                Personas = await (from p in _context.T000_PERSONA
                                  join e in _context.T120_EMPLEADO on p.idPersona equals e.idPersona
                                  where e.idtpEmpleado != null &&
                                  (p.apePaterno + " " + p.apeMaterno).Trim().Contains(apellidos)
                                  select new PersonaDTO
                                  {
                                      idPersona = p.idPersona,
                                      nombres = p.nombres,
                                      apellidoPaterno = p.apePaterno,
                                      apellidoMaterno = p.apeMaterno,
                                      telefono = p.telefono
                                  }).ToListAsync();

                for (int i = 0; i < Personas.Count; i++)
                {
                    Personas[i].personal = await (from e in _context.T120_EMPLEADO
                                                  where e.idPersona == Personas[i].idPersona
                                                  select new PersonalDTO
                                                  {
                                                      fechaIngreso = e.fecIngreso.Value.ToString("yyyy-MM-dd"),
                                                      cargo = e.cargo
                                                  }).FirstOrDefaultAsync();
                }
            }
            return Personas;
        }


        public async Task<PersonaDTO> GetById(int? id)
        {
            PersonaDTO Persona = new PersonaDTO();
            Persona = await (from p in _context.T000_PERSONA
                             join e in _context.T120_EMPLEADO on p.idPersona equals e.idPersona
                             where p.idPersona == id
                             select new PersonaDTO
                             {
                                 idPersona = p.idPersona,
                                 nombres = p.nombres,
                                 apellidoPaterno = p.apePaterno,
                                 apellidoMaterno = p.apeMaterno,
                                 fecNacimiento = p.fecNace,
                                 telefono = p.telefono,
                                 numeroDocumento = (int)p.dniPersona,
                                 ruc = p.nroRuc
                             }).FirstOrDefaultAsync();
            Persona.personal = await (from e in _context.T120_EMPLEADO
                                      where e.idPersona == Persona.idPersona
                                      select new PersonalDTO
                                      {
                                          idEmpleado = e.idEmpleado,
                                          idTipoEmpleado = e.idtpEmpleado,
                                          fechaIngreso = e.fecIngreso.Value.ToString("yyyy-MM-dd"),
                                          cargo = e.cargo,
                                          descArea = e.descArea
                                      }).FirstOrDefaultAsync();
            //Tipo de Empleado verificar
            if (Persona.personal.idTipoEmpleado == (int)await _detalleRepository.GetIdDetalleByDescripcion("MEDICA/O"))
            {
                PersonalDTO personaTemporal = new PersonalDTO();
                personaTemporal = await (from m in _context.T212_MEDICO
                                             where m.idEmpleado == Persona.personal.idEmpleado
                                             select new PersonalDTO
                                             {
                                                 idEspecialidad = (from tb in _context.D00_TBDETALLE
                                                                   where m.idEspecialidad == tb.idDet
                                                                   select m.idEspecialidad).FirstOrDefault(),
                                                 idMedico = m.idMedico,
                                                 numeroColegio = m.nroColegio
                                             }).FirstOrDefaultAsync();
                Persona.personal.idEspecialidad = personaTemporal.idEspecialidad;
                Persona.personal.idMedico = personaTemporal.idMedico;
                Persona.personal.numeroColegio = personaTemporal.numeroColegio;
            }
            return Persona;
        }
    }

}