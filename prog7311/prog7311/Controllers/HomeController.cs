﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prog7311.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
                        return View();
        }

        public ActionResult Contact()
        {
            
            return View();
        }

        public ActionResult Register => RedirectToAction("Register", "User");
    }
}