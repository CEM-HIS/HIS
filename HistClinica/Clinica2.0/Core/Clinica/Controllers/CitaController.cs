using Clinica2._0.Clinica.DTO;
using Clinica2._0.DTO;
using Clinica2._0.Core.Clinica.Models;
using Clinica2._0.Core.Clinica.Repositories.Interfaces;
using Clinica2._0.Data;
using Clinica2._0.DTO;
using Clinica2._0.Repositories.EntityRepositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clinica2._0.Controllers
{
    [Authorize]
    public class CitaController : Controller
    {
        private readonly IPacienteRepository _pacienteRepository;
        private readonly ClinicaServiceContext _context;
        private readonly ICitaRepository _citarepository;
        private readonly IUtilRepository _utilrepository;
        private readonly ICronogramaRepository _cronogramarepository;
        private readonly IMedicoRepository _medicorepository;
        private readonly IOrdenRepository _ordenRepository;

        public CitaController(ClinicaServiceContext clinicaService,
            ICitaRepository repository, 
            IUtilRepository utilRepository, 
            IPacienteRepository pacienterepository,
            ICronogramaRepository cronogramaRepository,
            IMedicoRepository medicoRepository,
            IOrdenRepository ordenrepository)
        {
            _citarepository = repository;
            _context = clinicaService;
            _utilrepository = utilRepository;
            _pacienteRepository = pacienterepository;
            _cronogramarepository = cronogramaRepository;
            _medicorepository = medicoRepository;
            _ordenRepository = ordenrepository;
        }

        // GET: Cita
        public async Task<IActionResult> Index()
        {
            return View(/*await _repository.GetAllCitas()*/);
        }


        // GET: Cita/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t068_CITA = await _citarepository.GetById(id);
            if (t068_CITA == null)
            {
                return NotFound();
            }

            return PartialView(t068_CITA);
        }



        // GET: Cita/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cita/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CitaDTO Cita)
        {
            if (Cita != null)
            {
                await _citarepository.InsertCita(Cita);
                return RedirectToAction(nameof(Index));
            }
            return View(Cita);
        }

        // GET: Cita/Edit/5
        public async Task<IActionResult> Edit(int? id, int medicocita, int especialidad, string fechacita)
        {
            int? idmedico = medicocita;
            int? idespecialidad = especialidad;
            string fecha = fechacita;
            if (medicocita == 0 && especialidad == 0 && fechacita == null)
            {
                idmedico = HttpContext.Session.GetInt32("idmedico");
                idespecialidad = HttpContext.Session.GetInt32("idespecialidad");
                fecha = HttpContext.Session.GetString("fecha");
            } else
            {
                HttpContext.Session.SetInt32("idmedico", Convert.ToInt32(idmedico));
                HttpContext.Session.SetInt32("idespecialidad", Convert.ToInt32(idespecialidad));
                HttpContext.Session.SetString("fecha", fecha);
            }


            var lespecialidads = new Object();
            lespecialidads = await _utilrepository.GetTipo("Especialidad");
            ViewBag.listaespecialidades = lespecialidads;

            var medico = await _medicorepository.GetMedicos();
            ViewBag.listamedicos = medico;

            CitaDTO cita = await _citarepository.GetById(id);
            List<CitaDTO> citas = await _citarepository.GetAllCitas(Convert.ToInt32(idmedico), Convert.ToInt32(idespecialidad), fecha);

            CitaCupoDTO citaCupo = new CitaCupoDTO();
            citaCupo.citas = citas;
            if (cita != null)
            {
                citaCupo.idcita = cita.idCita;
                citaCupo.idpaciente = cita.idPaciente;
            }

            return PartialView(citaCupo);

        }

    /*    [HttpGet]
        public async Task<IActionResult> BuscarReprogramacion(int idmedico, int idespecialidad, string fecha)
        {
            CitaCupoDTO citas = new CitaCupoDTO();
            citas.citas = await _repository.GetAllCitas(idmedico,idespecialidad,fecha);

            return PartialView("Edit", citas);
        }*/

        // POST: Cita/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpGet]
        public async Task<IActionResult> Reprogramar(ParametrosCitaDTO parametros)
        {
            CitaDTO cita = await _citarepository.GetById(parametros.idcitaactual);
            CitaDTO citaact = await _citarepository.GetById(parametros.idcita);
            TempData["mensajecita"] = await _citarepository.ReprogramarCupo(parametros.idpaciente,citaact, cita, parametros.idcita);
            return RedirectToAction("Edit");
        }

        // GET: Cita/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t068_CITA = await _citarepository.GetById(id);
            if (t068_CITA == null)
            {
                return NotFound();
            }

            return View(t068_CITA);
        }

        public async Task<JsonResult> BuscarDni(int dni)
        {
            var personaDTO = await _pacienteRepository.GetByDnioNombresyApellidos(dni,"","");
            return Json(personaDTO);
        }

        // POST: Cita/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _citarepository.DeleteCita(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<JsonResult> GetMedicoByEsp(int id)
        {
            var medico = await _medicorepository.GetMedicoByEspecialidad(id);
            return Json(medico);
        }

        public async Task<JsonResult> GetCronogramaByMedico(int id)
        {
            var cronograma = await _cronogramarepository.GetCronogramaByMedico(id);
            return Json(cronograma);
        }

    /*    public async Task<JsonResult> GetHorasByCronograma(int id)
        {
            var horas = await _utilrepository.GetHorasByCronograma(id);
            return Json(horas);
        }*/

        public async Task<IActionResult> Registro(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            CitaDTO cita = await _citarepository.GetById(id);
            return PartialView(cita);
        }

        [HttpPost]
        public async Task<IActionResult> Registro(CitaDTO cita)
        {
            if (cita != null)
            {
             //   TempData["dni"] = dni;
                TempData["mensajecita"] = await _citarepository.UpdateCita(cita);
                return RedirectToAction("RegistroCita");
            }
            return PartialView(cita);
        }


        public async Task<IActionResult> AnularCita(int? id)
        {
            string[] motivos = new string[] { "Reprogramacion de especialidad","Paciente no asistirá a la cita" };
            ViewBag.motivos = motivos;
            var t068_CITA = await _citarepository.GetById(id);
            if (t068_CITA == null)
            {
                return NotFound();
            }
            return PartialView(t068_CITA);
        }
        [HttpPost]
        public async Task<IActionResult> AnularCita(CitaDTO cita)
        {
            TempData["dni"] = cita.dniPaciente;
            TempData["mensajecita"] = await _citarepository.AnularCita(cita.idCita, cita.motivoAnulacion);
            return RedirectToAction("RegistroCita");
        }

        public async Task<IActionResult> CambiarEstadoCita(int id)
        {
            var estado = await _citarepository.getEstadoCita();
            ViewBag.idEstado = estado;
            CitaDTO cita = await _citarepository.GetById(id);
            return PartialView(cita);
        }

        [HttpPost]
        public async Task<IActionResult> CambiarEstadoCita(CitaDTO cita)
        {
            TempData["msjcita"] = await _citarepository.CambiarEstadoCita(cita);
            return RedirectToAction("AdmicionMedico", "Paciente");
        }

        public async Task<IActionResult> RegistroCita(int? idmedico, int? idespecialidad, string fecha)
        {

            if (TempData["mensajecita"] != null)
            {
                ViewBag.message = TempData["mensajecita"].ToString();
            }
            if (idmedico != 0 && idespecialidad != 0 && fecha != null)
            {
                HttpContext.Session.SetInt32("idmedico", Convert.ToInt32(idmedico));
                HttpContext.Session.SetInt32("idespecialidad", Convert.ToInt32(idespecialidad));
                HttpContext.Session.SetString("fecha", fecha);
            } else
            {
                idmedico = HttpContext.Session.GetInt32("idmedico");
                idespecialidad = HttpContext.Session.GetInt32("idespecialidad");
                fecha = HttpContext.Session.GetString("fecha");
            }

            var lespecialidads = new Object();
            lespecialidads = await _utilrepository.GetTipo("Especialidad");
            ViewBag.listaespecialidades = lespecialidads;

            var medico = await _medicorepository.GetMedicos();
            ViewBag.listamedicos = medico;
            List<CitaDTO> cita = await _citarepository.GetAllCitas(Convert.ToInt32(idmedico), Convert.ToInt32(idespecialidad), fecha);
            return View(cita);
        }

        public async Task<IActionResult> ConfirmacionReprogramacion(int id)
        {
            CitaDTO cita = await _citarepository.GetById(id);
            return PartialView(cita);
        }

        public async Task<IActionResult> BuscarPaciente()
        {
            if (TempData.ContainsKey("dni"))
            {
                var dni = TempData["dni"].ToString();
                PersonaDTO personaDTO = await _pacienteRepository.GetByDnioNombresyApellidos(Convert.ToInt32(dni), "", "");
                return PartialView(personaDTO);
            }
            return View();
        }

      /*  [HttpPost]
        public async Task<IActionResult> BuscarPaciente(int dni)
        {
            var personaDTO = await _pacienteRepository.GetByDnioNombresyApellidos(dni, "", "");
            return View(personaDTO);
        }*/


        public async Task<JsonResult> BuscarPacienteByDni(int dni)
        {
            return Json(await _pacienteRepository.GetByDnioNombresyApellidos(dni, "", ""));
        }

        public async Task<IActionResult> OrdenAtencion()
        {
            int idorden = Convert.ToInt32(HttpContext.Session.GetInt32("orden"));
            OrdenDTO dto = await _ordenRepository.GetOrden(idorden);
            return PartialView(dto);
        }


        public async Task<IActionResult> OrdenAtencionAdd(OrdenDTO modelo)
        {
            OrdenDTO dto = new OrdenDTO();
            if (modelo.numeroHC != null)
            {
             int idorden = await _ordenRepository.AddOrden(modelo);
                HttpContext.Session.SetInt32("orden", idorden);
            }
            return RedirectToAction("OrdenAtencion");
        }

        public async Task<IActionResult> DetalleLaboratorio()
        {
            List<LABORATORIO> data = await _utilrepository.getLaboratorio();
            return PartialView(data);
        }

        public async Task<IActionResult> SeleccionarLaboratorio(int id)
        {
            int idorden = Convert.ToInt32(HttpContext.Session.GetInt32("orden"));
            LABORATORIO lab = await _utilrepository.getLab(id);
            await _ordenRepository.AddDetalleOrden(idorden,lab);
            return RedirectToAction("OrdenAtencion");
        }

        public async Task<IActionResult> DeleteDetalleOrden(int id)
        {
            await _ordenRepository.DeleteDetalleOrden(id);
            return RedirectToAction("OrdenAtencion");
        }
    }
}
