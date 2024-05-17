using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Restoran.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        
    }
}