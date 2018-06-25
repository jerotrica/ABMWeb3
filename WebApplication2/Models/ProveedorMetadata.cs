using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Entidades

{
    public class ProveedorMetadata
    {

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"^([^<>]){1,50}$", ErrorMessage = "Este campo {0} es obligatorio y tiene un máximo de 50 caracteres.")]
        [Display(Name = "idProveedor")]
        public int idProveedor { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"^([^<>]){1,50}$", ErrorMessage = "Este campo {0} es obligatorio y tiene un máximo de 50 caracteres.")]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }
    }
}