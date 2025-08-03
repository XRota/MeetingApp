using MEETINGAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace MEETINGAPP.Controllers
{

    public class MeetingController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Apply()
        {

            return View();
        }
        public IActionResult List()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            ArgumentNullException.ThrowIfNull(model);
            return View();
        }



    }
}