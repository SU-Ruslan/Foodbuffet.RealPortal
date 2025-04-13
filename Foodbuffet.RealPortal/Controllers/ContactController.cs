using Microsoft.AspNetCore.Mvc;

namespace Foodbuffet.RealPortal.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
