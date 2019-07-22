using cinema.Contexts;
using cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cinema.Controllers
{
    public class LoginController : Controller
    {
        private DBContext db = new DBContext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string Username, string Password)
        {
            if (ModelState.IsValid)
            {
                var u = (User)db.Users.Where(user => user.Username == Username && user.Password == Password);
                if (u != null)
                {
                    var r = db.Roles.Select(o => o.ID == u.RoleID);
                    if (r != null)
                    {
                        string role = ((Role)r).Name;
                        switch (role)
                        {
                            case "User":
                                return RedirectToAction("Index", "Home");
                            case "Admin":
                                return RedirectToAction("Index", "Home", new { area = "Admin" });
                        }
                    }
                }
            }
            ViewBag.Error = "Username or password incorrect";
            return View();
        }
    }
}