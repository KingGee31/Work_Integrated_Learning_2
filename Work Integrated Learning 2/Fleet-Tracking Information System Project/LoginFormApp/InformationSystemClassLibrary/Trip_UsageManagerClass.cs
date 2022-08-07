using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystemClassLibrary
{
    class Trip_UsageManagerClass
    {
        //Declaring variables to hold values 
        private int tripId;
        private string tripDestination;
        private int numberOfKilometersToTravel;
        private int numberOfKilometersTravelled;

        //Declaring a default constructor 
        public Trip_UsageManagerClass()
        {

        }

        //Declaring Properties to set and get variable values 
        public int TripId
        {
            get
            {
                return tripId;
            }
            set
            {
                tripId = value;
            }
        }
        public string TripDestination
        {
            get
            {
                return tripDestination;
            }
            set
            {
                tripDestination = value;
            }
        }
        public int NumberOfKilometersToTravel
        {
            get
            {
                return numberOfKilometersToTravel;
            }
            set
            {
                numberOfKilometersToTravel = value;
            }
        }
        public int NumberOfKilometersTravelled
        {
            get
            {
                return numberOfKilometersTravelled;
            }
            set
            {
                numberOfKilometersTravelled = value;
            }
        }
    }
}
