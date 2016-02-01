using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlixRev0
{
    public class Genre : IEnumerable
    { 
        public List<Title> ListOfTitles;
        public string Name;

        public Genre(string name)
        {
            this.Name = name;
            this.ListOfTitles = new List<Title>();
        }
     
        public IEnumerator GetEnumerator()
        {
            foreach(Title title in ListOfTitles)
            {
                yield return title;
            }
        }
    }
}
