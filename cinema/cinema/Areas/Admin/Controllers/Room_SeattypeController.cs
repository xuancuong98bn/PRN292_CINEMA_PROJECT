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
    public class Room_SeattypeController : Controller
    {
        private DBContext db = new DBContext();

        // GET: Admin/Room_Seattype
        public ActionResult Index(int? RoomId)
        {
            
            return View();
            //return View(db.Room_Seattypes.ToList());
        }

        // GET: Admin/Room_Seattype/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Room_Seattype room_Seattype = db.Room_Seattypes.Find(id);
        //    if (room_Seattype == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(room_Seattype);
        //}



        // GET: Admin/Room_Seattype/Create
        public ActionResult Create(int RoomId)
        {
            //roomId
            Room_Seattype room_Seattype = new Room_Seattype();
            room_Seattype.RoomID = RoomId;

            Room room = db.Rooms.Find(RoomId);
            if(room == null)
            {
                //
                return HttpNotFound();
            }
            int numberRow = room.RowQuantity;
            //    room_Seattype.RowthWithType = new Dictionary<int, int>(numberRow);
            ViewBag.NumberRow = room.RowQuantity;

            //dropdownlist seattype to sellect
            var seattypes = db.Seattypes.ToList();
            ViewBag.SeattypeID = new SelectList(seattypes, "Code", "Name");

            return View(room_Seattype);
        }

        // POST: Admin/Room_Seattype/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RoomID,RowthWithType,IsEnable")] Room_Seattype room_Seattype)
        {
            Console.Write(room_Seattype.RowthWithType.ToString());
            //if (ModelState.IsValid)
            //{
            //    db.Room_Seattypes.Add(room_Seattype);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}

            return View(room_Seattype);
        }

        // GET: Admin/Room_Seattype/Edit/5
        public ActionResult Edit(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //Room_Seattype room_Seattype = db.Room_Seattypes.Find(id);
            //if (room_Seattype == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(room_Seattype);
            return View();
        }

        // POST: Admin/Room_Seattype/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RoomID,Rowth,SeattypeID,IsEnable")] Room_Seattype room_Seattype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(room_Seattype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(room_Seattype);
        }

        // GET: Admin/Room_Seattype/Delete/5
        public ActionResult Delete(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //Room_Seattype room_Seattype = db.Room_Seattypes.Find(id);
            //if (room_Seattype == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(room_Seattype);
            return View();
        }

        // POST: Admin/Room_Seattype/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Room_Seattype room_Seattype = db.Room_Seattypes.Find(id);
            //db.Room_Seattypes.Remove(room_Seattype);
            //db.SaveChanges();
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
