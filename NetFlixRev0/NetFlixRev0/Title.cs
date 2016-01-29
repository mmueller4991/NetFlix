using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlixRev0
{
    public class Title  //myBaseClass
    {
        private int RatingofMovie;
        private string TitleOfMovie;
        private string v1;
        private double v2;

        public Title(string name, int rating)  //overload constructor: takes in name and rating fields and sets them
        {
            TitleOfMovie = name;
            RatingofMovie = rating;
        }
        public Title()
        {
            TitleOfMovie = null;
            int? RatingOfMovie;
            RatingOfMovie = null;
        }

        public Title(string v1, double v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}

