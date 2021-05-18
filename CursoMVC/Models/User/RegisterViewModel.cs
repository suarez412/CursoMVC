using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CursoMVC.Models.User
{
    public class RegisterViewModel
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z\s]+$",    ErrorMessage ="Solo debe contener letras")]
        public string Nombre { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Solo debe contener letras")]
        public string Apellido { get; set; }
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Solo debe contener numeros")]
        public string Cedula { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Correo invalido")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage = "La contraseña debe tener al menos 5 caracteres")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Confirmar Contraseña")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Las contraseñas no coinciden")]
        public string PasswordConfirm { get; set; }
    }
}