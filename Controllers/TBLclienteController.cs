using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRACTICA_AEAE_3_Juan_Quiceno.Models;

namespace PRACTICA_AEAE_3_Juan_Quiceno.Controllers
{
    public class TBLclienteController : Controller
    {
        private readonly FACTURASContext _context;

        public TBLclienteController(FACTURASContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Cliente()
        {
            return View(await _context.Tblclientes.ToListAsync());
        }
       
    }
}
