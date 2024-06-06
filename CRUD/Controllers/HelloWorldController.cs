using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int age = 4)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["Age"] = age;
            return View();
        }

    }
}
