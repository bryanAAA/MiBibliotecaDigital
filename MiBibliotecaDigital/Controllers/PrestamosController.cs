using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiBibliotecaDigital.Data;
using MiBibliotecaDigital.Models;
using System.Threading.Tasks;

namespace MiBibliotecaDigital.Controllers
{
    public class PrestamosController : Controller
    {
        private readonly AppDbContext _context;

        public PrestamosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Prestamos
        public async Task<IActionResult> Index()
        {
            var prestamos = await _context.Prestamos.ToListAsync();
            return View(prestamos);
        }
    }
}
