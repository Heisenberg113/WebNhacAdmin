using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1Admin.Models;

namespace Test1Admin.Controllers
{
    public class SingersController : Controller
    {
        public ActionResult Singers()
        {
            ViewBag.Layout = "~/Views/Shared/_Layout.cshtml";
            WebNgheNhacEntities db = new WebNgheNhacEntities();
            var singers = db.Singers.ToList();
            return View(singers);
        }

        [HttpPost]
        public ActionResult CreateSinger(string name)
        {
            Singer singer = new Singer();
            singer.NAME = name;
            WebNgheNhacEntities db = new WebNgheNhacEntities();
            if (name != null)
            {
                db.Singers.Add(singer);
                db.SaveChanges();
            }
            return RedirectToAction("Singers");
        }

        public ActionResult DeleteSinger(int id)
        {
            WebNgheNhacEntities db = new WebNgheNhacEntities();
            var singer = db.Singers.Find(id);
            if (singer != null)
            {
                db.Singers.Remove(singer);
                db.SaveChanges();
            }
            else
            {
                return HttpNotFound();
            }

            return RedirectToAction("Singers");
        }

        public ActionResult UpdateSinger(int id, string name)
        {
            WebNgheNhacEntities db = new WebNgheNhacEntities();
            var singer = db.Singers.Find(id);
            if (singer != null)
            {
                singer.NAME = name;
                db.SaveChanges();
            }
            else
            {
                return HttpNotFound();
            }
            return RedirectToAction("Singers");
        }
    }
}