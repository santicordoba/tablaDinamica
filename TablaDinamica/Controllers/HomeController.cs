using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TablaDinamica.Models;

namespace TablaDinamica.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Services.ITabla _tablaService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _tablaService = new Services.WSTabla();
        }

        public IActionResult Index()
        {
            var cuadro = _tablaService.TraerCuadro();
            return View(cuadro);
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