using HistClinica.Data;
using HistClinica.DTO;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace HistClinica.Controllers
{
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
            return View(await _repository.GetAllCitas());
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
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lespecialidads = new Object();
            lespecialidads = await _utilrepository.GetTipo("Especialidad");
            ViewBag.listaespecialidades = lespecialidads;

            var medico = await _utilrepository.GetMedicos();
            ViewBag.listamedicos = medico;

            var lcronograma = await _utilrepository.GetCronograma();
            ViewBag.lcronograma = lcronograma;

            var lhoras = _utilrepository.GetHoras();
            ViewBag.lhoras = lhoras;

            var lestado = await _utilrepository.getEstadoCita();
            ViewBag.lestado = lestado;

            var servicios = await _utilrepository.GetTipo("Servicio Clinica");
            ViewBag.servicios = servicios;

            var t068_CITA = await _repository.GetById(id);
            if (t068_CITA == null)
            {
                return NotFound();
            }
            return PartialView(t068_CITA);

        }

        // POST: Cita/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CitaDTO cita)
        {
            if (cita.idCita != 0)
            {
                try
                {
                    TempData["dni"] = cita.dniPaciente;
                   TempData["mensajecita"] = await _repository.ReprogramarCita(cita);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _repository.CitaExists(cita.idCita))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index","Paciente");
            }
            return View();
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

        public async Task<JsonResult> GetHorasByCronograma(int id)
        {
            var horas = await _utilrepository.GetHorasByCronograma(id);
            return Json(horas);
        }

        public async Task<IActionResult> Registro(int dni)
        {
            var lespecialidads = new Object();
            lespecialidads = await _utilrepository.GetTipo("Especialidad");
            ViewBag.listaespecialidades = lespecialidads;

            var medico = await _utilrepository.GetMedicos();
            ViewBag.listamedicos = medico;

            var lcronograma = await _utilrepository.GetCronograma();
            ViewBag.lcronograma = lcronograma;

            var servicios = await _utilrepository.GetTipo("Servicio Clinica");
            ViewBag.servicios = servicios;

            var lhoras = _utilrepository.GetHoras();
            ViewBag.lhoras = lhoras;

            CitaDTO cita = new CitaDTO();

            if (dni != 0)
            {
                PersonaDTO persona = await _pacienteRepository.GetByDnioNombresyApellidos(dni,"","");
                cita.dniPaciente = persona.numeroDocumento;
                cita.nombrePaciente = persona.nombres + ' ' + persona.apellidoPaterno + ' ' + persona.apellidoMaterno;
                cita.idPaciente = persona.paciente.idPaciente;
            }
            return PartialView(cita);
        }

        [HttpPost]
        public async Task<IActionResult> Registro(CitaDTO cita,string dni)
        {
            if (cita != null)
            {
                TempData["dni"] = dni;
                   TempData["mensajecita"] = await _repository.InsertCita(cita);
                return RedirectToAction("Index","Paciente");
            }
            return View(cita);
        }


        public async Task<IActionResult> AnularCita(int id)
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
            TempData["mensajecita"] = await _repository.AnularCita(cita.idCita, cita.motivoanulacion);
            return RedirectToAction("Index", "Paciente");
        }

        public async Task<IActionResult> CambiarEstadoCita(int id)
        {
            var estado = await _utilrepository.getEstadoCita();
            ViewBag.estado = estado;
            CitaDTO cita = await _repository.GetById(id);
            return PartialView(cita);
        }

        [HttpPost]
        public async Task<IActionResult> CambiarEstadoCita(CitaDTO cita)
        {
            TempData["msjcita"] = await _repository.CambiarEstadoCita(cita);
            return RedirectToAction("AdmicionMedico", "Paciente");
        }
    }
}
