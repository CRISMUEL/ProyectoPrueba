using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplicationPRUEBA.Models;

namespace WebApplicationPRUEBA.Controllers
{
    public class EmpleadosInactivoesController : Controller
    {
        private RecursosHumanosEntities1 db = new RecursosHumanosEntities1();

        // GET: EmpleadosInactivoes
        public ActionResult Index()
        {
            return View(db.EmpleadosInactivos.ToList());
        }

        // GET: EmpleadosInactivoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpleadosInactivo empleadosInactivo = db.EmpleadosInactivos.Find(id);
            if (empleadosInactivo == null)
            {
                return HttpNotFound();
            }
            return View(empleadosInactivo);
        }

        // GET: EmpleadosInactivoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpleadosInactivoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,codigoEmpleado,nombre,apellido,telefono,idDepartamento,idCargo,fechaIngreso,salario,estatus,idManager")] EmpleadosInactivo empleadosInactivo)
        {
            if (ModelState.IsValid)
            {
                db.EmpleadosInactivos.Add(empleadosInactivo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empleadosInactivo);
        }

        // GET: EmpleadosInactivoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpleadosInactivo empleadosInactivo = db.EmpleadosInactivos.Find(id);
            if (empleadosInactivo == null)
            {
                return HttpNotFound();
            }
            return View(empleadosInactivo);
        }

        // POST: EmpleadosInactivoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,codigoEmpleado,nombre,apellido,telefono,idDepartamento,idCargo,fechaIngreso,salario,estatus,idManager")] EmpleadosInactivo empleadosInactivo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empleadosInactivo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empleadosInactivo);
        }

        // GET: EmpleadosInactivoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpleadosInactivo empleadosInactivo = db.EmpleadosInactivos.Find(id);
            if (empleadosInactivo == null)
            {
                return HttpNotFound();
            }
            return View(empleadosInactivo);
        }

        // POST: EmpleadosInactivoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmpleadosInactivo empleadosInactivo = db.EmpleadosInactivos.Find(id);
            db.EmpleadosInactivos.Remove(empleadosInactivo);
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
