using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic.Vehicles;

namespace Ex03.GarageLogic
{
    class GarageClient
    {
        private string m_Name;
        private string m_Phone;
        private Vehicle m_Vehicle;

        public GarageClient(string i_Name, string i_Phone, Vehicle i_Vehicle)
        {
            this.m_Name = i_Name;
            this.m_Phone = i_Phone;
            this.m_Vehicle = i_Vehicle;
        }
    }
}
