using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic.VehicleParts;

namespace Ex03.GarageLogic.Vehicles
{
    class Vehicle
    {
        private string m_ModelName;
        private string m_RegistrationPlate; // לוחית רישוי
        private float m_PercentageRemainingEnergy;
        private Wheel[] Wheels;
    }

}
