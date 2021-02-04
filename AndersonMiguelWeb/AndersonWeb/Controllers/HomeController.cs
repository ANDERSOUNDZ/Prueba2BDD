using AndersonMigelWeb.Models;
using AndersonMiguelBiblioteca;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AndersonMigelWeb.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult vistaProfesor(string nombre, string apellido)
        {
            Profesor profesor = new Profesor();
            profesor.Nombre = nombre;
            profesor.Apellido = apellido;
            profesor.IngresaDatos();
            ViewBag.IngresarDatos = String.Format(profesor.Nombre + profesor.Apellido);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
