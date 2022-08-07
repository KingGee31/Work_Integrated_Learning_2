using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystemClassLibrary
{
    class ServiceManagerClass
    {
        //Declaring Variables to hold values for the service Manager class 
        private int vehicleNo;
        private string serviceType;
        private string appointmentDateAndTime;
        private string workToBeCompleted;

        //Declaring a Default constructor for the class ServiceManagerClass
        public ServiceManagerClass()
        {

        }

        //Declaring Properties to Hold set and get varibale values from other classes 
        public int VehicleNo
        {
            get
            {
                return vehicleNo;
            }
            set
            {
                vehicleNo = value;
            }
        }
        public string ServiceType
        {
            get
            {
                return serviceType;
            }
            set
            {
                serviceType = value;
            }
        }
        public string AppointmentDateAndTime
        {
            get
            {
                return appointmentDateAndTime;
            }
            set
            {
                appointmentDateAndTime = value;
            }
        }
        public string WorkToBeCompleted
        {
            get
            {
                return workToBeCompleted;
            }
            set
            {
                workToBeCompleted = value;
            }
        }
    }
}
