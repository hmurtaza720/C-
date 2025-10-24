using M_UserLogin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace M_UserLogin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<Users> _userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<Users> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        // 👇 Public page — visible without login
        [AllowAnonymous]
        public IActionResult Welcome()
        {
            return View();
        }

        // 👇 Dashboard page — visible only to logged-in users
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            return View(user);
        }

        [Authorize]
        public IActionResult Privacy() => View();

        [AllowAnonymous]
        public IActionResult Error() => View();
    }
}
