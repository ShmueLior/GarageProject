using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic.VehicleParts
{
    class FuelEngine : Engine
    {
       private eFuelType m_FuelType;
      
       public FuelEngine (float i_RemainderEnergy, float i_Capacity,  eFuelType i_FuelType) 
                          :base (i_RemainderEnergy, i_Capacity)
        {
            m_FuelType = i_FuelType;
        }
    }
}
