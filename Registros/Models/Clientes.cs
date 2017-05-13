using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Registros.Models
{
    public class Clientes
    {
        [Key]

        public int ClienteID { get; set; }
        [Required(ErrorMessage = "Debe ingresar un nombre")]
        [StringLength(50)]
        [RegularExpression(@"^[zA-Z]([a-zA-Z])")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar una telefono")]
        [StringLength(100)]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Debe ingresar una direccion")]
        [StringLength(100)]
        public string Direccion { get; set; }

        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Debe ingresar un email")]
        [StringLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debe ingresar una cedula")]
        [StringLength(100)]
        public string Cedula { get; set; }
    }
}