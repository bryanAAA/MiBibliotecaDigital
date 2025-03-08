using Microsoft.EntityFrameworkCore;
using MiBibliotecaDigital.Models;

namespace MiBibliotecaDigital.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Autores> Autores { get; set; }
        public DbSet<Libros> Libros { get; set; }
        public DbSet<AutoresLibros> AutoresLibros { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }
    }
}
