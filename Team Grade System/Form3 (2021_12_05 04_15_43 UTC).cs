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
    public partial class PrintForm : Form
    {
        public string studentID { get; set; }
        public PrintForm()
        {
            InitializeComponent();
            ErrorLabel.Visible = false;
        }

        private void SaveReportButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(StudentIDTextBox.Text)){
                ErrorLabel.Text = "Must enter a student ID";
                ErrorLabel.Visible = true;
            }
            else
            {
                studentID = StudentIDTextBox.Text;
                //Verify that student is in the database
                if (Student.retrievedStudentID(studentID))
                {
                    this.Close();
                }
                else
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Student not in the database!";
                }
            }
            
        }

        private void StudentIDTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
            
        }
    }
}
