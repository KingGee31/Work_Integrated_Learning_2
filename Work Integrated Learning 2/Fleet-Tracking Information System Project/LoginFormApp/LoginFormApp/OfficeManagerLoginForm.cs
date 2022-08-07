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
    public partial class OfficeManagerLoginForm : Form
    {
        public OfficeManagerLoginForm()
        {
            InitializeComponent();
        }
        //Declaring a Stream Reader to read the Data From The User User Textfile and other varibales that enable the data to be Retreived 
        private StreamReader inFile;
        string[] userInformation = new string[4];
        //Declaring 2 Number FOr the User Login Test 
        Random random = new Random();
        int no1, no2, totalValue;
        

        private void loginButtonOfficeManagerLoginForm_Click(object sender, EventArgs e)
        {
           
           

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


            //Using An If Statement To Check Whether Ther values and information entered allow the user To Login Succesffull into the Office Manager Section
            if (usernameTextboxOfficeManagerLoginForm.Text != userInformation[0] || PasswordTextboxOfficeManagerLoginForm.Text != userInformation[1])
            {
                MessageBox.Show("You Have Entered Wrong Login Details, Please Enter The Correct Details", "Wrong Log In Information error");
            }
            else if(int.Parse(securityQuestionAnswerOfficeMangerLoginForm.Text) != totalValue)
            {
                MessageBox.Show("You Have Answered Wrong the Question,Please Answer Correctly", "Failed To Answer The Security Question");
            }
            else
            {
                //Loading the Office Manager Form To Give the Office Manager Access to The application
                OfficeManagerForm officeManagerForm = new OfficeManagerForm();
                this.Hide();
                this.Close();
                officeManagerForm.Show();
                
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
        }

        private void clearButtonOfficeManagerLoginForm_Click(object sender, EventArgs e)
        {
            //Clearing the values of the variables in the Textboxes
            usernameTextboxOfficeManagerLoginForm.Clear();
            PasswordTextboxOfficeManagerLoginForm.Clear();
            securityQuestionAnswerOfficeMangerLoginForm.Clear();
        }

        private void securityQuestionAnswerOfficeMangerLoginForm_TextChanged(object sender, EventArgs e)
        {

        }

        private void clickHereButtonOfficeManagerLoginForm_Click(object sender, EventArgs e)
        {
            //Loading the Main Menu Form when the user clicks this button 
            MainMenu main = new MainMenu();

            this.Close();
            main.Show();
            
        }

        private void toLogOutOfficeManagerLoginForm_Click(object sender, EventArgs e)
        {
            //Loading the Login Form When the User clicks The Login Button 
            Form1 form1Object = new Form1();
            this.Hide();
            this.Close();

            form1Object.Show();
          
        }

        private void takeTestButtonOfficeManagerLoginForm_Click(object sender, EventArgs e)
        {
            //Assigning the variables values to Make the Test
            no1 = random.Next(1, 20);
            no2 = random.Next(1, 20);
            totalValue = no1 + no2;

            //Assigning the numbers to the Labels to diplay the test 
            firstNoLabelOfficeManagerLoginForm.Text = string.Concat(no1);
            secondNoLabelOfficeManagerLoginForm.Text = string.Concat(no2);
        }

        private void exit_ButtonOfficeManagerLoginForm_Click(object sender, EventArgs e)
        {
            //Closing the form when the user clicks the exit button 
            this.Close();
        }

        private void usernameTextboxOfficeManagerLoginForm_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
