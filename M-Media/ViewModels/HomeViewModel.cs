using M_Media.Models;

namespace M_Media.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<GameModel> GameOfYear { get; }

        public HomeViewModel(IEnumerable<GameModel> gameOfYear)
        {
            GameOfYear = gameOfYear;
        }
    }
}
