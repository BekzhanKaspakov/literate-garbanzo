
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asd.Models;
using Microsoft.AspNetCore.Mvc;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace asd.Controllers
{
    public class FormController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Index(FormModel form)
        {
			return Content($"Your firstName: {form.FirstName}\n" +
			               $"Your lastName: {form.LastName}\n" +
			               $"Your EMAIL: {form.Email}");
        }
    }
}
