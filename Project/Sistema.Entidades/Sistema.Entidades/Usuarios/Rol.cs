using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Usuarios
{
    public class Rol
    {
        public int idRol { get; set; }
        [Required]
        [StringLength(30, MinimumLength =3, ErrorMessage = "El nombre debe de tener máximo de 50 carácteres, y no menos de 3 carácteres.")]
        public string nombre { get; set; }
        [StringLength(100,ErrorMessage = "La dirección su tamaño maximo es de 100 carácteres.")]
        public string direccion { get; set; }
        public bool condicion { get; set; }
    }
}
