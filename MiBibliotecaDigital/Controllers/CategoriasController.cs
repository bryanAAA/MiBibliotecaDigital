using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiBibliotecaDigital.Data;
using MiBibliotecaDigital.Models;
using System.Threading.Tasks;

namespace MiBibliotecaDigital.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly AppDbContext _context;

        public CategoriasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Categorias
        public async Task<IActionResult> Index()
        {
            var categorias = await _context.Categorias.ToListAsync();
            return View(categorias);
        }
    }
}
