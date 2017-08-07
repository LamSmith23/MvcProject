using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class UserLoginController : Controller
    {
        // GET: UserLogin
        public ActionResult Index()
        {
            using(UserLoginDBContext db = new UserLoginDBContext())
                {
                return View(db.UserLogin.ToList());
            }
        }

        public ActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Register(UserLogin login)
        {
            if (ModelState.IsValid)
            {
                using (UserLoginDBContext db = new UserLoginDBContext())
                {
                    db.UserLogin.Add(login);
                    db.SaveChanges();
                }

                ModelState.Clear();
                ViewBag.Message = login.FirstName + "" + login.LastName + "successfully registered.";
            }

            return View();
        }
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]

        public ActionResult Login(UserLogin user)
        {
            using (UserLoginDBContext db = new UserLoginDBContext())
            {
                var usr = db.UserLogin.Where(u => u.UserName == user.UserName && u.Password == user.Password).FirstOrDefault();
                if (usr != null)
                {
                    Session["UserID"] = usr.UserID.ToString();
                    Session["UserName"] = usr.UserName.ToString();
                    return RedirectToAction("LoggedIn");
                }

                else
                {
                    ModelState.AddModelError("", "UserName or Password is wrong");
                }

                return View();
            }
        }

        public ActionResult LoggedIn()
        {
            if(Session["UserId"] != null)
            {
                return View();
            }

            else
            {
                return RedirectToAction("Login");
            }
        }

    }
}