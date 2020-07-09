using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HistClinica.DTO;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HistClinica.Controllers
{
    public class TablasController : Controller
    {
        private readonly IGeneralRepository _generalRepository;
        private readonly IDetalleRepository _detalleRepository;

        public TablasController(IGeneralRepository generalrepo, IDetalleRepository detallerepo)
        {
            _generalRepository = generalrepo;
            _detalleRepository = detallerepo;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["mensajetipo"] != null)
            {
                ViewBag.message = TempData["mensajetipo"].ToString();
            }
            return View(await _generalRepository.GetAllGeneral());
        }

        [HttpPost]
        public async Task<IActionResult> Index(string codigo, string descripcion)
        {
            if (codigo == null && descripcion == null)
            {
                return RedirectToAction("Index");
            } else
            {
                List<TABLA_GENERAL> modelo = await _generalRepository.GetByCodigo(codigo,descripcion);
                return View(modelo);
            }
        }


        // GET: Detalle/Edit/5

        public ActionResult AgregarTipo()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> AgregarTipo(TABLA_GENERAL modelo)
        {
            TempData["mensajetipo"] = await _generalRepository.InsertGeneral(modelo);
            return RedirectToAction("Index", "Tablas");
        }

        public async Task<IActionResult> EditarTipo(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            TABLA_GENERAL general = await _generalRepository.GetById(id);
            return PartialView(general);
        }

        [HttpPost]
        public async Task<IActionResult> EditarTipo(TABLA_GENERAL modelo)
        {
            // TABLA_GENERAL general = _generalRepository.listarxIdGeneral(id);
            var mensaje = await _generalRepository.UpdateGeneral(modelo);
            TempData["mensajetipo"] = mensaje;
            return RedirectToAction("Index", "Tablas");
        }



        // POST: Detalle/Edit/5

        public async Task<IActionResult> VistaDetalle(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (TempData["mensajedetalle"] != null)
            {
                ViewBag.message = TempData["mensajedetalle"].ToString();
            }
            DetalleDTO dto = await _detalleRepository.GetDetalle(id);
            return View(dto);
        }

        [HttpPost]
        public ActionResult VistaDetalle()
        {
            return View();
        }

        public async Task<IActionResult> AgregarDetalle(int id)
        {
            var model = await _generalRepository.GetById(id);
            TABLA_DETALLE detalle = new TABLA_DETALLE();
            detalle.idTablaGeneral = model.idTablaGeneral;
            return PartialView(detalle);
        }

        [HttpPost]
        public async Task<IActionResult> AgregarDetalle(TABLA_DETALLE modelo)
        {
            TempData["mensajedetalle"] = await _detalleRepository.InsertDetalle(modelo);
            return RedirectToAction("VistaDetalle", new { id = modelo.idTablaGeneral });
        }

        public async Task<IActionResult> EditarDetalle(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            TABLA_DETALLE detalle = await _detalleRepository.GetById(id);
            return PartialView(detalle);
        }

        [HttpPost]
        public async Task<IActionResult> EditarDetalle(TABLA_DETALLE modelo)
        {
            var mensaje = await _detalleRepository.UpdateDetalle(modelo);
            TempData["mensajedetalle"] = mensaje;
            return RedirectToAction("VistaDetalle", new { id = modelo.idTablaGeneral });
        }

        // GET: Detalle/Delete/5
        public async Task<IActionResult> DeleteTipo(int id)
        {
            TABLA_GENERAL general = await _generalRepository.GetById(id);
            return PartialView(general);
        }

        // POST: Detalle/Delete/5
        [HttpPost]
        public async Task<IActionResult> DeleteTipo(TABLA_GENERAL modelo)
        {
            try
            {
                TempData["mensajetipo"] = await _generalRepository.DeleteGeneral(modelo);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public async Task<IActionResult> DeleteDetalle(int id)
        {
            TABLA_DETALLE detalle = await _detalleRepository.GetById(id);
            return PartialView(detalle);
        }

        // POST: Detalle/Delete/5
        [HttpPost]
        public async Task<IActionResult> DeleteDetalle(TABLA_DETALLE modelo)
        {
            try
            {
                TempData["mensajedetalle"] = await _detalleRepository.DeleteDetalle(modelo.idTablaDetalle);

                return RedirectToAction("VistaDetalle", new { id = modelo.idTablaGeneral });
            }
            catch
            {
                return View();
            }
        }   
    }
}