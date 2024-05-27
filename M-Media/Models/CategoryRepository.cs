using M_Media.ModelInterfaces;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace M_Media.Models
{
    internal class CategoryRepository : ICategoryRepository
    {
        private readonly MMediaDbContext _context;

        public CategoryRepository(MMediaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CategoryModel> AllCategories => _context.Categories.OrderBy(g => g.CategoryName);

    }
}