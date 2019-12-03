using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationPRUEBA.Controllers
{
    public class NominaController : Controller
    {
        // GET: Nomina
        public ActionResult Index()
        {
            return View();
        }

        // GET: Nomina/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Nomina/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nomina/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Nomina/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Nomina/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Nomina/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Nomina/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
