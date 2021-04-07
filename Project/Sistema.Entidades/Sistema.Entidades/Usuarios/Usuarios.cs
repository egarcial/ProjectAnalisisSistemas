﻿using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Usuarios
{
    public class Usuarios
    {
        public int idUsuario { get; set; }
        [Required]
        [StringLength(100, MinimumLength =3, ErrorMessage = "El nombre debe de tener máximo de 100 carácteres, y no menos de 3 carácteres.")]
        public string nombre { get; set; }
        public string tipo_documento { get; set; }
        [StringLength(20, MinimumLength = 3, ErrorMessage = "El número debe de tener máximo de 20 carácteres, y no menos de 3 carácteres.")]
        public string num_documento { get; set; }
        [StringLength(70, MinimumLength = 3, ErrorMessage = "Dirección debe de tener máximo de 70 carácteres, y no menos de 3 carácteres.")]
        public string direccion { get; set; }
        public string telefono { get; set; }//ojo este atributo va a cambiar
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Correo debe de tener máximo de 50 carácteres, y no menos de 3 carácteres.")]
        public string email { get; set; }
        [StringLength(64, MinimumLength = 3, ErrorMessage = "Constraseña debe de tener máximo de 64 carácteres, y no menos de 3 carácteres.")]
        public string password_hash { get; set; }
        [StringLength(64, MinimumLength = 3, ErrorMessage = "Constraseña debe de tener máximo de 64 carácteres, y no menos de 3 carácteres.")]
        public string password_sat { get; set; }
        public bool condicion { get; set; }

    }

}
