using BasicECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BasicECommerce.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
