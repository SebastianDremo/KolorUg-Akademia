using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int test1 = 50;//okreslamy zmienne pomocnicze z ktorych bedziemy korzystac w przykladach
            int test2 = 75;
            int test3 = 100;
            if (test1 != 50)// nasza pierwsza instrukcja warunkowa "if", miedzy nawiasami ten funkcji ustawiamy warunek splenienia jej, w tym przypadku wykona sie "jesli test1 NIE jest rowny 50"
                Console.WriteLine("if spelniony");


            if (test1 == 50 || test2 == 60) // || oznacza "lub", czyli jeden z dwoch warunkow musi byc spelniony aby "if" wykonal sie
                Console.WriteLine("if nr 2 spelniony");

            if (test1 == 50 && test2 == 60) // && oznacza "i", czyli oba warunki MUSZA byc spelnione
            { Console.WriteLine("if nr 3 spelniony"); }

            else { Console.WriteLine("if nr 3 nie jest spelniony"); } // insutrkcja "else" mowi nam co innego ma sie wykonac jesli poprzedzajacy ja "if" nie wykona sie

            if (test1 == 50 || (test2 == 60 && test3 == 90))
                Console.WriteLine("if nr 4 spelniony");//jesli tylko jedna instrukcja pod ifem to mozna ominac klamry 

             //i++ oznacza i = i + 1
            // i-- oznacza i = i - 1

            //pierwsza petla - for

            for (int i = 0; i < 20; i++) //w pierwszym bloku petli for (tzn przed pierwszym srednikiem) okreslana jest zmienna na ktorej ta petla bedzie dzialac
                                         //w drugim bloku ustawiany jest warunek zakonczenia petli
                                         //w trzecim bloku okreslamy co ma sie zdarzyc z nasza zmienna po kazdym obrocie petli. W tym przypadku "i" wzrasta o 1 po kazdym okrazeniu
            {
                if(i==10)
                {
                    break; // instrukcja break - natychmiastowe wyjscie z petli, zakonczenie jej wykonywania, oraz kontynuacja programu nizej
                }
                    Console.WriteLine(i); //podczas kazdego okrazenia petli wypisujemy na ekran wartosc zmiennej "i", dlatego przy np 10 obrotach wypisza sie liczby od 0 do 9

            }
            Console.WriteLine("koniec petli");
            // druga petla - while

            int j = 10; // okreslamy pomocnicza zmienna "j" do operowania w funkcji while
            while(j<20) // w nawiazach petli while ustawiany jest warunek zakonczenia jej
            {

                j = j + 5;

                Console.WriteLine(j);

                j = j + 5;
                
            }

            //3 petla - do...while
            int zmienna1 = 20;
            Console.WriteLine("petla do while");//pomocniczy znacznik gdzie zaczyna  sie nasza petla "do while"
            do
            { //otwieramy nawias klamrowy naszego polecenia "do"
               zmienna1 = zmienna1+ 2;//zwiekszenie zmiennej "zmienna1" o 2 na poczatku petli
                Console.WriteLine(zmienna1);

                if (zmienna1 == 30)
                    continue; // instrukcja continue - przeskakiwanie do konca pętli oraz iteracja 
                Console.WriteLine("continue nie spelnione");

                if(zmienna1==32)
                break;//instrukcja break do wyjscia z petli
                else
                Console.WriteLine("break nie spelnione");


            }
            while (zmienna1 < 40);//nasza petla do while wykonuje sie dopoki "zmienna1" jest mniejsza od 40
            Console.ReadLine();
        }

    }
}