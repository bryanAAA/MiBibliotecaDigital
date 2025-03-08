using System.ComponentModel.DataAnnotations;

namespace MiBibliotecaDigital.Models
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required]
        public string NombreCompleto { get; set; }

        [Required]
        public string CorreoElectronico { get; set; }

        [Required]
        public string Contraseña { get; set; }

        [Required]
        public int ProvinciaId { get; set; }

        [Required]
        public int CantonId { get; set; }

        [Required]
        public string Telefono { get; set; }

        [Required]
        public string Estado { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.Now;
    }
}
