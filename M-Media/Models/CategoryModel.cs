using System.ComponentModel.DataAnnotations;

namespace M_Media.Models
{
    public class CategoryModel
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public List<GameModel>? Games { get; set; }
    }
}