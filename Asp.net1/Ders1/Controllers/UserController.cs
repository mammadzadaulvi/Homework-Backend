using Microsoft.AspNetCore.Mvc;

namespace Ders1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Ulvi";
            ViewBag.Surname = "Mammadzada";
            ViewBag.Age = 21;
            ViewBag.Country = "Azerbaijan";
            ViewBag.PhoneNumber = "050-555-55-55";
            return View();
        }
    }
}
