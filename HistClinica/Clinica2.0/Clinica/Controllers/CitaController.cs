using Clinica2._0.Clinica.DTO;
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
        private readonly ICitaRepository _repository;
        private readonly IUtilRepository _utilrepository;

        public CitaController(ClinicaServiceContext clinicaService,ICitaRepository repository, IUtilRepository utilRepository, IPacienteRepository pacienterepository)
        {
            _repository = repository;
            _context = clinicaService;
            _utilrepository = utilRepository;
            _pacienteRepository = pacienterepository;
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

            var t068_CITA = await _repository.GetById(id);
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
                await _repository.InsertCita(Cita);
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

            var medico = await _utilrepository.GetMedicos();
            ViewBag.listamedicos = medico;

            CitaDTO cita = await _repository.GetById(id);
            List<CitaDTO> citas = await _repository.GetAllCitas(Convert.ToInt32(idmedico), Convert.ToInt32(idespecialidad), fecha);

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
            CitaDTO cita = await _repository.GetById(parametros.idcita);
            await _repository.ReprogramarCupo(parametros.idpaciente, cita, parametros.idcitaactual);
            return RedirectToAction("Edit");
        }

        // GET: Cita/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t068_CITA = await _repository.GetById(id);
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
            await _repository.DeleteCita(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<JsonResult> GetMedicoByEsp(int id)
        {
            var medico = await _utilrepository.GetMedicoByEspecialidad(id);
            return Json(medico);
        }

        public async Task<JsonResult> GetCronogramaByMedico(int id)
        {
            var cronograma = await _utilrepository.GetCronogramaByMedico(id);
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
            CitaDTO cita = await _repository.GetById(id);
            return View(cita);
        }

        [HttpPost]
        public async Task<IActionResult> Registro(CitaDTO cita)
        {
            if (cita != null)
            {
             //   TempData["dni"] = dni;
                TempData["mensajecita"] = await _repository.UpdateCita(cita);
                return RedirectToAction("RegistroCita");
            }
            return View(cita);
        }


        public async Task<IActionResult> AnularCita(int? id)
        {
            var t068_CITA = await _repository.GetById(id);
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
            TempData["mensajecita"] = await _repository.AnularCita(cita.idCita, cita.motivoAnulacion);
            return RedirectToAction("RegistroCita");
        }

        public async Task<IActionResult> CambiarEstadoCita(int id)
        {
            var estado = await _utilrepository.getEstadoCita();
            ViewBag.idEstado = estado;
            CitaDTO cita = await _repository.GetById(id);
            return PartialView(cita);
        }

        [HttpPost]
        public async Task<IActionResult> CambiarEstadoCita(CitaDTO cita)
        {
            TempData["msjcita"] = await _repository.CambiarEstadoCita(cita);
            return RedirectToAction("AdmicionMedico", "Paciente");
        }

        public async Task<IActionResult> RegistroCita(int idmedico, int idespecialidad, string fecha)
        {
            if (idmedico != 0 && idespecialidad != 0 && fecha != null)
            {
                HttpContext.Session.SetInt32("idmedico", idmedico);
                HttpContext.Session.SetInt32("idespecialidad", idespecialidad);
                HttpContext.Session.SetString("fecha", fecha);
            }

            var lespecialidads = new Object();
            lespecialidads = await _utilrepository.GetTipo("Especialidad");
            ViewBag.listaespecialidades = lespecialidads;

            var medico = await _utilrepository.GetMedicos();
            ViewBag.listamedicos = medico;
            List<CitaDTO> cita = await _repository.GetAllCitas(idmedico, idespecialidad, fecha);
            return View(cita);
        }

        public IActionResult ConfirmacionReprogramacion()
        {
            return PartialView();
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

        [HttpPost]
        public async Task<IActionResult> BuscarPaciente(int dni)
        {
            var personaDTO = await _pacienteRepository.GetByDnioNombresyApellidos(dni, "", "");
            return View(personaDTO);
        }
    }
}
