﻿using System.ComponentModel.DataAnnotations;

namespace PracticaParaPracticaJueves.Models
{
    public class User
    {

        [Key]
        public int Id { get; set; }

        //rol---------------------------
        [Display(Name = "Rol")]
        public int RolId { get; set; }

        public virtual Rol Rol { get; set; }
        //rol---------------------------

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Username { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
