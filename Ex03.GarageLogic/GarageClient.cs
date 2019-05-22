using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic.Vehicles;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic
{
    class GarageClient
    {
        private string m_Name;
        private string m_Phone;
        private Vehicle m_Vehicle;
        private eVehicleStatusInGarage m_VehicleStatus;

        public GarageClient(string i_Name, string i_Phone, Vehicle i_Vehicle)
        {
            this.m_Name = i_Name;
            this.m_Phone = i_Phone;
            this.m_Vehicle = i_Vehicle;
            this.m_VehicleStatus = eVehicleStatusInGarage.InRepair;
        }

        public eVehicleStatusInGarage VehicleStatus
        {
            get { return m_VehicleStatus; }
            set { m_VehicleStatus = value; }
        }

        public Vehicle Vehicle
        {
            get { return Vehicle; }
            set { Vehicle = value; }
        }

        public override string ToString()
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.AppendFormat("Owner name: {0}{1}", m_Name, Environment.NewLine);
            strBuild.Append(m_Vehicle.ToString());

            return strBuild.ToString();
        }

    }
}
