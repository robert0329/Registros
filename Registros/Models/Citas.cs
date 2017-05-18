using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Registros.Models
{
    public class Citas
    {
        [Key]
        public int CitaId { get; set; }
        public int ClienteId { get; set; }
        public int ServicioId { get; set; }
        public string NombreCliente { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
    }
}