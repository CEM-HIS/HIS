using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clinica2._0.Controllers
{
    public class PanelController : Controller
    {
        public IActionResult Index()
        {
            string name = "xdd";
            ViewBag.nombre = name;
            return View();
        }
    }
}