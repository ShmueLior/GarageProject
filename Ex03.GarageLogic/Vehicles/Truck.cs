using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic.VehicleParts;

namespace Ex03.GarageLogic.Vehicles
{
    public class Truck: Vehicle
    {
        private readonly bool m_ContainRiskyMaterial;
        private readonly float m_TruckCapacity;
        private readonly Engine m_Engine;

        public Truck(string i_ModelName, string i_LicenseNumber, float i_PercentageRemainingEnergy, Wheel[] i_Wheels, bool i_ContainRiskyMaterial, float i_TruckCapacity, Engine i_Engine)
                   : base(i_ModelName, i_LicenseNumber, i_PercentageRemainingEnergy, i_Wheels)
        {
            m_ContainRiskyMaterial = i_ContainRiskyMaterial;
            m_TruckCapacity = i_TruckCapacity;
            m_Engine = i_Engine;
        }
    }
}
