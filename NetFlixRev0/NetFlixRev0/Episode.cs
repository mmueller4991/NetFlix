using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlixRev0
{
    public class Episode
    {
        public double Rating;
        public string Name;

        public Episode(double rating, string name)
        {
            this.Rating = rating;
            this.Name = name;
        }
    }
}
