using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlixRev0
{
    public class Title  //myBaseClass also referred to as an object, includes fields lke name, rating
    {
        public double? Rating;
        public string Name;
        public Genre Genre;
      
        public Title()
        {
            this.Rating = null;
            this.Name = null;
            this.Genre = null;
        }
        public Title(string name, double rating, Genre genre)
        {
            this.Rating = rating;
            this.Name = name;
            this.Genre = genre;
        }
    }
}

