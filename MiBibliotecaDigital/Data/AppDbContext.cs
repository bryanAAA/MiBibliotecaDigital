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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Datos iniciales para Usuarios
            modelBuilder.Entity<Usuarios>().HasData(
                new Usuarios { UsuarioId = 1, NombreCompleto = "Juan Pérez", CorreoElectronico = "juanperez@email.com", Contraseña = "123456", ProvinciaId = 1, CantonId = 1, Telefono = "8888-8888", Estado = "Activo", FechaRegistro = DateTime.Now, FechaUltimaModificacion = DateTime.Now },
                new Usuarios { UsuarioId = 2, NombreCompleto = "María González", CorreoElectronico = "mariagonzalez@email.com", Contraseña = "abcdef", ProvinciaId = 2, CantonId = 3, Telefono = "7777-7777", Estado = "Activo", FechaRegistro = DateTime.Now, FechaUltimaModificacion = DateTime.Now }
            );

            // Datos iniciales para Categorías
            modelBuilder.Entity<Categorias>().HasData(
                new Categorias { CategoriaId = 1, Nombre = "Ciencia Ficción", Descripcion = "Libros de ciencia ficción y fantasía", Estado = "Activa", FechaCreacion = DateTime.Now, FechaModificacion = DateTime.Now },
                new Categorias { CategoriaId = 2, Nombre = "Historia", Descripcion = "Libros de historia mundial", Estado = "Activa", FechaCreacion = DateTime.Now, FechaModificacion = DateTime.Now }
            );

            // Datos iniciales para Autores
            modelBuilder.Entity<Autores>().HasData(
                new Autores { AutorId = 1, Nombre = "Isaac", Apellidos = "Asimov", Nacionalidad = "Rusa", FechaNacimiento = new DateTime(1920, 1, 2), Biografia = "Autor de ciencia ficción y divulgación científica.", FechaCreacion = DateTime.Now, FechaModificacion = DateTime.Now },
                new Autores { AutorId = 2, Nombre = "Yuval", Apellidos = "Harari", Nacionalidad = "Israelí", FechaNacimiento = new DateTime(1976, 2, 24), Biografia = "Historiador y escritor de Sapiens.", FechaCreacion = DateTime.Now, FechaModificacion = DateTime.Now }
            );

            // Datos iniciales para Libros
            modelBuilder.Entity<Libros>().HasData(
                new Libros { LibroId = 1, Titulo = "Fundación", CategoriaId = 1, ImagenPortada = "fundacion.jpg", AñoPublicacion = 1951, Editorial = "Gnome Press", Sinopsis = "Una de las sagas más famosas de ciencia ficción.", Formato = "PDF", Disponibilidad = "Disponible", FechaCreacion = DateTime.Now, FechaModificacion = DateTime.Now },
                new Libros { LibroId = 2, Titulo = "Sapiens", CategoriaId = 2, ImagenPortada = "sapiens.jpg", AñoPublicacion = 2011, Editorial = "Debate", Sinopsis = "Historia de la humanidad contada de forma fascinante.", Formato = "EPUB", Disponibilidad = "Disponible", FechaCreacion = DateTime.Now, FechaModificacion = DateTime.Now }
            );

            // Datos iniciales para Préstamos
            modelBuilder.Entity<Prestamos>().HasData(
                new Prestamos { PrestamoId = 1, UsuarioId = 1, LibroId = 1, FechaPrestamo = DateTime.Now, FechaDevolucionProgramada = DateTime.Now.AddDays(15), FechaDevolucionReal = null, Estado = "Activo", Comentarios = "Buena condición", FechaCreacion = DateTime.Now, FechaModificacion = DateTime.Now },
                new Prestamos { PrestamoId = 2, UsuarioId = 2, LibroId = 2, FechaPrestamo = DateTime.Now, FechaDevolucionProgramada = DateTime.Now.AddDays(15), FechaDevolucionReal = null, Estado = "Activo", Comentarios = "Nuevo", FechaCreacion = DateTime.Now, FechaModificacion = DateTime.Now }
            );
        }

    }
}
