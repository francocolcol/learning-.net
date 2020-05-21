using System;
using System.Collections.Generic;
using System.Text;
using Training_3.Classes;

namespace Training_3.Factories
{
    interface IFactory
    {
        IVehicle IdentifyVehicle(int wheels);
    }
}
