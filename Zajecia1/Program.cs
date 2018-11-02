using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmienne
{
    class Program
    {
        static void Main(string[] args)
        {
            //To jest deklaracja liczby calkowitej
            int liczbaCalkowita; 
            liczbaCalkowita = 20;

            int liczbaCalkowita2 = liczbaCalkowita;

            int liczbaCalkowita3 = 20, liczbaCalkowita4 = 20;

            //liczba zmiennoprzecinkowa
            double liczbaZmien = 40.00;

            int liczbaCalkowita5 = (int)liczbaZmien;
            int liczbaCalkowita6 = Convert.ToInt32(liczbaZmien);

            //wartosc logiczna - bool
            bool logika = true;

            bool czyPrawda = 10 != 6;  //!= -> różne

            //string vs char
            char znak = '2';

            string napis = "2";

            //ciezkie rzeczy
            //int a = 2;

            //Console.WriteLine(a++);
            //Console.WriteLine(++a + " " + a--);

            //Console.WriteLine(--a);

            int a = 10;
            a = a + 2;

            int b = 10;
            b += 2; //b = b + 2;

            double c = 10;

            c *= b;

            //instrukcje warunkowe
            //if 

            //Czy podana liczba jest wieksza od 10

            Console.Write("Podaj 1 liczbe: ");
            int podanaLiczba1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj 2 liczbe: ");
            int podanaLiczba2 = Convert.ToInt32(Console.ReadLine());

            if (podanaLiczba1 > podanaLiczba2) Console.WriteLine($"{podanaLiczba1} jest wieksza od {podanaLiczba2}");

            Console.ReadLine();
        }
    }
}
