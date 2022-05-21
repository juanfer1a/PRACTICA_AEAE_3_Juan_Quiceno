using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        

    }
}
