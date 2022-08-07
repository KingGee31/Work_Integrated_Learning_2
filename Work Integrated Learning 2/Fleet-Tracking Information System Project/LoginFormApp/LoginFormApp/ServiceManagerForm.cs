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
using InformationSystemClassLibrary;

namespace LoginFormApp
{
    public partial class ServiceManagerForm : Form
    {
        public ServiceManagerForm()
        {
            InitializeComponent();
        }
        //Declaring a StreamWriter 
        private StreamWriter fil;
        private StreamReader inFile;
        string[] userInformation = new string[9];

        //Defining the Attributes for Database Connection
        string ConStr;
        SqlConnection Con;
        SqlCommand Cmd;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clickHereButtonServiceManagerForm_Click(object sender, EventArgs e)
        {
            //Loading the Main Menu Form when the user clicks this button 
            MainMenu main = new MainMenu();

            this.Close();
            main.Show();
        }

        private void toLogOutServiceManagerForm_Click(object sender, EventArgs e)
        {
            //Loading the Login Form When the User clicks The Login Button 
            Form1 form1Object = new Form1();
            this.Hide();
            this.Close();
            form1Object.Show();
            
        }

        private void exit_ButtonServiceManagerForm_Click(object sender, EventArgs e)
        {
            //Closing the form when the user clicks the exit button 
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaring An Object To Receive The User Input 
            
            //Using Message Box to check if the User is sure with his data 
            var result = MessageBox.Show("Are You Sure With The Values You Want To Enter", "Data Validation Message", MessageBoxButtons.YesNo);


            if (result == DialogResult.No)
            {
                //Clearing the Textboxes when the user clicks Clear
                vehicleNumberServiceManagerForm.Clear();
                serviceTypeComboBoxServiceManagerForm.ResetText();
                appointmentAndTimeServiceManagerForm.Clear();
                workToBeCompletedServiceManagerForm.Clear();
            }
            else if (result == DialogResult.Yes)
            {
                //Connecting to the database and saving the Data
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("Insert Into ServiceManagerTB(VehicleNo, ServiceType, AppointmentDateAndTime, WorkToBeCompleted) Values('" + vehicleNumberServiceManagerForm.Text + "','" + serviceTypeComboBoxServiceManagerForm.SelectedItem + "','" + appointmentAndTimeServiceManagerForm.Text + "','" + workToBeCompletedServiceManagerForm.Text + "')", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Success Record Saved");
            }
            
        }

        private void clearButtonServiceManagerForm_Click(object sender, EventArgs e)
        {
            //Clearing the Textboxes when the user clicks Clear
            vehicleNumberServiceManagerForm.Clear();
            serviceTypeComboBoxServiceManagerForm.ResetText();
            appointmentAndTimeServiceManagerForm.Clear();
            workToBeCompletedServiceManagerForm.Clear();
        }

        private void generateReportServiceJobSheetButtonServiceManagerForm_Click(object sender, EventArgs e)
        {
            //Retrieving  Saved data from the database and diplaying it in the DatagridView of The Form

            ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
            Con = new SqlConnection(ConStr);
            Con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from ServiceManagerTB", Con);
            DataSet ds = new DataSet();
            da.Fill(ds, "ServiceManagerTB");
            dataGridViewServiceManagerForm.DataSource = ds;
            dataGridViewServiceManagerForm.DataMember = "ServiceManagerTB";
            Con.Close();
        }

        private void generateServiceAppointmentListButtonServiceManagerForm_Click(object sender, EventArgs e)
        {
            //Writing The User Information to a Text file, To generate a report 
            //Writing the User information to a File
            try
            {
                fil = new StreamWriter(@"C:\UserInfomation\ServiceAppointmentListReport.txt");
                fil.WriteLine(appointmentAndTimeServiceManagerForm.Text + "\n" + vehicleNumberServiceManagerForm.Text + "\n" + workToBeCompletedServiceManagerForm.Text + "\n" + serviceTypeComboBoxServiceManagerForm.SelectedItem);
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("The Was An Error Writing To a Text File, " + exc, "Error Writing To A file Message");
            }
            catch (System.IO.IOException Exc)
            {
                MessageBox.Show("The File Writing Could Not be Successfully initiated, " + Exc, "Writing to File Error Found");
            }

            //Closing Writing To File When the User Navigates to the Login Form
            try
            {
                fil.Close();
            }
            catch
            {
                MessageBox.Show("After Writing to File, The File Could Not Close Properly", "Error Closing The File");
            }
        }

        private void generateVehicleServicesButtonServiceManagerForm_Click(object sender, EventArgs e)
        {
            //Writing The User Information to a Text file, To generate a report 
            //Writing the User information to a File
            try
            {
                fil = new StreamWriter(@"C:\UserInfomation\VehicleServiceReport.txt");
                fil.WriteLine(appointmentAndTimeServiceManagerForm.Text + "\n" + vehicleNumberServiceManagerForm.Text + "\n" + serviceTypeComboBoxServiceManagerForm.SelectedItem + "\n" + workToBeCompletedServiceManagerForm.Text);
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("The Was An Error Writing To a Text File, " + exc, "Error Writing To A file Message");
            }
            catch (System.IO.IOException Exc)
            {
                MessageBox.Show("The File Writing Could Not be Successfully initiated, " + Exc, "Writing to File Error Found");
            }

            //Closing Writing To File When the User Navigates to the Login Form
            try
            {
                fil.Close();
            }
            catch
            {
                MessageBox.Show("After Writing to File, The File Could Not Close Properly", "Error Closing The File");
            }
        }

        private void generateSpecificServiceButtonServiceManagerForm_Click(object sender, EventArgs e)
        {
            //Writing The User Information to a Text file, To generate a report 
            //Writing the User information to a File
            try
            {
                fil = new StreamWriter(@"C:\UserInfomation\SpecificServiceReport.txt");
                fil.WriteLine(appointmentAndTimeServiceManagerForm.Text + "\n" + vehicleNumberServiceManagerForm.Text + "\n" + workToBeCompletedServiceManagerForm.Text + "\n" + serviceTypeComboBoxServiceManagerForm.SelectedItem);
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("The Was An Error Writing To a Text File, " + exc, "Error Writing To A file Message");
            }
            catch (System.IO.IOException Exc)
            {
                MessageBox.Show("The File Writing Could Not be Successfully initiated, " + Exc, "Writing to File Error Found");
            }

            //Closing Writing To File When the User Navigates to the Login Form
            try
            {
                fil.Close();
            }
            catch
            {
                MessageBox.Show("After Writing to File, The File Could Not Close Properly", "Error Closing The File");
            }
        }

        private void printReportButtonServiceManagerForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Connect To A Printer", "Printing The Report");
        }

