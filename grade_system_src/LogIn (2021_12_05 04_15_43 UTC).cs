using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Grade_System
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            ErrorLabelForLogIn.Visible = false;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if(checkEmptyBoxes() == false)
            {
                //validate login combination
                if (StaffMember.authenticateStaffMember(UserNameTextBox.Text,PasswordTextBox.Text))
                {
                    this.Hide();
                    Form1 validUser = new Form1();
                    validUser.ShowDialog();
                    this.Close();
                }
                else
                {
                    ErrorLabelForLogIn.Text = "Username or password are incorrect!";
                    ErrorLabelForLogIn.Visible = true;
                }
            }

            else
            {
                ErrorLabelForLogIn.Text = "Fields must be filled out!";
                ErrorLabelForLogIn.Visible = true;
            }
        }
        
        //Hide the label once the text changes. 
        private void resetErrorLabel(object sender, EventArgs e)
        {
            ErrorLabelForLogIn.Visible = false;

        }

        //Check for empty boxes
        private Boolean checkEmptyBoxes()
        {
            Boolean result = false;
            if(String.IsNullOrEmpty(UserNameTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text))
            {
               result = true;
            }
            return result;
        }

    }
}
