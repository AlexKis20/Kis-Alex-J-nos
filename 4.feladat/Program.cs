using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random vszam=new Random(100);
            int paros = 0;
            int paratlan = 0;
            for (int i = 0; i < 20; i++)
            {
               if (i % 2 == 0)
                {
                    paros++;
                }
                else
                {
                    paratlan++;
                }

            }
            Console.WriteLine("Eredmények:");
            Console.WriteLine($"Páros számok száma: {paros}");
            Console.WriteLine($"Páratlan számok száma: {paratlan}");



            Console.ReadKey();
        }
    }
}
