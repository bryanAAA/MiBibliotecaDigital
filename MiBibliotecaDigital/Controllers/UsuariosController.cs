using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiBibliotecaDigital.Data;
using MiBibliotecaDigital.Models;
using System.Threading.Tasks;

namespace MiBibliotecaDigital.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            var usuarios = await _context.Usuarios.ToListAsync();
            return View(usuarios);
        }
    }
}
