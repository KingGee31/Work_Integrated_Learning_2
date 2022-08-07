using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Starting the eMail Textbox disabled so that the user can enter the eMail Address when he/ she forgot the password
            eMailAddressTextboxLoginForm.Enabled = false;
        }
        //Declaring a Stream Reader to read the Data From The User User Textfile and other varibales that enable the data to be Retreived 
        private StreamReader inFile;
        string[] userInformation = new string[6];
        


        private void toExitButtonLoginForm_Click(object sender, EventArgs e)
        {
            //Closing the program when ther user clicks the exit button
            this.Close();
            
            
        }

        private void toRegisterNewAccountButtonLoginForm_Click(object sender, EventArgs e)
        {
            //Loading or Displayin the Register Form When the User Clicks The Regitser account Button
            RegisterForm formRegister = new RegisterForm();

            this.Hide();
            formRegister.Show();


        }

        private void clearButtonLoginForm_Click(object sender, EventArgs e)
        {
            //Clearing the Textfields and Un-checking the radio Button when the user clicks the Clear button
            userNameTextboxLoginForm.Clear();
            passWordTextboxLoginForm.Clear();
            eMailAddressTextboxLoginForm.Clear();

            forgotPasswordCheckBoxForm.Refresh();
        }

        private void loginButtonLoginForm_Click(object sender, EventArgs e)
        {
            
                
            //Using Stream Reader To Read Information From the User File And An If Statement To Enable The User to Login
            string inValue;
            int a = 0;
            if (File.Exists(@"C:\UserInfomation\UserInformation.txt"))
            {
                try
                {
                    inFile = new StreamReader(@"C:\UserInfomation\UserInformation.txt");
                    while((inValue = inFile.ReadLine()) != null)
                    {
                        userInformation[a] = inValue;

                        a +=1;
                    }
                }
                catch(System.IO.IOException exc)
                {
                    MessageBox.Show("The Was An Error Reading From The File, File Could not be Located "+exc,"Error Reading From File");
                }
            }
            else
            {
                MessageBox.Show("File Could Not Be Found", "File Not Found Error");
            }


            //Login In the User When His/ Her Information is Correct And Generating an Error When The User Enters Wrong Details 
            if (userNameTextboxLoginForm.Text != userInformation[0] || passWordTextboxLoginForm.Text != userInformation[1])
            {
                MessageBox.Show("You Have Entered A Wrong Username Or Wrong Password, Please Enter Again","Wrong Login Details");

                //Clearing the textboxes to allow the user to re-enter information
                userNameTextboxLoginForm.Clear();
                passWordTextboxLoginForm.Clear();

                userNameTextboxLoginForm.Focus();
            }
            else
            {
              
                //Closing the File After reading The Information from It 
                try
                {
                    inFile.Close();
                }
                catch
                {
                    MessageBox.Show("Could Not Properly Close the File","File Closing Error");
                }

                //Loading the Main Menu Form When the User enters The Correct Information 
                MainMenu menuForm = new MainMenu();
                this.Hide();
                this.Close();
                menuForm.Show();
                
            }
        }

        private void userNameTextboxLoginForm_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void forgotPasswordClickButtonForm1_Click(object sender, EventArgs e)
        {
            eMailAddressTextboxLoginForm.Enabled = true;
            //Using Stream Reader To Read Information From the User File And An If Statement To Enable The User to Login
            string inValue;
            int a = 0;
            if (File.Exists(@"C:\UserInfomation\UserInformation.txt"))
            {
                try
                {
                    inFile = new StreamReader(@"C:\UserInfomation\UserInformation.txt");
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
            //Closing the File After reading The Information from It 
            try
            {
                inFile.Close();
            }
            catch
            {
                MessageBox.Show("Could Not Properly Close the File", "File Closing Error");
            }

            MessageBox.Show("Enter Email Address To Receive User Details","User Enquiring The Details On forgot Password");
            if (forgotPasswordCheckBoxForm.Checked && eMailAddressTextboxLoginForm.Text == userInformation[2])
            {
                MessageBox.Show("Your Username is " + userInformation[0] + "\nYourPasssword Is " + userInformation[1], "Message To The Forgot Password User");
            }
            else if (forgotPasswordCheckBoxForm.Checked && eMailAddressTextboxLoginForm.Text != userInformation[2])
            {
                MessageBox.Show("You Have Entered A Wrong eMail Address To Retreive The User Password and Username", "Wrong User eMail Address");
            }
        }

        private void eMailAddressTextboxLoginForm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
