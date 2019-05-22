using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic.VehicleParts;

namespace Ex03.GarageLogic.Vehicles
{
    public class Truck:Vehicle
    {
        private readonly bool m_ContainRiskyMaterial;
        private readonly float m_TruckCapacity;

        public Truck(string i_ModelName, string i_LicenseNumber, float i_PercentageRemainingEnergy, Wheel[] i_Wheels, bool i_ContainRiskyMaterial, float i_TruckCapacity, Engine i_Engine)
                   : base(i_ModelName, i_LicenseNumber, i_PercentageRemainingEnergy, i_Wheels, i_Engine)
        {
            m_ContainRiskyMaterial = i_ContainRiskyMaterial;
            m_TruckCapacity = i_TruckCapacity;
        }

        public override string ToString()
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.Append(base.ToString());
            strBuild.AppendFormat("Is the truck contain risky materials? {0}{1}", m_ContainRiskyMaterial.ToString(), Environment.NewLine);
            strBuild.AppendFormat("The truck container capacity is: {0}{1}", m_TruckCapacity, Environment.NewLine);

            return strBuild.ToString();
        }
    }
}
