using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérlek add meg a nevedet: ");
            string nev =Console.ReadLine();
            Console.WriteLine("Kérlek add meg az életkorodat: ");
            int kor = Convert.ToInt32(Console.ReadLine());
            if (kor>=18)
            {
                Console.WriteLine($"{nev} nagykorú.");
            }
            else
            {
                Console.WriteLine($"{nev} kiskorú.");
            }

            Console.ReadKey();
        }
    }
}
