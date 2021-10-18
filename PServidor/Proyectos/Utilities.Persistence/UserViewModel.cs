using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Persistence
{
   public  class UserViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(8, ErrorMessage = "La logitud maxima es de 8 caracteres")]
        [DisplayName("Nombre de usuario")]
        public string UserName { get; set; }

        [DisplayName("Contraseña")]
        public string Password { get; set; }


        [DisplayName("Nombre")]
        public string Name { get; set; }


        [DisplayName("Fecha de creación")]
        public DateTime CreatedDate { get; set; }
    }
}
