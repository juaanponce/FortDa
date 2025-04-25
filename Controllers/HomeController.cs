using System.Diagnostics;
using FortDa.Models;
using Microsoft.AspNetCore.Mvc;

namespace FortDa.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Formulario()
        {
            return View();
        }

        public IActionResult Areas()
        {
            return View();
        }

        public IActionResult Precios()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }
    }
}
