using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlixRev0
{
    public class Catalog
    {
        public List<Genre> Genres;

        public Catalog()
        {
            this.Genres = new List<Genre>();
        }
        public void CreateGenreList(Genre All, Genre Action, Genre Romance, Genre Drama)
        {
            Genres.Add (All);
            Genres.Add (Action);
            Genres.Add (Romance);
            Genres.Add (Drama);
        }
        public void CreateAllTitlesList(Genre All)
        {
            All.ListOfTitles.Add(new Movie("Spotlight", 4.5, 128));
            All.ListOfTitles.Add(new Movie("Brooklyn", 4, 92));
            All.ListOfTitles.Add(new Movie("The Revenant", 5, 160));
            All.ListOfTitles.Add(new Movie("Room", 3.5, 88));
            All.ListOfTitles.Add(new Movie("The Martian", 3, 132));
            All.ListOfTitles.Add(new Movie("Mad Max", 3.5, 125));
            All.ListOfTitles.Add(new TV_Show("Mr. Robot"));
            All.ListOfTitles.Add(new TV_Show("Game Of Thrones"));
            All.ListOfTitles.Add(new TV_Show("Narcos"));
            All.ListOfTitles.Add(new TV_Show("Outlander"));
            All.ListOfTitles.Add(new TV_Show("Empire"));
        }

        public void CreateActionTitlesList(Genre Action, Genre All)
        {
            Action.ListOfTitles.Add(All.ListOfTitles[0]);
            Action.ListOfTitles.Add(All.ListOfTitles[1]);
            Action.ListOfTitles.Add(All.ListOfTitles[5]);
            Action.ListOfTitles.Add(All.ListOfTitles[7]);
        }
        public void CreateRomanceTitlesList(Genre Romance, Genre All)
        {
            Romance.ListOfTitles.Add(All.ListOfTitles[2]);
            Romance.ListOfTitles.Add(All.ListOfTitles[6]);
        }
        public void CreateDramaTitlesList(Genre Drama, Genre All)
        {
            Drama.ListOfTitles.Add(All.ListOfTitles[3]);
            Drama.ListOfTitles.Add(All.ListOfTitles[4]);
            Drama.ListOfTitles.Add(All.ListOfTitles[8]);
        }
    }
}
