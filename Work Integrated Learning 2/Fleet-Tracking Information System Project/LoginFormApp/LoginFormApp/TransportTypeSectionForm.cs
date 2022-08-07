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
    public partial class TransportTypeSectionForm : Form
    {
        public TransportTypeSectionForm()
        {
            InitializeComponent();
        }

        private void clickHereButtonTranportTypeSectionForm_Click(object sender, EventArgs e)
        {
            //Loading the Main Menu Form when the user clicks this button 
            MainMenu main = new MainMenu();

            this.Close();
            main.Show();
        }

        private void toLogOutTranportTypeSectionForm_Click(object sender, EventArgs e)
        {
            //Loading the Login Form When the User clicks The Login Button 
            Form1 form1Object = new Form1();
            this.Hide();
            this.Close();
            form1Object.Show();
           
        }

        private void exit_ButtonTranportTypeSectionForm_Click(object sender, EventArgs e)
        {
            //Closing the form when the user clicks the exit button 
            this.Close();
        }
    }
}
