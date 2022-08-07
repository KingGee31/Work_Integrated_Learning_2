using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystemClassLibrary
{
    public class DriverClass
    {
        //Declaring relevant variables to hold the driver information 
        private int driverId;
        private string driverEmailAddress;
        private int driverContactNo;
        private string driverAddress;
        private string driverFullNames;

        //Creating a default constructor for the class 
        public DriverClass()
        {

        }
        //Creating properties for the Driver Class To Use the Varibales on Other Forms 
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
        public string DriverEmailAddress
        {
            get
            {
                return driverEmailAddress;
            }
            set
            {
                driverEmailAddress = value;
            }
        }
        public int DriverContactNo
        {
            get
            {
                return driverContactNo;
            }
            set
            {
                driverContactNo = value;
            }
        }
        public string DriverAddress
        {
            get
            {
                return driverAddress;
            }
            set
            {
                driverAddress = value;

            }
        }
        public string DriverFullNames
        {
            get
            {
                return driverFullNames;
            }
            set
            {
                driverFullNames = value;
            }
        }

    }
}
