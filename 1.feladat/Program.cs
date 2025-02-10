using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Egy kg alma ára: ");
            int egykgalma =Convert.ToInt16(Console.ReadLine());
            Console.Write("Hány kg almát veszel: ");
            double mennyikgkell = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Ennyi alma ára {mennyikgkell * egykgalma} korona.");



            Console.ReadKey();
        }
    }
}
