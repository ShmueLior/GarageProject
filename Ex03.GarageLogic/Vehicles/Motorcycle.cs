using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic.Enums;
using Ex03.GarageLogic.VehicleParts;

namespace Ex03.GarageLogic.Vehicles
{
   public class Motorcycle : Vehicle
    {
        private readonly eMotorcycleLicenseType m_LicenseType;
        private readonly int m_EngineCapacity;
        private readonly Engine m_Engine;

        public Motorcycle(string i_ModelName, string i_LicenseNumber, float i_PercentageRemainingEnergy, Wheel[] i_Wheels, eMotorcycleLicenseType i_LicenseType, int i_EngineCapacity, Engine i_Engine)
                        :base(i_ModelName, i_LicenseNumber, i_PercentageRemainingEnergy, i_Wheels)
        {
            this.m_LicenseType = i_LicenseType;
            this.m_EngineCapacity = i_EngineCapacity;
            this.m_Engine = i_Engine;
        }
    }
}
