using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Almacen
{
    public class Articulo
    {
        public int idArticulo { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El código debe de tener máximo de 50 carácteres, y no menos de 3 carácteres.")]
        public string codigo { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe de tener máximo de 100 carácteres, y no menos de 3 carácteres.")]
        public string nombre { get; set; }
        public double precio { get; set; }
        public int stock { get; set; }
        [StringLength(256, ErrorMessage = "Descripción debe de tener máximo de 100 carácteres.")]
        public string descripcion { get; set; }
        public bool condicion { get; set; }
        public int idMarca { get; set; }
        public int idCategoria { get; set; }
    }
}
