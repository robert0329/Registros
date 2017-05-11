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
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Cedula { get; set; }
    }
}