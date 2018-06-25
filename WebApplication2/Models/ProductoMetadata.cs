using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Entidades
{
    public class ProductoMetadata
    {
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"^([^<>]){1,50}$", ErrorMessage = "Este campo {0} es obligatorio y tiene un máximo de 50 caracteres.")]
        [Display(Name = "IDProducto")]
        public int idProducto { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"^([^<>]){1,50}$", ErrorMessage = "Este campo {0} es obligatorio y tiene un máximo de 50 caracteres.")]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }
    }
}