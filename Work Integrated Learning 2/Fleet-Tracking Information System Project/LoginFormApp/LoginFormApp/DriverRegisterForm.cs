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
    public partial class DriverRegisterForm : Form
    {
        public DriverRegisterForm()
        {
            InitializeComponent();
        }
        //Declaring a stream Writer
        private StreamWriter fil;
        //Defining the Attributes for Database Connection
        string ConStr;
        SqlConnection Con;
        SqlCommand Cmd;
        //User Email Address Variable
        string registerEmailAddress;

        private void registerButtonDriverRegistrationForm_Click(object sender, EventArgs e)
        {
            //Declaring an object to accept user input for Driver Class in the Class Library 
            InformationSystemClassLibrary.DriverClass classLibrary = new InformationSystemClassLibrary.DriverClass();


            //Using Message Box to check if the User is sure with his data 
            var result = MessageBox.Show("Are You Sure With The Values You Want To Enter", "Data Validation Message", MessageBoxButtons.YesNo);


            if (result == DialogResult.No)
            {
                //Clearing the textboxes when the user clicks clear button 
                driverNameTextboxDriverRegistrationForm.Clear();
                driverEmailAddressTextboxDriverRegistrationForm.Clear();
                driverContactNoTextboxDriverRegistrationForm.Clear();
                driverAdressTextboxDriverRegistrationForm.Clear();
            }
            else if (result == DialogResult.Yes)
            {

                //Connecting to the database and saving the Data
                ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                Con = new SqlConnection(ConStr);
                Con.Open();

                Cmd = new SqlCommand("Insert Into DriverTB(ID, DriverEmailAddress, DriverContactNo, DriverAddress,DriverFullNames) Values('" + DriverIdTextBoxVehicleInformationTB .Text+ "','" + driverEmailAddressTextboxDriverRegistrationForm.Text + "','" + driverContactNoTextboxDriverRegistrationForm.Text + "','" + driverAdressTextboxDriverRegistrationForm.Text + "','" + driverNameTextboxDriverRegistrationForm.Text + "')", Con);
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Success, Record Saved");

                //initializing the variables with values 
                classLibrary.DriverFullNames = driverNameTextboxDriverRegistrationForm.Text;
                classLibrary.DriverEmailAddress = driverEmailAddressTextboxDriverRegistrationForm.Text;
                classLibrary.DriverContactNo =int.Parse(driverContactNoTextboxDriverRegistrationForm.Text);
                classLibrary.DriverAddress = driverAdressTextboxDriverRegistrationForm.Text;
                classLibrary.DriverId = int.Parse(DriverIdTextBoxVehicleInformationTB.Text);
            }       
         
        }

        private void clearButtonDriverRegistrationForm_Click(object sender, EventArgs e)
        {
            //Clearing the textboxes when the user clicks clear button 
            driverNameTextboxDriverRegistrationForm.Clear();
            driverEmailAddressTextboxDriverRegistrationForm.Clear();
            driverContactNoTextboxDriverRegistrationForm.Clear();
            driverAdressTextboxDriverRegistrationForm.Clear();

        }

        private void clickHereButtonDriverRegistrationForm_Click(object sender, EventArgs e)
        {
            //Loading the Main Menu Form when the user clicks this button 
            MainMenu main = new MainMenu();

            this.Close();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Loading the Login Form When the User clicks The Login Button 
            Form1 form1Object = new Form1();
            this.Hide();
            this.Close();
            form1Object.Show();
           
        }

        private void exit_ButtonDriverRegistrationForm_Click(object sender, EventArgs e)
        {
            //Closing the form when the user clicks the exit button 
            this.Close();
        }

        private void driverEmailAddressTextboxDriverRegistrationForm_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void driverContactNoTextboxDriverRegistrationForm_TextChanged(object sender, EventArgs e)
        {
            //Validating if the User Enters the Correct Data Or Format Of the Email address
            if (driverEmailAddressTextboxDriverRegistrationForm.Text.Contains("@gmail.com"))
            {
                registerEmailAddress = driverEmailAddressTextboxDriverRegistrationForm.Text;
            }
            else
            {
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("You Have Entered Your E-Mail Address in an Incorrect format, Enter A correct Email Format", "Wrong Email Address Format", boxButtons);

                if (result == DialogResult.OK)
                {
                    driverEmailAddressTextboxDriverRegistrationForm.Clear();
                    driverEmailAddressTextboxDriverRegistrationForm.Focus();
                }


            }
        }

        private void driverAdressTextboxDriverRegistrationForm_TextChanged(object sender, EventArgs e)
        {
            driverContactNoTextboxDriverRegistrationForm.Text.ToLower();
            //Validating the user Phone Number to check whether they are in a coorect format
            if (driverContactNoTextboxDriverRegistrationForm.Text.Contains("abcdefghijklmnopqrstuvwxyz"))
            {
                MessageBoxButtons BoxButtons = MessageBoxButtons.OK;
                DialogResult Result = MessageBox.Show("You Have Entered An Incorrect Format of Phone Numbers, Plpease Enter the Correct Details", "Wrong Phone Number Format", BoxButtons);
                if (Result == DialogResult.OK)
                {
                    driverContactNoTextboxDriverRegistrationForm.Clear();
                    driverContactNoTextboxDriverRegistrationForm.Focus();
                }

            }
            else
            {
               //Continue To Register
               
            }
        }

        private void driverNameTextboxDriverRegistrationForm_TextChanged(object sender, EventArgs e)
        {

            DriverIdTextBoxVehicleInformationTB.Text.ToLower();
            //Checking if The Textbox Contains Alphabets 
            if (DriverIdTextBoxVehicleInformationTB.Text.Contains("abcdefghijklmnopqrstuvwxyz"))
            {
                MessageBoxButtons BoxButtons = MessageBoxButtons.OK;
                DialogResult Result = MessageBox.Show("You Have Entered An Incorrect Format of The Driver Id, Please Enter Only Numbers", "Wrong Driver Id Format", BoxButtons);
                if (Result == DialogResult.OK)
                {
                    driverContactNoTextboxDriverRegistrationForm.Clear();
                    driverContactNoTextboxDriverRegistrationForm.Focus();
                }
            }
            else
            {
                //Continue To Register

            }

           
        }

        private void DriverIdTextBoxVehicleInformationTB_TextChanged(object sender, EventArgs e)
        {
       
        }
    }
}
