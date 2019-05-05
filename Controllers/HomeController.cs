using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarsWebMvc.Models;

namespace CarsWebMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly Repository repository;

        public HomeController(Repository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            ViewBag.Greeting = DateTime.Now.Hour > 12 ? "Good afternoon" : "Good morning";
            return View("MyView");
        }

        [HttpPost]
        public IActionResult RsvpForm([FromForm]GuestResponse response)
        {
            if (ModelState.IsValid)
            {
                repository.AddResponse(response);
                return View("Thanks", response);
            }
            else
            {
                return View();
            }
            
        }

        public IActionResult RsvpForm()
        {
            return View();
        }

        public IActionResult ListResponses()
        {
            return View(repository.Responses.Where(x => x.WillAttend == true));
        }

        public IActionResult Contact()
        {
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
