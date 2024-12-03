using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Mvc;
using System.Web.Services.Description;
using Test1Admin.Models;

namespace Test1Admin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Layout = "~/Views/Shared/_Layout.cshtml";
            return View();
        }
    }
}