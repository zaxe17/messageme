using Microsoft.AspNetCore.Mvc;
using mvc_example.Models;
using System.Diagnostics;

namespace mvc_example.Controllers
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
            return View();
        }

        [HttpPost]
        public IActionResult Index(MessageModel model)
        {
            if(ModelState.IsValid)
            {
                Console.WriteLine(model.UpperCaseName + ": " + model.Message);
                return View("ThankYou", model);
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
