using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcApp1.Models;

namespace MvcApp1.Controllers
{
    [Area("MvcApp1")]
    public class HomeController : Controller
    {
        private readonly ExampleService _exampleService;

        public HomeController(ExampleService exampleService)
        {
            _exampleService = exampleService;
        }
        public IActionResult Index()
        {
            return View("Index", _exampleService.GetText());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
