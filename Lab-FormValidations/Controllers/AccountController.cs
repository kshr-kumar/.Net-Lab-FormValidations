using Lab_FormValidations.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_FormValidations.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserViewModel model)
        {
            if (ModelState.IsValid) {

                return RedirectToAction("Index", "Home");            
            }
            return View();
        }
    }
}
