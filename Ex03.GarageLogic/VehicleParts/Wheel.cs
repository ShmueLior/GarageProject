using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic.VehicleParts
{
    public class Wheel
    {
        private readonly string r_ManufacturerName;
        private float m_CurrentAirPressure;
        private readonly float r_MaxAirPressure;

        public Wheel(string i_ManufacturerName, float i_CurrentAirPressure, float i_MaxAirPressure)
        {
            r_ManufacturerName = i_ManufacturerName;
            m_CurrentAirPressure = i_CurrentAirPressure;
            r_MaxAirPressure = i_MaxAirPressure;
        }

        public void FillWheelToMax()
        {
            m_CurrentAirPressure = r_MaxAirPressure;
        }

        public override string ToString()
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.AppendFormat("Wheels manufacture name: {0}{1}", r_ManufacturerName, Environment.NewLine);
            strBuild.AppendFormat("Current air pressure in the wheels: {0}{1}", m_CurrentAirPressure, Environment.NewLine);
            return strBuild.ToString();
        }

    }


}
