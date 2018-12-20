using System;

namespace OOP2.Interfaces //zmaiana przestrzeni nazw na podprzestrzeń przestrzeni głównej naszego projektu
{
    // Deklaracja interfejsu
    // Nazwy interfejsów powinny zaczynać się z prefixem, duża litera 'i' -> 'I'
    public interface ISayHello
    {
        // Interfejsy zawierają samą definicję metod bez ich implementacji
        // określają w definicji typ zwracany przez metodę, nazwę metody oraz przyjmowane argumenty

        // Wszystkie metody w interfejsie są publiczne
        void SayHello();
    }

    public interface ISayGoodbye
    {
        void SayGoodbye();
    }

    public interface IHumanBehaviors : ISayGoodbye, ISayHello // Interfejsy mogą po sobie dziedziczyć
    {
        void HowAreYouFeelingToday(string mood);
    }

    // Klasa implementująca interfejs jest zmuszona do zapewnienia implementacji metod zdefiniowanych w interfejsie 
    public class Human : IHumanBehaviors // klasa implementuje interfejs 'IHumanBehaviors'
    {
        void IHumanBehaviors.HowAreYouFeelingToday(string mood) //jawna implementacja interfejsu w celu uniknięcia zderzeń nazw
        {
            Console.WriteLine($"{mood}, and you?");
        }

        public void SayGoodbye() // nie jawna implementacja metod interfejsu
        {
            Console.WriteLine("Goodbye!");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }

    public class Man : ISayHello, ISayGoodbye   // Klasy mogą implementować wiele interfejsów
    {
        public void SayGoodbye()
        {
            Console.WriteLine("Goodbye!");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }
}
