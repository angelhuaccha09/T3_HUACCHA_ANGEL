using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using T3_HUACCHA_ANGEL.Models;

namespace T3_HUACCHA_ANGEL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Acción para la pestaña de Arquitectura
        public IActionResult Arquitectura()
        {
            return View();
        }

        // Acción para la pestaña de Diseño
        public IActionResult Diseno()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}