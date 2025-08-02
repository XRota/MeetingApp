using Microsoft.AspNetCore.Mvc;

namespace meetingapp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "home/index";
        }
    }
} 