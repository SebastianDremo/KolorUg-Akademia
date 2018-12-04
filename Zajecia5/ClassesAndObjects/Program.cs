using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mercedes = new Car("Merceds","Czarny");
            Car secondMercedes = mercedes;
            Console.WriteLine(mercedes.Color);
            secondMercedes.Color = "Biał";
            Console.WriteLine(mercedes.Color);
            Console.ReadKey();
        }
    }

    class Car
    {
        public string Color;
        private string _make;
        public string Make
        {
            get
            {
                return _make;
            }
            private set
            {
                if (value != "BMW")
                    _make = value;
            }
        }

        public Car(string make, string color)
        {
            this.Make = make;
            this.Color = color;
        }  
  
    }
}
