using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HistClinica.Data;
using HistClinica.DTO;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HistClinica.Controllers
{
    public class CronogramaController : Controller
    {
        private readonly ClinicaServiceContext _context;
        private readonly ICronogramaRepository cronogramaRepository;
        private readonly IUtilRepository _utilrepository;

        public CronogramaController(ClinicaServiceContext clinicaService, ICronogramaRepository cronograma, IUtilRepository utilRepository)
        {
            _context = clinicaService;
            cronogramaRepository = cronograma;
            _utilrepository = utilRepository;
        }


        public async Task<IActionResult> Index()
        {

            string[] horas = new string[] {"1:00","2:00","3:00","4:00","5:00","6:00","7:00","8:00","9:00","10:00","11:00","12:00","13:00","14:00","15:00","16:00","17:00","18:00","19:00","20:00","21:00","22:00","23:00","24:00"};


            //combo consultorios
            var lconsultorio =  await _utilrepository.GetTipo("Consultorio");
            ViewBag.listaconsultorio = lconsultorio;

            //combo especialidades
            var lespecialidads = await _utilrepository.GetTipo("Especialidad");
            ViewBag.listaespecialidades = lespecialidads;

            //combo horas
            ViewBag.listahoras = horas;

            //combo medicos
            var medico = await _utilrepository.GetMedicos();
            ViewBag.listamedicos = medico;

            //listar
            List<CronogramaDTO> cronograma = new List<CronogramaDTO>();
            cronograma = await cronogramaRepository.GetAllCronogramas();

            if (TempData["mensaje"] != null)
            {
                ViewBag.message = TempData["mensaje"].ToString();
            }

            return View(cronograma);
        }

        public async Task<JsonResult> GetEspecialidad(int id)
        {
            var newlistespe = await _utilrepository.GetEspecialidad(id);
           // ViewBag.listaespecialidades = newlistespe;
            return Json(newlistespe);
        }

        public async Task<IActionResult> Create(D012_CRONOMEDICO cronoMedico)
        {
            if (cronoMedico != null)
            {
               TempData["mensaje"] = await cronogramaRepository.InsertCronograma(cronoMedico);
               return RedirectToAction("Index");
            }
            return PartialView();
        }

        public async Task<IActionResult> Delete(int id)
        {

            CronogramaDTO cronograma = await cronogramaRepository.GetByIdCrono(id);
            return PartialView(cronograma);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeletePost(D012_CRONOMEDICO cronograma)
        {

            await cronogramaRepository.DeleteCronograma(cronograma.idProgramMedica);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {

            CronogramaDTO cronoMedico = await cronogramaRepository.GetByIdCrono(id);

            return PartialView(cronoMedico);
        }

        public async Task<IActionResult> Editar(int id)
        {
            string[] horas = new string[] { "1:00", "2:00", "3:00", "4:00", "5:00", "6:00", "7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "24:00" };

            //combo consultorios
            var lconsultorio = await _utilrepository.GetTipo("Consultorio");
            ViewBag.listaconsultorio = lconsultorio;

            //combo especialidades
            var lespecialidads = await _utilrepository.GetTipo("Especialidad");
            ViewBag.listaespecialidades = lespecialidads;

            //combo estado
            var estado = new Object();
            estado = await _utilrepository.GetTipo("ESTADO CRONOGRAMA");
            ViewBag.lestado = estado;

            //combo medicos
            var medico = await _utilrepository.GetMedicos();
            ViewBag.listamedicos = medico;

            ViewBag.listahoras = horas;

            CronogramaDTO cronoMedico = await cronogramaRepository.GetByIdCrono(id);

            return PartialView("Edit",cronoMedico);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(D012_CRONOMEDICO cronoMedico)
        {
            if (ModelState.IsValid)
            {
                TempData["mensaje"] = await cronogramaRepository.UpdateCronograma(cronoMedico);
                return RedirectToAction("Index");
            }
            return PartialView();
        }

        [HttpGet]
        public async Task<IActionResult> ConsultarCronograma()
        {
            List<CronogramaDTO> cronograma = new List<CronogramaDTO>();
            cronograma = await cronogramaRepository.GetAllCronogramasConsulta();

            //filtro de medico
            var medico = await _utilrepository.GetMedicos();
            ViewBag.listamedicos = medico;

            return PartialView(cronograma);
        }
        
        public async Task<IActionResult> ConsultarCronogramapost(int id)
        {
            var medico = await _utilrepository.GetMedicos();
            ViewBag.listamedicos = medico;

            List<CronogramaDTO> cronograma = new List<CronogramaDTO>();
            cronograma = await cronogramaRepository.GetCronogramaByMedico(id);
            return PartialView("ConsultarCronograma", cronograma);
        }
    }
}