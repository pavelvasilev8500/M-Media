using M_Media.ModelInterfaces;
using M_Media.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace M_Media.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGameRepository _gameRepository;

        public HomeController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public IActionResult Index()
        {
            var gameOfYear = _gameRepository.GameOfTheYear;
            var homeViewModel = new HomeViewModel(gameOfYear);
            return View(homeViewModel);
        }
    }
}