        private void printReportButtonServiceAppointmentServiceManagerForm_Click(object sender, EventArgs e)
        {
            //Reading the User Information From  A textfile And Printing It To A Message box
            //Using Stream Reader To Read Information From the User File And An If Statement To Enable The User to Login
            string inValue;
            int a = 0;
            if (File.Exists(@"C:\UserInfomation\ServiceAppointmentListReport.txt"))
            {
                try
                {
                    inFile = new StreamReader(@"C:\UserInfomation\ServiceAppointmentListReport.txt");
                    while ((inValue = inFile.ReadLine()) != null)
                    {
                        userInformation[a] = inValue;

                        a += 1;
                    }
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show("The Was An Error Reading From The File, File Could not be Located " + exc, "Error Reading From File");
                }
            }
            else
            {
                MessageBox.Show("File Could Not Be Found", "File Not Found Error");
            }
            string specificWork = workToBeCompletedServiceManagerForm.Text + "\n" + serviceTypeComboBoxServiceManagerForm.SelectedItem;

            string ServiceAppointmentListReport = "Appointment Times: " + appointmentAndTimeServiceManagerForm.Text + "\nVehicle Number: " + vehicleNumberServiceManagerForm.Text + "\nServices To Be Performed: " + serviceTypeComboBoxServiceManagerForm.SelectedItem + "\nProcedure Code And Description: " + specificWork;

            MessageBox.Show(ServiceAppointmentListReport, "Service Appointment List Report");

        }

        private void printReportButtonVehicleServicesServiceManagerForm_Click(object sender, EventArgs e)
        {
            //Reading the User Information From  A textfile And Printing It To A Message box
            //Using Stream Reader To Read Information From the User File And An If Statement To Enable The User to Login
            string inValue;
            int a = 0;
            if (File.Exists(@"C:\UserInfomation\VehicleServiceReport.txt"))
            {
                try
                {
                    inFile = new StreamReader(@"C:\UserInfomation\VehicleServiceReport.txt");
                    while ((inValue = inFile.ReadLine()) != null)
                    {
                        userInformation[a] = inValue;

                        a += 1;
                    }
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show("The Was An Error Reading From The File, File Could not be Located " + exc, "Error Reading From File");
                }
            }
            else
            {
                MessageBox.Show("File Could Not Be Found", "File Not Found Error");
            }
            string TotalCosts ="30000";

            string VehicleServiceReport = "Appointment Times: " + appointmentAndTimeServiceManagerForm.Text + "\nVehicle Number: " + vehicleNumberServiceManagerForm.Text + "\nServices To Be Performed: " + serviceTypeComboBoxServiceManagerForm.SelectedItem + "\nCosts Included: "+ TotalCosts;

            MessageBox.Show(VehicleServiceReport, "Vehicle Service Report");
        }

