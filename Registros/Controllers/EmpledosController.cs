using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Registros.DAL;
using Registros.Models;

namespace Registros.Controllers
{
    public class EmpledosController : Controller
    {
        private BeautyBaseDB db = new BeautyBaseDB();

        // GET: Empledos
        public ActionResult Index()
        {
            return View(db.Empledos.ToList());
        }

        // GET: Empledos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empledos empledos = db.Empledos.Find(id);
            if (empledos == null)
            {
                return HttpNotFound();
            }
            return View(empledos);
        }

        // GET: Empledos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empledos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmpleadosID,Nombre,Cedula,Telefono,Direccion,FechaNacimiento,FechaDeEntrada,SueldoFijo,Email")] Empledos empledos)
        {
            if (ModelState.IsValid)
            {
                db.Empledos.Add(empledos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empledos);
        }

        // GET: Empledos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empledos empledos = db.Empledos.Find(id);
            if (empledos == null)
            {
                return HttpNotFound();
            }
            return View(empledos);
        }

        // POST: Empledos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpleadosID,Nombre,Cedula,Telefono,Direccion,FechaNacimiento,FechaDeEntrada,SueldoFijo,Email")] Empledos empledos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empledos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empledos);
        }

        // GET: Empledos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empledos empledos = db.Empledos.Find(id);
            if (empledos == null)
            {
                return HttpNotFound();
            }
            return View(empledos);
        }

        // POST: Empledos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Empledos empledos = db.Empledos.Find(id);
            db.Empledos.Remove(empledos);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
