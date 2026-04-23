using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SIMS3
{
    class CourseClass
    {
        DBConnect connect = new DBConnect();


        public bool insertCourse(string cCode, string cName, double hr, double units, string dept, string desc)
        {
            try
            {
                // Your perfectly updated SQL query
                MySqlCommand command = new MySqlCommand("INSERT INTO `course`(`CourseCode`, `CourseName`, `CourseHour`, `CourseUnits`, `Department`, `Description`, `IsActive`) VALUES (@cc, @cn, @ch, @cu, @dept, @desc, 1)", connect.GetConnection());

                command.Parameters.Add("@cc", MySqlDbType.VarChar).Value = cCode;
                command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cName;
                command.Parameters.Add("@ch", MySqlDbType.Double).Value = hr;
                command.Parameters.Add("@cu", MySqlDbType.Double).Value = units;
                command.Parameters.Add("@dept", MySqlDbType.VarChar).Value = dept;
                command.Parameters.Add("@desc", MySqlDbType.Text).Value = desc;

                connect.openConnect();

                // If it successfully inserts 1 row, return true
                bool result = (command.ExecuteNonQuery() == 1);
                return result;
            }
            catch (Exception ex)
            {
                // Catch any database errors without crashing the app
                MessageBox.Show("Error inserting course: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Guarantee the connection closes no matter what happens
                connect.closeConnect();
            }
        }

        public DataTable getCourse(MySqlCommand command)
        {
            command.Connection = connect.GetConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }


        // function for course edit
        public bool updateCourse(int id, string cCode, string cName, double hr, double units, string dept, string desc)
        {
            try
            {
                // THE FIX: Added `CourseCode`=@cc to the SQL string!
                string query = "UPDATE `course` SET `CourseCode`=@cc, `CourseName`=@cn, `CourseHour`=@hr, `CourseUnits`=@cu, `Department`=@dept, `Description`=@desc WHERE `Course ID`=@id";

                MySqlCommand command = new MySqlCommand(query, connect.GetConnection());

                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                command.Parameters.Add("@cc", MySqlDbType.VarChar).Value = cCode; // Added this!
                command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cName;
                command.Parameters.Add("@hr", MySqlDbType.Double).Value = hr;
                command.Parameters.Add("@cu", MySqlDbType.Double).Value = units;
                command.Parameters.Add("@dept", MySqlDbType.VarChar).Value = dept;
                command.Parameters.Add("@desc", MySqlDbType.Text).Value = desc;

                connect.openConnect();
                bool result = (command.ExecuteNonQuery() == 1);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connect.closeConnect();
            }
        }

        //delete function 

        public bool deleteCourse(int id)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `course` SET `IsActive` = 0 WHERE `Course ID` = @id", connect.GetConnection());

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            connect.openConnect();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        //seach method
        public DataTable SearchCourse(string searchdata, int statusFilter)
        {
            string query = "SELECT * FROM `course` WHERE CONCAT_WS(' ', `Course ID`, `CourseCode`, `CourseName`, `CourseUnits`, `Department`, `Description`) LIKE @search";

            if (statusFilter == 1)
            {
                query += " AND `IsActive` = 1";
            }
            else if (statusFilter == 0)
            {
                query += " AND `IsActive` = 0";
            }

            query += " ORDER BY `Course ID` DESC";

            MySqlCommand command = new MySqlCommand(query, connect.GetConnection());
            command.Parameters.AddWithValue("@search", "%" + searchdata + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }





    }
}

