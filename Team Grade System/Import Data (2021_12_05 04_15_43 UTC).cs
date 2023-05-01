using ExcelDataReader;
using MySql.Data.MySqlClient;
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

namespace Team_Grade_System
{
    public partial class Import_Data : Form
    {
        String year;
        String semester;
        String prefix;
        String crn;
        DataTableCollection tableCollection;

        public Import_Data()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Filename.Text = openFileDialog.FileName;
                    getCourseInformationFromFileName(Filename.Text);
                }
            }
        }

        //##################### Import student information to database ############################
        private void importToDatabase(object sender, EventArgs e)
        {
            using (var stream = File.Open(Filename.Text, FileMode.Open, FileAccess.Read))
            {
                using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                {
                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                    });

                    tableCollection = result.Tables;

                    DataTable x;

                    //Insert each student to database 
                    foreach (DataTable table in tableCollection)
                    {
                        x = table;
                        if (insertToDatabase(x))
                        {
                            MessageBox.Show("Student's data was inserted to database successfully!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sorry, something went wrong!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
        }
        //################## INSERT STUDENT"S INFO TO DATABASE ##################################
        private Boolean insertToDatabase(DataTable table)
        {
            Boolean result = false;
            string connStr = "server=localhost;user=root;database=rino_gs;port=3306;password='';";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            //Try to insert values students table 
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    String firstName = getFirstName((String)table.Rows[i][0]);
                    String lastName = getLastName((String)table.Rows[i][0]);
                    String ID = table.Rows[i][1].ToString();
                    String grade = (String)table.Rows[i][2];

                    //Console.WriteLine(firstName + " " + lastName + " " + ID + " " + grade);

                    string sql = "INSERT IGNORE INTO student VALUES (@studentID, @firstname, @lastname, @GPA);";
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@studentID", ID);
                    cmd.Parameters.AddWithValue("@firstname", firstName);
                    cmd.Parameters.AddWithValue("@lastname", lastName);
                    cmd.Parameters.AddWithValue("@GPA", null);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Insertion to Student Successful");
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            insertCourseWorkCatalogInformation(crn,table);
            //Console.WriteLine("Inserted into student and courseworkfromcatalog tables");
            return result;
        }//################################ END OF INSERT STUDENTS INFO ####################################

        //####################################### FUNCTIONS TO INSERT GRADES ###################################
        private void getCourseInformationFromFileName(String filename)
        {
            int indexOfBSlash;
            int dot = filename.LastIndexOf(".");
            indexOfBSlash = filename.LastIndexOf("\\");
            prefix = filename.Substring(indexOfBSlash + 1, 8);
            prefix = prefix.Replace(" ", "");
            year = filename.Substring(indexOfBSlash + 9, 4);
            dot = dot - filename.LastIndexOf(" ");
            semester = filename.Substring(filename.LastIndexOf(" ") + 1, dot - 1);

            //get CRN number from the database to set variable globally
            getCRN();

            Console.WriteLine(crn);
            Console.WriteLine(prefix);
            Console.WriteLine(year);
            Console.WriteLine(semester);
        }

        private void getCRN()
        {
            string connStr = "server=localhost;user=root;database=rino_gs;port=3306;password='';";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM catalog WHERE Prefix = @prefix AND YEAR = @year  AND Semester = @semester;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@prefix", prefix);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@semester", semester);

                //read response from database
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.HasRows)
                {
                    myReader.Read();
                    crn = myReader.GetString(0);
                    Console.WriteLine(crn);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void insertCourseWorkCatalogInformation(String cRN, DataTable table)
        {
            string connStr = "server=localhost;user=root;database=rino_gs;port=3306;password='';";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    String ID = table.Rows[i][1].ToString();
                    String grade = (String)table.Rows[i][2];

                    string sql = "Insert IGNORE INTO studentcourseworkfromcatalog VALUES (@cRN, @studentID, @grade);";
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@cRN", cRN);
                    cmd.Parameters.AddWithValue("@studentID", ID);
                    cmd.Parameters.AddWithValue("@grade", grade);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Successful insertion to studentcourseworkfromcatalog");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
        //####################################### END OF INSERT GRADES ########################################
        private String getFirstName(String name)
        {
            String res = name.Substring(0, name.IndexOf(" "));

            return res;
        }

        private String getLastName(String name)
        {
            String res = name.Substring(name.LastIndexOf(" ") + 1);

            return res;
        }
    }
}
