using System;

namespace VehicleLot
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var car = new Car();
            var semi = new Semi();

            Console.WriteLine(car.getManufacturer());

        }
    }
}
