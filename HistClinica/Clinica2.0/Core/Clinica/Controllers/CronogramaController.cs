﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Clinica2._0.Data;
using Clinica2._0.DTO;
using Clinica2._0.Models;
using Clinica2._0.Repositories.EntityRepositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clinica2._0.Controllers
{
    [Authorize]
    public class CronogramaController : Controller
    {
        private readonly ClinicaServiceContext _context;
        private readonly ICronogramaRepository cronogramaRepository;
        private readonly IUtilRepository _utilrepository;
        private readonly IMedicoRepository _medicorepository;
        private readonly IDetalleRepository _detalleRepository;

        public CronogramaController(ClinicaServiceContext clinicaService, 
            ICronogramaRepository cronograma, 
            IUtilRepository utilRepository, 
            IMedicoRepository medicoRepository,
            IDetalleRepository detalleRepository)
        {
            _context = clinicaService;
            cronogramaRepository = cronograma;
            _utilrepository = utilRepository;
            _medicorepository = medicoRepository;
            _detalleRepository = detalleRepository;
        }

        public class Intervalos
        {
            public int intervalo { get; set; }
            public string descripcion { get; set; }
        }


        public async Task<IActionResult> Index()
        {

            string[] horas = new string[] {"1:00","2:00","3:00","4:00","5:00","6:00","7:00","8:00","9:00","10:00","11:00","12:00","13:00","14:00","15:00","16:00","17:00","18:00","19:00","20:00","21:00","22:00","23:00","24:00"};
            List<Intervalos> intervalos = new List<Intervalos>
            {
                new Intervalos {  intervalo = 5, descripcion = "5 minutos"  },
                new Intervalos {  intervalo = 10, descripcion = "10 minutos"  },
                new Intervalos {  intervalo = 15, descripcion = "15 minutos"  },
                new Intervalos {  intervalo = 20, descripcion = "20 minutos"  },
                new Intervalos {  intervalo = 30, descripcion = "30 minutos"  },
                new Intervalos {  intervalo = 60, descripcion = "60 minutos"  }
            };
        

            //combo consultorios
            var lconsultorio =  await _utilrepository.GetTipo("Consultorio");
            ViewBag.listaconsultorio = lconsultorio;

            //combo especialidades
            var lespecialidads = await _utilrepository.GetTipo("Especialidad");
            ViewBag.listaespecialidades = lespecialidads;

            //combo horas
            ViewBag.listahoras = horas;
            ViewBag.intervalos = intervalos;

            //combo medicos
            var medico = await _medicorepository.GetMedicos();
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
            var newlistespe = await _detalleRepository.GetEspecialidad(id);
           // ViewBag.listaespecialidades = newlistespe;
            return Json(newlistespe);
        }

        public async Task<IActionResult> Create(CRONOGRAMA_MEDICO cronoMedico)
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
        public async Task<IActionResult> DeletePost(CRONOGRAMA_MEDICO cronograma)
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
            List<Intervalos> intervalos = new List<Intervalos>
            {
                new Intervalos {  intervalo = 5, descripcion = "5 minutos"  },
                new Intervalos {  intervalo = 10, descripcion = "10 minutos"  },
                new Intervalos {  intervalo = 15, descripcion = "15 minutos"  },
                new Intervalos {  intervalo = 20, descripcion = "20 minutos"  },
                new Intervalos {  intervalo = 30, descripcion = "30 minutos"  },
                new Intervalos {  intervalo = 60, descripcion = "60 minutos"  }
            };

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
            var medico = await _medicorepository.GetMedicos();
            ViewBag.listamedicos = medico;

            ViewBag.listahoras = horas;
            ViewBag.intervalos = intervalos;

            CronogramaDTO cronoMedico = await cronogramaRepository.GetByIdCrono(id);

            return PartialView("Edit",cronoMedico);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(CRONOGRAMA_MEDICO cronoMedico)
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
            var lespecialidads = await _utilrepository.GetTipo("Especialidad");
            ViewBag.listaespecialidades = lespecialidads;

            //filtro de medico
            //var medico = await _utilrepository.GetMedicos();
            // ViewBag.listamedicos = medico;

            return PartialView(cronograma);
        }
        
        [HttpGet]
        public async Task<IActionResult> ConsultarCronogramapost(FiltroCronoDTO model)
        {
            if (model.idespecialidad == null && model.nombre == null && model.apellido == null)
            {
               return RedirectToAction("ConsultarCronograma");
            } else
            {
                var lespecialidads = await _utilrepository.GetTipo("Especialidad");
                ViewBag.listaespecialidades = lespecialidads;

                List<CronogramaDTO> cronograma = new List<CronogramaDTO>();
                cronograma = await cronogramaRepository.GetCronogramaByMedico(model.nombre, model.apellido, Convert.ToInt32(model.idespecialidad));
                return RedirectToAction("ConsultarCronograma", cronograma);
            }
        }

        public async Task<IActionResult> ConsultarMedEsp()
        {
            var lespecialidads = await _utilrepository.GetTipo("Especialidad");
            ViewBag.listaespecialidades = lespecialidads;
            List<MedicoDTO> medicos = await _medicorepository.getAllMedico();
            return PartialView(medicos);
        }

        [HttpGet]
        public async Task<IActionResult> ConsultarMedEspPost(FiltroCronoDTO model)
        {
            if (model.idespecialidad == null && model.nombre == null && model.apellido == null)
            {
                return RedirectToAction("ConsultarMedEsp");
            }
            else
            {
                var lespecialidads = await _utilrepository.GetTipo("Especialidad");
                ViewBag.listaespecialidades = lespecialidads;
                List<MedicoDTO> medicos = await _medicorepository.getAllMedicoByMedEsp(model.nombre, model.apellido, Convert.ToInt32(model.idespecialidad));
                return PartialView("ConsultarMedEsp", medicos);
            }
        }
    }
}