using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic.Enums;
using Ex03.GarageLogic.VehicleParts;

namespace Ex03.GarageLogic.Vehicles
{
    public class Car : Vehicle
    {
        private readonly eCarColor m_Color;
        private readonly eNumberOfDoorsInCar m_NumOfDoord;
        private readonly Engine m_Engine;

        public Car(string i_ModelName, string i_LicenseNumber, float i_PercentageRemainingEnergy, Wheel[] i_Wheels, eCarColor i_CarColor,
                    eNumberOfDoorsInCar i_NumberOfDoorsInCar, Engine i_Engine)
                    : base(i_ModelName, i_LicenseNumber, i_PercentageRemainingEnergy, i_Wheels)
        {
            m_Color = i_CarColor;
            m_NumOfDoord = i_NumberOfDoorsInCar;
            m_Engine = i_Engine;
        }
    }
}