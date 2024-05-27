namespace M_Media.Models
{
    public static class DBInitializer
    {
        private static Dictionary<string, CategoryModel>? categories;
        public static Dictionary<string, CategoryModel> Categories
        {
            get
            {
                if(categories == null)
                {
                    var genresList = new CategoryModel[]
                    {
                         new CategoryModel
                         {
                            CategoryName = "Action",
                            Description = "Ready to Action"
                         },
                         new CategoryModel
                         {
                            CategoryName = "Racing",
                            Description = "Your Race, your rules"
                         },
                         new CategoryModel
                         {
                            CategoryName = "Strategies",
                            Description = "Take Strategic command"
                         }
                    };
                    categories = new Dictionary<string, CategoryModel>();
                    foreach(var o in genresList)
                    {
                        categories.Add(o.CategoryName, o);
                    }
                }
                return categories;
            }
        }

        public static void Send(IApplicationBuilder applicationBuilder)
        {
            MMediaDbContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<MMediaDbContext>();
            if(!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }
            if(!context.Games.Any())
            {
                context.AddRange
                (
                     new GameModel
                     {
                         Name = "Assassin's Creed",
                         ShortDescription = "Best action game of 2007",
                         FullDescription = "An action-adventure " +
                         "computer game developed by Ubisoft Montreal and published by Ubisoft. " +
                         "For the first time, the game was presented at the X ’05 exhibition " +
                         "hosted by Microsoft. At E3 2006, the game was officially announced for" +
                         "the PlayStation 3 under the title Assassin's Creed. Later, Ubisoft also " +
                         "announced the release of the game on Xbox 360 and Windows. The console " +
                         "version went on sale in November 2007, and the PC version went on sale on " +
                         "April 8, 2008. The game was developed by people who participated in " +
                         "the creation of Prince of Persia: The Sands of Time. The music of the " +
                         "game was written by Jesper Kud.",
                         StorePrise = 12,
                         ImageUrl = "https://droidnews.ru/img/2022/april/moddery-prokachali-pervuyu-assassins-creed-i-sravnili-s-originalom-2007-goda_12-04-22-23-31-41.jpg",
                         ImageThunbnailUrl = "https://avatars.mds.yandex.net/i?id=b65ad553798377e8766bb5e50710973e_l-11402455-images-thumbs&n=13",
                         IsGameOfTheYear = true,
                         CategoryId = 1,
                         Category = Categories["Action"]
                     },
                    new GameModel
                    {
                        Name = "XCom 2",
                        ShortDescription = "Rescue Earth from aliens",
                        FullDescription = "A turn-based tactical computer game developed by " +
                        "Firaxis Games and released by 2K Games for Microsoft Windows, macOS " +
                        "and Linux in 2016. XCOM 2 is a sequel to XCOM: Enemy Unknown (2012), " +
                        "a 1994 remake of X—COM: UFO Defense. If XCOM: Enemy Unknown offered the " +
                        "player to defend planet Earth from an alien invasion that had just begun, " +
                        "XCOM 2 shows a world in which the aliens won the war, and twenty years " +
                        "have passed since their victory; a totalitarian regime has been " +
                        "established on Earth, and the revived XCOM organization is already acting " +
                        "as an underground rebel movement. As in the previous game, XCOM 2 combines " +
                        "two modes — tactical, where the player controls a squad of 4-6 fighters in " +
                        "a turn—based battle, and strategic, where the player must one by one " +
                        "recapture regions of the Earth from aliens using the Avenger, an alien ship " +
                        "captured by XCOM and serving as a mobile base for the organization. " +
                        "The game received high critical acclaim and was nominated for a number of " +
                        "awards.",
                        StorePrise = 15,
                        ImageUrl = "https://i.pinimg.com/originals/9e/c9/38/9ec9382cb9f421c9da5b863065a79cc4.jpg",
                        ImageThunbnailUrl = "https://ns-on.ru/wp-content/uploads/2020/07/cee6ef17-36d6-4c00-9c6e-5a1093a75a86-1536x864.jpeg",
                        IsGameOfTheYear = false,
                        CategoryId = 3,
                        Category = Categories["Strategies"]
                    },
                    new GameModel
                    {
                        Name = "Need For Speed Most Wanted(2005)",
                        ShortDescription = "Race of your life",
                        FullDescription = "A computer game of the Need for Speed series in " +
                        "the genre of arcade car racing, developed by EA Canada studio and " +
                        "published by Electronic Arts for consoles, personal computers and " +
                        "mobile phones in 2005. The release of the game was timed to coincide " +
                        "with the start of sales of the new Xbox 360 console, the game disc " +
                        "was supplied with the console[9]. Russian Russian edition of Most Wanted " +
                        "was published by the Soft Club company, initially with Russian " +
                        "documentation[1], and since 2006 — completely in Russian[K 2]. " +
                        "The PlayStation Portable version of the game was released under the " +
                        "title Need for Speed: Most Wanted 5-1-0.",
                        StorePrise = 10,
                        ImageUrl = "https://i.pinimg.com/originals/d7/8b/3f/d78b3f1712468c3f884dd93b76ea232a.jpg",
                        ImageThunbnailUrl = "https://images.hdqwalls.com/download/need-for-speed-most-wanted-key-art-5k-q7-2048x1152.jpg",
                        IsGameOfTheYear = true,
                        CategoryId = 2,
                        Category = Categories["Racing"]
                    },
                    new GameModel
                    {
                        Name = "Grid Autosport",
                        ShortDescription = "Best autosimulator",
                        FullDescription = "Grid Autosport is a 2014 racing video game developed " +
                        "by Codemasters for Microsoft Windows, PlayStation 3, Xbox 360, Linux, " +
                        "iOS, macOS, Nintendo Switch and Android. It is the third game in the " +
                        "Grid series. It aims to move the series back towards more authentic " +
                        "racing games following the release of Grid 2, which Codemasters felt " +
                        "was not as well-received by the company's core fanbase as it was hoped " +
                        "for.[1] The developers consequently introduced major modifications to " +
                        "the handling model and built a lean, race-first oriented design for this " +
                        "title.",
                        StorePrise = 20,
                        ImageUrl = "https://i0.wp.com/mynintendonews.com/wp-content/uploads/2018/11/grid_autosport.jpg?fit=1920%2C1080&ssl=1",
                        ImageThunbnailUrl = "https://www.nintendoworldreport.com/media/49727/4/7.jpg",
                        IsGameOfTheYear = false,
                        CategoryId = 2,
                        Category = Categories["Racing"]
                    }
                );
            }
            context.SaveChanges();
        }
    }
}
