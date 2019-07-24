using cinema.Contexts;
using cinema.Models;
using cinema.ModelsView;
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
            List<Film> ListFreshFilm = db.Films.Take(3).OrderByDescending(f => f.PublicationDate).ToList();
            List<Film> ListShowingFilm = db.Films.OrderByDescending(f => f.PublicationDate).Take(4).Where(f => f.PublicationDate < DateTime.Now).ToList();
            List<Film> ListCommingsoonFilm = db.Films.OrderByDescending(f => f.PublicationDate).Take(3).Where(f => f.PublicationDate > DateTime.Now).ToList();
            HomeFilmView homeFilm = new HomeFilmView(ListFreshFilm, ListShowingFilm, ListCommingsoonFilm);
            return View(homeFilm);
        }
    }
}