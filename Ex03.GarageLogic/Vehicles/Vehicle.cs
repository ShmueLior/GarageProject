using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic.VehicleParts;

namespace Ex03.GarageLogic.Vehicles
{
    public class Vehicle
    {
        private readonly string r_ModelName;
        private readonly string r_LicenseNumber;
        private readonly float r_PercentageRemainingEnergy;
        private readonly Wheel[] r_Wheels;
        private readonly Engine r_Engine;

        protected Vehicle(string i_ModelName, string i_LicenseNumber, float i_PercentageRemainingEnergy, Wheel[] i_Wheels, Engine i_Engine)
        {
            this.r_ModelName = i_ModelName;
            this.r_LicenseNumber = i_LicenseNumber;
            this.r_PercentageRemainingEnergy = i_PercentageRemainingEnergy;
            this.r_Wheels = i_Wheels;
            this.r_Engine = i_Engine;
        }

        public string LicenseNumber
        {
            get { return r_LicenseNumber; }
        }

        
        public Engine GetEngine
        {
            get { return r_Engine; }
        }

        public Wheel [] Wheels
        {
            get { return Wheels; }
        }

        public void fillAllWheelsToMax()
        {
            foreach(Wheel wheel in r_Wheels)
            {
                wheel.FillWheelToMax();
            }
        }

        public void FillEnergy(float i_AmountToFill)
        {
            
        }

        public override string ToString()
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.AppendFormat("License number: {0}{1}", r_LicenseNumber, Environment.NewLine);
            strBuild.AppendFormat("Model name: {0}{1}", r_ModelName, Environment.NewLine);
            strBuild.AppendFormat("Remaining energy precentage: {0}%{1}", r_PercentageRemainingEnergy, Environment.NewLine);
            strBuild.Append(r_Engine.ToString());
            strBuild.Append(r_Wheels[0].ToString());

            return strBuild.ToString();
        }

    }

}
