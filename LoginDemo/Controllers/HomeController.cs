using LoginDemo.Models;
using LoginDemo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LoginDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAcmeRepository _repository;
        public HomeController(IAcmeRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View(new HomeIndexVM
            {
                Header = _repository.GetHeader()
            });
        }
    }
}
