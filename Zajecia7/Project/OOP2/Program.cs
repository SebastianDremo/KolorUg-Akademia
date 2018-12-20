using System;
using OOP2.Casting;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wszystkie implementacje porusoznych na zajęciach tematów znjadują się w odpowiednich plikach projektu

            // Możesz odkomentować zakomentowane błędne implementacje dla sprawdzenia komunikatów o błędach

            // Aby testować rozwiązania należy dodać deklaracje przestrzeni nazw znajdującej się w danym pliku na górze tego pliku
            // lub podać pełną ścieżkę wraz z przestrzenią nazw
            // przykład u góry 'using OOP2.Casting;'
            // przykładowe wywołanie:
            Casting.Casting.CustomCastingTest(); // Dla unikniecia zderzeń nazw testując podawaj dokłądną ścieżkę razem z przestrzenią nazw
            
            Console.ReadKey();
        }
    }
}
