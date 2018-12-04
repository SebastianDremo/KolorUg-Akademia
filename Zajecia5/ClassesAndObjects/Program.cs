using System;
using System.Collections.Generic;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mercedes = new Car("Merceds", "Czarny");
            Car Audi = new Car("Audi");
           
            Console.WriteLine(Car.counter);
            Console.ReadKey();

            Console.WriteLine(Math.Abs(-2));
        }
    }

    class Car
    {
        public static int counter = 0;
        
        private List<int> _distance;
        public string Type;
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
        public Car()
        {
            this.Type = "Sedan";
            this._distance = new List<int>();
            counter++;
        }
        public Car(string make, string color) : this()
        {
            this.Make = make;
            this.Color = color;
        }
        public Car(string make) : this()
        {
            this.Make = make;
        }

        public void Drive()
        {
            Console.WriteLine("Wrum wrum");
            _make = "Jaguar";
        }
        public void addDistance(int distance)
        {
            this._distance.Add(distance);
        }
        public Car()
        {

        }
        public int MyProperty { get; set; }
    }

    static class Dealer
    {
        static int x;
        static public void something()
        { }
        
        
    }
}
