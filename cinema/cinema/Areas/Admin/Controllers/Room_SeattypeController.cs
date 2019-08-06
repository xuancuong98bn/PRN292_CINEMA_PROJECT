using cinema.Areas.Admin.Models;
using cinema.Contexts;
using cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cinema.Areas.Admin.Controllers
{
    public class Room_SeattypeController : Controller
    {
        private DBContext db = new DBContext();

        // GET: Admin/Room_Seattype
        public ActionResult Index()
        {
            return View();
        }

        //GET Create
        public ActionResult Create(int? roomId = 1)
        {
       
            Room room = db.Rooms.Find(roomId);
            if (room == null)
            {
                //
                return HttpNotFound();
            }

            Room_Seattype room_Seattype = new Room_Seattype();
            room_Seattype.RoomID = room.ID;
            ViewBag.NumberRow = room.RowQuantity;

            //dropdownlist seattype to sellect
            var seattypes = db.Seattypes.ToList();
            ViewBag.SeattypeID = new SelectList(seattypes, "Code", "Name");

            return View(room_Seattype);
            
         //   return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Code,Name,RowQuantity,ColumnQuantity,IsEnable")] Room room)
        {
            if (ModelState.IsValid)
            {
                //roomDb.Rooms.Add(room);
                //roomDb.SaveChanges();
                //return RedirectToAction("Index");

                //go to create controller _ Seat
                return RedirectToAction("Create", "Room_Seattype", new { RoomId = room.ID });
            }
            return View(room);

        }

    }
}