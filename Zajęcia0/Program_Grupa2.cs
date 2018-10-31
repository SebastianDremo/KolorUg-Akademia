using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolor2Grupa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pierwszy program Kolor
            //Tworzenie kom. ctrl + k + c
            //Usuwanie ctrl + k + u

            //Console.WriteLine("Hello world");

            //Console.Write("Hello world2");
            //Console.Write("Hello world2\n");


            //Console.WriteLine("Hello world3");


            //Console.WriteLine("2 + 2");
            //Console.WriteLine(2 + 2);

            //Console.WriteLine("3 / 2");
            //Console.WriteLine((double)3 / 2);
            //Console.WriteLine(3.0 / 2);

            //Console.WriteLine(10 % 3);

            //Console.WriteLine($"2 + 5 = {2 + 5}");
            ////Console.WriteLine("2 + 5 = {0}", 2 + 5);
            ////Console.WriteLine("2 + 5 = " + (2 + 5));

            //Console.WriteLine($" 2 - 5 = {(double)2.0 / 5}");

            //int liczbaCalkowita1 = 3;
            //int liczbaCalkowita2 = 5;



            //Console.WriteLine("Witaj w kalkulatorze");
            //Console.WriteLine($"{liczbaCalkowita1} + {liczbaCalkowita2} = {liczbaCalkowita1 + liczbaCalkowita2}");
            //Console.WriteLine($"{liczbaCalkowita1} / {liczbaCalkowita2} = {(double)liczbaCalkowita1 / liczbaCalkowita2}");

            Console.Write("Podaj liczbe: ");

            int liczbaCalkowita = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Podana liczba: {liczbaCalkowita}, {liczbaCalkowita} + 2");
            Console.WriteLine($"Podana liczba: {liczbaCalkowita}, {liczbaCalkowita + 2}");


            Console.ReadKey();
        }
    }
}
