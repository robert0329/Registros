using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Registros.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Empleados()
        {
            ViewBag.Message = "Your Employes page.";

            return View();
        }
        public ActionResult Clientes()
        {
            ViewBag.Message = "Your client page.";

            return View();
        }


    }
}