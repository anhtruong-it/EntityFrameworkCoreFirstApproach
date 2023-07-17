using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace coreIdentityApplication.Controllers
{
    public class DemoController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult Details()
        {
            return View();
        }
        [Authorize]
        public IActionResult Policy()
        {
            return View();
        }
    }
}
