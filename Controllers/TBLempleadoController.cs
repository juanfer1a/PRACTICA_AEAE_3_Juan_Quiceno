using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PRACTICA_AEAE_3_Juan_Quiceno.Models;

namespace PRACTICA_AEAE_3_Juan_Quiceno.Controllers
{
    public class TblEmpleadoController : Controller
    {
        private readonly FACTURASContext _context;

        public TblEmpleadoController(FACTURASContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        => View(await _context.Tblempleados.ToListAsync());

        public IActionResult Nuevo()
        {
            ViewData["rol"] = new SelectList(_context.Tblroles, "IdRolEmpleado", "StrDescripcion");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Nuevo(IFormCollection collection)
        {

            //ViewData["empleado"] = new SelectList(_context.Tblempleados, "idempleado", "StrNombre");

            if (ModelState.IsValid)
            {
                var NuevoEmpleado = new Tblempleado()
                {
                    StrNombre = collection["StrNombre"],
                    NumDocumento = long.Parse(collection["NumDocumento"]),
                    StrDireccion = collection["StrDireccion"],
                    StrTelefono = collection["StrTelefono"],
                    StrEmail = collection["StrEmail"],
                    IdRolEmpleado = int.Parse(collection["IdRolEmpleado"]),
                    DtmIngreso = Convert.ToDateTime(collection["DtmIngreso"]),
                    DtmRetiro = Convert.ToDateTime(collection["DtmRetiro"]),
                    StrDatosAdicionales = collection["StrDatosAdicionales"],
                    DtmFechaModifica = DateTime.Now.Date,
                    StrUsuarioModifico = "Juan"
                };

                _context.Add(NuevoEmpleado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }


        public async Task<IActionResult> Editar(int? id)
        {

            var empleado = await _context.Tblempleados.FindAsync(id);
            ViewData["rol"] = new SelectList(_context.Tblroles, "IdRolEmpleado", "StrDescripcion", empleado.IdRolEmpleado);

            return View(empleado);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(Tblempleado model)
        {
            if (ModelState.IsValid)
            {

                var DatosModif = await _context.Tblempleados.FindAsync(model.IdEmpleado);
                DatosModif.StrNombre = model.StrNombre;
                DatosModif.NumDocumento = model.NumDocumento;
                DatosModif.StrDireccion = model.StrDireccion;
                DatosModif.StrTelefono = model.StrTelefono;
                DatosModif.StrEmail = model.StrEmail;
                DatosModif.IdRolEmpleado = model.IdRolEmpleado;
                DatosModif.DtmIngreso = model.DtmIngreso;
                DatosModif.DtmRetiro = model.DtmRetiro;
                DatosModif.StrDatosAdicionales = model.StrDatosAdicionales;
                DatosModif.StrUsuarioModifico = "Juan";
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

            var registro = await _context.Tblempleados.FindAsync(id);
            _context.Tblempleados.Remove(registro);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

    }
}
