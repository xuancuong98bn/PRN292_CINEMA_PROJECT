using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using cinema.Areas.Admin.Models;
using cinema.Contexts;
using cinema.Models;

namespace cinema.Areas.Admin.Controllers
{
    public class FilmsController : Controller
    {
        private DBContext db = new DBContext();

        // GET: Films
        public ActionResult Index(String keyword)
        {
            var films = from fi in db.Films
                        select fi;

            if (!String.IsNullOrEmpty(keyword))
            {
                films = films.Where(s => s.Title.Contains(keyword));
            }

            return View(films);
          
        }

        // GET: Films/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // GET: Films/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Films/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Code,Title,Author,Actor,PublicationDate,ContentFilm,Image, ImageFile, IsEnable")]  Film2 film)
        {
            //Check Code unique
            //var filmcheck = db.Films.Where(m => m.Code.Equals(film.Code));
            //if(filmcheck != null)
            //{
            //    string message = "Code is duplicate";
            //    ViewBag.Duplicate = message;
            //    return View("Create");
            //}

            //from video---------------
            
            string fileName = Path.GetFileName(film.ImageFile.FileName);
            film.Image = "~/Image/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);
            film.ImageFile.SaveAs(fileName);

            //
            Film fileO = new Film()
            {
                ID = film.ID,
                Code = film.Code,
                Title = film.Title,
                Author = film.Author,
                Actor = film.Actor,
                ContentFilm = film.ContentFilm,
                PublicationDate = film.PublicationDate,
                Image = film.Image,
                IsEnable = film.IsEnable
            };

            if (ModelState.IsValid)
            {
                db.Films.Add(fileO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelState.Clear();
            return View(film);
        }


      

            // GET: Films/Edit/5
            public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // POST: Films/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID, Code,Title,Author,Actor,PublicationDate,ContentFilm,Image,IsEnable")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Entry(film).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Films");
            }
            return View(film);
        }

        // GET: Films/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        /// <summary>
        /// if(not ticket booked) { delete }    else {enable = false}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // POST: Films/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Film film = db.Films.Find(id);
            db.Films.Remove(film);
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
