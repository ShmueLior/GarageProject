using System;
using System.Collections.Generic;
using System.Text;

using Ex03.GarageLogic.Enums;
using Ex03.GarageLogic.Vehicles;
using Ex03.GarageLogic.VehicleParts;

namespace Ex03.GarageLogic
{
    public class VehiclesBulider
    {
        //  private List<eVehicleType> m_VehiclesType;

        /// ------------------car Const Details-----------------------
        private const float k_FuelEngineCapacityForCar = 55;
        private const float k_ElectricitEngineCapacityForCar =  1.8f;
        private const int k_NumOfWheelsInCar = 4;
        private const int k_MaxAirPressureInCar = 31;

        /// ------------------MotorCycle Const Details-----------------------
        private const float k_FuelEngineCapacityForMotorCycle = 8;
        private const float k_ElectricitEngineCapacityForMotorCycle = 1.4f;
        private const int k_NumOfWheelsInMotorCycle = 2;
        private const int k_MaxAirPressureInMotorCycle = 8;

        /// ------------------Truck Const Details-----------------------
        private const float k_EngineCapacityForTruck = 110;
        private const int k_NumOfWheelsInTruck = 12;
        private const int k_MaxAirPressureInTruck = 26;

        /// ------------------------builder method for each Vehicle---------------

        /// ----------------- fuel motorcycle---------------------------

        public Vehicle BuildFuelMotorCycle(string i_ModelName, string i_LicenseNumber, float i_PercentageRemainingEnergy, string i_ManufacturerName,
                                    float i_CurrentAirPressure, eMotorcycleLicenseType m_LicenseType, int m_EngineCapacity)
        {
            Engine fuelEngineForMotorCycle = createFuelEngineForMotorCycle(i_PercentageRemainingEnergy);
            Wheel[] motorCycleWheels = createWheelsForVehicle(i_ManufacturerName, i_CurrentAirPressure, k_NumOfWheelsInMotorCycle);

            Vehicle newFuelMotorCycle = new Motorcycle(i_ModelName, i_LicenseNumber, i_PercentageRemainingEnergy, motorCycleWheels, m_LicenseType,
                                 m_EngineCapacity, fuelEngineForMotorCycle);

            return newFuelMotorCycle;
        }

        /// ----------------- Electric motorcycle-----------------------
        public Vehicle BuildElectricMotorCycle(string i_ModelName, string i_LicenseNumber, float i_PercentageRemainingEnergy, string i_ManufacturerName,
                            float i_CurrentAirPressure, eMotorcycleLicenseType m_LicenseType, int m_EngineCapacity)
        {
            Engine electricEngineForMotorCycle = createElectricitEngineForMotorCycle(i_PercentageRemainingEnergy);
            Wheel[] motorCycleWheels = createWheelsForVehicle(i_ManufacturerName, i_CurrentAirPressure, k_NumOfWheelsInMotorCycle);

            Vehicle newElectricMotorCycle = new Motorcycle(i_ModelName, i_LicenseNumber, i_PercentageRemainingEnergy, motorCycleWheels, m_LicenseType,
                                 m_EngineCapacity, electricEngineForMotorCycle);

            return newElectricMotorCycle;
        }

        /// ----------------------fuel Car------------------------------

        public Vehicle BuildFuelCar(string i_ModelName, string i_LicenseNumber, float i_PercentageRemainingEnergy, string i_ManufacturerName,
                                float i_CurrentAirPressure, eCarColor i_CarColor, eNumberOfDoorsInCar i_NumberOfDoorsInCar)
        {
            Engine fuelEngineForCar = createFuelEngineForCar(i_PercentageRemainingEnergy);
            Wheel[] CarWheels = createWheelsForVehicle(i_ManufacturerName, i_CurrentAirPressure, k_NumOfWheelsInCar);

            Vehicle newFuelCar = new Car(i_ModelName, i_LicenseNumber, i_PercentageRemainingEnergy, CarWheels, i_CarColor,
                                 i_NumberOfDoorsInCar, fuelEngineForCar);

            return newFuelCar;
        }


        /// ----------------- electrcit car---------------------------

