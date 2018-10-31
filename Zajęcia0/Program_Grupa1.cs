using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupa1Kolor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pierwsza aplikacja
            //Tworzenie komentarza => ctrl + k + c
            //Usuwanie => ctrl + k + u

            //Console.WriteLine("Witamy w super kalkulatorze");

            //Console.WriteLine($"1 + 2 = {1 + 2}");
            //Console.WriteLine("1 + 2 = {0}", 1 + 2);
            //Console.WriteLine($"1 + 2 = " + (1 + 2));

            //Console.WriteLine($"1 - 2 = {1 - 2}");

            Console.WriteLine("Witamy w kalkulatorze");

            Console.WriteLine("Podaj pierwsza liczbe: ");

            double liczbaCalkowita1 = 2;
            int liczbaCalkowita2 = 4;


            Console.WriteLine($"{liczbaCalkowita1} + {liczbaCalkowita2} = {liczbaCalkowita1 + liczbaCalkowita2}");
            Console.WriteLine($"{liczbaCalkowita1} / {liczbaCalkowita2} = {liczbaCalkowita1 / liczbaCalkowita2}");

            Console.WriteLine(liczbaCalkowita1 / liczbaCalkowita2);

            int wczytanaLiczba = Convert.ToInt32(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
