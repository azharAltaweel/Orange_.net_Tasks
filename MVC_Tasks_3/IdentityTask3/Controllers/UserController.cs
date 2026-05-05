using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityTask3.Controllers
{
    [Authorize(Roles ="User")]
    public class UserController : Controller
    {
        public IActionResult HelloUser()
        {
            return View();
        }
    }
}
