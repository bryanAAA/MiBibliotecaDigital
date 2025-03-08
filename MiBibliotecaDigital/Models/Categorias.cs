using System.ComponentModel.DataAnnotations;

namespace MiBibliotecaDigital.Models
{
    public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        public string Estado { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
    }
}
