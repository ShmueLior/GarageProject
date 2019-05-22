using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic.Enums;
using Ex03.GarageLogic.Vehicles;
using Ex03.GarageLogic.VehicleParts;

namespace Ex03.GarageLogic
{
    public class Garage
    {
        private Dictionary<string, GarageClient> m_Clients { get; }

        private VehiclesBulider m_VehiclesBulider;

        public Garage()
        {
            m_Clients = new Dictionary<string, GarageClient>();
            m_VehiclesBulider = new VehiclesBulider();
        }

        public void InsertNewVehicle(string i_Name, string i_PhoneNumber, Vehicle i_Vehicle)
        {
            GarageClient newClient = new GarageClient(i_Name, i_PhoneNumber, i_Vehicle);
            m_Clients.Add(i_Vehicle.LicenseNumber, newClient);
        }

        public VehiclesBulider VehiclesBulider
        {
            get { return m_VehiclesBulider; }
        }

        public bool DoesVehicleExistInGrage(string i_VehicleRegistrationPlates)
        {
            return m_Clients.ContainsKey(i_VehicleRegistrationPlates);
        }

        public List<string> GetAllLicenseNumbers()
        {
            List<string> licenseNumbers = new List<string>(m_Clients.Keys);

            return licenseNumbers; 
        }

        public void ChangeStatusOfVehicle (string i_LicenseNumber, eVehicleStatusInGarage i_NewStatus)
        {
            m_Clients[i_LicenseNumber].VehicleStatus = i_NewStatus;
        }

        public void InflateWheelsOfWehicleToMax (string i_LicenseNumber) 
        {
            GarageClient garageClient;
            bool isGargaeClientExist = m_Clients.TryGetValue(i_LicenseNumber, out garageClient);

            garageClient.Vehicle.fillAllWheelsToMax();

        }

        public void FuelVehicle (string i_LicenseNumber, eEnergyType i_FuelType, float i_AmountToFill) 
        {
            FuelEngine fuelEngine = m_Clients[i_LicenseNumber].Vehicle.GetEngine as FuelEngine;

            fuelEngine.FillEnergy(i_FuelType, i_AmountToFill);
        }

        public void ChargeVehicle(string i_LicenseNumber, float i_AmountToFill) 
        {
                ElectricEngine electricEngine = m_Clients[i_LicenseNumber].Vehicle.GetEngine as ElectricEngine;

                electricEngine.FillEnergy(i_AmountToFill);
            
        }

        public string GetVehicleDetails(string i_LicenseNumber)
        {
            return m_Clients[i_LicenseNumber].ToString();
        }
     
        public int GetNumberOfClients()
        {
            return m_Clients.Count;
        }

        public List<string> GetListOfGarageClientByInputType(eVehicleStatusInGarage i_eVehicleStatusInGarage)
        {
            List<string> licenseNumberListByInputType = new List<string>();

            foreach (KeyValuePair<string, GarageClient> entry in m_Clients)
            {
                if  (entry.Value.VehicleStatus == i_eVehicleStatusInGarage)
                    {
                      licenseNumberListByInputType.Add(entry.Key);
                    }
            }

            return licenseNumberListByInputType;
            
        }
    }
}
