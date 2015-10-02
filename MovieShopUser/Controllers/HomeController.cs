﻿using MoviesShopProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieShopUser.Controllers
{
    public class HomeController : Controller
    {

        Facade facade = new Facade();

        public ActionResult Index()
        {
            
            return View(facade.GetMovieRepository().ReadAll());
        }

        public ActionResult Buy(int id)
        {
            return View(id);
        }

        public ActionResult Info(int id)
        {
            return View(facade.GetMovieRepository().Read(id));
        }
    }
}