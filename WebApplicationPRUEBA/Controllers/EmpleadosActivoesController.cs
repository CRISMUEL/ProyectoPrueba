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
    public class EmpleadosActivoesController : Controller
    {
        private RecursosHumanosEntities db = new RecursosHumanosEntities();

        // GET: EmpleadosActivoes
        public ActionResult Index()
        {
            return View(db.EmpleadosActivoes.ToList());
        }

        // GET: EmpleadosActivoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpleadosActivo empleadosActivo = db.EmpleadosActivoes.Find(id);
            if (empleadosActivo == null)
            {
                return HttpNotFound();
            }
            return View(empleadosActivo);
        }

        // GET: EmpleadosActivoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpleadosActivoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,codigoEmpleado,nombre,apellido,telefono,idDepartamento,idCargo,fechaIngreso,salario,estatus,idManager")] EmpleadosActivo empleadosActivo)
        {
            if (ModelState.IsValid)
            {
                db.EmpleadosActivoes.Add(empleadosActivo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empleadosActivo);
        }

        // GET: EmpleadosActivoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpleadosActivo empleadosActivo = db.EmpleadosActivoes.Find(id);
            if (empleadosActivo == null)
            {
                return HttpNotFound();
            }
            return View(empleadosActivo);
        }

        // POST: EmpleadosActivoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,codigoEmpleado,nombre,apellido,telefono,idDepartamento,idCargo,fechaIngreso,salario,estatus,idManager")] EmpleadosActivo empleadosActivo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empleadosActivo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empleadosActivo);
        }

        // GET: EmpleadosActivoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpleadosActivo empleadosActivo = db.EmpleadosActivoes.Find(id);
            if (empleadosActivo == null)
            {
                return HttpNotFound();
            }
            return View(empleadosActivo);
        }

        // POST: EmpleadosActivoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmpleadosActivo empleadosActivo = db.EmpleadosActivoes.Find(id);
            db.EmpleadosActivoes.Remove(empleadosActivo);
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
