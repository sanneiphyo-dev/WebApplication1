using ContosoUniversity.AppDbContextModels;
using ContosoUniversity.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
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

        public async Task<IActionResult> Students()
        {
            var students = await _context.Students 
                .AsNoTracking()
                .Select(s => new StudentViewModel
                {
                    Id = s.Id,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    EnrollmentDate = s.EnrollmentDate
                })
                .ToListAsync();

            return View(students); 
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


        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
