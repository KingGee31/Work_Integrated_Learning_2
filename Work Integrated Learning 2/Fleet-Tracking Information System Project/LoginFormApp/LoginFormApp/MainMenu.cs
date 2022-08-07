using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void logOutButtonMainMenuForm_Click(object sender, EventArgs e)
        {
            //Navigating the User To The Log In Form when They Log Out Of the Main Menu Form
            Form1 formObject = new Form1();
            this.Hide();
            this.Close();
            formObject.Show();
           
        }

        private void exitButtonMainMenuForm_Click(object sender, EventArgs e)
        {
            //Closing the Appliaction When the user Clicks The Exit Button
            this.Close();
        }

        private void serviceManagerSectionButtonMainMenuForm_Click(object sender, EventArgs e)
        {
            //Loading the Service Manager Form When the User Clicks The Button 
            ServiceManagerForm managerForm = new ServiceManagerForm();
            this.Hide();
            this.Close();
            managerForm.Show();
            
        }

        private void vehicleInformationAdminstratorSectionButton_Click(object sender, EventArgs e)
        {
            //Loading the Vehicle Information Administration Form When The User Clicks This Button 
            VehicleInformationAdministratorForm administratorForm = new VehicleInformationAdministratorForm();

            this.Hide();
            this.Close();
            administratorForm.Show();
        }

        private void trip_usageManagerSectionButtonMainMenuForm_Click(object sender, EventArgs e)
        {
            //Loading The Trip/Usage Manager Section when The User clicks This Button 
            Trip_UsageManagerForm usageManagerForm = new Trip_UsageManagerForm();

            this.Hide();
            this.Close();
            usageManagerForm.Show();
        }

        private void timesheetManagerSectionButtonMainMenuForm_Click(object sender, EventArgs e)
        {
            //Loading the TimeSheet Manager Section When The user Clicks This Button 
            TimeSheetManagerForm sheetManagerForm = new TimeSheetManagerForm();

            this.Hide();
            this.Close();
            sheetManagerForm.Show();
            


        }

        private void driverRegisterSectionButtonMainMenuForm_Click(object sender, EventArgs e)
        {
            //Loading the Driver section Form When the User Clicks This Button 
            DriverRegisterForm driverRegisterForm = new DriverRegisterForm();

            this.Hide();
            this.Close();
            driverRegisterForm.Show();
        }

        private void viewTransportTypesButtonMainMenu_Click(object sender, EventArgs e)
        {
            //Loading The View Transport Type section When The User Clicks the Button
            TransportTypeSectionForm typeSectionForm = new TransportTypeSectionForm();

            this.Hide();
            this.Close();
            typeSectionForm.Show();
        }

        private void officeManagerSectionButtonMainMenuForm_Click(object sender, EventArgs e)
        {
            //Loading the Login Form For The Office Manager , To Add Extra Security To The application
            OfficeManagerLoginForm managerLoginForm = new OfficeManagerLoginForm();

            this.Hide();
            this.Close();
            managerLoginForm.Show();
        }
    }
}
