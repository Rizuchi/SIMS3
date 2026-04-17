using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SIMS3
{
    class ScoreClass
    {
        DBConnect connect = new DBConnect();

        // Create a function to insert course
        public bool insertCourse(int stdId, string cName, double score, string desc)
        {
            // The SQL query modified to target the 'score' table
            MySqlCommand command = new MySqlCommand("INSERT INTO `score`(`Student ID`, `CourseName`, `Score`, `Description`) VALUES (@stdId, @cName, @score, @desc)", connect.GetConnection());

            command.Parameters.Add("@stdId", MySqlDbType.Int32).Value = stdId;
            command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@score", MySqlDbType.Double).Value = score;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;

            connect.openConnect();

            // Execute the query
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


        //function to get score list

        public DataTable getlist(MySqlCommand command)
        {
            command.Connection = connect.GetConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        // Create a function to check if the score already exists for a given student and course
        public bool checkScore(int stdId, string cName)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score` WHERE `Student ID` = @stdId AND `CourseName` = @cName", connect.GetConnection());

            // Using parameters just like you did in your updateCourse function!
            command.Parameters.Add("@stdId", MySqlDbType.Int32).Value = stdId;
            command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = cName;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            // If it finds 1 or more rows, the score already exists
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        // Create a function to update the score for a specific student and course
        public bool updateScore(int stdId, string cName, double score, string desc)
        {
            // The UPDATE query changes the Score and Description ONLY where the Student ID and Course Name match
            string query = "UPDATE `score` SET `Score` = @score, `Description` = @desc WHERE `Student ID` = @stdId AND `CourseName` = @cName";

            MySqlCommand command = new MySqlCommand(query, connect.GetConnection());

            // Bind all four parameters (the order you add them here doesn't matter, as long as the names match the query)
            command.Parameters.Add("@stdId", MySqlDbType.Int32).Value = stdId;
            command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@score", MySqlDbType.Double).Value = score;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;

            connect.openConnect();

            // Execute the query
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true; // Successfully updated 1 row
            }
            else
            {
                connect.closeConnect();
                return false; // Failed to update (maybe the score didn't exist)
            }
        }

        // Create a function to "delete" (deactivate) a course by setting IsActive to 0
        public bool deleteScore(int stdId, string cName)
        {
            // Your code inside should look like this:
            string query = "UPDATE `score` SET `IsActive` = 0 WHERE `Student ID` = @stdId AND `CourseName` = @cName";

            MySqlCommand command = new MySqlCommand(query, connect.GetConnection());

            command.Parameters.Add("@stdId", MySqlDbType.Int32).Value = stdId;
            command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = cName;

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

        // This is the same as SearchCourse but it also checks if IsActive = 1 to hide deleted courses
        public DataTable SearchScore(string searchdata)
        {
            // Added the AS aliases for your DataGridView, and the WHERE clause for the search!
            string query = "SELECT score.`Student ID` AS `Student ID`, student.FirstName AS `First Name`, student.LastName AS `Last Name`, score.CourseName AS `CourseName`, score.Score, score.Description FROM score INNER JOIN student ON score.`Student ID` = student.`Student ID` WHERE student.FirstName LIKE @search OR student.LastName LIKE @search OR score.CourseName LIKE @search OR score.`Student ID` LIKE @search";
            MySqlCommand command = new MySqlCommand(query, connect.GetConnection());
            command.Parameters.AddWithValue("@search", "%" + searchdata + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }


    }
}

