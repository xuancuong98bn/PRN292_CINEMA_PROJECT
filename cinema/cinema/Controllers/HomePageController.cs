using cinema.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cinema.Controllers
{
    public class HomePageController : Controller
    {
        DBContext db = new DBContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Films.Take(3).OrderBy(f => f.PublicationDate).ToList());
        }
    }
}