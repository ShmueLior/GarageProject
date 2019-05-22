using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic.VehicleParts
{
    class ElectricEngine : Engine
    {
        public ElectricEngine(float i_RemainderEnergy, float i_Capacity) : base(i_RemainderEnergy, i_Capacity) {}

        public void FillEnergy(float i_AmountToFill)
        {
            //  execption is needed
            m_RemainderEnergy += i_AmountToFill;
        }

        public override string ToString()
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.AppendFormat("Battery status: {0} minutes", m_RemainderEnergy);
            return strBuild.ToString();
        }
    }
}
