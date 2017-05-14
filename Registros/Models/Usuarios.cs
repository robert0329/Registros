using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Registros.Models
{
    public class Usuarios
    {
        [Key]
        public int UsuariosId { get; set; }
        public string Nombres { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }

    }
}