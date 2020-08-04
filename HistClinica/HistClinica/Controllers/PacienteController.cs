using HistClinica.DTO;
using HistClinica.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HistClinica.Controllers
{
    public class PacienteController : Controller
    {
        private readonly IPersonaRepository _personaRepository;
        private readonly IPacienteRepository _pacienteRepository;
        private readonly IUtilRepository _utilrepository;
        private readonly ICitaRepository _citarepository;

        public PacienteController(IPersonaRepository personaRepository, IPacienteRepository pacienteRepository, IUtilRepository utilrepository, ICitaRepository citaRepository)
        {
            _personaRepository = personaRepository;
            _pacienteRepository = pacienteRepository;
            _utilrepository = utilrepository;
            _citarepository = citaRepository;
        }


        public async Task<IActionResult> Index()
        {
            if (TempData.ContainsKey("mensajecita"))
            {
                ViewBag.message = TempData["mensajecita"].ToString();
            }
            if (TempData.ContainsKey("dni"))
            {
                var dni = TempData["dni"].ToString();
                PersonaDTO personaDTO = await _pacienteRepository.GetByDnioNombresyApellidos(Convert.ToInt32(dni), "", "");
                return View(personaDTO);
            }
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Index(int dni, string nombre, string apellidos)
        {
            PersonaDTO personaDTO = await _pacienteRepository.GetByDnioNombresyApellidos(dni, nombre, apellidos);
            return View(personaDTO);
        }

        public async Task<IActionResult> AdmicionMedico()
        {
            if (TempData.ContainsKey("msjcita"))
            {
                ViewBag.message = TempData["msjcita"].ToString();
            }
            List<CitaDTO> cita = await _citarepository.GetAllCitas();
            return View(cita);
        }

        // GET: Paciente/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _pacienteRepository.GetByDnioNombresyApellidos(id, "", "");
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        private async Task CargarCombosPacientes()
        {
            var lsttipsexo = new Object();
            lsttipsexo = await _utilrepository.GetTipo("sexo");
            ViewBag.lssexo = lsttipsexo;

            var lsgrdinstruccion = new Object();
            lsgrdinstruccion = await _utilrepository.GetTipo("grado instruccion");
            ViewBag.lgrdinst = lsgrdinstruccion;

            var ocupacion = new Object();
            ocupacion = await _utilrepository.GetTipo("Ocupacion");
            ViewBag.locupacion = ocupacion;

            var gruposangre = new Object();
            gruposangre = await _utilrepository.GetTipo("Grupo Sangre");
            ViewBag.lgpsangre = gruposangre;

            var factrh = new Object();
            factrh = await _utilrepository.GetTipo("Factor RH");
            ViewBag.lfh = factrh;

            var parentesco = new Object();
            parentesco = await _utilrepository.GetTipo("Parentesco");
            ViewBag.lparentesco = parentesco;

            var tipovia = new Object();
            tipovia = await _utilrepository.GetTipo("Tipo Via");
            ViewBag.ltipovia = tipovia;

            var tippac = new Object();
            tippac = await _utilrepository.GetTipo("Tipo Paciente");
            ViewBag.ltippac = tippac;

            var estadocivil = new Object();
            estadocivil = await _utilrepository.GetTipo("Estado Civil");
            ViewBag.lestcivil = estadocivil;

            var tipdoc = new Object();
            tipdoc = await _utilrepository.GetTipo("Tipo Documento");
            ViewBag.ltipdoc = tipdoc;
        }

        // GET: Paciente/Create
        public async Task<IActionResult> Create()
        {
            await CargarCombosPacientes();
            return View();
        }

        // POST: Paciente/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PersonaDTO persona)
        {
            if (persona != null)
            {
                TempData["dni"] = persona.numeroDocumento;
                TempData["mensajecita"] = await _personaRepository.InsertPersona(persona);
                return RedirectToAction(nameof(Index));
            }
            return View(persona);
        }

        // GET: Paciente/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            await CargarCombosPacientes();
            PersonaDTO persona = await _pacienteRepository.GetById(id);
            if (persona == null)
            {
                return NotFound();
            }
            return View(persona);
        }

        // POST: Paciente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(PersonaDTO persona)
        {

            if (persona != null)
            {
                try
                {
                    TempData["dni"] = persona.numeroDocumento;
                    TempData["mensajecita"] = await _personaRepository.UpdatePersona(persona);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!(await _pacienteRepository.PacienteExists(persona.paciente.idPaciente)))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(persona);
        }

        // GET: Paciente/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _pacienteRepository.GetByDnioNombresyApellidos(id, "", "");
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        // POST: Paciente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var paciente = await _pacienteRepository.GetByDnioNombresyApellidos(id, "", "");
            await _pacienteRepository.DeletePaciente(id);
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Pago()
        {
            return View();
        }

    }
}