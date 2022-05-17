using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PRACTICA_AEAE_3_Juan_Quiceno.Controllers
{
    public class TBLproductoController : Controller
    {
        // GET: TBLproductoController
        public ActionResult Producto()
        {
            return View();
        }

        // GET: TBLproductoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TBLproductoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TBLproductoController/Create
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

        // GET: TBLproductoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TBLproductoController/Edit/5
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

        // GET: TBLproductoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TBLproductoController/Delete/5
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
