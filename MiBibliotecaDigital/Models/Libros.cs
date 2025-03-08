using System.ComponentModel.DataAnnotations;

namespace MiBibliotecaDigital.Models
{
    public class Libros
    {
        [Key]
        public int LibroId { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        public int CategoriaId { get; set; }

        public string ImagenPortada { get; set; }

        [Required]
        public int AñoPublicacion { get; set; }

        [Required]
        public string Editorial { get; set; }

        [Required]
        public string Sinopsis { get; set; }

        [Required]
        public string Formato { get; set; }
        [Required]
        public string Disponibilidad { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
    }
}
