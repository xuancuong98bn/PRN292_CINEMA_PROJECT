using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using cinema.Contexts;
using cinema.Models;

namespace cinema.Areas.Admin.Controllers
{
    public class SeattypesController : Controller
    {
        private DBContext db = new DBContext();

        // GET: Admin/Seattypes
        public ActionResult Index()
        {
            return View(db.Seattypes.ToList());
        }

        // GET: Admin/Seattypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seattype seattype = db.Seattypes.Find(id);
            if (seattype == null)
            {
                return HttpNotFound();
            }
            return View(seattype);
        }

        // GET: Admin/Seattypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Seattypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Code,Name,PlusPrice,IsEnable")] Seattype seattype)
        {
            if (ModelState.IsValid)
            {
                db.Seattypes.Add(seattype);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(seattype);
        }

        // GET: Admin/Seattypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seattype seattype = db.Seattypes.Find(id);
            if (seattype == null)
            {
                return HttpNotFound();
            }
            return View(seattype);
        }

        // POST: Admin/Seattypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Code,Name,PlusPrice,IsEnable")] Seattype seattype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(seattype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(seattype);
        }

        // GET: Admin/Seattypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seattype seattype = db.Seattypes.Find(id);
            if (seattype == null)
            {
                return HttpNotFound();
            }
            return View(seattype);
        }

        // POST: Admin/Seattypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Seattype seattype = db.Seattypes.Find(id);
            db.Seattypes.Remove(seattype);
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
