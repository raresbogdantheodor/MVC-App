using MVC_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_App.Controllers
{
    public class TrainsController : Controller
    {
        private TrainsToDb _db = new TrainsToDb();

        // GET: Trains
        public ActionResult Index()
        {
            var model = _db.Trains.ToList();
            return View(model);
        }

        // GET: Trains/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Trains/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trains/Create
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

        // GET: Trains/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Trains/Edit/5
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

        // GET: Trains/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Trains/Delete/5
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

        protected override void Dispose(bool disposing)
        {
            if(_db == null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
