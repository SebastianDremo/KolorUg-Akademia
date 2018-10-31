using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolor3Grupa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pierwszy program
            //tworzenia kom. ctrl + k + c
            //usuwanie ctrl + k + u

            //Console.WriteLine("Hello world");

            //Console.Write("Hello world\n");

            //Console.WriteLine("Hello world");

            //Console.WriteLine("2 + 4");

            //Console.WriteLine(2 + 4);

            //Console.WriteLine(6 / 4);
            //Console.WriteLine(6.0 / 4);
            //Console.WriteLine((double)6 / 4);   //rzutowanie double na int

            Console.WriteLine("Witamy w kalkulatorze");

            //Console.WriteLine("5 + 4 = {5 + 4}");
            //Console.WriteLine($"5 + 4 = {5 + 4}");
            //Console.WriteLine("2 + 4 = {0}", 2 + 4);

            int liczbaCalkowita1 = 7;
            int liczbaCalkowita2 = 5;

            //int liczbaCalkowita3 = 5, liczba4 = 5;


            //c -> w tab tab -> Console.WriteLine();

            //Console.WriteLine("5 + 3 = 8");
            //Console.WriteLine($"{liczbaCalkowita1} + {liczbaCalkowita2} = {liczbaCalkowita1 + liczbaCalkowita2}");
            //Console.WriteLine($"{liczbaCalkowita1} / {liczbaCalkowita2} = {(double)liczbaCalkowita1 / liczbaCalkowita2}");

            Console.Write("Podaj liczbe: ");
            int nowaLiczba = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Podana liczba to: {nowaLiczba}, {nowaLiczba + 2}"); //ctrl + k + d

            Console.ReadKey();
        }
    }
}
