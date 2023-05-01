using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Team_Grade_System
{
    class Student
    {
        //Attributes for Student class
        private int ID;
        private String firstName;
        private String lastName;
        private double GPA;

        public Student()
        {

        }

        public int getStudentID()
        {
            return this.ID;
        }

        public void setStudentID(int StudentID)
        {
            this.ID = StudentID;
        }

        public String getStudentFirstName()
        {
            return this.firstName;
        }

        public void setStudentFirstName(String StudentFirstName)
        {
            this.firstName = StudentFirstName;
        }

        public String getStudentLastName()
        {
            return this.lastName;
        }

        public void setStudentLastName(String StudentLastName)
        {
            this.lastName = StudentLastName;
        }

        public double getStudentGPA()
        {
            return this.GPA;
        }

        public static Boolean retrievedStudentID(String studentID)
        {
            bool result = true;
            DataTable myTable = new DataTable(); //will read all rows from the returning values
            string connStr = "server=localhost;user=root;database=rino_gs;port=3306;password='';";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            //Check if SQL statement response returned a studentID
            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Console.WriteLine("WE made it here");
                string sql = "SELECT * FROM student WHERE StudentID = @StudentID;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@StudentID", studentID);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    //studentID exists in the database
                    result = true;
                }
                else
                {
                    result = false;
                }
                myReader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            return result;
        }
    }
}
