using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic.VehicleParts
{
    public abstract class Engine
    {
        private float m_RemainderEnergy;
        private float m_Capacity;

        public Engine(float i_RemainderEnergy, float i_Capacity)
        {
            m_RemainderEnergy = i_RemainderEnergy;
            m_Capacity = i_Capacity;
        }
    }


}
