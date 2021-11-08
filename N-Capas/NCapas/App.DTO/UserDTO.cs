using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        //prueba 2
        
        [Required]
        [DisplayName("Nombre")]
        public string NickName { get; set; }

        
        [Required]
        [DisplayName("Correo electrónico")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Contraseña")]
        public string Password { get; set; }

        public bool IsEnabled { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
