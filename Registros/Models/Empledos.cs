using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Registros.Models
{
    public class Empledos
    {
        [Key]
        public int EmpleadosID { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaDeEntrada { get; set; }
        public double SueldoFijo { get; set; }
        public string Email { get; set; }
    }

}