using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Almacen
{
    public class Categoria
    {
        public int idCategoria { get; set; }
        [Required]
        [StringLength(50,MinimumLength =3, ErrorMessage = "El nombre debe de tener máximo de 50 carácteres, y no menos de 3 carácteres.")]
        public string nombre { get; set; }
        [StringLength(256, ErrorMessage = "La descripción su tamaño maximo es de 256 carácteres.")]
        public string descripcion { get; set; }

        public bool condicion { get; set; }
    }
}
