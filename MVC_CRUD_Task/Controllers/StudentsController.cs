using Microsoft.AspNetCore.Mvc;

namespace MVC_CRUD_Task.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
