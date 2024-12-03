using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1Admin.Models;

namespace Test1Admin.Controllers
{
    public class UsersController : Controller
    {
        public ActionResult Users()
        {
            ViewBag.Layout = "~/Views/Shared/_Layout.cshtml";
            WebNgheNhacEntities db = new WebNgheNhacEntities();
            List<User> t = db.Users.ToList();
            ViewBag.Alluser = t;
            return PartialView("Users");
        }
    }
}