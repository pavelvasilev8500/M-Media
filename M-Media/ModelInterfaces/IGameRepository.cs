using M_Media.Models;

namespace M_Media.ModelInterfaces
{
    public interface IGameRepository
    {
        IEnumerable<GameModel> AllGames { get; }
        IEnumerable<GameModel> GameOfTheYear { get; }
        GameModel? GetGameById(int id);
    }
}
