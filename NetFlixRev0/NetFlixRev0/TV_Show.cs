using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlixRev0
{
    class TV_Show : Title
    {
        List<Episode> Episodes;

        public new double Rating;            //Override parent's Rating to return a string wth name of show and number of episodes
        private double ratings;

        public TV_Show(string name)         //b)	Overrides parent's (the class) Rating to return an average rating of Episode ratings
        {
            this.Name = name;
            CreateEpisodeList();
            GetAverageRatingOfEpisodes();
        }
        public void CreateEpisodeList()
        {
            double Rating1;
            double Rating2;
            double Rating3;
            double Rating4;
            Rating1 = 1.0;
            Rating2 = 2.0;
            Rating3 = 3.0;
            Rating4 = 4.0;

            this.Episodes = new List<Episode>()
             { new Episode(Rating1, "Episode 2"), new Episode(Rating2, "Episode 2"), new Episode(Rating3, "Episode 3"), new Episode(Rating4, "Episode 4") };
        }
        public void GetAverageRatingOfEpisodes()
        {
            foreach(Episode episode in Episodes)
            {
                ratings += episode.Rating;
            }
            this.Rating = ratings / Episodes.Count;
        }
        public override string ToString()
        {
            return (Name + " Rating : " + Rating.ToString());
        }
    }
}
