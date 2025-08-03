using Microsoft.AspNetCore.Mvc;

namespace meetingapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            ViewBag.selamlama = saat < 12 ? "İyi günler" : "Günaydın";
            return View();
        }
    }
} 