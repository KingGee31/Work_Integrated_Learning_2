using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystemClassLibrary
{
    class TimeSheetManagerClass
    {
        //Declaring variables to hold values for the TimeSheetManagerClass
        private int driverId;
        private int numberOfHoursDrivenByDriver;
        private int numberOfHoursWorkedByMechanic;
        private string dateDay;

        //declaring a default constructor for the class 
        public TimeSheetManagerClass()
        {

        }

        //Declaring The Properties to set and get values from other classes 
        public int DriverId
        {
            get
            {
                return driverId;
            }
            set
            {
                driverId = value;
            }
        }
        public int NumberOfHoursDrivenByDriver
        {
            get
            {
                return numberOfHoursDrivenByDriver;
            }
            set
            {
                numberOfHoursDrivenByDriver = value;
            }
        }
        public int NumberOfHoursWorkedByMechanic
        {
            get
            {
                return numberOfHoursWorkedByMechanic;
            }
            set
            {
                numberOfHoursWorkedByMechanic = value;
            }
        }
        public string DateDay
        {
            get
            {
                return dateDay;
            }
            set
            {
                dateDay = value;
            }
        }
    }
}
