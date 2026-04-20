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
        public bool insertTeacher(string fname, string lname, string username, string password, string department, string role)
        {
            string sql = "INSERT INTO `user_accounts`(`FirstName`, `LastName`, `Username`, `Password`, `Department`, `Role`, `IsActive`) VALUES (@fn, @ln, @un, @pw, @dpt, @role, 1)";

            MySqlCommand command = new MySqlCommand(sql, connect.GetConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pw", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@dpt", MySqlDbType.VarChar).Value = department;
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = role;


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




        // 5. Function to search for a teacher account
        public DataTable searchTeacher(string searchData, int statusFilter)
        {
            string query = "SELECT UserID, FirstName, LastName, Username, Password, Department, Role, IsActive FROM `user_accounts` WHERE CONCAT_WS(' ', `UserID`, `FirstName`, `LastName`, `Username`, `Department`, `Role`) LIKE @search";

            // Use the integer to decide which filter to apply
            if (statusFilter == 1)
            {
                query += " AND `IsActive` = 1";
            }
            else if (statusFilter == 0)
            {
                query += " AND `IsActive` = 0";
            }

            query += " ORDER BY UserID DESC";

            MySqlCommand command = new MySqlCommand(query, connect.GetConnection());
            command.Parameters.AddWithValue("@search", "%" + searchData + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        // 6. Function to update teacher account details
        public bool updateTeacher(int id, string fname, string lname, string username, string password, string department)
        {
            // Updates based on TeacherID
            string query = "UPDATE `user_accounts` SET `FirstName`=@fn, `LastName`=@ln, `Username`=@un, `Password`=@pw, `Department`=@dpt WHERE `TeacherID`=@id";

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



        // Function to check for duplicate usernames (excluding the current teacher when updating)
        public bool checkDuplicateUsername(string username, int currentId = 0)
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user_accounts` WHERE `Username` = @user AND `UserID` != @id", connect.GetConnection());

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
            try
            {
                // THE FIX: Changed TeacherID to UserID
                MySqlCommand command = new MySqlCommand("UPDATE `user_accounts` SET `IsActive` = 0 WHERE `UserID` = @id", connect.GetConnection());

                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                connect.openConnect();

                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error disabling account: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connect.closeConnect();
            }
        }

        // function to update an existing user account
        public bool Teacherupdate(int id, string fname, string lname, string username, string password, string department, string role)
        {
            try
            {
                // THE FIX: Changed TeacherID to UserID at the very end of this string
                string query = "UPDATE `user_accounts` SET `FirstName`=@fn, `LastName`=@ln, `Username`=@un, `Password`=@pw, `Department`=@dpt, `Role`=@role WHERE `UserID`=@id";

                MySqlCommand command = new MySqlCommand(query, connect.GetConnection());

                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
                command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
                command.Parameters.Add("@un", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@pw", MySqlDbType.VarChar).Value = password;
                command.Parameters.Add("@dpt", MySqlDbType.VarChar).Value = department;
                command.Parameters.Add("@role", MySqlDbType.VarChar).Value = role;

                connect.openConnect();

                bool result = (command.ExecuteNonQuery() == 1);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connect.closeConnect();
            }
        }
    }


        
    }

