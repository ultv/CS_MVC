﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testMVC.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ViewResult Result()
        {

            ViewData["Name"] = "Андрей";            
            return View("Result");
        }
    }
}