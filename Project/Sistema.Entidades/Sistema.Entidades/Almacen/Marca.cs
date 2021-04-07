using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Almacen
{
    public class Marca
    {
        public int idMarca { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe de tener máximo de 50 carácteres, y no menos de 3 carácteres.")]
        public string nombre { get; set; }
        public bool condicion { get; set; }
    }
}
