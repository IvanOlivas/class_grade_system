using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Grade_System
{
    class StaffMember
    {
        //Attributes
        private String userName;
        private String password;

        public StaffMember()
        {

        }

        public String getUserName()
        {
            return this.userName;
        }

        public String getPassword()
        {
            return this.password;
        }

        //Validate the user to grant access to the system
        public static Boolean authenticateStaffMember(String userName, String password)
        {
            bool result = true;
            DataTable myTable = new DataTable(); //will read all rows from the returning values
            string connStr = "server=localhost;user=root;database=rino_gs;port=3306;password='';";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql = "SELECT * FROM users WHERE userName = @userName AND PASSWORD = @password;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@password", password);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    //staff member credentials exist in the database
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
