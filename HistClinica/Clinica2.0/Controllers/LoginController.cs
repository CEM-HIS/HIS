using Clinica2._0.Data;
using Clinica2._0.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Clinica2._0.Controllers
{
    public class LoginController : Controller
    {
        private readonly UsuarioContext _context;

        public LoginController(UsuarioContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(USUARIO usu)
        {
            var user = _context.USUARIO.Where(u => u.UserName.Equals(usu.UserName) && u.PasswordHash.Equals(usu.PasswordHash)).FirstOrDefault();
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