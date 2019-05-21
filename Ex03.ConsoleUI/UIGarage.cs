using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic;
using Ex03.GarageLogic.Enums;

namespace Ex03.ConsoleUI
{
    class UIGarage
    {
        private Garage m_Garage;

        public UIGarage()
        {
            m_Garage = new Garage();
        }

        public void StartUI()
        {
            bool quit = false;
            int userInput;

            while(!quit)
            {
                printMenu();
                userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        insertNewVehicleToTheGarge();
                        break;
                    case 2:
                        printVehiclesLicenseNumbers();
                        break;
                    case 3:
                        changeVehicelStatus();
                        break;
                    case 4:
                        inflateMaxAirInWheels();
                        break;
                    case 5:
                        fuelVehicelsWithFuelTank();
                        break;
                    case 6:
                        chargeElectricVehicle();
                        break;
                    case 7:
                        printVehicleFullDetails();
                        break;
                    case 8:
                        clearScreen();
                        break;
                    case 9:
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("InValid Choice");
                        break;
                }
            }
        }

        private void printMenu()
        {
            Console.Write(
@"  __  __                  
 |  \/  | ___ _ __  _   _ 
 | |\/| |/ _ \ '_ \| | | |
 | |  | |  __/ | | | |_| |
 |_|  |_|\___|_| |_|\__,_|
___________________________

1. Add a vehicle to garage.
2. Display plate license of vehicles in the garage their status.
3. Change a vehicle status.
4. Inflate wheels of a vehicle.
5. Add Fuel to vehicle.
6. Charge electric vehicle.
7. Display details of a vehicle by a license number.
8. Clear Screen
9. Exit
");
        }

        private void insertNewVehicleToTheGarge()
        {
            string licenseNumber = null;
            Console.WriteLine("Enter license number:");
            licenseNumber = Console.ReadLine();
            if(m_Garage.DoesVehicleExistInGrage(licenseNumber))
            {
                Console.WriteLine("The vehicle is already at the garage. Updating it status to inrepair...");
                m_Garage.ChangeStateOfVehicle(licenseNumber, eVehicleStatusInGarage.InRepair);
            }
            else
            {
                string ownerName, ownerPhoneNumber;
                string modelName, manufacturerWheels;
                eVehicleType vehicleType;
                float remaningEnergy, currentWheelAirPressure;


                ownerName = getOwnerNameFromUser();

                ownerPhoneNumber = getPhoneNumberFromUser();

                vehicleType = getVehicleTypeFromUser();

                modelName = getModelNameFromUser();

                remaningEnergy = getReamningEnergyFromUser();

                manufacturerWheels = getManufactuerWheelsFromUser();

                switch (vehicleType)
                {
                    case eVehicleType.ElectricCar:
                        {
                            eCarColor carColor = getCarColorFromUser();
                            eNumberOfDoorsInCar numOfDoors = getNumOfDoorsInCarFromUser();
                            currentWheelAirPressure = getCurrentWheelAirPressureFromUser(31);
                            m_Garage.InsertNewVehicle(ownerName, ownerPhoneNumber, m_Garage.VehiclesBulider.BuildElectricCar(modelName, licenseNumber, remaningEnergy, manufacturerWheels, currentWheelAirPressure, carColor, numOfDoors));
                            break;
                        }
                    case eVehicleType.ElectricMotorcycle:
                        {
                            eMotorcycleLicenseType licenseType = getMotocycleLicenseTypeFromUser();
                            int engineCapacity = getMotoEngineCapacityFromUser();
                            currentWheelAirPressure = getCurrentWheelAirPressureFromUser(33);
                            m_Garage.InsertNewVehicle(ownerName, ownerPhoneNumber, m_Garage.VehiclesBulider.BuildElectricMotorCycle(modelName, licenseNumber, remaningEnergy, manufacturerWheels, currentWheelAirPressure, licenseType, engineCapacity));
                            break;
                        }
                    case eVehicleType.FualCar:
                        {
                            eCarColor carColor = getCarColorFromUser();
                            eNumberOfDoorsInCar numOfDoors = getNumOfDoorsInCarFromUser();
                            currentWheelAirPressure = getCurrentWheelAirPressureFromUser(31);
                            m_Garage.InsertNewVehicle(ownerName, ownerPhoneNumber, m_Garage.VehiclesBulider.BuildFuelCar(modelName, licenseNumber, remaningEnergy, manufacturerWheels, currentWheelAirPressure, carColor, numOfDoors));
                            break;
                        }
                    case eVehicleType.FuelMotorCycle:
                        {
                            eMotorcycleLicenseType licenseType = getMotocycleLicenseTypeFromUser();
                            int engineCapacity = getMotoEngineCapacityFromUser();
                            currentWheelAirPressure = getCurrentWheelAirPressureFromUser(33);
                            m_Garage.InsertNewVehicle(ownerName, ownerPhoneNumber, m_Garage.VehiclesBulider.BuildFuelMotorCycle(modelName, licenseNumber, remaningEnergy, manufacturerWheels, currentWheelAirPressure, licenseType, engineCapacity));
                            break;
                        }
                    case eVehicleType.Truck:
                        {
                            bool containRiskyMaterial = getFromUserIfTruckContainRiskyMaterial();
                            float truckCapacity = getTruckCapacityFromUser();
                            currentWheelAirPressure = getCurrentWheelAirPressureFromUser(26);
                            m_Garage.InsertNewVehicle(ownerName, ownerPhoneNumber, m_Garage.VehiclesBulider.BuildTruck(modelName, licenseNumber, remaningEnergy, manufacturerWheels, currentWheelAirPressure, containRiskyMaterial, truckCapacity));
                            break;
                        }
                }
            }
        }

        private eVehicleType getVehicleTypeFromUser()
        {
            int numberOfOptions = Enum.GetNames(typeof(eVehicleType)).Length;
            int userInput = -1;
            bool tryParse = false;
           
                while ((!tryParse) || (userInput > numberOfOptions) || (userInput < 1))
                {
                    Console.WriteLine("Choose a vehicle:");
                    foreach (eVehicleType vehicleType in Enum.GetValues(typeof(eVehicleType)))
                    {
                        Console.WriteLine("{0}. {1}", (int)vehicleType, vehicleType.ToString());
                    }

                    tryParse = int.TryParse(Console.ReadLine(), out userInput);
                }
            
            return (eVehicleType)userInput;
        }

        private void printVehiclesLicenseNumbers()
        {
            List<string> licenseNumbers = m_Garage.GetAllLicenseNumbers();
            int index = 1;
            foreach(string num in licenseNumbers)
            {
                Console.WriteLine("{0}){1}", index, num);
                index++;
            }
        }

        private void changeVehicelStatus()
        {
            string licenseNumber;
            Console.WriteLine("Enter license number:");
            licenseNumber = Console.ReadLine();
            Console.WriteLine("Choose an update status for vehicle number: {0}", licenseNumber);
            
        }

        private void inflateMaxAirInWheels()
        {

        }

        private void fuelVehicelsWithFuelTank()
        {

        }

        private void chargeElectricVehicle()
        {

        }

        private void printVehicleFullDetails()
        {

        }

        private void clearScreen()
        {
            Console.Clear();
        }

        private string getOwnerNameFromUser()
        {
            Console.WriteLine("Enter your name:");
            return Console.ReadLine();
        }

        private string getPhoneNumberFromUser()
        {
            bool validInput = false;
            string phoneNumber = null;
            while(!validInput)
            {
                Console.WriteLine("Enter your phone number:");
                phoneNumber = Console.ReadLine();
                validInput = isLegalPhoneNumber(phoneNumber);
                if(!validInput)
                {
                    Console.WriteLine("Wrong phone number! your number shoulde include at least 7 digits and only digits");
                }
            }
            return phoneNumber;
        }

        private bool isLegalPhoneNumber(string i_PhoneNumber)
        {
            bool res = true;
            for(int i = 0; i < i_PhoneNumber.Length; i++)
            {
                if(i_PhoneNumber[i] < '0' || i_PhoneNumber[i] > '9')
                {
                    res = false;
                }
            }
            res = res && i_PhoneNumber.Length >= 7;
            return res;
        }

        private string getModelNameFromUser()
        {
            Console.WriteLine("Enter your vehicle model:");
            return Console.ReadLine();
        }

        private float getReamningEnergyFromUser()
        {
            string userInput = null;
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("Enter the percent of energy left in your vehicle: (It's need to be between 0 - 100) ");
                userInput = Console.ReadLine();
                validInput = isLegalReamningEnergy(userInput);
                if(!validInput)
                {
                    Console.WriteLine("Worng choice");
                }
            }
            return float.Parse(userInput);
        }

