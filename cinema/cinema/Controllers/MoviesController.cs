using cinema.Contexts;
using cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace cinema.Controllers
{
    public class MoviesController : Controller
    {
        DBContext db = new DBContext();
        // GET: Movies
        public ActionResult Index()
        {
            return View(db.Films.ToList());
        }

        // GET: Movies/Detail/5
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film f = db.Films.Find(id);
            if (f == null)
            {
                return HttpNotFound();
            }
            return View(f);
        }
    }
}