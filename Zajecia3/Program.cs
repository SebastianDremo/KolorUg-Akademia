using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wprowadz liczbe ");
            int liczba = int.Parse(Console.ReadLine());


            switch (liczba) // uzywamy wartosci w () jako zmiennej
            {
                 //do jakiegos menu lub wyboru, 
                case 1:
                    Console.WriteLine("wybralismy 1");
                    break;
                case 2:
                    Console.WriteLine("wybralismy 2");
                    break;
                default:
                    Console.WriteLine("nie mamy takiej opcji w menu");
                    break;
            }

            int ocena1 = 3;
            int ocena2 = 2;
            int ocena3 = 6;

            int[] tablicaOcen = new int[3]; // liczymy elemnty od 0
            tablicaOcen[0] = 3;
            tablicaOcen[1] = 5;
            tablicaOcen[2] = 2;

            for (int i = 0; i < 3; i++) // indeksujemy po i
            {
                Console.WriteLine(tablicaOcen[i]);
                //wypiszemy element czwarty czyli tablicaOcen[3]
            }

            int[][] tablicaDwuwymiarowa = new int[4][];

            for (int i = 0; i < 4; i++)
            {
                tablicaDwuwymiarowa[i] = new int[3];
                {
                    for (int j = 0; j < 3; j++)
                    {
                        tablicaDwuwymiarowa[i][j] = j;
                        ;
                    }
                }
            }

            Console.WriteLine(tablicaDwuwymiarowa[0][1]); // 1

           //  0 1 2
           //  0 1 2
           //  0 1 2
           //  0 1 2
            int[] tablicaOcenDruga = new int[5];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tablicaDwuwymiarowa[i][j] + " ");
                }
                Console.WriteLine();
            }

            int[,] tablica = new int[2, 2]; // przy tablicach kwadratowych

            string[] tablicaStringow =
            {
                "kolor",
                "sala"
            };

            //listy

            List<int> listaNumerow = new List<int>()
            {
                3,5,6,7
            };

            //dodawanie do listy 5 
            listaNumerow.Add(5);
            //usuwanie pierwszej 5 która znajdzie sie w liście
            listaNumerow.Remove(5);


            for (int i = 0; i < listaNumerow.Count; i++)
            {
                Console.WriteLine(listaNumerow[i]);
            }

            //Tworzenie listy stringow
            List<string> listaStringow = new List<string>()
            {
            "jest", "nas", "duzo"
            };


            string koncowyNapis = "";
            for (int i = 0; i < listaStringow.Count; i++)
            {
                koncowyNapis += listaStringow[i];
            }

            Console.WriteLine(koncowyNapis);

            for (int i = 0; i < listaStringow.Count; i++)
            {
                Console.Write(listaStringow[i]);
            }

            int suma = 0;
            for (int i = 0; i < listaNumerow.Count; i++)
            {
                suma += listaNumerow[i];
            }

            // nadpisywanie elementu o indeksie 0 w liscie
            listaStringow[0] = "czyms";

            // ciekawostka - jest to szukanie w liscie takie elementu który zawiera "jes"
            listaStringow.Where(x=>x.Contains("jes"));

            //nadpisywanie w tablicy danego elementu
            int[] tab = new int[1];
            tab[0] = 2;
            tab[0] = 6;


            string koncowyNapis2 = "";
            foreach (var napis in listaStringow)
            {
                koncowyNapis2 += napis;

            }

            //ksiazka telefoniczna
            // 60603232 - "Jan Kowalski"

            Dictionary<string, string> daneUzytkownikow = new Dictionary<string, string>()
            {
                ["jkowalski"] = "kolor",
            };

            Console.WriteLine("podaj login");
            string login = Console.ReadLine();
            Console.WriteLine("podaj haslo ");
            string haslo = Console.ReadLine();

            string hasloUzytkowinka = daneUzytkownikow[login];
            if (daneUzytkownikow[login] == haslo)
            {
                Console.WriteLine("zalogowales sie");
            }
            else
            {
                Console.WriteLine("nie zalogowales sie");
            }

            // mozna robic dictionary z różnymi typami danych
            Dictionary<int, string> intDictonary = new Dictionary<int, string>();


            Console.ReadKey();

        }
    }
}