        private bool isLegalReamningEnergy(string i_ReaminigEnergy)
        {
            float fNumber;
            float.TryParse(i_ReaminigEnergy,out fNumber);
            return fNumber >= 0f || fNumber <= 100f;
        }

        private string getManufactuerWheelsFromUser()
        {
            Console.WriteLine("Enter the manufactuer of yout wheels:");
            return Console.ReadLine();
        }

        private float getCurrentWheelAirPressureFromUser(int i_MaxPressure)
        {
            float currentAirPressure = i_MaxPressure;
            bool validInput = false;
            while(!validInput)
            {
                Console.WriteLine("Enter the current air pressuer of your wheels : (It's need to be between 0 to {0})", i_MaxPressure);
                validInput = float.TryParse(Console.ReadLine(), out currentAirPressure);
                if(!validInput || currentAirPressure < 0 || currentAirPressure > i_MaxPressure)
                {
                    Console.WriteLine("Wrong choice");
                    validInput = false;
                }
            }
            return currentAirPressure;
        }

        private eCarColor getCarColorFromUser()
        {
            int numberOfOptions = Enum.GetNames(typeof(eCarColor)).Length;
            int userInput = -1;
            bool tryParse = false;

            while ((!tryParse) || (userInput > numberOfOptions) || (userInput < 1))
            {
                Console.WriteLine("Choose your car color:");
                foreach (eCarColor carColor in Enum.GetValues(typeof(eCarColor)))
                {
                    Console.WriteLine("{0}. {1}", (int)carColor, carColor.ToString());
                }

                tryParse = int.TryParse(Console.ReadLine(), out userInput);
            }

            return (eCarColor)userInput;
        }

