using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Registros.Models
{
    public class Empleados
    {
        [Key]
        public int EmpleadosID { get; set; }

        [StringLength(100)]
        [RegularExpression("^([a-zA-Z .&']+)$", ErrorMessage = "Solo se puede escribir letras")]
        [Required(ErrorMessage = "Debe ingresar un nombre")]
        public string Nombre { get; set; }
        
        public DateTime FechaDeEntrada { get; set; }

        [StringLength(100)]
        [RegularExpression("^([0-9]+)$", ErrorMessage = "Solo se puede escribir numeros")]
        [Required(ErrorMessage = "Debe ingresar un sueldo")]
        public string SueldoFijo { get; set; }
        

        [StringLength(100)]
        [RegularExpression("^([0-9.&-]+)$", ErrorMessage = "Solo se puede escribir numeros")]
        [Required(ErrorMessage = "Debe ingresar una telefono")]
        public string Telefono { get; set; }

        [StringLength(100)]
        [RegularExpression("^([a-zA-Z0-9 .&'-]+)$", ErrorMessage = "Contiene caracteres Invalidos")]
        [Required(ErrorMessage = "Debe ingresar una direccion")]
        public string Direccion { get; set; }

        public DateTime FechaNacimiento { get; set; }

        [StringLength(100)]
        [RegularExpression("^([a-zA-Z0-9.&'@.&'-]+)$", ErrorMessage = "Contiene caracteres Invalidos")]
        [Required(ErrorMessage = "Debe ingresar un email")]
        public string Email { get; set; }

        [StringLength(100)]
        [RegularExpression("^([0-9.&-]+)$", ErrorMessage = "Solo se puede escribir numeros")]
        [Required(ErrorMessage = "Debe ingresar una cedula")]
        public string Cedula { get; set; }
    }

}