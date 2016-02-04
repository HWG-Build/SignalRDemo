﻿using System.Web.Mvc;

namespace SignalRDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Referral()
        {
            ViewBag.Message = "Add a referral.";

            return View();
        }
    }
}