using cinema.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace cinema.Contexts
{
    public class UserDBContext : DbContext
    {
        public DbSet<User> Films { get; set; }
    }
}