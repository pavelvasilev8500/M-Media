namespace M_Media.Models
{
    public class GameModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ShortDescription { get; set; }
        public string? FullDescription { get; set; }
        public decimal StorePrise { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThunbnailUrl { get; set; }
        public bool IsGameOfTheYear { get; set; }
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; } = default!;
    }
}