        private eNumberOfDoorsInCar getNumOfDoorsInCarFromUser()
        {
            int numberOfOptions = Enum.GetNames(typeof(eNumberOfDoorsInCar)).Length;
            int userInput = -1;
            bool tryParse = false;

            while ((!tryParse) || (userInput > numberOfOptions) || (userInput < 1))
            {
                Console.WriteLine("Choose the number of doors in your car:");
                foreach (eNumberOfDoorsInCar numOfDoors in Enum.GetValues(typeof(eNumberOfDoorsInCar)))
                {
                    Console.WriteLine("{0}. {1}", (int)numOfDoors, numOfDoors.ToString());
                }

                tryParse = int.TryParse(Console.ReadLine(), out userInput);
            }

            return (eNumberOfDoorsInCar)userInput;
        }

        private eMotorcycleLicenseType getMotocycleLicenseTypeFromUser()
        {
            int numberOfOptions = Enum.GetNames(typeof(eMotorcycleLicenseType)).Length;
            int userInput = -1;
            bool tryParse = false;

            while ((!tryParse) || (userInput > numberOfOptions) || (userInput < 1))
            {
                Console.WriteLine("Choose a license type:");
                foreach (eMotorcycleLicenseType motoLicenseType in Enum.GetValues(typeof(eMotorcycleLicenseType)))
                {
                    Console.WriteLine("{0}. {1}", (int)motoLicenseType, motoLicenseType.ToString());
                }

                tryParse = int.TryParse(Console.ReadLine(), out userInput);
            }

            return (eMotorcycleLicenseType)userInput;
        }

        private int getMotoEngineCapacityFromUser()
        {
            bool validInput = false;
            int volume = 0;
            while (!validInput)
            {
                Console.WriteLine("What is the engine volume of your motorcycle?");
                validInput = int.TryParse(Console.ReadLine(), out volume);
                if(!validInput)
                {
                    Console.WriteLine("Wrong choice");
                }
            }
            return volume;

        }

        private bool getFromUserIfTruckContainRiskyMaterial()
        {
            string userInput = null;
            bool validInput = false;
            bool res = false;
            while (!validInput)
            {
                Console.WriteLine("Is your truck contain risky materials? Press 1 if yes otherwise press 0");
                userInput = Console.ReadLine();
                if(userInput == "1")
                {
                    res = true;
                    validInput = true;
                }
                else if(userInput == "0")
                {
                    res = false;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Worng choice");
                }
            }
            return res;
        }

        private float getTruckCapacityFromUser()
        {
            bool validInput = false;
            float capacity = 0f;
            while (!validInput)
            {
                Console.WriteLine("Enter the capacity of your truck container:");
                validInput = float.TryParse(Console.ReadLine(), out capacity);
                if(!validInput)
                {
                    Console.WriteLine("Wrong choice");
                }
            }
            return capacity;        
        }
    }
}
