using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Controllers
{
    public class AccountController : Controller
    {

        private UserManager<IdentityUser> userManager;
        public IActionResult Login()
        {
            return View();
        }
    }
}
