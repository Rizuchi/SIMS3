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

        // function to insert course
        public bool insertCourse(int stdId, string cName, double score, string desc)
        {

            MySqlCommand command = new MySqlCommand("INSERT INTO `score`(`Student ID`, `CourseName`, `Score`, `Description`) VALUES (@stdId, @cName, @score, @desc)", connect.GetConnection());

            command.Parameters.Add("@stdId", MySqlDbType.Int32).Value = stdId;
            command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@score", MySqlDbType.Double).Value = score;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;

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


        //function to get score list

        public DataTable getlist(MySqlCommand command)
        {
            command.Connection = connect.GetConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        // function to check if the score already exists for a given student and course
        public bool checkScore(int stdId, string cName)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score` WHERE `Student ID` = @stdId AND `CourseName` = @cName", connect.GetConnection());


            command.Parameters.Add("@stdId", MySqlDbType.Int32).Value = stdId;
            command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = cName;

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
        //function to update the score for a specific student and course
        public bool updateScore(int stdId, string cName, double score, string desc)
        {

            string query = "UPDATE `score` SET `Score` = @score, `Description` = @desc WHERE `Student ID` = @stdId AND `CourseName` = @cName";

            MySqlCommand command = new MySqlCommand(query, connect.GetConnection());


            command.Parameters.Add("@stdId", MySqlDbType.Int32).Value = stdId;
            command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@score", MySqlDbType.Double).Value = score;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;

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

        //function to "delete" (deactivate) a course by setting IsActive to 0
        public bool deleteScore(int stdId, string cName)
        {
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


        public DataTable SearchScore(string searchdata, int statusFilter)
        {
            string query = "SELECT score.`Student ID` AS `Student ID`, student.FirstName AS `First Name`, student.LastName AS `Last Name`, score.CourseName AS `CourseName`, score.Score, score.Description, score.IsActive FROM score INNER JOIN student ON score.`Student ID` = student.`Student ID` WHERE (student.FirstName LIKE @search OR student.LastName LIKE @search OR score.CourseName LIKE @search OR score.`Student ID` LIKE @search)";

            if (statusFilter == 1)
            {
                query += " AND score.IsActive = 1";
            }
            else if (statusFilter == 0)
            {
                query += " AND score.IsActive = 0";
            }

            query += " ORDER BY score.`Student ID` DESC";

            MySqlCommand command = new MySqlCommand(query, connect.GetConnection());
            command.Parameters.AddWithValue("@search", "%" + searchdata + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;


        }
    }
}

