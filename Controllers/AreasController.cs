using Microsoft.AspNetCore.Mvc;

namespace FortDa.Controllers
{
    public class AreasController : Controller
    {
        public IActionResult Areas()
        {
            return View();
        }
    }
}
