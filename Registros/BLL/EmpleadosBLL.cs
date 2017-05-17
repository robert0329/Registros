using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registros.BLL
{
    public class EmpleadosBLL
    {
        public static bool Insertar(Empleados employes)
        {
            bool retorno = false;

            using (var Conn = new BeautyBaseDB())
            {
                try
                {
                    var e = Buscar(employes.EmpleadosID);
                    if (e == null)
                    {
                        Conn.Empleado.Add(employes);
                    }
                    else
                        Conn.Entry(employes).State = EntityState.Modified;
                    Conn.SaveChanges();
                    retorno = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return retorno;
        }
        public static Empleados Buscar(int Id)
        {
            var c = new Empleados();
            using (var Conn = new BeautyBaseDB())
            {
                try
                {
                    c = Conn.Empleado.Find(Id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return c;
        }
        public static bool Eliminar(Empleados employes)
        {
            bool resultado = false;
            using (var Conn = new BeautyBaseDB())
            {
                try
                {
                    Conn.Entry(employes).State = EntityState.Deleted;
                    Conn.SaveChanges();
                    resultado = true;
                    ///
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return resultado;
        }
        public static List<Empleados> GetLista()
        {
            var lista = new List<Empleados>();
            using (var conexion = new BeautyBaseDB())
            {
                try
                {
                    lista = conexion.Empleado.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }
        public static List<Empleados> GetListaId(int EmpleadosId)
        {
            List<Empleados> list = new List<Empleados>();
            using (var db = new BeautyBaseDB())
            {
                try
                {
                    list = db.Empleado.Where(p => p.EmpleadosID == EmpleadosId).ToList();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return list;
        }
    }
}