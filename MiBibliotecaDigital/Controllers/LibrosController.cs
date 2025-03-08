using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiBibliotecaDigital.Data;
using MiBibliotecaDigital.Models;
using System.Threading.Tasks;

namespace MiBibliotecaDigital.Controllers
{
    public class LibrosController : Controller
    {
        private readonly AppDbContext _context;

        public LibrosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Libros
        public async Task<IActionResult> Index()
        {
            var libros = await _context.Libros.ToListAsync();
            return View(libros);
        }
    }
}
