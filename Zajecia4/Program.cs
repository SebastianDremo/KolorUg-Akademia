using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademia5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metoda();
            //String imieKolegi = "Heniu";
            //String drugieImie = "Krzysiu";
            //int ile = 3;
            //Metoda(imieKolegi, drugieImie);
            //Metoda(imieKolegi, ile);
            int zmienna = 3;
            int wynikMetody;
            //wynikMetody = Pomnoz(3);
            //Console.WriteLine(wynikMetody);
            String imieDziecka = "Ania";
            //DajZwierzaka(imieDziecka);

            int[] tab = StworzTabliceLosowa(6);
            for(int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }

            Console.ReadKey();
        }

        static int[] StworzTabliceLosowa(int jakDuza)
        {
            int[] tablica = new int[jakDuza];
            int x;
            bool czyJest = false;

            Random rand = new Random();
            for(int i = 0; i < jakDuza; i++)
            {
                do
                {
                    x = rand.Next(1, 7);
                    if (!tablica.Contains(x))
                    {
                        czyJest = true;
                        tablica[i] = x;
                    }
                } while (!czyJest);
                czyJest = false;
            }
            Array.Sort(tablica);
            return tablica;
        }

        static void DajZwierzaka(String imie)
        {
            Console.WriteLine("Wybierz zwierzaka\n1.Pieseł\n2.Koteł\n3.Nic w ogóle :(");
            int wybor = Convert.ToInt32(Console.ReadLine());
            switch(wybor)
            {
                case 1:
                    imie += " ma psa!";
                    break;
                case 2:
                    imie += " ma kota!";
                    break;
                default:
                    imie += " nie ma zwierzaka :(";
                    break;
            }
            Console.WriteLine(imie);
        }

        static int Pomnoz(int x)
        {
            int wynik;
            wynik = x * 3;
            return wynik;
        }

        static void Metoda()
        {
            Console.WriteLine("Siema!");
        }

        static void Metoda(String imie, String drugieImie)
        {
            Console.WriteLine($"Siema, {imie}! Gdzie jest {drugieImie}?");
        }

        static void Metoda(String imie, int ilosc)
        {
            Console.WriteLine($"Siema {imie}, kup {ilosc} piwka!");
        }

    }

}
