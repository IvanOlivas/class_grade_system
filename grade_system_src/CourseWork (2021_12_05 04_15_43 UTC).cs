using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace Team_Grade_System
{
    class CourseWork
    {
        //Attributes
        private int courseWorkID;
        private int CRN;
        private String prefix;
        private String grade;
        private String semester;
        private String year;
        private int studentID;
        private int creditHours; 

        public CourseWork(int CRN, String prefix, String grade, String semester, int studentID, String year, int creditHours)
        {
            this.CRN = CRN;
            this.prefix = prefix;
            this.grade = grade;
            this.semester = semester;
            this.studentID = studentID;
            this.year = year;
            this.creditHours = creditHours;
        }

        public CourseWork()
        {

        }

        public int getCourseWorkID()
        {
            return this.courseWorkID;
        }

        public void setCourseWorkID(int courseWorkID)
        {
            this.courseWorkID = courseWorkID;
        }

        public int getCRN()
        {
            return this.CRN;
        }

        public void setCRN(int CRN)
        {
            this.CRN = CRN;
        }

        public String getPrefix()
        {
            return this.prefix;
        }

        public void setPrefix(String prefix)
        {
            this.prefix = prefix;
        }

        public String getGrade()
        {
            return this.grade;
        }

        public void setGrade(String grade)
        {
            this.grade = grade;
        }

        public String getSemester()
        {
            return this.semester;
        }

        public void setSemester(String semester)
        {
            this.semester = semester;
        }

        public int getStudentID()
        {
            return this.studentID;
        }

        public void setStudentID(int studentID)
        {
            this.studentID = studentID;
        }

        public int getCreditHours()
        {
            return this.creditHours;
        }

        public void setCreditHours(int creditHours)
        {
            this.creditHours = creditHours;
        }

        public String getYear()
        {
            return this.year;
        }

        public void setYear(String year)
        {
            this.year = year;
        }
    
        //Retrieve CRN to see if a course exists
        public static Boolean retrieveCRN(String CRN)
        {
            //first access the database and pull the CRN provided by the user.
            bool result = true;
            DataTable myTable = new DataTable(); //will read all rows from the returning values
            string connStr = "server=localhost;user=root;database=rino_gs;port=3306;password='';";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                //Console.WriteLine("WE made it here");
                string sql = "SELECT * FROM Catalog WHERE CRN = @CRN;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CRN", CRN);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    //course with specified CRN exists in the database
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

        public static Boolean hasStudentTakenThisCourse(String CRN, String studentID)
        {
            //first access the database and pull the CRN provided
            bool result = true;
            DataTable myTable = new DataTable(); //will read all rows from the returning values
            string connStr = "server=localhost;user=root;database=rino_gs;port=3306;password='';";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                //Console.WriteLine("WE made it here");
                string sql = "SELECT * FROM studentcourseworkfromcatalog WHERE CRN = @CRN AND studentID = @studentID;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CRN", CRN);
                cmd.Parameters.AddWithValue("@studentID", studentID);

                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    //CRN specified, has been taken by the specified student
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

        //###################### Function to Retrieve courseWork Information that a student has taken 
        public static ArrayList RetrieveCourseWorkInformationUsingStudent(String ID)
        {
            ArrayList listOfCoursesTaken = new ArrayList();
            DataTable myTable = new DataTable(); //will read all rows from the returning values
            string connectionToDatabse = "server=localhost;user=root;database=rino_gs;port=3306;password='';";
            MySqlConnection conn = new MySqlConnection(connectionToDatabse);

            try
            {
                Console.WriteLine("Connecting to MySql...");
                conn.Open();
                string selectSingleEventSQL = "SELECT c.CRN, c.Prefix, c.Semester, c.YEAR, cw.StudentID, cw.Grade, c.CreditHours FROM catalog c INNER JOIN studentcourseworkfromcatalog cw ON(cw.StudentID = @studentID AND c.CRN = cw.CRN) ORDER BY (YEAR); ";
                MySqlCommand cmd = new MySqlCommand(selectSingleEventSQL, conn);
                cmd.Parameters.AddWithValue("@studentID", ID);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(myTable); //populate table with values returned
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.Close();

            foreach (DataRow row in myTable.Rows)               //populate list with values from myTable, as course objects
            {
                CourseWork coursework = new CourseWork(); 

                //Populate a course object for each course found in the database
                coursework.CRN = Int32.Parse(row["CRN"].ToString());
                coursework.prefix = row["prefix"].ToString();
                coursework.semester = row["semester"].ToString();
                coursework.year = row["year"].ToString();
                coursework.grade = row["grade"].ToString();

                //Add the student to the object for internal use
                coursework.studentID = Int32.Parse(row["studentID"].ToString());

                //Add the creditHours to the object for internal use 
                coursework.creditHours = Int32.Parse(row["CreditHours"].ToString());

                //add course objects to the list
                listOfCoursesTaken.Add(coursework);
            }

            return listOfCoursesTaken;
        } //End of Retrieving Courses

        //############################# Function to Delete a Course from the database ##################################
        public Boolean DeleteCourse(String CRN, String studentID)
        {
            Boolean deletionSuccessfully = true;
       
            string connStr = "server=localhost;user=root;database=rino_gs;port=3306;password='';";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "DELETE FROM studentcourseworkfromcatalog WHERE (studentID = @studentId AND CRN = @CRN);";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cRN", CRN);
                cmd.Parameters.AddWithValue("@studentID", studentID);
                cmd.ExecuteNonQuery();
                Console.WriteLine("A course was deleted from the database");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            return deletionSuccessfully;
        }

    }
}
