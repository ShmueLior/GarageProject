using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic.VehicleParts;

namespace Ex03.GarageLogic.Vehicles
{
    public class Vehicle
    {
        private readonly string m_ModelName;
        private readonly string m_LicenseNumber;
        private readonly float m_PercentageRemainingEnergy;
        private readonly Wheel[] m_Wheels;

        protected Vehicle(string i_ModelName, string i_LicenseNumber, float i_PercentageRemainingEnergy, Wheel[] i_Wheels)
        {
            this.m_ModelName = i_ModelName;
            this.m_LicenseNumber = i_LicenseNumber;
            this.m_PercentageRemainingEnergy = i_PercentageRemainingEnergy;
            this.m_Wheels = i_Wheels;
        }

        public string LicenseNumber
        {
            get { return m_LicenseNumber; }
        }

            
    }

}
