using Microsoft.AspNetCore.Mvc;

namespace AspNetIntro.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
