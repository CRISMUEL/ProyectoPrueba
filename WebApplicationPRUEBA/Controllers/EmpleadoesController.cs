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
    public class EmpleadoesController : Controller
    {
        private RecursosHumanosEntities db = new RecursosHumanosEntities();

        // GET: Empleadoes
        public ActionResult Index()
        {
            var empleados = db.Empleados.Include(e => e.Cargo).Include(e => e.Departamento).Include(e => e.Departamento1);
            return View(empleados.ToList());
        }

        // GET: Empleadoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empleado empleado = db.Empleados.Find(id);
            if (empleado == null)
            {
                return HttpNotFound();
            }
            return View(empleado);
        }

        // GET: Empleadoes/Create
        public ActionResult Create()
        {
            ViewBag.idCargo = new SelectList(db.Cargoes, "id", "codigoCargo");
            ViewBag.idDepartamento = new SelectList(db.Departamentoes, "id", "codigoDepartamento");
            ViewBag.idDepartamento = new SelectList(db.Departamentoes, "id", "codigoDepartamento");
            return View();
        }

        // POST: Empleadoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,codigoEmpleado,nombre,apellido,telefono,idDepartamento,idCargo,fechaIngreso,salario,estatus,idManager")] Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                db.Empleados.Add(empleado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idCargo = new SelectList(db.Cargoes, "id", "codigoCargo", empleado.idCargo);
            ViewBag.idDepartamento = new SelectList(db.Departamentoes, "id", "codigoDepartamento", empleado.idDepartamento);
            ViewBag.idDepartamento = new SelectList(db.Departamentoes, "id", "codigoDepartamento", empleado.idDepartamento);
            return View(empleado);
        }

        // GET: Empleadoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empleado empleado = db.Empleados.Find(id);
            if (empleado == null)
            {
                return HttpNotFound();
            }
            ViewBag.idCargo = new SelectList(db.Cargoes, "id", "codigoCargo", empleado.idCargo);
            ViewBag.idDepartamento = new SelectList(db.Departamentoes, "id", "codigoDepartamento", empleado.idDepartamento);
            ViewBag.idDepartamento = new SelectList(db.Departamentoes, "id", "codigoDepartamento", empleado.idDepartamento);
            return View(empleado);
        }

        // POST: Empleadoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,codigoEmpleado,nombre,apellido,telefono,idDepartamento,idCargo,fechaIngreso,salario,estatus,idManager")] Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empleado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idCargo = new SelectList(db.Cargoes, "id", "codigoCargo", empleado.idCargo);
            ViewBag.idDepartamento = new SelectList(db.Departamentoes, "id", "codigoDepartamento", empleado.idDepartamento);
            ViewBag.idDepartamento = new SelectList(db.Departamentoes, "id", "codigoDepartamento", empleado.idDepartamento);
            return View(empleado);
        }

        // GET: Empleadoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empleado empleado = db.Empleados.Find(id);
            if (empleado == null)
            {
                return HttpNotFound();
            }
            return View(empleado);
        }

        // POST: Empleadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Empleado empleado = db.Empleados.Find(id);
            db.Empleados.Remove(empleado);
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
