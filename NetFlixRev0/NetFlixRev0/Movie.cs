﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlixRev0
{
    public class Movie : Title
    {
        public int DurationInMinutes;

        public Movie(string name, double rating, int durationInMin)
        {
            this.Name = name;
            this.Rating = rating;
            this.DurationInMinutes = durationInMin;

        }
        public override string ToString()
        {
            return (Name + " has a duration of : " + DurationInMinutes + " minutes.");
        }
    }
}
