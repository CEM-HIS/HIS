using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HistClinica.Controllers
{
    public class PanelController : Controller
    {
        public IActionResult Index()
        {
            string name = HttpContext.Session.GetString("nombreusuario");
            ViewBag.nombre = name;
            return View();
        }
    }
}