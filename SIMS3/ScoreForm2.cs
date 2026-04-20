using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;


namespace SIMS3
{
    public partial class ScoreForm2 : Form
    {
        ScoreClass scoreClass = new ScoreClass();
        CourseClass course = new CourseClass();
        StudentClass student = new StudentClass();
        public ScoreForm2()
        {
            InitializeComponent();


        }

        // function to show data in datagridview
        private void showScore()
        {
            string query = "SELECT `Score ID`, `Student ID`, `CourseName`, `Score`, `Description` FROM `score` WHERE `IsActive` = 1 ORDER BY `Score ID` DESC";
            dataGridView_score1.DataSource = scoreClass.getlist(new MySqlCommand(query));
    
            dataGridView_score1.BackgroundColor = Color.FromArgb(34, 40, 64);
            dataGridView_score1.GridColor = Color.FromArgb(50, 60, 90);

            dataGridView_score1.EnableHeadersVisualStyles = false;
            dataGridView_score1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94); 
            dataGridView_score1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_score1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView_score1.ColumnHeadersHeight = 40;


            dataGridView_score1.DefaultCellStyle.BackColor = Color.FromArgb(44, 51, 80); 
            dataGridView_score1.DefaultCellStyle.ForeColor = Color.FromArgb(224, 224, 224); 
                                                                                          
            dataGridView_score1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(37, 43, 68);


            dataGridView_score1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 120, 180); 
            dataGridView_score1.DefaultCellStyle.SelectionForeColor = Color.White;


            dataGridView_score1.RowHeadersVisible = false;
            dataGridView_score1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_score1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ScoreForm2_Load(object sender, EventArgs e)

        {
            //populate the combobox with courses name
            comboBox_selectCourse.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            comboBox_selectCourse.DisplayMember = "CourseName";
            comboBox_selectCourse.ValueMember = "CourseName";

            showScore();
            showstudent();
            clearFields();


        }


        private void showstudent()
        {
            dataGridView_score1.DataSource = student.getlist(new MySqlCommand("SELECT `Student ID`, `FirstName`, `MiddleName`, `LastName`, `Suffix` FROM `student` WHERE `IsActive` = 1 ORDER BY `Student ID` DESC"));
            dataGridView_score1.BackgroundColor = Color.FromArgb(34, 40, 64); 
            dataGridView_score1.GridColor = Color.FromArgb(50, 60, 90);      


            dataGridView_score1.EnableHeadersVisualStyles = false;
            dataGridView_score1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94); 
            dataGridView_score1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_score1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView_score1.ColumnHeadersHeight = 40;

            dataGridView_score1.DefaultCellStyle.BackColor = Color.FromArgb(44, 51, 80); 
            dataGridView_score1.DefaultCellStyle.ForeColor = Color.FromArgb(224, 224, 224); 
                                                                                           
            dataGridView_score1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(37, 43, 68);


            dataGridView_score1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 120, 180); 
            dataGridView_score1.DefaultCellStyle.SelectionForeColor = Color.White;

      
            dataGridView_score1.RowHeadersVisible = false;
            dataGridView_score1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_score1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }



        private void button_AddScore_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text == "" || textBox_Score.Text == "" || comboBox_selectCourse.Text == "")
            {
                MessageBox.Show("Please fill in all required score data.", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                int stdId = Convert.ToInt32(textBox_ID.Text);
                string cName = comboBox_selectCourse.Text;
                double score = Convert.ToDouble(textBox_Score.Text);
                string desc = textBox_description.Text;

                if (!scoreClass.checkScore(stdId, cName))
                {

                    if (scoreClass.insertCourse(stdId, cName, score, desc))
                    {
                        MessageBox.Show("New score inserted successfully!", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        showScore();
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show("Score not inserted.", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This student already has a score for this course!", "Duplicate Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void clearFields()
        {
            textBox_ID.Clear();
            textBox_Score.Clear();
            textBox_description.Clear();
            comboBox_selectCourse.SelectedIndex = -1;

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showstudent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showScore();
        }

        private void dataGridView_Score1_Click(object sender, EventArgs e)
        {
            if (dataGridView_score1.CurrentRow != null)
            {
                textBox_ID.Text = dataGridView_score1.CurrentRow.Cells["Student ID"].Value.ToString();

            }
        }

        private void comboBox_selectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
