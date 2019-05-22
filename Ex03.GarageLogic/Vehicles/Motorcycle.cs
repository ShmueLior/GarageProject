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

        public Motorcycle(string i_ModelName, string i_LicenseNumber, float i_PercentageRemainingEnergy, Wheel[] i_Wheels, eMotorcycleLicenseType i_LicenseType, int i_EngineCapacity, Engine i_Engine)
                          :base(i_ModelName, i_LicenseNumber, i_PercentageRemainingEnergy, i_Wheels, i_Engine)
        {
            this.m_LicenseType = i_LicenseType;
            this.m_EngineCapacity = i_EngineCapacity;
        }

        public override string ToString()
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.AppendLine(base.ToString());
            strBuild.AppendFormat("Motocycle license type: {0}", m_LicenseType.ToString());
            strBuild.AppendFormat("Motocycle engine capacity: {0}", m_EngineCapacity);

            return strBuild.ToString();
        }
    }
}
