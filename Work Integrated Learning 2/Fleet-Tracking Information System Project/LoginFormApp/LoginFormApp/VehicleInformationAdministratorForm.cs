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
    public partial class VehicleInformationAdministratorForm : Form
    {
        public VehicleInformationAdministratorForm()
        {
            InitializeComponent();
        }

        //Declaring A Stream Writer
        private StreamWriter fil;
        private StreamReader inFile;
        string[] userInformation = new string[9];

        //Defining the Attributes for Database Connection
        string ConStr;
        SqlConnection Con;
        SqlCommand Cmd;

        private void clickHereButtonVehicleInformationAdministrationForm_Click(object sender, EventArgs e)
        {
            //Loading the Main Menu Form when the user clicks this button 
            MainMenu main = new MainMenu();

            this.Close();
            main.Show();
        }

        private void toLogOutVehicleInformationAdministrationForm_Click(object sender, EventArgs e)
        {
            //Loading the Login Form When the User clicks The Login Button 
            Form1 form1Object = new Form1();
            this.Hide();
            this.Close();
            form1Object.Show();
          
        }

        private void exit_ButtonVehicleInformationAdministrationForm_Click(object sender, EventArgs e)
        {
            //Closing the form when the user clicks the exit button 
            this.Close();
        }

        private void confirmButtonVehicleInformationAdministatorForm_Click(object sender, EventArgs e)
        {
            //Using Message Box to check if the User is sure with his data 
            var result = MessageBox.Show("Are You Sure With The Values You Want To Enter","Data Validation Message",MessageBoxButtons.YesNo);


            if (result == DialogResult.No)
            {
                //Clearing The Textboxes when the user Clicks The Clear Button
                vehicleNoeTextboxVehicleInfomartionAdministratorForm.Clear();
                registrationNoTextboxVehicleInfomartionAdministratorForm.Clear();
                vehicleTypeTextboxVehicleInfomartionAdministratorForm.Clear();
                manufacturerTextboxVehicleInfomartionAdministratorForm.Clear();
                engineSizeTextboxVehicleInfomartionAdministratorForm.Clear();
                currentOdometerTextboxVehicleInfomartionAdministratorForm.Clear();
                nextInUseTextboxVehicleInfomartionAdministratorForm.Clear();

                //giving the user another chance to enter values
                vehicleNoeTextboxVehicleInfomartionAdministratorForm.Focus();
            }
            else if(result == DialogResult.Yes)
            {
                //Connecting to the database and saving the Data
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("Insert Into Vehicle_InformationTB(ID, RegistrationNo, VehicleType, Manufacture, EngineSize, CurrentOdometerReading, NextServiceOdometerReading) Values('" + vehicleNoeTextboxVehicleInfomartionAdministratorForm.Text + "','" + registrationNoTextboxVehicleInfomartionAdministratorForm.Text + "','" + vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text + "','" + manufacturerTextboxVehicleInfomartionAdministratorForm.Text
                    + "','" + engineSizeTextboxVehicleInfomartionAdministratorForm.Text + "','" + currentOdometerTextboxVehicleInfomartionAdministratorForm.Text + "','" + nextInUseTextboxVehicleInfomartionAdministratorForm.Text + "')", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Success", "Record Saved");
            }

           
        }

        private void clearButtonVehicleInformationAdministatorForm_Click(object sender, EventArgs e)
        {
            //Clearing The Textboxes when the user Clicks The Clear Button
            vehicleNoeTextboxVehicleInfomartionAdministratorForm.Clear();
            registrationNoTextboxVehicleInfomartionAdministratorForm.Clear();
            vehicleTypeTextboxVehicleInfomartionAdministratorForm.Clear();
            manufacturerTextboxVehicleInfomartionAdministratorForm.Clear();
            engineSizeTextboxVehicleInfomartionAdministratorForm.Clear();
            currentOdometerTextboxVehicleInfomartionAdministratorForm.Clear();
            nextInUseTextboxVehicleInfomartionAdministratorForm.Clear();
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vehicleNoeTextboxVehicleInfomartionAdministratorForm_TextChanged(object sender, EventArgs e)
        {
            
          
           
        }

        private void generateReportButtonVehicleInformationAdministrationForm_Click(object sender, EventArgs e)
        {
           
            //Retrieving  Saved data from the database and diplaying it in the DatagridView of The Form

            ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
            Con = new SqlConnection(ConStr);
            Con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from Vehicle_InformationTB", Con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Vehicle_InformationTB");
            dataGridViewVehicleInformationAdministratorForm.DataSource = ds;
            dataGridViewVehicleInformationAdministratorForm.DataMember = "Vehicle_InformationTB";
            Con.Close();


        }

        private void printReportButtonVehicleInformationAdministrationForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Connect To A Printer","Printing The Report");
           
        }

        private void searchForDataTextBoxVehicleInformationForm_TextChanged(object sender, EventArgs e)
        {
            //Searching for the Database For the Required Data
            
            //Retrieving  Saved data from the database and diplaying it in the DatagridView of The Form

            ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
            Con = new SqlConnection(ConStr);
            Con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from Vehicle_InformationTB where ID like '"+ searchForDataTextBoxVehicleInformationForm.Text +"%'", Con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Vehicle_InformationTB");
            dataGridViewVehicleInformationAdministratorForm.DataSource = ds;
            dataGridViewVehicleInformationAdministratorForm.DataMember = "Vehicle_InformationTB";
            Con.Close();
        }

        private void updateButtonToUpdateDatabase_Click(object sender, EventArgs e)
        {
            //Updating Database Records 
            if (registrationNoTextboxVehicleInfomartionAdministratorForm.Text !=" " && vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text !=" " && manufacturerTextboxVehicleInfomartionAdministratorForm.Text !="" && engineSizeTextboxVehicleInfomartionAdministratorForm.Text !="" && currentOdometerTextboxVehicleInfomartionAdministratorForm.Text !="" && nextInUseTextboxVehicleInfomartionAdministratorForm.Text !="")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set  RegistrationNo ='"+ registrationNoTextboxVehicleInfomartionAdministratorForm .Text+ "', VehicleType ='"+ vehicleTypeTextboxVehicleInfomartionAdministratorForm .Text+ "', Manufacture = '"+ manufacturerTextboxVehicleInfomartionAdministratorForm .Text+ "', EngineSize = '"+ engineSizeTextboxVehicleInfomartionAdministratorForm .Text+ "', CurrentOdometerReading = '"+ currentOdometerTextboxVehicleInfomartionAdministratorForm .Text+ "', NextServiceOdometerReading = '"+ nextInUseTextboxVehicleInfomartionAdministratorForm.Text+ "'  where ID = '"+ searchForDataTextBoxVehicleInformationForm .Text+ "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
           else if (vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text != " " && manufacturerTextboxVehicleInfomartionAdministratorForm.Text != "" && engineSizeTextboxVehicleInfomartionAdministratorForm.Text != "" && currentOdometerTextboxVehicleInfomartionAdministratorForm.Text != "" && nextInUseTextboxVehicleInfomartionAdministratorForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set  VehicleType ='" + vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text + "', Manufacture = '" + manufacturerTextboxVehicleInfomartionAdministratorForm.Text + "', EngineSize = '" + engineSizeTextboxVehicleInfomartionAdministratorForm.Text + "', CurrentOdometerReading = '" + currentOdometerTextboxVehicleInfomartionAdministratorForm.Text + "', NextServiceOdometerReading ='" + nextInUseTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
            else if (manufacturerTextboxVehicleInfomartionAdministratorForm.Text != "" && engineSizeTextboxVehicleInfomartionAdministratorForm.Text != "" && currentOdometerTextboxVehicleInfomartionAdministratorForm.Text != "" && nextInUseTextboxVehicleInfomartionAdministratorForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set Manufacture = '" + manufacturerTextboxVehicleInfomartionAdministratorForm.Text + "', EngineSize = '" + engineSizeTextboxVehicleInfomartionAdministratorForm.Text + "', CurrentOdometerReading = '" + currentOdometerTextboxVehicleInfomartionAdministratorForm.Text + "', NextServiceOdometerReading ='" + nextInUseTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
            else if ( engineSizeTextboxVehicleInfomartionAdministratorForm.Text != "" && currentOdometerTextboxVehicleInfomartionAdministratorForm.Text != "" && nextInUseTextboxVehicleInfomartionAdministratorForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set  EngineSize = '" + engineSizeTextboxVehicleInfomartionAdministratorForm.Text + "', CurrentOdometerReading = '" + currentOdometerTextboxVehicleInfomartionAdministratorForm.Text + "', NextServiceOdometerReading ='" + nextInUseTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }else if (currentOdometerTextboxVehicleInfomartionAdministratorForm.Text != "" && nextInUseTextboxVehicleInfomartionAdministratorForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set  CurrentOdometerReading = '" + currentOdometerTextboxVehicleInfomartionAdministratorForm.Text + "', NextServiceOdometerReading ='" + nextInUseTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
            else if (nextInUseTextboxVehicleInfomartionAdministratorForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set  NextServiceOdometerReading ='" + nextInUseTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
            else if (currentOdometerTextboxVehicleInfomartionAdministratorForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set  CurrentOdometerReading = '" + currentOdometerTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
            else if (engineSizeTextboxVehicleInfomartionAdministratorForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set  EngineSize = '" + engineSizeTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
            else if (manufacturerTextboxVehicleInfomartionAdministratorForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set  Manufacture = '" + manufacturerTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
            else if (vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text != " ")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set   VehicleType ='" + vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
            else if (registrationNoTextboxVehicleInfomartionAdministratorForm.Text != " ")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set RegistrationNo ='" + registrationNoTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
            else if (registrationNoTextboxVehicleInfomartionAdministratorForm.Text != " " && vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text != " " && manufacturerTextboxVehicleInfomartionAdministratorForm.Text != "" && engineSizeTextboxVehicleInfomartionAdministratorForm.Text != "" && currentOdometerTextboxVehicleInfomartionAdministratorForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set  RegistrationNo ='" + registrationNoTextboxVehicleInfomartionAdministratorForm.Text + "', VehicleType ='" + vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text + "', Manufacture = '" + manufacturerTextboxVehicleInfomartionAdministratorForm.Text + "', EngineSize = '" + engineSizeTextboxVehicleInfomartionAdministratorForm.Text + "', CurrentOdometerReading = '" + currentOdometerTextboxVehicleInfomartionAdministratorForm.Text + "' where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
            else if (registrationNoTextboxVehicleInfomartionAdministratorForm.Text != " " && vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text != " " && manufacturerTextboxVehicleInfomartionAdministratorForm.Text != "" && engineSizeTextboxVehicleInfomartionAdministratorForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set  RegistrationNo ='" + registrationNoTextboxVehicleInfomartionAdministratorForm.Text + "', VehicleType ='" + vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text + "', Manufacture = '" + manufacturerTextboxVehicleInfomartionAdministratorForm.Text + "', EngineSize = '" + engineSizeTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
            else if (registrationNoTextboxVehicleInfomartionAdministratorForm.Text != " " && vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text != " " && manufacturerTextboxVehicleInfomartionAdministratorForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set  RegistrationNo ='" + registrationNoTextboxVehicleInfomartionAdministratorForm.Text + "', VehicleType ='" + vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text + "', Manufacture = '" + manufacturerTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
            else if (registrationNoTextboxVehicleInfomartionAdministratorForm.Text != " " && vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text != " ")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set  RegistrationNo ='" + registrationNoTextboxVehicleInfomartionAdministratorForm.Text + "', VehicleType ='" + vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
            else if (vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text != " " && manufacturerTextboxVehicleInfomartionAdministratorForm.Text != "" && engineSizeTextboxVehicleInfomartionAdministratorForm.Text != "" && currentOdometerTextboxVehicleInfomartionAdministratorForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set VehicleType ='" + vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text + "', Manufacture = '" + manufacturerTextboxVehicleInfomartionAdministratorForm.Text + "', EngineSize = '" + engineSizeTextboxVehicleInfomartionAdministratorForm.Text + "', CurrentOdometerReading = '" + currentOdometerTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
            else if (vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text != " " && manufacturerTextboxVehicleInfomartionAdministratorForm.Text != "" && engineSizeTextboxVehicleInfomartionAdministratorForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set VehicleType ='" + vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text + "', Manufacture = '" + manufacturerTextboxVehicleInfomartionAdministratorForm.Text + "', EngineSize = '" + engineSizeTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
            else if (vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text != " " && manufacturerTextboxVehicleInfomartionAdministratorForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set VehicleType ='" + vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text + "', Manufacture = '" + manufacturerTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
            else if (manufacturerTextboxVehicleInfomartionAdministratorForm.Text != "" && engineSizeTextboxVehicleInfomartionAdministratorForm.Text != "" && currentOdometerTextboxVehicleInfomartionAdministratorForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set  Manufacture = '" + manufacturerTextboxVehicleInfomartionAdministratorForm.Text + "', EngineSize = '" + engineSizeTextboxVehicleInfomartionAdministratorForm.Text + "', CurrentOdometerReading = '" + currentOdometerTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
            else if (manufacturerTextboxVehicleInfomartionAdministratorForm.Text != "" && engineSizeTextboxVehicleInfomartionAdministratorForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set  Manufacture = '" + manufacturerTextboxVehicleInfomartionAdministratorForm.Text + "', EngineSize = '" + engineSizeTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
            else if (engineSizeTextboxVehicleInfomartionAdministratorForm.Text != "" && currentOdometerTextboxVehicleInfomartionAdministratorForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set  EngineSize = '" + engineSizeTextboxVehicleInfomartionAdministratorForm.Text + "', CurrentOdometerReading = '" + currentOdometerTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
            else if (vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text != " " && nextInUseTextboxVehicleInfomartionAdministratorForm.Text != " ")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set  VehicleType ='" + vehicleTypeTextboxVehicleInfomartionAdministratorForm.Text + "', NextServiceOdometerReading = '" + nextInUseTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
            else if (manufacturerTextboxVehicleInfomartionAdministratorForm.Text != "" && nextInUseTextboxVehicleInfomartionAdministratorForm.Text != " ")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set  Manufacture = '" + manufacturerTextboxVehicleInfomartionAdministratorForm.Text + "', NextServiceOdometerReading = '" + nextInUseTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
            else if (engineSizeTextboxVehicleInfomartionAdministratorForm.Text != "" && nextInUseTextboxVehicleInfomartionAdministratorForm.Text != " ")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update Vehicle_InformationTB set EngineSize = '" + engineSizeTextboxVehicleInfomartionAdministratorForm.Text + "', NextServiceOdometerReading = '" + nextInUseTextboxVehicleInfomartionAdministratorForm.Text + "'  where ID = '" + searchForDataTextBoxVehicleInformationForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Record Updated Successfuly");
            }
        }

        private void registrationNoTextboxVehicleInfomartionAdministratorForm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
