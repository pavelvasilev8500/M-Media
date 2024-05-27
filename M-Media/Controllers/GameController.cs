using M_Media.ModelInterfaces;
using M_Media.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace M_Media.Controllers
{
    public class GameController : Controller
    {

        private readonly IGameRepository _gameRepository;
        private readonly ICategoryRepository _categoryRepository;
        //private readonly IText _text;

        public GameController(IGameRepository gameRepository, ICategoryRepository categoryRepository)
        {
            _gameRepository = gameRepository;
            _categoryRepository = categoryRepository;
        }

        //public GameController(IGameRepository gameRepository, IText text)
        //{
        //    _gameRepository = gameRepository;
        //    _text = text;
        //}

        public IActionResult GameList()
        {
            //var vm = new TextViewModel();
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine(vm.GetMessage());
            //Console.ResetColor();
            var gameViewModel = new GameListViewModel(_gameRepository.AllGames, "All Games");
            return View(gameViewModel);
        }

        public IActionResult GameDetails(int id)
        {
            var game = _gameRepository.GetGameById(id);
            if(game == null)
                return NotFound();
            return View(game);
        }
    }
}
