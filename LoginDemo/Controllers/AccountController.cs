using LoginDemo.Models;
using LoginDemo.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LoginDemo.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly AccountService _service;

        public AccountController(AccountService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return Content($"You are logged in as {User.Identity.Name}");
        }

        [Route("")]
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [Route("")]
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(AccountLoginVM account)
        {
            if (!ModelState.IsValid)
                return View(account);

            var result = await _service.SignInAsync(account.UserName, account.Password);

            if (!result)
            {
                ModelState.AddModelError(nameof(AccountLoginVM.UserName), "Invalid login credentials");
                return View(account);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
