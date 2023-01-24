using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Portafolio.Models;
using Portafolio.NET.Models;
using Portafolio.NET.Servicios;
using System.Diagnostics;

namespace Portafolio.NET.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositorioProyectos repositorioProyecto;


        //Constructor
        public HomeController(IRepositorioProyectos repositorioProyecto)
        {
            this.repositorioProyecto = repositorioProyecto;
        }

        #region Views

        public IActionResult Index() => View();

        public IActionResult SobreMi() => View();

        public IActionResult Trabajos()
        {
            var Proyectos = repositorioProyecto.ObtenerProyectos().Take(4).ToList();
            var Modelo = new HomeIndexViewModel() { Proyectos = Proyectos };

            return View(Modelo);
        }

        public IActionResult Blog() => View();

        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto(ContactoViewModel contactoViewModel)
        {
            return View();
        }

        public IActionResult PreguntasFrecuentes() => View();

        #endregion

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}