        public Vehicle BuildElectricCar(string i_ModelName, string i_LicenseNumber, float i_PercentageRemainingEnergy, string i_ManufacturerName,
                                            float i_CurrentAirPressure, eCarColor i_CarColor, eNumberOfDoorsInCar i_NumberOfDoorsInCar)
        {
            Engine electricitEngineForCar = createElectricitEngineForCar(i_PercentageRemainingEnergy);
            Wheel[] CarWheels = createWheelsForVehicle(i_ManufacturerName, i_CurrentAirPressure, k_NumOfWheelsInCar);

            Vehicle newElectricCar = new Car(i_ModelName, i_LicenseNumber, i_PercentageRemainingEnergy, CarWheels, i_CarColor,
                                 i_NumberOfDoorsInCar, electricitEngineForCar);

            return newElectricCar;
        }


        /// ----------------- Truck---------------------------
        public Vehicle BuildTruck(string i_ModelName, string i_LicenseNumber, float i_PercentageRemainingEnergy, string i_ManufacturerName,
                                    float i_CurrentAirPressure, bool m_ContainRiskyMaterial, float m_TruckCapacity)
        {
            Engine fuelEngineForTruck = createEngineForTruck(i_PercentageRemainingEnergy);
            Wheel[] truckWheels = createWheelsForVehicle(i_ManufacturerName, i_CurrentAirPressure, k_NumOfWheelsInTruck);

            Vehicle newTruck = new Truck(i_ModelName, i_LicenseNumber, i_PercentageRemainingEnergy, truckWheels,
                                          m_ContainRiskyMaterial, k_EngineCapacityForTruck, fuelEngineForTruck);

            return newTruck;
        }





        /// ------------------------Builder method for Special components
        /// 
        /// ------------------------Wheels for each Vehicle-----------------------
        
        private Wheel[] createWheelsForVehicle(string i_ManufacturerName, float i_CurrentAirPressure, int i_NumOfWheels)
        {
            Wheel[] carWheels = new Wheel[i_NumOfWheels];

            for (int i = 0; i < i_NumOfWheels; i++)
            {
                carWheels[i] = new Wheel(i_ManufacturerName, i_CurrentAirPressure, k_MaxAirPressureInCar);
            }
            return carWheels;
        }

        /// ------------------------Electric engine for MotorCycle------------------
        
        private Engine createElectricitEngineForMotorCycle(float i_PercentageRemainingEnergy)
        {
            float remainingEnergy = k_ElectricitEngineCapacityForCar * i_PercentageRemainingEnergy;
            return new ElectricEngine(remainingEnergy, k_ElectricitEngineCapacityForCar);
        }
        /// ------------------------Fuel engine for MotorCycle----------------------
        
        private Engine createFuelEngineForMotorCycle(float i_PercentageRemainingEnergy)
        {
            float remainingEnergy = k_FuelEngineCapacityForMotorCycle * i_PercentageRemainingEnergy;
            return new FuelEngine(remainingEnergy, k_FuelEngineCapacityForMotorCycle, eFuelType.Octan95);
        }

        /// ------------------------Electric engine for car------------------------
        
        private Engine createElectricitEngineForCar(float i_PercentageRemainingEnergy)
        {
            float remainingEnergy = k_ElectricitEngineCapacityForCar * i_PercentageRemainingEnergy;
            return new ElectricEngine(remainingEnergy, k_ElectricitEngineCapacityForCar);
        }

        /// ------------------------Fuel engine for car---------------------------
        
        private Engine createFuelEngineForCar(float i_PercentageRemainingEnergy)
        {
            float remainingEnergy = k_FuelEngineCapacityForCar * i_PercentageRemainingEnergy;
            return new FuelEngine(remainingEnergy, k_FuelEngineCapacityForCar, eFuelType.Octan96);
        }

        /// ------------------------engine for truck---------------------------
        
        private Engine createEngineForTruck(float i_PercentageRemainingEnergy)
        {
            float remainingEnergy = k_EngineCapacityForTruck * i_PercentageRemainingEnergy;
            return new FuelEngine(remainingEnergy, k_EngineCapacityForTruck, eFuelType.Soler);
        }


    }
}
