﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (Request.Method.ToLower() == "post")
            {
                var redirectResult = Redirect("./Home/Privacy");
                return redirectResult;
            }
            else
            {
                return View();
            }
        }

        public IActionResult Privacy()
        {
            if (Request.Method.ToLower() == "post")
            {
                var redirectResult = Redirect("./Home/Index");
                return redirectResult;
            }
            else
            {
                return View();
            }
        }

      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
