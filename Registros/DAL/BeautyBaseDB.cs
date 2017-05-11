using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Registros.DAL
{
    public class BeautyBaseDB : DbContext
    {

        public BeautyBaseDB() : base("ConStr")
        {

        }

        public System.Data.Entity.DbSet<Registros.Models.Clientes> Clientes { get; set; }

        public System.Data.Entity.DbSet<Registros.Models.Empledos> Empledos { get; set; }
    }
}