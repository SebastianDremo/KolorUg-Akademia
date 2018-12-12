using System; // Użycie przestrzeni nazw z biblioteki podstawowej
using Geometry; // Użycie własnej przestrzeni nazw


namespace OOP // Przestrzeń nazw naszego projektu
{
    class Program
    {
        static void Main(string[] args)
        {
            Audi audi = new Audi("Czarny", 2.0f); // Stworzenie obiektu dziedziczącego po klasie Car i przekazanie do jego konstrukotra parametrów wymaganych przez konstruktor Car
            audi.Accelerate(10); // Wywołanie metody odzedziczonej po Car w klasie Audi
            
            Square sq = new Square(); // Tworzenie obiektu znajdującego się w innej przestrzeni nazw (wymagana tu jest klauzula "using Geometry;" w górnej części pliku!!!) 
            Geometry.Square sq2 = new Geometry.Square(); // Przykład użycia klasy z innej przestrzeni nazw bez klauzuly using

            Console.WriteLine(Car.FuelTankCapacity); // Wywołanie pola const z klasy Car które stało się tym samym statyczne

            string test = "test";
            // Przekazanie prametru bez referencji
            RefAndOutTest.Test(test);
            Console.WriteLine(test);

            // Przekazanie parametru z referencją
            RefAndOutTest.TestWithRef(ref test);
            Console.WriteLine(test);

            // Przekazanie parametru z out
            string testOut;
            RefAndOutTest.TestWithOut(out testOut);
            Console.WriteLine(testOut);

            Console.ReadKey();
        }

    }
    
    abstract public class Car // Klasa abstarkcyjna. Nie można utworzyć jej instancji (obiektu)!
    {
        // Hermetyzacja pól klasy

        // Pole ze słowem kluczowym readonly może być przypisane po deklaracji lub w konstrukotrze co pozwala na nada wartości z zewnątrz 
        public readonly string Color;

        // Druga możliwość deklarowania "właściwości" tylko do oczytu przy użyciu składni c# dla getter, zachowanie podobne do readonly
        public float EngineDisplacement { get;} 

        // Pole ze słowem kluczowym "const" wymaga przypisania wartości przy deklaracji, staję się nie mutowalne i  statyczne
        public const int FuelTankCapacity = 40;

        // Prywatna właściwość klasy
        private int Fuel { get; set; }




        // Właściwość Speed odwołująca sie do prywatnego pola _speed posiada weryfikację wartości podawanych do setter'a warto je tworzyć w przypadku kiedy wiele
        // metod z danej klasy odwołuje się do danego pola wiele razy, a nie powinniśmy w takim przypadku implementować w każdej metodzie mechanizmy weryfikacji podawanych wartości
        // łamiąc tym samym zasadę DRY (Don't Repeat Yourself)
        private short _speed;
        public short Speed
        {
            get{
                return this._speed;
            }
            set{
                if(value >= 0 && value < 180)
                    _speed = value;
            }
        }

        // Konstruktory klasy abstakcyjnej, nie mogą zostać użyte do utowrzenia jej obiektu ale mogą zostać wykorzystane przez klasy dziedziczące
        public Car()
        {
            Speed = 0;
            Fuel = 0;
        }
        public Car(string color,float engineDispacement) : this()
        {
            Color = color;
            EngineDisplacement = engineDispacement;
            this.Refuel();
        }

        public void Refuel()
        {
            Fuel = FuelTankCapacity;
        }

        public void Accelerate(int targetSpeed)
        {
            while(Speed <= targetSpeed)
            {
                Console.WriteLine($"Prędkość: {this.Speed++}  Stan paliwa: {this.Fuel--}/{FuelTankCapacity}");
            }
        }


    }


    // Klasa Audi dziedziczy po abstrakcyjnej klasie Car
    // Zostałą oznaczona słówkiem kluczowym "sealed" co oznacza, że nie jest możliwe dalsze dziedziczenie po tej klasie
    public sealed class Audi : Car
    {
        public bool Quattro; //Pole klasy Audi

        public Audi(string color, float engineDispacement) // konstruktora klasy Audi przyjmuje dwa parametry
            : base(color, engineDispacement) // odwołanie do konstruktora klasy bazowej, przekazane są do niego paramatry wcześniej podane do konstruktora Audi
        {

        }

        public void RefuelAudi()
        {
            base.Refuel(); // Odwoływanie do klasy bazowej jest wykonywane przy pomocy słówka kluczowego "base"
        }
    }
    
    public static class RefAndOutTest
    {
        public static void Test(string value)
        {
            value = "Zmieniona bez referencji";
        }
        public static void TestWithRef(ref string value)
        {
            value = "Zmieniona przez referencje";
        }
        public static void TestWithOut(out string value)
        {
            value = "Przypisana przez out";
        }
    }
}
