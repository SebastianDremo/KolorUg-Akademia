using System;
using geometry;


namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Audi audi = new Audi("Czarny", 2.0f, 48);
            audi.Accelerate(10);
            
            square sq = new square();
            Console.ReadKey();
        }

    }
    
    abstract public class Car
    {
        public string Color { get; set; }
        public float EngineDisplacement { get; set; }
        public int FuelTankCapacity ;
        private int Fuel { get; set; }
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

        public Car()
        {
            Speed = 0;
            Fuel = 0;
        }
        public Car(string color,float engineDispacement, int fuelTankCapacity) : this()
        {
            Color = color;
            EngineDisplacement = engineDispacement;
            FuelTankCapacity = fuelTankCapacity;
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
                Console.WriteLine($"Prędkość: {this.Speed++}  Stan paliwa: {this.Fuel--}/{this.FuelTankCapacity}");
            }
        }

        public void Stop()
        {
            Console.WriteLine("\nHamowanie!");
            Speed = 0;
            Console.WriteLine($"Prędkość: {Speed}  Stan paliwa: {this.Fuel}/{this.FuelTankCapacity}");            
        }
        public void test(ref int a)
        {
             a++;
        }
    }


    public class Audi : Car
    {
        public bool Quattro;
        public Audi(string color,float engineDispacement, int fuelTankCapacity) : base(color, engineDispacement, fuelTankCapacity)
        {}
    }
    
}
