using cinema.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace cinema.Contexts
{
    public class FilmDBContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
    }
}