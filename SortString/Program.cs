using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Nos ide most beírtam valamit, hogy menjen a hely bla bla bla.";
            string[] sa = s.Split(' ');

            Array.Sort(sa);

            s = string.Join(" ", sa);
            Console.WriteLine(s);
        }
    }
}
