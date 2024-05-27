using M_Media.ModelInterfaces;
using Microsoft.EntityFrameworkCore;

namespace M_Media.Models
{
    public class GameRepository : IGameRepository
    {
        private readonly MMediaDbContext _context;

        public GameRepository(MMediaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<GameModel> AllGames
        {
            get
            {
                return _context.Games.Include(c => c.Category);
            }
        }

        public IEnumerable<GameModel> GameOfTheYear
        {
            get
            {
                return _context.Games.Include(c => c.Category).Where(g => g.IsGameOfTheYear);
            }
        }

        public GameModel? GetGameById(int id)
        {
            return _context.Games.FirstOrDefault(g => g.Id == id);
        }
    }
}
