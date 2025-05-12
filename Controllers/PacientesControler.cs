using Microsoft.AspNetCore.Mvc;

namespace FortDa.Controllers 
{
    public class PacientesController : Controller
    {
        public IActionResult Pacientes()
        {
            return View();
        }

        public IActionResult AgregarPaciente(string nombre, int edad, string dni, string contacto)
        {
            TempData["MensajeExito"] = "¡Paciente agregado exitosamente!";
            return RedirectToAction("Pacientes");
        }
    }
}