        private void printReportButtonSpecificServiceReportServiceManagerForm_Click(object sender, EventArgs e)
        {
            //Reading the User Information From  A textfile And Printing It To A Message box
            //Using Stream Reader To Read Information From the User File And An If Statement To Enable The User to Login
            string inValue;
            int a = 0;
            if (File.Exists(@"C:\UserInfomation\SpecificServiceReport.txt"))
            {
                try
                {
                    inFile = new StreamReader(@"C:\UserInfomation\SpecificServiceReport.txt");
                    while ((inValue = inFile.ReadLine()) != null)
                    {
                        userInformation[a] = inValue;

                        a += 1;
                    }
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show("The Was An Error Reading From The File, File Could not be Located " + exc, "Error Reading From File");
                }
            }
            else
            {
                MessageBox.Show("File Could Not Be Found", "File Not Found Error");
            }
            string serviceStatus ="Completed";

            string SpecificServiceReport = "VehicleNo: " + vehicleNumberServiceManagerForm.Text + "\nServiceType: " + serviceTypeComboBoxServiceManagerForm.SelectedItem + "\nAppointment Date: " + appointmentAndTimeServiceManagerForm.Text + "\nWorkToBeCompleted: " + workToBeCompletedServiceManagerForm.Text + "\nService Status: " + serviceStatus;

            MessageBox.Show(SpecificServiceReport, "Specific Service Report");
        }

        private void searchForDataTextBoxTimeSheetMangerForm_TextChanged(object sender, EventArgs e)
        {

            //Searching for the Database For the Required Data

            //Retrieving  Saved data from the database and diplaying it in the DatagridView of The Form

            ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
            Con = new SqlConnection(ConStr);
            Con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from ServiceManagerTB where VehicleNo like '" + searchForDataTextBoxTimeSheetMangerForm.Text + "%'", Con);
            DataSet ds = new DataSet();
            da.Fill(ds, "ServiceManagerTB");
            dataGridViewServiceManagerForm.DataSource = ds;
            dataGridViewServiceManagerForm.DataMember = "ServiceManagerTB";
            Con.Close();
        }

        private void updateButtonServiceManager_Click(object sender, EventArgs e)
        {
            //Updating Records For The Service Manager Class
            if (serviceTypeComboBoxServiceManagerForm.Text !="")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update ServiceManagerTB set ServiceType ='" + serviceTypeComboBoxServiceManagerForm.Text+"' where VehicleNo = '" + searchForDataTextBoxTimeSheetMangerForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                
            }
            else if (appointmentAndTimeServiceManagerForm.Text !="")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update ServiceManagerTB set AppointmentDateAndTime ='" + appointmentAndTimeServiceManagerForm.Text + "' where VehicleNo = '" + searchForDataTextBoxTimeSheetMangerForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                
            }
            else if (workToBeCompletedServiceManagerForm.Text !="")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update ServiceManagerTB set WorkToBeCompleted ='" + workToBeCompletedServiceManagerForm.Text + "' where VehicleNo = '" + searchForDataTextBoxTimeSheetMangerForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

              
            }

            if (serviceTypeComboBoxServiceManagerForm.Text != "" && appointmentAndTimeServiceManagerForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update ServiceManagerTB set ServiceType ='"+ serviceTypeComboBoxServiceManagerForm.Text + "',AppointmentDateAndTime ='" + appointmentAndTimeServiceManagerForm.Text + "' where VehicleNo = '" + searchForDataTextBoxTimeSheetMangerForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

              
            }
            else if (serviceTypeComboBoxServiceManagerForm.Text != "" && workToBeCompletedServiceManagerForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update ServiceManagerTB set ServiceType ='" + serviceTypeComboBoxServiceManagerForm.Text + "',WorkToBeCompleted ='" + workToBeCompletedServiceManagerForm.Text + "' where VehicleNo = '" + searchForDataTextBoxTimeSheetMangerForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

              
            }
            else if (appointmentAndTimeServiceManagerForm.Text != "" && workToBeCompletedServiceManagerForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update ServiceManagerTB set AppointmentDateAndTime ='" + appointmentAndTimeServiceManagerForm.Text + "',WorkToBeCompleted ='" + workToBeCompletedServiceManagerForm.Text + "' where VehicleNo = '" + searchForDataTextBoxTimeSheetMangerForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

               
            }

            if (serviceTypeComboBoxServiceManagerForm.Text != "" && appointmentAndTimeServiceManagerForm.Text != "" && workToBeCompletedServiceManagerForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update ServiceManagerTB set ServiceType ='" + serviceTypeComboBoxServiceManagerForm.Text + "',AppointmentDateAndTime ='" + appointmentAndTimeServiceManagerForm.Text + "',WorkToBeCompleted ='"+ workToBeCompletedServiceManagerForm .Text+ "' where VehicleNo = '" + searchForDataTextBoxTimeSheetMangerForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

               
            }
            MessageBox.Show("Record Updated Successfuly");
        }
    }
}
