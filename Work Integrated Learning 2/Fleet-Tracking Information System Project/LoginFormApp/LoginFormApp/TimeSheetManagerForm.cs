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
    public partial class TimeSheetManagerForm : Form
    {
        public TimeSheetManagerForm()
        {
            InitializeComponent();
        }
        //Declaring a stream Writer 
        private StreamWriter fil;
        private StreamReader inFile;

        string[] userInformation = new string[9];
        //Defining the Attributes for Database Connection
        string ConStr;
        SqlConnection Con;
        SqlCommand Cmd;

        private void clickHereButtonTimeSheetMangerForm_Click(object sender, EventArgs e)
        {
            //Loading the Main Menu Form when the user clicks this button 
            MainMenu main = new MainMenu();

            this.Close();
            main.Show();
        }

        private void toLogOutTimeSheetMangerForm_Click(object sender, EventArgs e)
        {
            //Loading the Login Form When the User clicks The Login Button 
            Form1 form1Object = new Form1();
            this.Hide();
            this.Close();
            form1Object.Show();
           
        }

        private void exit_ButtonTimeSheetMangerForm_Click(object sender, EventArgs e)
        {
            //Closing the form when the user clicks the exit button 
            this.Close();
        }

        private void numberOfDrivenHoursByDriverTextboxTimeSheetMangerForm_TextChanged(object sender, EventArgs e)
        {

        }

        private void proceedButtonTimeSheetManagerForm_Click(object sender, EventArgs e)
        {

            //Using Message Box to check if the User is sure with his data 
            var result = MessageBox.Show("Are You Sure With The Values You Want To Enter", "Data Validation Message", MessageBoxButtons.YesNo);


            if (result == DialogResult.No)
            {
                //Clearing the textboxes 
                numberOfDrivenHoursByDriverTextboxTimeSheetMangerForm.Clear();
                numberOfWorkedHoursByMechanicTextboxTimeSheetMangerForm.Clear();

                numberOfDrivenHoursByDriverTextboxTimeSheetMangerForm.Focus();
            }
            else if (result == DialogResult.Yes)
            {
                      

                //Connecting to the database and saving the Data
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("Insert Into TimeSheetManagerTB(DriverID, NumberOfHoursDrivenByDriver, NumberOfHoursWorkedByMechanic, DateDay) Values('" + userIdTextboxTimeSheetManagerForm.Text + "','" + numberOfDrivenHoursByDriverTextboxTimeSheetMangerForm.Text + "','" + numberOfWorkedHoursByMechanicTextboxTimeSheetMangerForm.Text + "','" + enterDateDayTextBoxTimeSheetManagerForm.Text
                    + "')", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
            }

           

            
        }

        private void clearButtonTimeSheetManagerForm_Click(object sender, EventArgs e)
        {
            //Clearing the textboxes 
            numberOfDrivenHoursByDriverTextboxTimeSheetMangerForm.Clear();
            numberOfWorkedHoursByMechanicTextboxTimeSheetMangerForm.Clear();
        }

        private void generateReportTimeSheetManagerForm_Click(object sender, EventArgs e)
        {

           
            //Retrieving  Saved data from the database and diplaying it in the DatagridView of The Form

            ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
            Con = new SqlConnection(ConStr);
            Con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from TimeSheetManagerTB", Con);
            DataSet ds = new DataSet();
            da.Fill(ds,"TimeSheetManagerTB");
            dataGridViewTimeSheetManagerForm.DataSource = ds;
            dataGridViewTimeSheetManagerForm.DataMember = "TimeSheetManagerTB";
            Con.Close();


        }

        private void printReportButtonTimeSheetManagerForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Connect To A Printer", "Printing The Report");
        }

        private void searchForDataTextBoxTimeSheetMangerForm_TextChanged(object sender, EventArgs e)
        {
            

            //Searching for the Database For the Required Data

            //Retrieving  Saved data from the database and diplaying it in the DatagridView of The Form

            ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
            Con = new SqlConnection(ConStr);
            Con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from TimeSheetManagerTB where DriverID like '" + searchForDataTextBoxTimeSheetMangerForm.Text + "%'", Con);
            DataSet ds = new DataSet();
            da.Fill(ds, "TimeSheetManagerTB");
            dataGridViewTimeSheetManagerForm.DataSource = ds;
            dataGridViewTimeSheetManagerForm.DataMember = "TimeSheetManagerTB";
            Con.Close();
        }

        private void updateButtonTimesheetManager_Click(object sender, EventArgs e)
        {
            
            if(numberOfDrivenHoursByDriverTextboxTimeSheetMangerForm.Text !="")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update TimeSheetManagerTB set NumberOfHoursDrivenByDriver ='" + numberOfDrivenHoursByDriverTextboxTimeSheetMangerForm.Text + "'  where DriverID = '" + searchForDataTextBoxTimeSheetMangerForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();


            }
            else if (numberOfWorkedHoursByMechanicTextboxTimeSheetMangerForm.Text !="")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update TimeSheetManagerTB set NumberOfHoursWorkedByMechanic ='" + numberOfWorkedHoursByMechanicTextboxTimeSheetMangerForm.Text + "'  where DriverID = '" + searchForDataTextBoxTimeSheetMangerForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
            }
            else if (enterDateDayTextBoxTimeSheetManagerForm.Text !="")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update TimeSheetManagerTB set DateDay ='" + enterDateDayTextBoxTimeSheetManagerForm.Text + "'  where DriverID = '" + searchForDataTextBoxTimeSheetMangerForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
            }

            if (numberOfDrivenHoursByDriverTextboxTimeSheetMangerForm.Text != "" && numberOfWorkedHoursByMechanicTextboxTimeSheetMangerForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update TimeSheetManagerTB set NumberOfHoursDrivenByDriver ='"+numberOfDrivenHoursByDriverTextboxTimeSheetMangerForm.Text+"',NumberOfHoursWorkedByMechanic ='"+numberOfWorkedHoursByMechanicTextboxTimeSheetMangerForm .Text+ "'  where DriverID = '" + searchForDataTextBoxTimeSheetMangerForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
            }
            else if (numberOfDrivenHoursByDriverTextboxTimeSheetMangerForm.Text != "" && enterDateDayTextBoxTimeSheetManagerForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update TimeSheetManagerTB set NumberOfHoursDrivenByDriver ='" + numberOfDrivenHoursByDriverTextboxTimeSheetMangerForm.Text + "',DateDay ='" + enterDateDayTextBoxTimeSheetManagerForm.Text + "'  where DriverID = '" + searchForDataTextBoxTimeSheetMangerForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
            }

            if (numberOfDrivenHoursByDriverTextboxTimeSheetMangerForm.Text != "" && numberOfWorkedHoursByMechanicTextboxTimeSheetMangerForm.Text != "" && enterDateDayTextBoxTimeSheetManagerForm.Text != "")
            {
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("update TimeSheetManagerTB set NumberOfHoursDrivenByDriver ='" + numberOfDrivenHoursByDriverTextboxTimeSheetMangerForm.Text + "',NumberOfHoursWorkedByMechanic ='" + numberOfWorkedHoursByMechanicTextboxTimeSheetMangerForm.Text + "',DateDay ='" + enterDateDayTextBoxTimeSheetManagerForm.Text + "'  where DriverID = '" + searchForDataTextBoxTimeSheetMangerForm.Text + "'", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
            }
            MessageBox.Show("Record Updated Successfuly");
        }
    }
}
