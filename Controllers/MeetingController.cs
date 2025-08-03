using MEETINGAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace MEETINGAPP.Controllers
{

    public class MeetingController : Controller
    {

        public IActionResult Apply()
        {

            return View();
        }
        public IActionResult List()
        {

            return View(Repository.Users);
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            Repository.CreateUser(model);
            ViewBag.UserCount=Repository.Users.Where(i=> i.WillAttend == true).Count();
            
            return View("Thanks",model);
        }



    }
}