using System.Diagnostics;
using Foodbuffet.RealPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Foodbuffet.RealPortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        
    }
}
