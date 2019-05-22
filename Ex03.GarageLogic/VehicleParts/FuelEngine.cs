using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic.VehicleParts
{
    class FuelEngine : Engine
    {
       private eEnergyType m_FuelType;
      
       public FuelEngine (float i_RemainderEnergy, float i_Capacity,  eEnergyType i_FuelType) 
                          :base (i_RemainderEnergy, i_Capacity)
        {
            m_FuelType = i_FuelType;
        }

        public void FillEnergy(eEnergyType i_EnergyType, float i_AmountToFill)
        {
            //  execption is needed
            m_RemainderEnergy += i_AmountToFill;
        }

        public override string ToString()
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.AppendFormat("Fuel type: {0}{1}", m_FuelType, Environment.NewLine);
            strBuild.AppendFormat("Energy Remaining: {0} Liter{1}", m_RemainderEnergy, Environment.NewLine);
            return strBuild.ToString();
        }
    }
}
