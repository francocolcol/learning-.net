using System;
using Training_3.Classes;
using Training_3.Factories;

namespace Training_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new Factory();
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("How many wheels does your vehicle have?");
                string input = Console.ReadLine();
                int wheels;
                int.TryParse(input, out wheels);
                IVehicle vehiculo = factory.IdentifyVehicle(wheels);
                vehiculo.ParkVehicle();
                vehiculo.FindVehicle();
                bool parked = true;
                while (parked)
                {
                    Console.WriteLine("There is a vehicle parked, do you want to remove it? (Y/N)");
                    input = Console.ReadLine();
                    parked = (input.Trim().ToUpper() != "Y");
                }
                Console.WriteLine($"The total to pay is {vehiculo.CalculateRate()}");
                Console.WriteLine("Do you want to park another vehicle? (Y/N)");
                input = Console.ReadLine();
                exit = (input.Trim().ToUpper() == "Y");
            }
        }
    }
}
