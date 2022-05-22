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
        
    }
}
