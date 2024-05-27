using M_Media.Models;

namespace M_Media.ViewModels
{
    public class GameListViewModel
    {
        public IEnumerable<GameModel> Games { get; }
        public string? Category { get; }

        public GameListViewModel(IEnumerable<GameModel> games, string? category)
        {
            Games = games;
            Category = category;
        }
    }
}
