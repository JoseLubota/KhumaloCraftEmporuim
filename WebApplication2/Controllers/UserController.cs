using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace KhumaloCraftEmporium.Controllers
{
    public class UserController : Controller
    {
        public userTBL usertbl = new userTBL();

        [HttpPost]
        public ActionResult About(userTBL Users)
        {
            var result = usertbl.insert_User(Users);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult About() 
        { 
            return View(usertbl); 
        }
       
    }
}
