using Microsoft.AspNetCore.Mvc;

namespace PRACTICA_AEAE_3_Juan_Quiceno.Controllers
{
    public class PrincipalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }

        public IActionResult Acerca()
        {
            return View();
        }

        public IActionResult Ayuda()
        {
            return View();
        }
    }
}
