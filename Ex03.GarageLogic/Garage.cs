using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic.Enums;
using Ex03.GarageLogic.Vehicles;
using Ex03.GarageLogic;
namespace Ex03.GarageLogic
{
    public class Garage
    {
        private Dictionary<string, GarageClient> m_Clients;
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

        public List <string> GetAllLicenseNumbers()
        {
            return null; // לבדוק מה הדרך הטובה ביותר להחזיר רשימה של מספרי רישוי
        }

        public void ChangeStateOfVehicle (string i_LicenseNumber, eVehicleStatusInGarage i_NewStatus)
        {
           // Client vehicle = m_Clients.TryGetValue(i_LicenseNumber);
        }

        public void InflateWheelsOfWehicleToMax (string i_LicenseNumber)
        {
 
        }

        public void FuelVehicle (string i_LicenseNumber, eFuelType i_Fuel, float i_AmountToFill)
        {
 
        }

        public void ChargeVehicle(string i_LicenseNumber, float i_AmountToFill)
        {

        }

     /*   public string GetVehicleDetails(string i_LicenseNumber)
        {
            
        }
     */
    }
}
