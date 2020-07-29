using Clinica2._0.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
using Clinica2._0.Repositories.EntityRepositories.Interfaces;

namespace Clinica2._0.Controllers
{
    [Authorize]
    public class CajaController : Controller
    {
        private readonly Microsoft.AspNetCore.Identity.UserManager<USER> _userManager;
        private readonly SignInManager<USER> _signInManager;
        private readonly ILogger<LoginController> _logger;
        private readonly ICajaRepository _cajarepository;

        public CajaController(SignInManager<USER> signInManager,
            ILogger<LoginController> logger,
            Microsoft.AspNetCore.Identity.UserManager<USER> userManager,
            ICajaRepository cajaRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _cajarepository = cajaRepository;
        }
        // GET: CajaController
        public async Task<ActionResult> Index()
        {
            // Find user
            USER user = await _userManager.FindByIdAsync(User.Identity.GetUserId());
            string nombre = user.Id;
            return View(await _cajarepository.GetAllCajas());
        }

        // GET: CajaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CajaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CajaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CajaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CajaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CajaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CajaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult GeneracionComprobante()
        {
            return View();
        }

        public ActionResult Apertura()
        {
            return PartialView();
        }
    }
}
