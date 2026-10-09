using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
        }

        [HttpGet]
        public IActionResult Products()
        {
            TempData["StatusMessage"] = "New product created successfully!";
            return View();
        }

        //[HttpPost]
        //public IActionResult Create(Product product)
        //{
        //    TempData["StatusMessage"] = "New product created successfully!";

        //    return View("Products");
        //}

        public IActionResult Index()
        {
            //ViewData["PageTitle"] = "Our Products";
            //ViewData["AvailableProducts"] = new List<string> { "Laptop", "Mouse", "Keyboard" };
            ViewBag.PageTitle = "Our Products";
            ViewBag.AvailableProducts = new List<string> { "Laptop", "Mouse", "Keyboard" };
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Students()
        {
            return View();
        }


        public IActionResult Courses()
        {
            return View();
        }

        public IActionResult Instructors()
        {
            return View();
        }

        public IActionResult Departments()
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
