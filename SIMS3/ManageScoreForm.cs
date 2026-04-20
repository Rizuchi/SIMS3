using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace SIMS3
{
    public partial class ManageScoreForm : Form
    {
        CourseClass course = new CourseClass();
        ScoreClass scoreClass = new ScoreClass();
        public ManageScoreForm()
        {
            InitializeComponent();
 

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
                string desc = textBox_Description.Text;


                if (scoreClass.updateScore(stdId, cName, score, desc))
                {
      
                    MessageBox.Show("Score updated successfully!", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    showScore();
                    clearFields();
                }
                else
                {
             
                    MessageBox.Show("Score not updated. Make sure this student already has a grade registered for this course.", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {

            if (textBox_ID.Text == "" || comboBox_selectCourse.Text == "")
            {
                MessageBox.Show("Please select a score to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this score?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int stdId = Convert.ToInt32(textBox_ID.Text);
                    string cName = comboBox_selectCourse.Text;

                    if (scoreClass.deleteScore(stdId, cName))
                    {
                        MessageBox.Show("Score deleted successfully!", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showScore();
                        button_Clear_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Score not deleted.", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            comboBox_selectCourse.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            comboBox_selectCourse.DisplayMember = "CourseName";
            comboBox_selectCourse.ValueMember = "CourseName";

            showScore();
            clearFields();

        }



        private void showScore()
        {
            string query = "SELECT score.`Student ID` AS `Student ID`, student.FirstName AS `First Name`, student.LastName AS `Last Name`, score.CourseName AS `CourseName`, score.Score, score.Description, score.IsActive FROM score INNER JOIN student ON score.`Student ID` = student.`Student ID` WHERE score.IsActive = 1 ORDER BY score.`Score ID` DESC";

            dataGridView_manageCourse.DataSource = scoreClass.getlist(new MySqlCommand(query));

            dataGridView_manageCourse.BackgroundColor = Color.FromArgb(34, 40, 64); 
            dataGridView_manageCourse.GridColor = Color.FromArgb(50, 60, 90);    

        
            dataGridView_manageCourse.EnableHeadersVisualStyles = false;
            dataGridView_manageCourse.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94); 
            dataGridView_manageCourse.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_manageCourse.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView_manageCourse.ColumnHeadersHeight = 40;

         
            dataGridView_manageCourse.DefaultCellStyle.BackColor = Color.FromArgb(44, 51, 80); 
            dataGridView_manageCourse.DefaultCellStyle.ForeColor = Color.FromArgb(224, 224, 224); 

            dataGridView_manageCourse.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(37, 43, 68);

            dataGridView_manageCourse.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 120, 180); 
            dataGridView_manageCourse.DefaultCellStyle.SelectionForeColor = Color.White;


            dataGridView_manageCourse.RowHeadersVisible = false;
            dataGridView_manageCourse.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_manageCourse.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void clearFields()
        {
            textBox_ID.Clear();
            textBox_Score.Clear();
            textBox_Description.Clear();

            comboBox_selectCourse.SelectedIndex = -1;

        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }


        private void dataGridView_ManageScore_Click(object sender, EventArgs e)
        {

        }

        private void dtaGridView_ManageScre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_manageCourse.Rows[e.RowIndex];

                textBox_ID.Text = row.Cells[0].Value.ToString();


                comboBox_selectCourse.Text = row.Cells[3].Value.ToString();

                textBox_Score.Text = row.Cells[4].Value.ToString();

                textBox_Description.Text = row.Cells[5].Value.ToString();
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            int filter = 2;

            if (radioButton_Active.Checked)
            {
                filter = 1;
            }
            else if (radioButton_Deleted.Checked)
            {
                filter = 0;
            }

            dataGridView_manageCourse.DataSource = scoreClass.SearchScore(textBox_search.Text, filter);
            clearFields();
        }
    }
}

