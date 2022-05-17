using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PRACTICA_AEAE_3_Juan_Quiceno.Controllers
{
    public class TBLclienteController : Controller
    {
        // GET: TBLclienteController
        public ActionResult Cliente()
        {
            return View();
        }

        // GET: TBLclienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TBLclienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TBLclienteController/Create
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

        // GET: TBLclienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TBLclienteController/Edit/5
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

        // GET: TBLclienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TBLclienteController/Delete/5
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
