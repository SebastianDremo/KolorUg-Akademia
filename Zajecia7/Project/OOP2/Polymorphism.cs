using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2.Polymorphism
{
    public static class Polymorphism
    {
        public static void PolymorphismTest()
        {
            Human human = new Human();
            Woman woman = new Woman();
            Man man = new Man();

            Console.WriteLine("Przysłonięcie metody klasy bazowej: ");
            human.Introduce();
            woman.Introduce();
            man.Introduce();
            Console.WriteLine("Po rzutowaniu Woman/Man na Human:");
            ((Human)woman).Introduce();

            Console.WriteLine("\nNadpisanie metody klasy bazowej:");
            human.SayHello();
            woman.SayHello();
            Console.WriteLine("Po rzutowaniu Woman na Human:");
            ((Human)woman).SayHello();

            Console.WriteLine("\nNadpisywanie metod z klasy System.Object:");
            Console.WriteLine("Bazowa metoda ToString():");
            Console.WriteLine(man.BaseToString());
            Console.WriteLine("Nadpisana metoda ToString():");
            Console.WriteLine(man.ToString());
        }
    }

    public class Human
    {
        public void Introduce()
        {
            Console.WriteLine("Introduce - Human");
        }

        public virtual void SayHello()
        {
            Console.WriteLine("Human - Hello!");
        }
    }

    public class Woman : Human
    {
        public void Introduce() // przykrycie odziedzicoznej metody, bez 'new' otrzymujemy ostrzeżenie ponieważ przytsłonięcie może nie być celowe
        {                      
            Console.WriteLine("Introduce - Woman");
        }

        public sealed override void SayHello() // nadpisanie metody 'override', oraz blokada dalszych nadpisać 'sealed'
        {
            Console.WriteLine("Woman - Hello");

            //Możemy odwołać się do nadpisanej metody
            Console.WriteLine("Woman - wywołanie nadpisanej metody bazowej Human.SayHello() w obiekcie Woman:");
            base.SayHello();
        }
    }

    public class Man : Woman
    {
        public new void Introduce() // przysłonięcie metody bazowe ze słowem kluczowym 'new'
        {
            Console.WriteLine("Introduce - Man");
        }

        //public override void SayHello() { }  // nie możemy ponownie nadpisać metody ponieważ została zapieczętowana w klasie Woman

        // Mamy możliwość nadpisywania metod bazowych z klasy podstawowej System.Object (Equals, GetHashCode, GetType, ToString)
        // eg.
        public override string ToString()
        {
            return "Klasa Man zamieniona na string przez nadpisanie metody System.Object.ToString()";
        }

        public string BaseToString() 
        {
            return base.ToString();
        }
    }
}
