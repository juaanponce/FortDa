using Microsoft.AspNetCore.Mvc;

namespace FortDa.Controllers
{
    public class CalendarioController: Controller
    {
        public IActionResult Calendario()
        {
            return View();
        }
    }
}
