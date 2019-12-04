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
    public class salidasMes_ResultController : Controller
    {
        private RecursosHumanosEntities1 db = new RecursosHumanosEntities1();

        // GET: salidasMes_Result
        public ActionResult Index()
        {
            return View(db.salidasMes_Result.ToList());
        }

        // GET: salidasMes_Result/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            salidasMes_Result salidasMes_Result = db.salidasMes_Result.Find(id);
            if (salidasMes_Result == null)
            {
                return HttpNotFound();
            }
            return View(salidasMes_Result);
        }

        // GET: salidasMes_Result/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: salidasMes_Result/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Empleado,idEmpleado,tipoSalida,motivo,fechaSalida")] salidasMes_Result salidasMes_Result)
        {
            if (ModelState.IsValid)
            {
                db.salidasMes_Result.Add(salidasMes_Result);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(salidasMes_Result);
        }

        // GET: salidasMes_Result/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            salidasMes_Result salidasMes_Result = db.salidasMes_Result.Find(id);
            if (salidasMes_Result == null)
            {
                return HttpNotFound();
            }
            return View(salidasMes_Result);
        }

        // POST: salidasMes_Result/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Empleado,idEmpleado,tipoSalida,motivo,fechaSalida")] salidasMes_Result salidasMes_Result)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salidasMes_Result).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(salidasMes_Result);
        }

        // GET: salidasMes_Result/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            salidasMes_Result salidasMes_Result = db.salidasMes_Result.Find(id);
            if (salidasMes_Result == null)
            {
                return HttpNotFound();
            }
            return View(salidasMes_Result);
        }

        // POST: salidasMes_Result/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            salidasMes_Result salidasMes_Result = db.salidasMes_Result.Find(id);
            db.salidasMes_Result.Remove(salidasMes_Result);
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
