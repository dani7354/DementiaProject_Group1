using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        private readonly SignInManager<IdentityUser> _signInManager;
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}