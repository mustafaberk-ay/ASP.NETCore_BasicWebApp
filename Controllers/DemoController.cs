using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCore_BasicWebApp.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
