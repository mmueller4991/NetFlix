using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlixRev0
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            ViewTitlesWithGenres viewtitleswithgenres = new ViewTitlesWithGenres();
            Genre All = new Genre("All");
            Genre Action = new Genre("Action");
            Genre Romance = new Genre("Romance");
            Genre Drama = new Genre("Drama");

            catalog.CreateAllTitlesList(All);
            catalog.CreateActionTitlesList(Action, All);
            catalog.CreateRomanceTitlesList(Romance, All);
            catalog.CreateDramaTitlesList(Drama, All);
            catalog.CreateGenreList(All, Action, Romance, Drama);
            viewtitleswithgenres.DisplayGenresAndTitles(catalog.Genres);

            Console.ReadKey();
        }
        
    }
}
