using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            int a =2;
            car.test(ref a);
            System.Console.WriteLine(a);
            Console.ReadKey();
        }
    }
    
    public class Car
    {
        public string Color { get; set; }
        public float EngineDisplacement { get; set; }
        public int FuelTankCapacity { get; set; }
        public int Fuel { get; set; }
        public short Speed { get; set; }

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
             a=3;
        }
    }


    public class Audi
    {
        public string Color { get; set; }
        public float EngineDisplacement { get; set; }
        public int FuelTankCapacity { get; set; }
        public int Fuel { get; set; }
        public short Speed { get; set; }
        public bool Quattro { get; set; }

        public Audi()
        {
            Speed = 0;
            Fuel = 0;
        }
        public Audi(string color, float engineDispacement, int fuelTankCapacity) : this()
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
            while (Speed <= targetSpeed)
                Console.WriteLine($"Prędkość: {this.Speed++}  Stan paliwa: {this.Fuel--}/{this.FuelTankCapacity}");
        }

        public void Stop()
        {
            Console.WriteLine("\nHamowanie!");
            Speed = 0;
            Console.WriteLine($"Prędkość: {Speed}  Stan paliwa: {this.Fuel}/{this.FuelTankCapacity}");
        }
    }
}
