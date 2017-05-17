using Registros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Registros.DAL;
using System.Data.Entity;

namespace Registros.BLL
{
    public class ClientesBLL
    {
        public static bool Guardar(Clientes cliente)
        {
            bool retorno = false;
            try
            {
                using (var db = new BeautyBaseDB())
                {
                    if (Buscar(cliente.ClienteID) == null)
                        db.Cliente.Add(cliente);
                    else
                        db.Entry(cliente).State = EntityState.Modified;

                    db.SaveChanges();
                }
                retorno = true;
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }

        public static Clientes Buscar(int id)
        {
            Clientes client = new Clientes();
            using (BeautyBaseDB db = new BeautyBaseDB())
            {
                client = db.Cliente.Find(id);
            }
            return client;
        }

    }
}