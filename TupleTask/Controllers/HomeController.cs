using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TupleTask.Models;

namespace TupleTask.Controllers
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

            Student std1 = new Student()
            {
                Id = 1,
                Name = "Azhar",
                Age = 23
            };
            Course c1 = new Course()
            {
                CourseId = 101,
                CourseName = "ASP.NET MVC",
                InstructorName = "Rahma"
            };

            var data = new Tuple<Student, Course>(std1, c1);

            return View(data);
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
