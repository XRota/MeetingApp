namespace MEETINGAPP.Models;
using Microsoft.AspNetCore.Mvc;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        int saat = DateTime.Now.Hour;

        ViewBag.selamlama = saat > 12 ? "İyi günler" : "Günaydın";
        ViewBag.UserName = "Koray";
        ViewBag.DateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        var MeetingInfo = new MeetingInfo()
        {
            Id = 1,
            Location = "İstanbul, ABC Caddesi No: 123",
            Date = new DateTime(2025, 08, 15, 20, 0, 0),
            NumberOfPeople = 10
        };

        return View(MeetingInfo);
    }
}
