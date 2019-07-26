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
    public class LoginController : Controller
    {
        private DBContext db = new DBContext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                var u = db.Users.Where(us => us.Username == user.Username && us.Password == user.Password).FirstOrDefault();
                if (u != null)
                {
                    var r = db.Roles.Where(o => o.ID == u.RoleID).FirstOrDefault();
                    if (r != null)
                    {
                        Session.Add("user", u);
                        Session.Add("role", r);
                        string role = r.Name;
                        switch (role)
                        {
                            case "Customer":
                                TicketView tv = (TicketView)Session["TicketV"];
                                if (tv != null)
                                {
                                    return RedirectToAction("Step3", "Book");
                                }
                                else
                                {
                                    return RedirectToAction("Index", "HomePage");
                                }
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