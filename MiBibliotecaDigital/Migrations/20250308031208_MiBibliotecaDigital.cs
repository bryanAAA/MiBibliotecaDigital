using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiBibliotecaDigital.Migrations
{
    /// <inheritdoc />
    public partial class MiBibliotecaDigital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    AutorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nacionalidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Biografia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.AutorId);
                });

            migrationBuilder.CreateTable(
                name: "AutoresLibros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutorId = table.Column<int>(type: "int", nullable: false),
                    LibroId = table.Column<int>(type: "int", nullable: false),
                    TipoContribucion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoresLibros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    LibroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    ImagenPortada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AñoPublicacion = table.Column<int>(type: "int", nullable: false),
                    Editorial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sinopsis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Formato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Disponibilidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.LibroId);
                });

            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    PrestamoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    LibroId = table.Column<int>(type: "int", nullable: false),
                    FechaPrestamo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaDevolucionProgramada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaDevolucionReal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comentarios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.PrestamoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinciaId = table.Column<int>(type: "int", nullable: false),
                    CantonId = table.Column<int>(type: "int", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaModificacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.InsertData(
                table: "Autores",
                columns: new[] { "AutorId", "Apellidos", "Biografia", "FechaCreacion", "FechaModificacion", "FechaNacimiento", "Nacionalidad", "Nombre" },
                values: new object[,]
                {
                    { 1, "Asimov", "Autor de ciencia ficción y divulgación científica.", new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5856), new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5857), new DateTime(1920, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rusa", "Isaac" },
                    { 2, "Harari", "Historiador y escritor de Sapiens.", new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5860), new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5861), new DateTime(1976, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Israelí", "Yuval" }
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "Descripcion", "Estado", "FechaCreacion", "FechaModificacion", "Nombre" },
                values: new object[,]
                {
                    { 1, "Libros de ciencia ficción y fantasía", "Activa", new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5830), new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5830), "Ciencia Ficción" },
                    { 2, "Libros de historia mundial", "Activa", new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5833), new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5833), "Historia" }
                });

            migrationBuilder.InsertData(
                table: "Libros",
                columns: new[] { "LibroId", "AñoPublicacion", "CategoriaId", "Disponibilidad", "Editorial", "FechaCreacion", "FechaModificacion", "Formato", "ImagenPortada", "Sinopsis", "Titulo" },
                values: new object[,]
                {
                    { 1, 1951, 1, "Disponible", "Gnome Press", new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5879), new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5879), "PDF", "fundacion.jpg", "Una de las sagas más famosas de ciencia ficción.", "Fundación" },
                    { 2, 2011, 2, "Disponible", "Debate", new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5883), new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5883), "EPUB", "sapiens.jpg", "Historia de la humanidad contada de forma fascinante.", "Sapiens" }
                });

            migrationBuilder.InsertData(
                table: "Prestamos",
                columns: new[] { "PrestamoId", "Comentarios", "Estado", "FechaCreacion", "FechaDevolucionProgramada", "FechaDevolucionReal", "FechaModificacion", "FechaPrestamo", "LibroId", "UsuarioId" },
                values: new object[,]
                {
                    { 1, "Buena condición", "Activo", new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5907), new DateTime(2025, 3, 22, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5899), null, new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5907), new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5899), 1, 1 },
                    { 2, "Nuevo", "Activo", new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5912), new DateTime(2025, 3, 22, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5910), null, new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5912), new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5910), 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "CantonId", "Contraseña", "CorreoElectronico", "Estado", "FechaRegistro", "FechaUltimaModificacion", "NombreCompleto", "ProvinciaId", "Telefono" },
                values: new object[,]
                {
                    { 1, 1, "123456", "juanperez@email.com", "Activo", new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5614), new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5614), "Juan Pérez", 1, "8888-8888" },
                    { 2, 3, "abcdef", "mariagonzalez@email.com", "Activo", new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5617), new DateTime(2025, 3, 7, 21, 12, 8, 41, DateTimeKind.Local).AddTicks(5618), "María González", 2, "7777-7777" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropTable(
                name: "AutoresLibros");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Prestamos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
