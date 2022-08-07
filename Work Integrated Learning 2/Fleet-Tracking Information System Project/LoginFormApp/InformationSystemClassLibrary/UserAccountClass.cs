using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystemClassLibrary
{
    class UserAccountClass
    {
        //Declaring the varibales to hold values for the UserAccountClass
        private int userNo;
        private string password;
        private string emailAddress;
        private string userName;
        
        //Declaring a default constructor 
        public UserAccountClass()
        {

        }

        //Declaring the Properties to set and get varibale values 
        public int UserNo
        {
            get
            {
                return userNo;
            }
            set
            {
                userNo = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }

        }
        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }
            set
            {
                emailAddress = value;
            }
        }
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }
    }
}
