using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspnetcoreSessionstate.Models;
using Microsoft.AspNetCore.Http;

namespace AspnetcoreSessionstate.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Key1", "Hi, I am from session!!!!!!!!!!!!!");
            return View();
        }

        public IActionResult About()
        {

            ViewBag.sessionv = HttpContext.Session.GetString("Key1");
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
