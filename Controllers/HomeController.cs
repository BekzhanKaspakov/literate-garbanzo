using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using asd.Models;

namespace asd.Controllers
{
    public class HomeController : Controller
    {
		[HttpGet]
        public IActionResult Index()
        {
            return View();
        }
		[HttpPost]
		public IActionResult Index(string FirstName)
        {
			Console.WriteLine("SHIT HAPPENED");
			return Content($"Hello {FirstName}");
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
