using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic.VehicleParts
{
    class ElectricEngine : Engine
    {
        public ElectricEngine(float i_RemainderEnergy, float i_Capacity) : base(i_RemainderEnergy, i_Capacity) {}
    }
}
