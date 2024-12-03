using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1Admin.Models;

namespace Test1Admin.Controllers
{
    public class SongsController : Controller
    {
        public ActionResult Songs()
        {
            ViewBag.Layout = "~/Views/Shared/_Layout.cshtml";
            WebNgheNhacEntities db = new WebNgheNhacEntities();
            List<Song> t = db.Songs.ToList();
            ViewBag.Allsong = t;
            return PartialView("Songs");
        }
    }
}