using cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema.ModelsView
{
    public class HomeFilmView
    {
        public List<Film> ListFreshFilm { get; set; }
        public List<Film> ListShowingFilm { get; set; }
        public List<Film> ListCommingsoonFilm { get; set; }
        public HomeFilmView()
        {

        }

        public HomeFilmView(List<Film> listFreshFilm, List<Film> listShowingFilm, List<Film> listCommingsoonFilm)
        {
            ListFreshFilm = listFreshFilm;
            ListShowingFilm = listShowingFilm;
            ListCommingsoonFilm = listCommingsoonFilm;
        }
    }
}