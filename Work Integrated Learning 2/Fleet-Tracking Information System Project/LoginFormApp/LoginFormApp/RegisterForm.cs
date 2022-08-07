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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        //Declaring a stream Writer to write the user information to a TextFile
        private StreamWriter fil;
        //Defining the Attributes for Database Connection
        string ConStr;
        SqlConnection Con;
        SqlCommand Cmd;


        private void clickToCreateAccountButtonRegisterForm_Click(object sender, EventArgs e)
        {
            int userNo;
            Random NoOfUser = new Random();
            userNo = NoOfUser.Next(1, 50);

            //Using Message Box to check if the User is sure with his data 
            var result = MessageBox.Show("Are You Sure With The Values You Want To Enter", "Data Validation Message", MessageBoxButtons.YesNo);


            if (result == DialogResult.No)
            {
                //Clearing The Textfields If the User wants to Make Corrections Or Re enter Information 
                usernameTextboxRegisterForm.Clear();
                passwordTextboxRegisterForm.Clear();
                re_enterPasswordTextboxRegisterForm.Clear();
                emailAddressTextboxRegisterForm.Clear();
            }
            else if (result == DialogResult.Yes)
            {
                //Checking whether the user has regitered a correct email Address in the Email Address textbox
                //Validating if the User Enters the Correct Data Or Format Of the Email address
                if (emailAddressTextboxRegisterForm.Text.Contains("@gmail.com"))
                {
                    //Continue , Do nothing about this
                    //Accesing the User Input And Writing them To A file If the  Passwords match
                    //If Statement to check whether the Passwords are equal
                    if (passwordTextboxRegisterForm.Text != re_enterPasswordTextboxRegisterForm.Text)
                    {
                        MessageBox.Show("The 2 entered Passwords Are Not Equal, Enter Again", "Password Match Error Message");

                        //Giving the User another Chance to enter correct passwords 
                        passwordTextboxRegisterForm.Clear();
                        re_enterPasswordTextboxRegisterForm.Clear();

                        passwordTextboxRegisterForm.Focus();
                    }
                    else
                    {
                        try
                        {
                            fil = new StreamWriter(@"C:\UserInfomation\UserInformation.txt");
                            fil.WriteLine(usernameTextboxRegisterForm.Text + "\n" + passwordTextboxRegisterForm.Text + "\n" + emailAddressTextboxRegisterForm.Text);
                        }
                        catch (DirectoryNotFoundException exc)
                        {
                            string error = exc.Message;
                            MessageBox.Show(error);
                        }
                        catch (System.IO.IOException exc)
                        {
                            string errors = exc.Message;
                            MessageBox.Show(errors);
                        }

                        //Connecting to the database and saving the Data
                        ConStr = @"Data Source=CHARMONITA\MSSQLEXPRESS;Initial Catalog=Fleet_Tracking_SystemDB;Integrated Security=True;Pooling=False";
                        Con = new SqlConnection(ConStr);
                        Con.Open();

                        Cmd = new SqlCommand("Insert Into UserAccountTB(userNo, Password, EmailAddress,Username) Values('" + userNo+ "','" + passwordTextboxRegisterForm.Text + "','" + emailAddressTextboxRegisterForm.Text + "','" + usernameTextboxRegisterForm.Text + "')", Con);
                        Cmd.ExecuteNonQuery();
                        Con.Close();

                        MessageBox.Show("You Have Successfully Created An Account, Navigate to the Login Screen to Log Into The System", "Account Creation Success");

                    }
                }
                else
                {
                    MessageBoxButtons boxButtonS = MessageBoxButtons.OK;
                    DialogResult results = MessageBox.Show("You Have Entered Your E-Mail Address in an Incorrect format, Enter A correct Email Format", "Wrong Email Address Format", boxButtonS);

                    if (results == DialogResult.OK)
                    {
                        emailAddressTextboxRegisterForm.Clear();
                        emailAddressTextboxRegisterForm.Focus();
                    }


                }
            }


            
       
        }

        private void clearButtonRegisterForm_Click(object sender, EventArgs e)
        {
            //Clearing The Textfields If the User wants to Make Corrections Or Re enter Information 
            usernameTextboxRegisterForm.Clear();
            passwordTextboxRegisterForm.Clear();
            re_enterPasswordTextboxRegisterForm.Clear();
            emailAddressTextboxRegisterForm.Clear();
        }

        private void clickToNavigateToLoginMenuButtonRegisterForm_Click(object sender, EventArgs e)
        {
            //Closing Writing To File When the User Navigates to the Login Form
            try
            {
                fil.Close();
            }
            catch
            {
                MessageBox.Show("After Writing to File, The File Could Not Close Properly","Error Closing The File");
            }

            //Loading the The Login Form When the User CLicks this button
            Form1 formObject = new Form1();
            this.Hide();
            this.Close();
            formObject.Show();
          
        }

        private void emailAddressTextboxRegisterForm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
