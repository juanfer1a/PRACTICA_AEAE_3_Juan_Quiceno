using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRACTICA_AEAE_3_Juan_Quiceno.Models;

namespace PRACTICA_AEAE_3_Juan_Quiceno.Controllers
{
    public class TblProductoController : Controller
    {
        private readonly FACTURASContext _context;

        public TblProductoController(FACTURASContext context)
        {
            _context = context;
        }
        public async Task<ActionResult> Index()
        => View(await _context.Tblproductos.ToListAsync());

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
                var NuevoProducto = new Tblproducto()
                {
                    StrNombre = collection["StrNombre"],
                    StrCodigo = collection["StrCodigo"],
                    NumPrecioCompra = long.Parse(collection["NumPrecioCompra"]),
                    NumPrecioVenta = long.Parse(collection["NumPrecioVenta"]),
                    IdCategoria = int.Parse(collection["IdCategoria"]),
                    StrDetalle = collection["StrDetalle"],
                    NumStock = int.Parse(collection["NumStock"])

                };
                _context.Add(NuevoProducto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Editar(int? id)
        {

            var producto = await _context.Tblproductos.FindAsync(id);

            return View(producto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(Tblproducto model)
        {
            if (ModelState.IsValid)
            {
                var DatosModif = await _context.Tblproductos.FindAsync(model.IdProducto);
                DatosModif.StrNombre = model.StrNombre;
                DatosModif.StrCodigo = model.StrCodigo;
                DatosModif.NumPrecioCompra = model.NumPrecioCompra;
                DatosModif.NumPrecioVenta = model.NumPrecioVenta;
                DatosModif.IdCategoria = model.IdCategoria;
                DatosModif.StrDetalle = model.StrDetalle;
                DatosModif.NumStock = model.NumStock;
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

            var registro = await _context.Tblproductos.FindAsync(id);
            _context.Tblproductos.Remove(registro);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}
