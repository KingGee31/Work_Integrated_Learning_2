using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormApp
{
    public partial class Trip_UsageManagerForm : Form
    {
        public Trip_UsageManagerForm()
        {
            InitializeComponent();
        }
        //Declaring the StreamWriter 
        private StreamWriter fil;
        private StreamReader inFile;
        string[] userInformation = new string[9];

        //Defining the Attributes for Database Connection
        string ConStr;
        SqlConnection Con;
        SqlCommand Cmd;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clickHereButtonTrip_UsageManagerForm_Click(object sender, EventArgs e)
        {
            //Loading the Main Menu Form when the user clicks this button 
            MainMenu main = new MainMenu();

            this.Close();
            main.Show();
        }

        private void toLogOutTrip_UsageManagerForm_Click(object sender, EventArgs e)
        {
            //Loading the Login Form When the User clicks The Login Button 
            Form1 form1Object = new Form1();
            this.Hide();
            this.Close();
            form1Object.Show();
            
        }

        private void exit_ButtonTrip_UsageManagerForm_Click(object sender, EventArgs e)
        {
            //Closing the form when the user clicks the exit button 
            this.Close();
        }

        private void submitButtonTrip_UsageManagerForm_Click(object sender, EventArgs e)
        {

            //Using Message Box to check if the User is sure with his data 
            var result = MessageBox.Show("Are You Sure With The Values You Want To Enter", "Data Validation Message", MessageBoxButtons.YesNo);


            if (result == DialogResult.No)
            {
               // Clearing the Textfields When the User Clicks the Clear Button
            tripDestinationTextboxTrip_UsageManagerForm.Clear();
                noOfKilometersTextboxTrip_UsageManagerForm.Clear();
                departureTimeTextboxTrip_UsageManagerForm.Clear();
                fuelUsagePerTripComboBoxTrip_UsageManagerForm.ResetText();
                incidentsNameTextboxTrip_UsageManagerForm.Clear();
                noOfKmTravelledTextbox.Clear();

                tripDestinationTextboxTrip_UsageManagerForm.Focus();
            }
            else if (result == DialogResult.Yes)
            {
                

                //Connecting to the database and saving the Data
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("Insert Into Trip_UsageManagerTB(TripId, TripDestination, NumberOfKilometersToTravel, NumberOfKilometersTravelled) Values('" + TripIdTextBoxTrip_UsageManagerForm.Text + "','" + tripDestinationTextboxTrip_UsageManagerForm.Text + "','" + noOfKilometersTextboxTrip_UsageManagerForm.Text + "','" + noOfKmTravelledTextbox.Text + "')", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Success, Record Saved");
            }

            
        }

        private void ClearButtonTrip_UsageManagerForm_Click(object sender, EventArgs e)
        {
            //Clearing the Textfields When the User Clicks the Clear Button 
            tripDestinationTextboxTrip_UsageManagerForm.Clear();
                noOfKilometersTextboxTrip_UsageManagerForm.Clear();
            departureTimeTextboxTrip_UsageManagerForm.Clear();
            fuelUsagePerTripComboBoxTrip_UsageManagerForm.ResetText();
            incidentsNameTextboxTrip_UsageManagerForm.Clear();
            noOfKmTravelledTextbox.Clear();
        }

        private void generateReportButtonPlannedTripReportTrip_UsageManagerForm_Click(object sender, EventArgs e)
        {
            //Retrieving  Saved data from the database and diplaying it in the DatagridView of The Form

            ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
            Con = new SqlConnection(ConStr);
            Con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from Trip_UsageManagerTB", Con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Trip_UsageManagerTB");
            dataGridViewTrip_UsageManagerForm.DataSource = ds;
            dataGridViewTrip_UsageManagerForm.DataMember = "Trip_UsageManagerTB";
            Con.Close();


        }

        private void printReportButtonPlannedTripReportTrip_UsageManagerForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Connect To A Printer", "Printing The Report");
        }

       


        private void dataGridViewTrip_UsageManagerForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchForDataTextBoxVehicleInformationForm_TextChanged(object sender, EventArgs e)
        {
            //Searching for the Database For the Required Data

            //Retrieving  Saved data from the database and diplaying it in the DatagridView of The Form

            ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
            Con = new SqlConnection(ConStr);
            Con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from Trip_UsageManagerTB where TripId like '" + searchForDataTextBoxTrip_UsageMangerForm.Text + "%'", Con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Trip_UsageManagerTB");
            dataGridViewTrip_UsageManagerForm.DataSource = ds;
            dataGridViewTrip_UsageManagerForm.DataMember = "Trip_UsageManagerTB";
            Con.Close();
        }

        private void updateButtonTripManagerForm_Click(object sender, EventArgs e)
        {
            if (tripDestinationTextboxTrip_UsageManagerForm.Text !="")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Trip_UsageManagerTB set TripDestination ='" + tripDestinationTextboxTrip_UsageManagerForm.Text + "' where TripId = '" + searchForDataTextBoxTrip_UsageMangerForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
            }
            else if (noOfKilometersTextboxTrip_UsageManagerForm.Text !="")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Trip_UsageManagerTB set NumberOfKilometersToTravel ='" + noOfKilometersTextboxTrip_UsageManagerForm.Text + "' where TripId = '" + searchForDataTextBoxTrip_UsageMangerForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
            }
            else if (noOfKmTravelledTextbox.Text !="")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Trip_UsageManagerTB set NumberOfKilometersTravelled ='" + noOfKmTravelledTextbox.Text + "' where TripId = '" + searchForDataTextBoxTrip_UsageMangerForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
            }

            if (tripDestinationTextboxTrip_UsageManagerForm.Text != "" && noOfKilometersTextboxTrip_UsageManagerForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Trip_UsageManagerTB set TripDestination ='" + tripDestinationTextboxTrip_UsageManagerForm.Text + "',NumberOfKilometersToTravel ='" + noOfKilometersTextboxTrip_UsageManagerForm.Text + "' where TripId = '" + searchForDataTextBoxTrip_UsageMangerForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
            }
            else if (tripDestinationTextboxTrip_UsageManagerForm.Text != "" && noOfKmTravelledTextbox.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Trip_UsageManagerTB set TripDestination ='" + tripDestinationTextboxTrip_UsageManagerForm.Text + "',NumberOfKilometersTravelled ='" + noOfKmTravelledTextbox.Text + "' where TripId = '" + searchForDataTextBoxTrip_UsageMangerForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
            }
            else if (noOfKilometersTextboxTrip_UsageManagerForm.Text != "" && noOfKmTravelledTextbox.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Trip_UsageManagerTB set NumberOfKilometersToTravel ='" + noOfKilometersTextboxTrip_UsageManagerForm.Text + "',NumberOfKilometersTravelled ='" + noOfKmTravelledTextbox.Text + "' where TripId = '" + searchForDataTextBoxTrip_UsageMangerForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
            }

            if (tripDestinationTextboxTrip_UsageManagerForm.Text != "" && noOfKilometersTextboxTrip_UsageManagerForm.Text != "" && noOfKmTravelledTextbox.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Trip_UsageManagerTB set TripDestination ='" + tripDestinationTextboxTrip_UsageManagerForm.Text + "',NumberOfKilometersToTravel ='" + noOfKilometersTextboxTrip_UsageManagerForm.Text + "',NumberOfKilometersTravelled ='" + noOfKmTravelledTextbox.Text + "' where TripId = '" + searchForDataTextBoxTrip_UsageMangerForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
            }
            MessageBox.Show("Record Updated Successfuly");
        }
    }
}
