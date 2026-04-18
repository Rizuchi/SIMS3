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


        public bool insertCourse(string cName, double hr, double units, string dept, string desc)
        {

            MySqlCommand command = new MySqlCommand("INSERT INTO `course`(`CourseName`, `CourseHour`, `CourseUnits`, `Department`, `Description`) VALUES (@cn, @ch, @cu, @dept, @desc)", connect.GetConnection());

            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@ch", MySqlDbType.Int32).Value = hr;
            command.Parameters.Add("@cu", MySqlDbType.Int32).Value = units;    
            command.Parameters.Add("@dept", MySqlDbType.VarChar).Value = dept; 
            command.Parameters.Add("@desc", MySqlDbType.Text).Value = desc;

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


        public DataTable getCourse(MySqlCommand command)
        {
            command.Connection = connect.GetConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }


        //function for course edit
        public bool updateCourse(int id, string cName, double hr, double units, string dept, string desc)
        {

            MySqlCommand command = new MySqlCommand("UPDATE course SET CourseName=@cn, CourseHour=@hr, CourseUnits=@cu, Department=@dept, Description=@desc WHERE `Course ID`=@id", connect.GetConnection());

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@hr", MySqlDbType.Int32).Value = hr;
            command.Parameters.Add("@cu", MySqlDbType.Int32).Value = units;
            command.Parameters.Add("@dept", MySqlDbType.VarChar).Value = dept;
            command.Parameters.Add("@desc", MySqlDbType.Text).Value = desc;

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

        //delete function 

        public bool deleteCourse(int id)
        {
            MySqlCommand command = new MySqlCommand("UPDATE student SET IsActive = 0 WHERE `Student ID` = @id", connect.GetConnection());

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
        public DataTable SearchCourse(string searchdata)
        {
            string query = "SELECT * FROM `course` WHERE CONCAT_WS(' ', `CourseName`, `Department`, `Description`) LIKE @search";

            MySqlCommand command = new MySqlCommand(query, connect.GetConnection());

            command.Parameters.AddWithValue("@search", "%" + searchdata + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

           return table;

        }


        
       

    }
}

