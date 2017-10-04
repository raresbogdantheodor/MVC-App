using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_App.Models;

namespace MVC_App.Controllers
{
    public class TrainsController : Controller
    {
        private TrainsToDb _db = new TrainsToDb();

        // GET: Trains
        public async Task<ActionResult> Index()
        {
            return View(await _db.Trains.ToListAsync());
        }

        // GET: Trains/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Train train = await _db.Trains.FindAsync(id);
            if (train == null)
            {
                return HttpNotFound();
            }
            return View(train);
        }

        // GET: Trains/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trains/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,TrainType")] Train train)
        {
            if (ModelState.IsValid)
            {
                _db.Trains.Add(train);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(train);
        }

        // GET: Trains/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Train train = await _db.Trains.FindAsync(id);
            if (train == null)
            {
                return HttpNotFound();
            }
            return View(train);
        }

        // POST: Trains/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,TrainType")] Train train)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(train).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(train);
        }

        // GET: Trains/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Train train = await _db.Trains.FindAsync(id);
            if (train == null)
            {
                return HttpNotFound();
            }
            return View(train);
        }

        // POST: Trains/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Train train = await _db.Trains.FindAsync(id);
            _db.Trains.Remove(train);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
