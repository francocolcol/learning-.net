using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Training_3.Classes
{
    public abstract class AbstractVehicle : IVehicle
    {
        protected int wheels { get; set; }
        protected string vehicleType { get; set; }
        protected Stopwatch stopwatch { get; }

        public AbstractVehicle(int wheels, string vehicleType)
        {
            this.wheels = wheels;
            this.vehicleType = vehicleType;
            stopwatch = new Stopwatch();
            stopwatch.Start();
        }

        public double CalculateRate()
        {
            //En segundos para ver funcionamiento
            double tiempo = Math.Truncate(Convert.ToDouble(stopwatch.ElapsedMilliseconds / 1000));
            return tiempo * wheels;
        }

        public void FindVehicle()
        {
            Console.WriteLine($"The vehicle found is a {vehicleType}");
        }

        public void ParkVehicle()
        {
            Console.WriteLine($"The vehicle parked is a {vehicleType}");
        }
    }
}
