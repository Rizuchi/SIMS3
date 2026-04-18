using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SIMS3
{
    class AccountClass
    {
        DBConnect connect = new DBConnect();

        // 1. Function to insert a new teacher account
        public bool insertTeacher(string fname, string lname, string username, string password, string department)
        {
            // Insert into teacher_account. IsActive is automatically set to 1.
            MySqlCommand command = new MySqlCommand("INSERT INTO `teacher_account`(`FirstName`, `LastName`, `Username`, `Password`, `Department`, `IsActive`) VALUES (@fn, @ln, @un, @pw, @dpt, 1)", connect.GetConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pw", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@dpt", MySqlDbType.VarChar).Value = department;

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

        // 2. Generic function to execute a count query
        public string exeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.GetConnection());
            connect.openConnect();
            string count = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return count;
        }

        // 3. Count total teachers
        public string totalTeachers()
        {
            return exeCount("SELECT COUNT(*) FROM `teacher_account`");
        }

        // 4. Count only ACTIVE teachers (Replaced Male/Female counters)
        public string activeTeachers()
        {
            return exeCount("SELECT COUNT(*) FROM `teacher_account` WHERE `IsActive` = 1");
        }

        // 5. Function to search for a teacher account
        public DataTable searchTeacher(string searchdata)
        {
            // Searches by Name, Username, or Department
            string query = "SELECT * FROM `teacher_account` WHERE CONCAT(`FirstName`, `LastName`, `Username`, `Department`) LIKE '%" + searchdata + "%'";

            MySqlCommand command = new MySqlCommand(query, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // 6. Function to update teacher account details
        public bool updateTeacher(int id, string fname, string lname, string username, string password, string department)
        {
            // Updates based on TeacherID
            string query = "UPDATE `teacher_account` SET `FirstName`=@fn, `LastName`=@ln, `Username`=@un, `Password`=@pw, `Department`=@dpt WHERE `TeacherID`=@id";

            MySqlCommand command = new MySqlCommand(query, connect.GetConnection());

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pw", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@dpt", MySqlDbType.VarChar).Value = department;

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

        // 7. Function to return data for DataGridViews
        public DataTable getlist(MySqlCommand command)
        {
            command.Connection = connect.GetConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // 8. Soft Delete: Deactivates the teacher instead of deleting them permanently
        public bool softDeleteTeacher(int id)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `teacher_account` SET `IsActive` = 0 WHERE `TeacherID` = @id", connect.GetConnection());

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





        // Function to check for duplicate usernames (excluding the current teacher when updating)
        public bool checkDuplicateUsername(string username, int currentId = 0)
        {
         
            MySqlCommand command = new MySqlCommand("SELECT * FROM `teacher_account` WHERE `Username` = @user AND `TeacherID` != @id", connect.GetConnection());

            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = currentId;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

          
            if (table.Rows.Count > 0)
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }

        // function to disable account (set IsActive to 0)
        public bool disableAccount(int id)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `teacher_account` SET `IsActive` = 0 WHERE `TeacherID` = @id", connect.GetConnection());

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
    }
}
