using M_Media.Models;

namespace M_Media.ModelInterfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<CategoryModel> AllCategories { get; }
    }
}
