using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiBibliotecaDigital.Data;
using MiBibliotecaDigital.Models;
using System.Threading.Tasks;

namespace MiBibliotecaDigital.Controllers
{
    public class AutoresController : Controller
    {
        private readonly AppDbContext _context;

        public AutoresController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Autores
        public async Task<IActionResult> Index()
        {
            var autores = await _context.Autores.ToListAsync();
            return View(autores);
        }
    }
}
