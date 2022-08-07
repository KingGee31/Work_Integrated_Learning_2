using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystemClassLibrary
{
    class Vehicle_InformationClass
    {
        //Declaring varibale to hold values 
        private int id;
        private string registrationNo;
        private string vehicleType;
        private string manufacture;
        private string engineSize;
        private int currentOdometerReading;
        private int nextServiceOdometerReading;

    //Declaring a default constructor for the class
    public Vehicle_InformationClass()
        {

        }

        //declaring properties that will set and get values for variables 
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string RegistrationNo
        {
            get
            {
                return registrationNo;
            }
            set
            {
                registrationNo = value;
            }
        }
        public string VehicleType
        {
            get
            {
                return vehicleType;
            }
            set
            {
                vehicleType = value;
            }
        }
        public string Manufacture
        {
            get
            {
                return manufacture;
            }
            set
            {
                manufacture = value;
            }
        }
        public string EngineSize
        {
            get
            {
                return engineSize;
            }
            set
            {
                engineSize = value;
            }
        }
        public int CurrentOdometerReading
        {
            get
            {
                return currentOdometerReading;
            }
            set
            {
                currentOdometerReading = value;
            }
        }
        public int NextServiceOdometerReading
        {
            get
            {
                return nextServiceOdometerReading;
            }
            set
            {
                nextServiceOdometerReading = value;
            }
        }
    }
}
