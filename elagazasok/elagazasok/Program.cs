using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elagazasok
{
    class Program
    {    
        static void Main(string[] args)
        {
            //feladat1()
            feladat2();

        }
        static void feladat1()
        {
            Console.Write("Kérek egy számot!");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam % 2 == 0)
            {
                Console.WriteLine("A szám páros.");
            }
            else
            {
                Console.WriteLine("A szám páratlan.");
            }
            Console.Read();
        }
        static void feladat2()
        {
            Console.Write("adj meg egy számot!");
            int elojelek = Convert.ToInt32(Console.ReadLine());
            if (elojelek > 0)
            {
                Console.WriteLine("a szám pozitív");



            }

            else 
            {
                Console.WriteLine("a szám negatív");
            }
            Console.Read();
        }
    }
}
