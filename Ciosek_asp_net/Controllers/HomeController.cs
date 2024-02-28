﻿using Ciosek_asp_net.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ciosek_asp_net.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult StronaStatyczna()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}