using Microsoft.AspNetCore.Mvc;

namespace MyToDoList.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
