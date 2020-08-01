using Clinica2._0.Core.Clinica.DTO;
using Clinica2._0.Data;
using Clinica2._0.DTO;
using Clinica2._0.Models;
using Clinica2._0.Repositories.EntityRepositories.Interfaces;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Clinica2._0.Repositories.EntityRepositories.Repositories

{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly ClinicaServiceContext _context;
        public PacienteRepository(ClinicaServiceContext context)
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

        public async Task<bool> PacienteExists(int? id)
        {
            return await _context.PACIENTE.AnyAsync(e => e.idPersona == id);
        }
        public async Task DeletePaciente(int PacienteID)
        {
            PACIENTE Paciente = await _context.PACIENTE.FindAsync(PacienteID);
            Paciente.idEstado = 2;
            Paciente.fechaBaja = DateTime.Now.ToString();
            _context.Update(Paciente);
            await Save();
        }
        public async Task<string> InsertPaciente(PersonaDTO persona, int idPersona)
        {
            PACIENTE Paciente;
            try
            {
                Paciente = new PACIENTE()
                {
                    codigoPaciente = persona.paciente.codigoPaciente,
                    descripcion = persona.paciente.descripcion,
                    numeroHc = Convert.ToString(persona.numeroDocumento),
                    nombreAcompañante = persona.paciente.NombreAcompañante,
                    edadAcompañante = persona.paciente.edadAcompañante,
                    dniAcompañante = persona.paciente.numeroDocumentoAcompañante,
                    idGrupoSanguineo = persona.paciente.idGrupoSanguineo,
                    idFactorRh = persona.paciente.idFactorRrh,
                    cobertura = persona.paciente.coberturaCompañia ?? persona.paciente.coberturaConvenio,
                    ordenAtenMedica = persona.paciente.ordenAtencionMedicaCompañia ?? persona.paciente.ordenAtencionMedicaConvenio,
                    nombreAsegurado = persona.paciente.nombreAseguradoraCompañia,
                    codigoAsegurado = persona.paciente.codigoAseguradoCompañia,
                    poliza = persona.paciente.polizaCompañia,
                    idParentesco = persona.paciente.idParentescoPaciente,
                    inicioVigencia = persona.paciente.inicioVigenciaCompañia ?? persona.paciente.inicioVigenciaConvenio,
                    finVigencia = persona.paciente.finVigenciaCompañia ?? persona.paciente.finVigenciaConvenio,
                    idTipoPlanSalud = persona.paciente.tipoPlanSaludCompañia,
                    numeroPlanSalud = persona.paciente.numeroPlanSaludCompañia,
                    idTipoAfiliacion = persona.paciente.idtipoAfiliacion,
                    fechaAfiliacion = persona.paciente.fechaAfiliacion,
                    codigoTitular = persona.paciente.codigoTitular,
                    moneda = persona.paciente.moneda,
                    nombreContratante = persona.paciente.nombreContratante,
                    idTipoDocumento = persona.paciente.idTipoDocumentoAcompañante,
                    dniContratante = persona.paciente.dniContratante,
                    planSalud = persona.paciente.planSalud,
                    codigoCobertura = persona.paciente.codigoCobertura,
                    beneficio = persona.paciente.beneficio,
                    restriccion = persona.paciente.restriccion,
                    copagoFijo = persona.paciente.copagoFijo,
                    copagoVariable = persona.paciente.copagoVariable,
                    finCarencia = persona.paciente.finCarencia,
                    convenio = persona.paciente.convenio,
                    descuento = persona.paciente.descuento,
                    codigoPacienteConvenio = persona.paciente.codigoPacienteConvenio,
                    descripcionPacienteConvenio = persona.paciente.descripcionPacienteConvenio,
                    estadoPacienteConvenio = persona.paciente.estadoPacienteConvenio,
                    codigoPacienteSoat = persona.paciente.codigoPacienteSoat,
                    descripcionPacienteSoat = persona.paciente.descripcionPacienteSoat,
                    estadoPacienteSoat = persona.paciente.estadoPacienteSoat,
                    codigoPacienteExterno = persona.paciente.codigoPacienteExterno,
                    descripcionPacienteExterno = persona.paciente.descripcionPacienteExterno,
                    estadoPacienteExterno = persona.paciente.estadoPacienteExterno,
                    idPersona = idPersona,
                    hojafiliacion = persona.paciente.hojafiliacion,
                    concienteDato = persona.paciente.concienteDato,
                    idEstado = 1,
                    fechaBaja = persona.paciente.fechabaja,
                    idEstadoSeguro = null,
                    idTipoPaciente = null,
                    cuenta = null,
                    nroorden = null,
                    codigoPlanSalud = persona.paciente.numeroPlan
                };
                if (persona.paciente.estadoSeguro != null) Paciente.idEstadoSeguro = (int)persona.paciente.estadoSeguro;
                if (persona.paciente.idTipoPaciente != null) Paciente.idTipoPaciente = (int)persona.paciente.idTipoPaciente;
                await _context.PACIENTE.AddAsync(Paciente);
                await Save();
                return "Ingreso Exitoso Paciente";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.Message;
            }
        }
        public async Task<string> UpdatePaciente(PersonaDTO persona)
        {
            try
            {
                _context.Update(new PACIENTE()
                {
                    idPaciente = (int)persona.paciente.idPaciente,
                    descripcion = persona.paciente.descripcion,
                    numeroHc = persona.paciente.numeroHc,
                    nombreAcompañante = persona.paciente.NombreAcompañante,
                    edadAcompañante = persona.paciente.edadAcompañante,
                    dniAcompañante = persona.paciente.numeroDocumentoAcompañante,
                    idGrupoSanguineo = persona.paciente.idGrupoSanguineo,
                    idFactorRh = persona.paciente.idFactorRrh,
                    cobertura = persona.paciente.coberturaCompañia ?? persona.paciente.coberturaConvenio,
                    ordenAtenMedica = persona.paciente.ordenAtencionMedicaCompañia ?? persona.paciente.ordenAtencionMedicaConvenio,
                    nombreAsegurado = persona.paciente.nombreAseguradoraCompañia,
                    codigoAsegurado = persona.paciente.codigoAseguradoCompañia,
                    poliza = persona.paciente.polizaCompañia,
                    idParentesco = persona.paciente.idParentescoPaciente,
                    inicioVigencia = persona.paciente.inicioVigenciaCompañia ?? persona.paciente.inicioVigenciaConvenio,
                    finVigencia = persona.paciente.finVigenciaCompañia ?? persona.paciente.finVigenciaConvenio,
                    idTipoPlanSalud = persona.paciente.tipoPlanSaludCompañia,
                    numeroPlanSalud = persona.paciente.numeroPlanSaludCompañia,
                    idTipoAfiliacion = persona.paciente.idtipoAfiliacion,
                    fechaAfiliacion = persona.paciente.fechaAfiliacion,
                    codigoTitular = persona.paciente.codigoTitular,
                    moneda = persona.paciente.moneda,
                    nombreContratante = persona.paciente.nombreContratante,
                    idTipoDocumento = persona.paciente.idTipoDocumentoAcompañante,
                    dniContratante = persona.paciente.dniContratante,
                    planSalud = persona.paciente.planSalud,
                    codigoCobertura = persona.paciente.codigoCobertura,
                    beneficio = persona.paciente.beneficio,
                    restriccion = persona.paciente.restriccion,
                    copagoFijo = persona.paciente.copagoFijo,
                    copagoVariable = persona.paciente.copagoVariable,
                    finCarencia = persona.paciente.finCarencia,
                    convenio = persona.paciente.convenio,
                    descuento = persona.paciente.descuento,
                    codigoPacienteConvenio = persona.paciente.codigoPacienteConvenio,
                    descripcionPacienteConvenio = persona.paciente.descripcionPacienteConvenio,
                    estadoPacienteConvenio = persona.paciente.estadoPacienteConvenio,
                    codigoPacienteSoat = persona.paciente.codigoPacienteSoat,
                    descripcionPacienteSoat = persona.paciente.descripcionPacienteSoat,
                    estadoPacienteSoat = persona.paciente.estadoPacienteSoat,
                    codigoPacienteExterno = persona.paciente.codigoPacienteExterno,
                    descripcionPacienteExterno = persona.paciente.descripcionPacienteExterno,
                    estadoPacienteExterno = persona.paciente.estadoPacienteExterno,
                    idPersona = persona.idPersona,
                    hojafiliacion = persona.paciente.hojafiliacion,
                    concienteDato = persona.paciente.concienteDato,
                    idEstado = persona.paciente.idEstado,
                    fechaBaja = persona.paciente.fechabaja,
                    idTipoPaciente = persona.paciente.idTipoPaciente,
                    idEstadoSeguro = persona.paciente.estadoSeguro
                });

                await Save();
                return "Actualizacion Exitosa Paciente";
            }
            catch (Exception ex)
            {
                return "Error en el guardado " + ex.StackTrace;
            }
        }
        public async Task<List<PACIENTE>> GetAllPacientes()
        {
            List<PACIENTE> Pacientes = await (from p in _context.PACIENTE
                                                   join o in _context.PERSONA on p.idPersona equals o.idPersona
                                                   select p).ToListAsync();

            return Pacientes;
        }
        public async Task<AdmisionDTO> GetByDnioNombresyApellidos(int? Dni, string nombres, string apellidos)
        {
            AdmisionDTO admision = new AdmisionDTO();
            if (Dni != null && Dni != 0)
            {

                admision.Persona = await (from p in _context.PERSONA
                                 join pa in _context.PACIENTE on p.idPersona equals pa.idPersona
                                 where p.dniPersona == Dni
                                 select new PersonaDTO
                                 {
                                     nombres = p.nombres,
                                     apellidoPaterno = p.apellidoPaterno,
                                     apellidoMaterno = p.apellidoMaterno,
                                     numeroDocumento = p.dniPersona,
                                     correo = p.correo,
                                     edad = p.edad,
                                     descripcionOcupacion = (from det in _context.TABLA_DETALLE where det.idTablaDetalle == p.idOcupacion select det.descripcion).FirstOrDefault(),
                                     estadoCivil = (from det in _context.TABLA_DETALLE where det.idTablaDetalle == p.idEstadoCivil select det.descripcion).FirstOrDefault(),
                                     gradoInstruccion = (from det in _context.TABLA_DETALLE where det.idTablaDetalle == p.idGradoInstruccion select det.descripcion).FirstOrDefault(),
                                     celular = p.celular,
                                     parentesco = (from det in _context.TABLA_DETALLE where det.idTablaDetalle == pa.idParentesco select det.descripcion).FirstOrDefault(),
                                     tipoDocumento = (from det in _context.TABLA_DETALLE where det.idTablaDetalle == p.idTipoDocumento select det.descripcion).FirstOrDefault(),
                                     sexo = (from det in _context.TABLA_DETALLE where det.idTablaDetalle == p.idSexo select det.descripcion).FirstOrDefault(),
                                     fechaNacimiento = p.fechaNacimiento,
                                     paciente = new PacienteDTO()
                                     {
                                         idPaciente = (from pa in _context.PACIENTE
                                                       where pa.idPersona == p.idPersona
                                                       select pa.idPaciente).FirstOrDefault(),
                                         cita = new List<CitaDTO>(),
                                         idTipoPaciente = (from pan in _context.PACIENTE
                                                           where pa.idPersona == p.idPersona
                                                           select pa.idTipoDocumento).FirstOrDefault(),
                                         tipopaciente = (from pan in _context.PACIENTE join det in _context.TABLA_DETALLE on pan.idTipoPaciente equals det.idTablaDetalle where pa.idPersona == p.idPersona select det.descripcion).FirstOrDefault(),
                                         numeroHc = (from pan in _context.PACIENTE
                                                     where pa.idPersona == p.idPersona
                                                     select pa.numeroHc).FirstOrDefault(),
                                         cuenta = (from pan in _context.PACIENTE
                                                   where pa.idPersona == p.idPersona
                                                   select pa.cuenta).FirstOrDefault(),
                                         numeroorden = (from pan in _context.PACIENTE
                                                        where pa.idPersona == p.idPersona
                                                        select pa.nroorden).FirstOrDefault(),
                                         contratante = (from pac in _context.PACIENTE join per in _context.PERSONA on pac.idPersona equals per.idPersona
                                                        join pla in _context.PLAN_SALUD on pac.codigoPlanSalud equals pla.codigoPlanSalud where pa.idPersona == p.idPersona
                                                        select pla.contratante).FirstOrDefault(),
                                         aseguradora = (from pac in _context.PACIENTE
                                                        join per in _context.PERSONA on pac.idPersona equals per.idPersona
                                                        join pla in _context.PLAN_SALUD on pac.codigoPlanSalud equals pla.codigoPlanSalud
                                                        where pa.idPersona == p.idPersona
                                                        select pla.asegurado).FirstOrDefault(),
                                         numeroContrato = (from pac in _context.PACIENTE
                                                           join per in _context.PERSONA on pac.idPersona equals per.idPersona
                                                           join pla in _context.PLAN_SALUD on pac.codigoPlanSalud equals pla.codigoPlanSalud
                                                           where pa.idPersona == p.idPersona
                                                           select pla.numeroContrato).FirstOrDefault(),
                                         numeroPlan = (from pac in _context.PACIENTE
                                                           join per in _context.PERSONA on pac.idPersona equals per.idPersona
                                                           join pla in _context.PLAN_SALUD on pac.codigoPlanSalud equals pla.codigoPlanSalud
                                                           where pa.idPersona == p.idPersona
                                                           select pla.codigoPlanSalud).FirstOrDefault()
                                     }
                                 }).FirstOrDefaultAsync();
                if (admision.Persona != null)
                {
                    admision.Persona.paciente.cita = (from c in _context.CITA
                                             where c.idPaciente == admision.Persona.paciente.idPaciente
                                             select new CitaDTO
                                             {
                                                 idCita = c.idCita,
                                                 numeroCita = c.numeroCita,
                                                 idTipoCita = c.idtipoCita,
                                                 TipoCita = (from tb in _context.TABLA_DETALLE
                                                             where tb.idTablaDetalle == c.idtipoCita
                                                             select tb.descripcion).FirstOrDefault(),
                                                 fecha = (c.fechaCita).Value.Date.ToString(),
                                                 hora = (c.fechaCita).Value.ToString("H:mm"),
                                                 consultorio = (from de in _context.TABLA_DETALLE
                                                                where de.idTablaDetalle == c.idConsultorio
                                                                select de.descripcion).FirstOrDefault(),
                                                 descripcion = (from sc in _context.TABLA_DETALLE
                                                                where sc.idTablaDetalle == c.idServicioClinica
                                                                select sc.descripcion).FirstOrDefault(),
                                                 Medico = (from cm in _context.CRONOGRAMA_MEDICO
                                                           join m in _context.MEDICO on cm.idMedico equals m.idMedico
                                                           join p in _context.PERSONA on m.idPersona equals p.idPersona
                                                           where cm.idProgramMedica == c.idProgramacionMedica
                                                           select (p.nombres + " " + p.apellidoPaterno + " " + p.apellidoMaterno)).FirstOrDefault(),
                                                 especialidad = (from tb in _context.TABLA_DETALLE
                                                                 join cm in _context.CRONOGRAMA_MEDICO on c.idProgramacionMedica equals cm.idProgramMedica
                                                                 join m in _context.MEDICO on cm.idMedico equals m.idMedico
                                                                 where tb.idTablaDetalle == m.idEspecialidad
                                                                 select tb.descripcion).FirstOrDefault(),
                                                 precio = c.precio,
                                                 igv = c.igv,
                                                 descripcionEstado = (from ec in _context.ESTADO_CITA where ec.idEstadoCita == c.idEstadoCita select ec.estado).FirstOrDefault(),
                                                 descripcionEstadoPago = (from ep in _context.PAGO
                                                                          where ep.idCita == c.idCita
                                                                          select ep.estado).FirstOrDefault()
                                             }).ToList();
                 }
            }
            else admision.Persona = await GetByNombresyApellido(nombres, apellidos);
            //for (int i = 0; i < Persona.paciente.cita.Count; i++)
            //{
            //    Persona.paciente.cita[i].especialidad = (from tb in _context.TABLA_DETALLE where tb.idDet == Persona.paciente.cita[i].idEspecialidad select tb.descripcion).FirstOrDefault();
            //}
            return admision;
        }
        public async Task<PersonaDTO> GetByNombresyApellido(string nombre,string apellidos)
        {
            PersonaDTO Persona = await (from p in _context.PERSONA
                                        join pa in _context.PACIENTE on p.idPersona equals pa.idPersona
                                        where (p.nombres).Contains(nombre.Trim()) && 
                                        (p.apellidoPaterno + " " + p.apellidoMaterno).Trim().Contains(apellidos)
                                        select new PersonaDTO
                                        {
                                            nombres = p.nombres,
                                            apellidoPaterno = p.apellidoPaterno,
                                            apellidoMaterno = p.apellidoMaterno,
                                            numeroDocumento = p.dniPersona,
                                            correo = p.correo,
                                            edad = p.edad,
                                            descripcionOcupacion = (from det in _context.TABLA_DETALLE where det.idTablaDetalle == p.idOcupacion select det.descripcion).FirstOrDefault(),
                                            paciente = new PacienteDTO()
                                            {
                                                idPaciente = (from pa in _context.PACIENTE
                                                              where pa.idPersona == p.idPersona
                                                              select pa.idPaciente).FirstOrDefault(),
                                                cita = new List<CitaDTO>()
                                            }
                                        }).FirstOrDefaultAsync();
            if (Persona != null)
            {
                Persona.paciente.cita = (from c in _context.CITA
                                         where c.idPaciente == Persona.paciente.idPaciente
                                         select new CitaDTO
                                         {
                                             idCita = c.idCita,
                                             numeroCita = c.numeroCita,
                                             idTipoCita = c.idtipoCita,
                                             TipoCita = (from tb in _context.TABLA_DETALLE
                                                         where tb.idTablaDetalle == c.idtipoCita
                                                         select tb.descripcion).FirstOrDefault(),
                                             fecha = (c.fechaCita).Value.Date.ToString(),
                                             hora = (c.fechaCita).Value.ToString("H:mm"),
                                             consultorio = (from de in _context.TABLA_DETALLE
                                                            where de.idTablaDetalle == c.idConsultorio
                                                            select de.descripcion).FirstOrDefault(),
                                             descripcion = (from sc in _context.TABLA_DETALLE
                                                            where sc.idTablaDetalle == c.idServicioClinica
                                                            select sc.descripcion).FirstOrDefault(),
                                             Medico = (from cm in _context.CRONOGRAMA_MEDICO
                                                       join m in _context.MEDICO on cm.idMedico equals m.idMedico
                                                       join p in _context.PERSONA on m.idPersona equals p.idPersona
                                                       where cm.idProgramMedica == c.idProgramacionMedica
                                                       select (p.nombres + " " + p.apellidoPaterno + " " + p.apellidoMaterno)).FirstOrDefault(),
                                             especialidad = (from tb in _context.TABLA_DETALLE
                                                             join cm in _context.CRONOGRAMA_MEDICO on c.idProgramacionMedica equals cm.idProgramMedica
                                                             join m in _context.MEDICO on cm.idMedico equals m.idMedico
                                                             where tb.idTablaDetalle == m.idEspecialidad
                                                             select tb.descripcion).FirstOrDefault(),
                                             precio = c.precio,
                                             igv = c.igv,
                                             descripcionEstado = (from ec in _context.ESTADO_CITA where ec.idEstadoCita == c.idEstadoCita select ec.estado).FirstOrDefault(),
                                             descripcionEstadoPago = (from ep in _context.PAGO
                                                               where ep.idCita == c.idCita
                                                               select ep.estado).FirstOrDefault()
                                         }).ToList();
            }
            //for (int i = 0; i < Persona.paciente.cita.Count; i++)
            //{
            //    Persona.paciente.cita[i].especialidad = (from tb in _context.TABLA_DETALLE where tb.idDet == Persona.paciente.cita[i].idEspecialidad select tb.descripcion).FirstOrDefault();
            //}
            return Persona;
        }

        public async Task<PersonaDTO> GetById(int? id)
        {
            PersonaDTO Persona = await (from p in _context.PERSONA
                                        join pa in _context.PACIENTE on p.idPersona equals pa.idPersona
                                        where pa.idPaciente == id
                                        select new PersonaDTO
                                        {
                                            nombres = p.nombres,
                                            apellidoPaterno = p.apellidoPaterno,
                                            apellidoMaterno = p.apellidoMaterno,
                                            numeroDocumento = p.dniPersona,
                                            correo = p.correo,
                                            edad = p.edad,
                                            idSexo = p.idSexo,
                                            fechaNacimiento = p.fechaNacimiento,
                                            idOcupacion = p.idOcupacion,
                                            idGradoInstruccion = p.idGradoInstruccion,
                                            idEstadoCivil = p.idEstadoCivil,
                                            celular = p.celular,
                                            idParentesco = p.idParentesco,
                                            idTipoDocumento = p.idTipoDocumento,
                                            descripcionOcupacion = (from det in _context.TABLA_DETALLE where det.idTablaDetalle == p.idOcupacion select det.descripcion).FirstOrDefault(),
                                            idPersona = p.idPersona,
                                            paciente = new PacienteDTO()
                                            {
                                                idPaciente = (from pa in _context.PACIENTE
                                                              where pa.idPersona == p.idPersona
                                                              select pa.idPaciente).FirstOrDefault(),
                                                idTipoPaciente = (from pa in _context.PACIENTE
                                                                  where pa.idPersona == p.idPersona
                                                                  select pa.idTipoPaciente).FirstOrDefault(),
                                                idParentescoPaciente = p.idParentesco,
                                                estadoPaciente = pa.idEstado,
                                                cita = new List<CitaDTO>()
                                            }
                                        }).FirstOrDefaultAsync();
            if (Persona != null)
            {
                Persona.paciente.cita = (from c in _context.CITA
                                         where c.idPaciente == Persona.paciente.idPaciente
                                         select new CitaDTO
                                         {
                                             idCita = c.idCita,
                                             numeroCita = c.numeroCita,
                                             idTipoCita = c.idtipoCita,
                                             TipoCita = (from tb in _context.TABLA_DETALLE
                                                         where tb.idTablaDetalle == c.idtipoCita
                                                         select tb.descripcion).FirstOrDefault(),
                                             fecha = (c.fechaCita).Value.Date.ToString(),
                                             hora = (c.fechaCita).Value.ToString("H:mm"),
                                             consultorio = (from de in _context.TABLA_DETALLE
                                                            where de.idTablaDetalle == c.idConsultorio
                                                            select de.descripcion).FirstOrDefault(),
                                             descripcion = (from sc in _context.TABLA_DETALLE
                                                            where sc.idTablaDetalle == c.idServicioClinica
                                                            select sc.descripcion).FirstOrDefault(),
                                             Medico = (from cm in _context.CRONOGRAMA_MEDICO
                                                       join m in _context.MEDICO on cm.idMedico equals m.idMedico
                                                       join p in _context.PERSONA on m.idPersona equals p.idPersona
                                                       where cm.idProgramMedica == c.idProgramacionMedica
                                                       select (p.nombres + " " + p.apellidoPaterno + " " + p.apellidoMaterno)).FirstOrDefault(),
                                             especialidad = (from tb in _context.TABLA_DETALLE
                                                             join cm in _context.CRONOGRAMA_MEDICO on c.idProgramacionMedica equals cm.idProgramMedica
                                                             join m in _context.MEDICO on cm.idMedico equals m.idMedico
                                                             where tb.idTablaDetalle == m.idEspecialidad
                                                             select tb.descripcion).FirstOrDefault(),
                                             precio = c.precio,
                                             igv = c.igv,
                                             descripcionEstado = (from ec in _context.ESTADO_CITA where ec.idEstadoCita == c.idEstadoCita select ec.estado).FirstOrDefault(),
                                             descripcionEstadoPago = (from ep in _context.PAGO
                                                               where ep.idCita == c.idCita
                                                               select ep.estado).FirstOrDefault()
                                         }).ToList();
            }
            //for (int i = 0; i < Persona.paciente.cita.Count; i++)
            //{
            //    Persona.paciente.cita[i].especialidad = (from tb in _context.TABLA_DETALLE where tb.idDet == Persona.paciente.cita[i].idEspecialidad select tb.descripcion).FirstOrDefault();
            //}
            return Persona;
        }

        public async Task<PersonaDTO> GetByHC(string historia)
        {
            PersonaDTO Persona;
      
                Persona = await(from p in _context.PERSONA
                                join pa in _context.PACIENTE on p.idPersona equals pa.idPersona
                                where pa.numeroHc == historia
                                select new PersonaDTO
                                {
                                    nombres = p.nombres,
                                    apellidoPaterno = p.apellidoPaterno,
                                    apellidoMaterno = p.apellidoMaterno,
                                    numeroDocumento = p.dniPersona,
                                    correo = p.correo,
                                    edad = p.edad,
                                    descripcionOcupacion = (from det in _context.TABLA_DETALLE where det.idTablaDetalle == p.idOcupacion select det.descripcion).FirstOrDefault(),
                                    paciente = new PacienteDTO()
                                    {
                                        idPaciente = (from pa in _context.PACIENTE
                                                      where pa.idPersona == p.idPersona
                                                      select pa.idPaciente).FirstOrDefault(),
                                        cita = new List<CitaDTO>(),
                                        idTipoPaciente = (from pan in _context.PACIENTE
                                                          where pa.idPersona == p.idPersona
                                                          select pa.idTipoDocumento).FirstOrDefault(),
                                        numeroHc = (from pan in _context.PACIENTE
                                                    where pa.idPersona == p.idPersona
                                                    select pa.numeroHc).FirstOrDefault(),
                                        cuenta = (from pan in _context.PACIENTE
                                                  where pa.idPersona == p.idPersona
                                                  select pa.cuenta).FirstOrDefault(),
                                        numeroorden = (from pan in _context.PACIENTE
                                                       where pa.idPersona == p.idPersona
                                                       select pa.nroorden).FirstOrDefault(),
                                        contratante = (from pac in _context.PACIENTE
                                                       join per in _context.PERSONA on pac.idPersona equals per.idPersona
                                                       join pla in _context.PLAN_SALUD on pac.codigoPlanSalud equals pla.codigoPlanSalud
                                                       where pa.idPersona == p.idPersona
                                                       select pla.contratante).FirstOrDefault(),
                                        aseguradora = (from pac in _context.PACIENTE
                                                       join per in _context.PERSONA on pac.idPersona equals per.idPersona
                                                       join pla in _context.PLAN_SALUD on pac.codigoPlanSalud equals pla.codigoPlanSalud
                                                       where pa.idPersona == p.idPersona
                                                       select pla.asegurado).FirstOrDefault(),
                                        numeroContrato = (from pac in _context.PACIENTE
                                                          join per in _context.PERSONA on pac.idPersona equals per.idPersona
                                                          join pla in _context.PLAN_SALUD on pac.codigoPlanSalud equals pla.codigoPlanSalud
                                                          where pa.idPersona == p.idPersona
                                                          select pla.numeroContrato).FirstOrDefault(),
                                        numeroPlan = (from pac in _context.PACIENTE
                                                      join per in _context.PERSONA on pac.idPersona equals per.idPersona
                                                      join pla in _context.PLAN_SALUD on pac.codigoPlanSalud equals pla.codigoPlanSalud
                                                      where pa.idPersona == p.idPersona
                                                      select pla.codigoPlanSalud).FirstOrDefault()
                                    }
                                }).FirstOrDefaultAsync();
            return Persona;
        }

        public async Task<int> GetIdPaciente(int? id)
        {
            int idPaciente = await (from p in _context.PACIENTE
                                    where p.idPersona == id
                                    select p.idPaciente).FirstOrDefaultAsync();
            return idPaciente;
        }
    }
}
