using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic.VehicleParts
{
    public abstract class Engine
    {
        protected float m_RemainderEnergy;
        protected float m_Capacity;

        public Engine(float i_RemainderEnergy, float i_Capacity)
        {
            m_RemainderEnergy = i_RemainderEnergy;
            m_Capacity = i_Capacity;
        }
    }


}
