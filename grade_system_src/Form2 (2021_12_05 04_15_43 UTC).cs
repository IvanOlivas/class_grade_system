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
    public partial class EditForm : Form
    {
        public string grade { get; set; }
        public EditForm()
        {
            InitializeComponent();
            ErrorLabel.Visible = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Read the TextBoxGrade and sent it back to form1
            if (gradeTextBoxEmpty())
            {
                ErrorLabel.Visible = true;
            }
            else
            {
                //Close the DialogBox
                grade = GradeTextBox.Text.ToUpper();
                this.Close();
            }
            
        }

        //Check if TextBox is Empty
        private Boolean gradeTextBoxEmpty()
        {
            if(GradeTextBox.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Reset Error Label once user enters a grade
        private void resetErrorLabel(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
        }

        //Close form2 cancel button 
        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
