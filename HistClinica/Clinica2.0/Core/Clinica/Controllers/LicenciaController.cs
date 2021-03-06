﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Clinica2._0.Models;
using Clinica2._0.Repositories.EntityRepositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clinica2._0.Controllers
{

    [Authorize]
    public class LicenciaController : Controller
    {
        private readonly ILicenciaRepository licenciarepository;
        private readonly IUtilRepository _utilrepository;
        private readonly IMedicoRepository _medicorepository;

        public LicenciaController(ILicenciaRepository repository, 
            IUtilRepository utilRepository,
            IMedicoRepository medicoRepository)
        {
            licenciarepository = repository;
            _utilrepository = utilRepository;
            _medicorepository = medicoRepository;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["mensajelicencia"] != null)
            {
                ViewBag.message = TempData["mensajelicencia"].ToString();
            }
            return View(await licenciarepository.getAll());
        }

        public async Task<IActionResult> Registro()
        {
            string[] horas = new string[] { "1:00", "2:00", "3:00", "4:00", "5:00", "6:00", "7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "24:00" };
            ViewBag.listahoras = horas;

            var medico = await _medicorepository.GetMedicos();
            ViewBag.listamedicos = medico;
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> Registro(LICENCIA model)
        {
            if (model != null)
            {
              TempData["mensajelicencia"] = await licenciarepository.insertLicencia(model);
                return RedirectToAction("Index");
            }
            return PartialView();
        }

        public async Task<IActionResult> Edit(int id)
        {
            string[] horas = new string[] { "1:00", "2:00", "3:00", "4:00", "5:00", "6:00", "7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "24:00" };
            ViewBag.listahoras = horas;

            var medico = await _medicorepository.GetMedicos();
            ViewBag.listamedicos = medico;
            LICENCIA licencia = await licenciarepository.getLicencia(id);
            return PartialView(licencia);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(LICENCIA modelo)
        {
            if (modelo != null)
            {
                TempData["mensajelicencia"] = await licenciarepository.updateLicencia(modelo);
                return RedirectToAction("Index");
            }
            return PartialView();
        }

        public async Task<IActionResult> Delete(int id)
        {
            LICENCIA licencia = await licenciarepository.getLicencia(id);
            return PartialView(licencia);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(LICENCIA modelo)
        {
            if (modelo != null)
            {
                TempData["mensajelicencia"] = await licenciarepository.deleteLicencia(modelo);
                return RedirectToAction("Index");
            }
           
            return PartialView();
        }

        public IActionResult ValidateCorrect()
        {
            return PartialView();
        }

        public IActionResult ValidateIncorrect()
        {
            return PartialView();
        }

    }
}