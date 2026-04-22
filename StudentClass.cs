using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace SIMS3
{
    internal class StudentClass
    {
        // call connectdb
            DBConnect connect = new DBConnect();

            public bool insertStudent(string fname, string mname, string lname, string suffix, DateTime bdate, string gender, string phone, string address, byte[] img)
            {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`FirstName`, `MiddleName`, `LastName`, `Suffix`, `Birthdate`, `Gender`, `Phone`, `Address`, `Photo`, `IsActive`) VALUES (@fn, @mn, @ln, @sfx, @bdt, @gnd, @phn, @adr, @img, 1)", connect.GetConnection());

            //@fn, @ln, @bd, @gd, @ph, @adr, @img
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
                command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname;   
                command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
                command.Parameters.Add("@sfx", MySqlDbType.VarChar).Value = suffix; 
                command.Parameters.Add("@bdt", MySqlDbType.Date).Value = bdate;
                command.Parameters.Add("@gnd", MySqlDbType.VarChar).Value = gender;
                command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
                command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
                command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

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

            public DataTable getStudentlist(MySqlCommand command)
            {
                command.Connection = connect.GetConnection();

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable table = new DataTable();

                adapter.Fill(table);
                return table;

            }
            //function to execute the count
            public string exeCount(string query)
            {
                MySqlCommand command = new MySqlCommand(query, connect.GetConnection());
                connect.openConnect();
                string count = command.ExecuteScalar().ToString();
                connect.closeConnect();
                return count;
            }

            // 
            public string totalStudents()
            {
            return exeCount("SELECT COUNT(*) FROM student WHERE IsActive = 1");
            }

          
            public string maleStudents()
            {
      
            return exeCount("SELECT COUNT(*) FROM student WHERE Gender = 'Male' AND IsActive = 1");
            }

            public string femaleStudents()
            {
            return exeCount("SELECT COUNT(*) FROM student WHERE Gender = 'Female' AND IsActive = 1");
            }

        // function for student seach

        public DataTable searchStudent(string searchData, int statusFilter)
        {
            string query = "SELECT * FROM `student` WHERE CONCAT_WS(' ', `Student ID`, `FirstName`, `MiddleName`, `LastName`, `Suffix`) LIKE @search";
            if (statusFilter == 1)
            {
                query += " AND `IsActive` = 1";
            }
            else if (statusFilter == 0)
            {
                query += " AND `IsActive` = 0";
            }

            MySqlCommand command = new MySqlCommand(query, connect.GetConnection());
            command.Parameters.AddWithValue("@search", "%" + searchData + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        


    

            public bool updateStudent(int id, string fname, string mname, string lname, string suffix, DateTime bdate, string gender, string phone, string address, byte[] img)
            {
         
                string query = "UPDATE `student` SET `FirstName`=@fn, `MiddleName`=@mn, `LastName`=@ln, `Suffix`=@sfx, `Birthdate`=@bd, `Gender`=@gd, `Phone`=@ph, `Address`=@adr, `Photo`=@img WHERE `Student ID`=@id";

                MySqlCommand command = new MySqlCommand(query, connect.GetConnection());

          
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
                command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname; 
                command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
                command.Parameters.Add("@sfx", MySqlDbType.VarChar).Value = suffix; 
                command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
                command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
                command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
                command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
                command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

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

            //fucntion for any command in students
            public DataTable getlist(MySqlCommand command)
            {
                command.Connection = connect.GetConnection();

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;

            }
        public bool softDeleteStudent(int id)
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
        

       

        // method to get student count by course
        public DataTable getStudentCountByCourse(string courseName)
        {
            string query = @"SELECT COUNT(DISTINCT CASE WHEN student.Gender = 'Male' THEN student.`Student ID` END) AS MaleCount, COUNT(DISTINCT CASE WHEN student.Gender = 'Female' THEN student.`Student ID` END) AS FemaleCount FROM student INNER JOIN score ON student.`Student ID` = score.`Student ID` WHERE TRIM(score.CourseName) = TRIM(@cName) AND student.IsActive = 1";

            MySqlCommand command = new MySqlCommand(query, connect.GetConnection());

            command.Parameters.AddWithValue("@cName", courseName.Trim());

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }




    }
}

