using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Red", 1.8f, 36);
            Audi audi = new Audi("Black", 2.0f, 42);

            Console.WriteLine("Obiekt Car: ");
            car.Accelerate(10);
            car.Stop();
            
            Console.WriteLine("\n \nObiekt Audi: ");
            audi.Accelerate(10);
            audi.Stop();

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
