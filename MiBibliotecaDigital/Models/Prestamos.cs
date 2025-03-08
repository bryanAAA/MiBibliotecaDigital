using System.ComponentModel.DataAnnotations;

namespace MiBibliotecaDigital.Models
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [Required]
        public int LibroId { get; set; }

        [Required]
        public DateTime FechaPrestamo { get; set; } = DateTime.Now;

        [Required]
        public DateTime FechaDevolucionProgramada { get; set; }

        public DateTime? FechaDevolucionReal { get; set; }

        [Required]
        public string Estado { get; set; }

        public string Comentarios { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
    }
}
