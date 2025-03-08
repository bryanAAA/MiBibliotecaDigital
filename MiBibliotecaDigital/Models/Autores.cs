using System.ComponentModel.DataAnnotations;

namespace MiBibliotecaDigital.Models
{
    public class Autores
    {
        [Key]
        public int AutorId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellidos { get; set; }

        [Required]
        public string Nacionalidad { get; set; }

        public DateTime FechaNacimiento { get; set; }

        [Required]
        public string Biografia { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
    }
}
