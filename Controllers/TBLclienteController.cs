using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PRACTICA_AEAE_3_Juan_Quiceno.Models;

namespace PRACTICA_AEAE_3_Juan_Quiceno.Controllers
{
    public class TblClienteController : Controller
    {
        private readonly FACTURASContext _context;

        public TblClienteController(FACTURASContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
         => View(await _context.Tblclientes.ToListAsync());


        public IActionResult Nuevo()
        {
            //ViewData["Clientes"] = new SelectList(_context.Tblclientes, "idCliente", "StrNombre");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Nuevo(IFormCollection collection)
        {
            if (ModelState.IsValid)
            {
                var Nuevocliente = new Tblcliente()
                {
                    StrNombre = collection["StrNombre"],
                    NumDocumento = long.Parse(collection["NumDocumento"]),
                    StrDireccion = collection["StrDireccion"],
                    StrTelefono = collection["StrTelefono"],
                    StrEmail = collection["StrEmail"],
                };
                _context.Add(Nuevocliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            Console.WriteLine($"Cliente creado*************************");

            return View();
        }

        public async Task<IActionResult> Editar(int? id)        {

            var cliente = await _context.Tblclientes.FindAsync(id);

            return View(cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(Tblcliente model)
        {
            if (ModelState.IsValid)
            {
                var DatosModif = await _context.Tblclientes.FindAsync(model.IdCliente);
                DatosModif.StrNombre = model.StrNombre;
                DatosModif.NumDocumento = model.NumDocumento;
                DatosModif.StrDireccion = model.StrDireccion;
                DatosModif.StrTelefono = model.StrTelefono;
                DatosModif.StrEmail = model.StrEmail;
                DatosModif.StrUsuarioModifica = "Juan";
                DatosModif.DtmFechaModifica = DateTime.Now.Date;


                _context.Entry(DatosModif).State = EntityState.Modified;
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

           

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Borrar(int? id)
        {

            var registro = await _context.Tblclientes.FindAsync(id);
            _context.Tblclientes.Remove(registro);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

    }
}
