using Microsoft.AspNetCore.Mvc;
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
        =>  View(await _context.Tblempleados.ToListAsync());
        
    }
}
