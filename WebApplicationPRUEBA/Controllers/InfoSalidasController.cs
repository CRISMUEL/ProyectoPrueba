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
    public class InfoSalidasController : Controller
    {
        private RecursosHumanosEntities1 db = new RecursosHumanosEntities1();

        // GET: InfoSalidas
        public ActionResult Index()
        {
            return View(db.Salidas.ToList());
        }

        // GET: InfoSalidas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salida salida = db.Salidas.Find(id);
            if (salida == null)
            {
                return HttpNotFound();
            }
            return View(salida);
        }

        // GET: InfoSalidas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InfoSalidas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idEmpleado,tipoSalida,motivo,fechaSalida")] Salida salida)
        {
            if (ModelState.IsValid)
            {
                db.Salidas.Add(salida);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(salida);
        }

        // GET: InfoSalidas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salida salida = db.Salidas.Find(id);
            if (salida == null)
            {
                return HttpNotFound();
            }
            return View(salida);
        }

        // POST: InfoSalidas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idEmpleado,tipoSalida,motivo,fechaSalida")] Salida salida)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salida).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(salida);
        }

        // GET: InfoSalidas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salida salida = db.Salidas.Find(id);
            if (salida == null)
            {
                return HttpNotFound();
            }
            return View(salida);
        }

        // POST: InfoSalidas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Salida salida = db.Salidas.Find(id);
            db.Salidas.Remove(salida);
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
