using Microsoft.AspNetCore.Mvc;//import namespace necessesary classes for creating controllers
using SimpleWebApp.Models;//import model
using System.Diagnostics;//for system diagnostics and debugging

//This controller handles requests related to the home page 
//    and other general pages of the application.

namespace SimpleWebApp.Controllers
{
    public class HomeController : Controller 
    {
        private readonly ILogger<HomeController> _logger;//constructor of the controller

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() //action method that handles requests to the root UR
        {
            return View(); //return index page
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
