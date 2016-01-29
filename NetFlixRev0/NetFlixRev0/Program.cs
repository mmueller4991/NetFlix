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
            Title myTitle = new Title(); // calls the class named "Title," then sets up fields for a new Title
            Title title2 = new Title("Titanic", 4);
            Title title3 = new Title("Spotlight", 4.5);

            Console.WriteLine(myTitle);
            Console.ReadLine();
        }
        
    }
}
