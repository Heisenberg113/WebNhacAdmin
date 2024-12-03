using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using Test1Admin.Models;

namespace Test1Admin.Controllers
{
    public class TypesController : Controller
    {
        public ActionResult Types()
        {
            ViewBag.Layout = "~/Views/Shared/_Layout.cshtml";
            WebNgheNhacEntities db = new WebNgheNhacEntities();
            List<Type> t = db.Types.ToList();
            ViewBag.Alltype = t;
            return PartialView("Types");
        }
    }
}