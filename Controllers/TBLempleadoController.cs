using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PRACTICA_AEAE_3_Juan_Quiceno.Controllers
{
    public class TBLempleadoController : Controller
    {
        // GET: TBLempleadoController
        public ActionResult Empleado()
        {
            return View();
        }

        // GET: TBLempleadoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TBLempleadoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TBLempleadoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TBLempleadoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TBLempleadoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TBLempleadoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TBLempleadoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
