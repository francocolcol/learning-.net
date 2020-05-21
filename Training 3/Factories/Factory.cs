using System;
using System.Collections.Generic;
using System.Text;
using Training_3.Classes;

namespace Training_3.Factories
{
    class Factory : IFactory
    {
        public IVehicle IdentifyVehicle(int wheels)
        {
            switch (wheels)
            {
                case 2:
                    return new Bicycle();
                case 4:
                    return new Car();
                case var _ when (wheels > 4):
                    return new Truck(wheels);
                default:
                    return null;
            }
        }
    }
}
