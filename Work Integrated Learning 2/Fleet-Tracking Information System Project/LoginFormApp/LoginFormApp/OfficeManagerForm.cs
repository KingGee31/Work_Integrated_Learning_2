using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormApp
{
    public partial class OfficeManagerForm : Form
    {
        //Defining the Attributes for Database Connection
        string ConStr;
        SqlConnection Con;
        SqlCommand Cmd;
        public OfficeManagerForm()
        {
            InitializeComponent();
        }

        private void vehicleInformationAdministratorReportButtonOfficeManagerForm_Click(object sender, EventArgs e)
        {
            //Loading the Vehicle Information Administration Form When The User Clicks This Button 
            VehicleInformationAdministratorForm administratorForm = new VehicleInformationAdministratorForm();

            this.Hide();
            this.Close();
            administratorForm.Show();
        }

        private void toLogOutOfficeManagerForm_Click(object sender, EventArgs e)
        {
            //Loading the Login Form When the User clicks The Login Button 
            Form1 form1Object = new Form1();
            this.Hide();
            this.Close();
            form1Object.Show();
           
        }

        private void exit_ButtonOfficeManagerForm_Click(object sender, EventArgs e)
        {
            //Closing the form when the user clicks the exit button 
            this.Close();
        }

        private void Trip_UsageManagerReportButtonOfficeMangerForm_Click(object sender, EventArgs e)
        {
            //Loading The Trip/Usage Manager Section when The User clicks This Button 
            Trip_UsageManagerForm usageManagerForm = new Trip_UsageManagerForm();

            this.Hide();
            this.Close();
            usageManagerForm.Show();
        }

        private void timeSheetReportButtonOfficeManagerForm_Click(object sender, EventArgs e)
        {
            //Loading the TimeSheet Manager Section When The user Clicks This Button 
            TimeSheetManagerForm sheetManagerForm = new TimeSheetManagerForm();

            this.Hide();
            this.Close();
            sheetManagerForm.Show();
           
        }

        private void serviceManagerReportButtonOfficeManagerForm_Click(object sender, EventArgs e)
        {
            //Loading the Service Manager Form When the User Clicks The Button 
            ServiceManagerForm managerForm = new ServiceManagerForm();
            this.Hide();
            this.Close();
            managerForm.Show();
          
        }

        private void generateReportButtonOfficeManagerForm_Click(object sender, EventArgs e)
        {
            //Displaying the Crystal Report By Inserting Every Table Data into the OfficeManagerTB
            /*
              //Connecting to the database and saving the Data from The Driver Table
              ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
              Con = new SqlConnection(ConStr);
              Con.Open();

              Cmd = new SqlCommand("INSERT INTO OfficeManagerTB(ID,  DriverFullNames,  DriverContactNo,  DriverAddress) SELECT ID, DriverFullNames, DriverContactNo, DriverAddress FROM DriverTB ", Con);
              Cmd.ExecuteNonQuery();
              Con.Close();

              //Connecting to the database and saving the Data from the Service Manager Table
              ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
              Con = new SqlConnection(ConStr);
              Con.Open();

              Cmd = new SqlCommand("INSERT INTO OfficeManagerTB(ID,  ServiceType,  AppointmentDateAndTime,  WorkToBeCompleted) SELECT VehicleNo, ServiceType, AppointmentDateAndTime, WorkToBeCompleted FROM ServiceManagerTB ", Con);
              Cmd.ExecuteNonQuery();
              Con.Close();

              //Connecting to the database and saving the Data from the TimeSheetManagerTB
              ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
              Con = new SqlConnection(ConStr);
              Con.Open();

              Cmd = new SqlCommand("INSERT INTO OfficeManagerTB(ID,  NumberOfHoursDrivenByDriver,  NumberOfHoursWorkedByMechanic,  DateDay) SELECT DriverID, NumberOfHoursDrivenByDriver, NumberOfHoursWorkedByMechanic, DateDay FROM TimeSheetManagerTB ", Con);
              Cmd.ExecuteNonQuery();
              Con.Close();

              //Connecting to the database and saving the Data from the Trip_UsageManagerTB
              ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
              Con = new SqlConnection(ConStr);
              Con.Open();

              Cmd = new SqlCommand("INSERT INTO OfficeManagerTB(ID,  TripDestination,  NumberOfKilometersToTravel,  NumberOfKilometersTravelled) SELECT TripId, TripDestination, NumberOfKilometersToTravel, NumberOfKilometersTravelled FROM Trip_UsageManagerTB ", Con);
              Cmd.ExecuteNonQuery();
              Con.Close();

              //Connecting to the database and saving the Data from the Vehicle_InformationTB
              ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
              Con = new SqlConnection(ConStr);
              Con.Open();

              Cmd = new SqlCommand("INSERT INTO OfficeManagerTB(ID,  RegistrationNo,  VehicleType,  Manufacture, EngineSize, CurrentOdometerReading, NextServiceOdometerReading) SELECT ID, RegistrationNo, VehicleType, Manufacture, EngineSize, CurrentOdometerReading, NextServiceOdometerReading FROM Vehicle_InformationTB ", Con);
              Cmd.ExecuteNonQuery();
              Con.Close();
              */

            

            MessageBox.Show("Values Entered Successfully");


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Connecting to the database and saving the Data from the Vehicle_InformationTB
            ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
            Con = new SqlConnection(ConStr);
            Con.Open();

            Cmd = new SqlCommand("SELECT DriverTB.ID, DriverTB.DriverFullNames, DriverTB.DriverContactNo, DriverTB.DriverAddress, Vehicle_InformationTB.VehicleType, Vehicle_InformationTB.Manufacture, Vehicle_InformationTB.EngineSize, Vehicle_InformationTB.CurrentOdometerReading, Vehicle_InformationTB.NextServiceOdometerReading," +
                "ServiceManagerTB.ServiceType, ServiceManagerTB.AppointmentDateAndTime, ServiceManagerTB.WorkToBeCompleted, Trip_UsageManagerTB.TripDestination, Trip_UsageManagerTB.NumberOfKilometersToTravel, Trip_UsageManagerTB.NumberOfKilometersTravelled, TimeSheetManagerTB.NumberOfHoursDrivenByDriver,TimeSheetManagerTB.NumberOfHoursWorkedByMechanic," +
                "TimeSheetManagerTB.DateDay FROM DriverTB, Vehicle_InformationTB,ServiceManagerTB,Trip_UsageManagerTB,TimeSheetManagerTB WHERE DriverTB.ID = Vehicle_InformationTB.ID AND DriverTB.ID = ServiceManagerTB.VehicleNo AND DriverTB.ID = Trip_UsageManagerTB.TripId AND  DriverTB.ID = TimeSheetManagerTB.DriverID;", Con);
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridViewOfficeManagerForm.DataSource = ds;
            //dataGridViewOfficeManagerForm.DataMember = "OfficeManagerTB";
            Con.Close();

        }
    }
}
