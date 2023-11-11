using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Web_UI.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}