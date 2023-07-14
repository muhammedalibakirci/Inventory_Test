using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace proje1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginKontrol()
        {
            return View();
        }
       
    }
}
