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

            CuadroViewModel model = new CuadroViewModel();
            model.DescCuadro = cuadro.descCuadro;

            foreach(var item in cuadro.cuadro)
            {
                var celda = (CeldaModel)item;
                if(model.Filas.Count > 0)
                {
                    // Ya se cargo al menos una celda

                    // Verifico que se haya cargado una celda de la misma fila
                    if(model.Filas.Exists(fila => fila.Id == celda.OrdenFila))
                    {
                        // ya se cargo una celda de la misma fila
                        var fila = model.Filas.Find(fila => fila.Id == celda.OrdenFila);
                        fila.Columnas.Add(celda);
                    } else
                    {
                        // no se cargo ninguna celda de esta fila
                        var fila = new FilaModel();
                        fila.Id = celda.OrdenFila;
                        fila.EsCabecera = (celda.OrdenFila == "0");
                        fila.EsTotal = (celda.OrdenFila.Contains(".5"));
                        fila.Columnas.Add(celda);
                        model.Filas.Add(fila);
                    }

                } else
                {
                    var fila = new FilaModel();
                    fila.Id = celda.OrdenFila;
                    fila.EsCabecera = (celda.OrdenFila == "0");
                    fila.EsTotal = (celda.OrdenFila.Contains(".5"));
                    fila.Columnas.Add(celda);
                    model.Filas.Add(fila);
                }
            }


            return View(model);
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