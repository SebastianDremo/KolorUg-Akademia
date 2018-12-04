using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Car objectCar = new Car();
            objectCar.Make = "Mercedes";
            Console.WriteLine(objectCar.Make);
            Console.ReadKey();
        }
    }

    class Car
    {
        private string Make;

        public void setMake(string make)
        {
            Make = make;
        }
  
    }
}
