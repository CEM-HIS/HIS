using Clinica2._0.Data;
using Clinica2._0.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace Clinica2._0.Controllers
{
    public class LoginController : Controller
    {
        private readonly UsuarioContext _context;
        private readonly ILogger<LoginController> _logger;

        public LoginController(UsuarioContext context, ILogger<LoginController> logger)
        {
            _context = context;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(USUARIO usu)
        {
            var user = _context.USUARIO.Where(u => u.UserName.Equals(usu.UserName) 
            //&& u.PasswordHash.Equals(usu.PasswordHash)
            ).FirstOrDefault();
            if (user != null)
            {
               // HttpContext.Session.SetString("nombreusuario", "Bertol Franco");
                return RedirectToAction("Index", "Panel");
            }
            ViewBag.error = "Usuario invalido";
            return View();
        }
    }
}