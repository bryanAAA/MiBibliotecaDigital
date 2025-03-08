using System.ComponentModel.DataAnnotations;

namespace MiBibliotecaDigital.Models
{
    public class AutoresLibros
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AutorId { get; set; }

        [Required]
        public int LibroId { get; set; }

        [Required]
        public string TipoContribucion { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
