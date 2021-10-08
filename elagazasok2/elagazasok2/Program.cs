using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elagazasok2
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat12();
            //feladat13();
            feladat14();

            //mintafeladat();
            Console.WriteLine("enter");
            Console.ReadLine();
        }
        static void mintafeladat()
        {
            Console.WriteLine("Kávéautomata");
            Console.WriteLine("A: expresso");
            Console.WriteLine("B:Latte");
            Console.WriteLine("C:espresso");
            Console.WriteLine("D:cappucino");
            Console.WriteLine("E:bécsi kávé");
            Console.WriteLine("F:ristretto");
            Console.WriteLine("G: forró csoki");
            Console.Write("Válassz egy terméket(A-G) ");
            char valasztas = char.Parse(Console.ReadLine());
            switch(valasztas)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("Az expresso kávé ára 130Ft");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("latte ára 130Ft");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("espresso ára 120Ft");
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine("cappucino ára 110Ft");
                    break;
                case 'E':
                case 'e':
                    Console.WriteLine("Bécsi kávé ára 150Ft");
                    break;
                case 'F':
                case 'f':
                    Console.WriteLine("ristretto ára 200Ft");
                    break;
                case 'G':
                case 'g':
                    Console.WriteLine("forró csoki ára 100Ft");
                    break;







                default:
                    Console.WriteLine("Nincs ilyen lehetőség.");


                   break;
            }
        }
        static void feladat12()
        {
           
            Console.WriteLine("adj meg egy számot(1-12)");
            int honap1 = int.Parse(Console.ReadLine());
            switch (honap1)
            {
                case 1:
                    Console.WriteLine("Január");
                    break;
                case 2:
                    Console.WriteLine("Február");
                    break;
                case 3:
                    Console.WriteLine("Március");
                    break;
                case 4:
                    Console.WriteLine("Április");
                    break;
                case 5:
                    Console.WriteLine("Május");
                    break;
                case 6:
                    Console.WriteLine("Június");
                    break;
                case 7:
                    Console.WriteLine("Július");
                    break;
                case 8:
                    Console.WriteLine("Augusztus");
                    break;
                case 9:
                    Console.WriteLine("Szeptember");
                    break;
                case 10:
                    Console.WriteLine("Október");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;

                default:
                    Console.WriteLine("Nincs ilyen sorszámú hónap.");
                    break;
            }
        }
        static void feladat13()
        {
            Console.WriteLine("Adj meg egy számot (1-12)");

            int honapok1 = int.Parse(Console.ReadLine());
            switch(honapok1)
            {
                case 1:
                    Console.WriteLine("Január,tél");
                    break;
                case 2:
                    Console.WriteLine("február,tél");
                    break;
                case 3:
                    Console.WriteLine("március.tavasz");
                    break;
                case 4:
                    Console.WriteLine("április,tavasz");
                    break;
                case 5:
                    Console.WriteLine("május,tavasz");
                    break;
                case 6:
                    Console.WriteLine("junius,nyár");
                    break;
                case 7:
                    Console.WriteLine("Julius,nyár");
                    break;
                case 8:
                    Console.WriteLine("augusztus,nyár");
                    break;
                case 9:
                    Console.WriteLine("szeptember,ősz");
                    break;
                case 10:
                    Console.WriteLine("október,ösz");
                    break;
                case 11:
                    Console.WriteLine("november,ősz");
                    break;
                case 12:
                    Console.WriteLine("December,tél");
                    break;
                default:
                    Console.WriteLine("Nincs ilyen sorszámú hónap.");
                    break;
            }
           
        }
        static void feladat14()
        {

        }
        
    }
}
