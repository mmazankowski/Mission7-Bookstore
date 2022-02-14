﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission7_Bookstore.Models;

namespace Mission7_Bookstore.Controllers
{
    public class HomeController : Controller
    {
        private iBookstoreRepository repo;

        public HomeController(iBookstoreRepository temp)
        {
            repo = temp; 
        }

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}


        //public HomeController(BookstoreContext temp)
        //{
        //    context = temp;
        //}

        //private BookstoreContext context { get; set; }

        //public HomeController(BookstoreContext temp) => context = temp; 

        public IActionResult Index()
        {
            var blah = repo.Books.ToList();

            return View(blah);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
