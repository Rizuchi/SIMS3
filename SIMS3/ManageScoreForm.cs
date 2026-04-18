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
                // 1. Gather all the data from your inputs
                int stdId = Convert.ToInt32(textBox_ID.Text);
                string cName = comboBox_selectCourse.Text;
                double score = Convert.ToDouble(textBox_Score.Text);
                string desc = textBox_Description.Text;

                // 2. Call the updateScore method directly
                if (scoreClass.updateScore(stdId, cName, score, desc))
                {
                    // 3. Success Message
                    MessageBox.Show("Score updated successfully!", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 4. Refresh the table and clear the form
                    showScore();
                    clearFields();
                }
                else
                {
                    // If the update fails (for example, if they try to update a score that doesn't exist yet)
                    MessageBox.Show("Score not updated. Make sure this student already has a grade registered for this course.", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // This catches errors like typing "A+" into the Score box instead of a number
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            // 1. Safety check
            if (textBox_ID.Text == "" || comboBox_selectCourse.Text == "")
            {
                MessageBox.Show("Please select a score to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete this score?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int stdId = Convert.ToInt32(textBox_ID.Text);
                    string cName = comboBox_selectCourse.Text;

                    // 3. Run the soft delete
                    if (scoreClass.deleteScore(stdId, cName))
                    {
                        MessageBox.Show("Score deleted successfully!", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh your grid to see the checkbox uncheck!
                        showScore();

                        // Optional: clear fields
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
            string query = "SELECT score.`Student ID` AS `Student ID`, student.FirstName AS `First Name`, student.LastName AS `Last Name`, score.CourseName AS `CourseName`, score.Score, score.Description, score.IsActive FROM score INNER JOIN student ON score.`Student ID` = student.`Student ID`";

            dataGridView_manageCourse.DataSource = scoreClass.getlist(new MySqlCommand(query));

            dataGridView_manageCourse.BackgroundColor = Color.FromArgb(34, 40, 64); // Slightly lighter than the background
            dataGridView_manageCourse.GridColor = Color.FromArgb(50, 60, 90);      // Visible but soft grid lines

            // 2. The Header - Let's make it stand out with a lighter Slate Blue
            dataGridView_manageCourse.EnableHeadersVisualStyles = false;
            dataGridView_manageCourse.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94); // Light Slate Blue
            dataGridView_manageCourse.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_manageCourse.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView_manageCourse.ColumnHeadersHeight = 40;

            // 3. The Rows - Lighter Navy so the text is easier to read
            dataGridView_manageCourse.DefaultCellStyle.BackColor = Color.FromArgb(44, 51, 80); // Lighter navy row
            dataGridView_manageCourse.DefaultCellStyle.ForeColor = Color.FromArgb(224, 224, 224); // Off-white text (easier on eyes)
            // 4. Alternating Rows - This adds "Zebra Stripes" to make it look much more modern
            dataGridView_manageCourse.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(37, 43, 68);

            // 5. Selection Color - A nice highlight color
            dataGridView_manageCourse.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 120, 180); // Bright selection blue
            dataGridView_manageCourse.DefaultCellStyle.SelectionForeColor = Color.White;

            // Optional: Hide the little row header arrow column on the far left to make it cleaner
            dataGridView_manageCourse.RowHeadersVisible = false;
            dataGridView_manageCourse.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 2. Center all the text inside every single cell in the grid
            dataGridView_manageCourse.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void clearFields()
        {
            // 1. Clear all the typing boxes
            textBox_ID.Clear();
            textBox_Score.Clear();
            textBox_Description.Clear();

            // 2. Reset the dropdown menu so nothing is selected
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

                // Column 0 is Student ID
                textBox_ID.Text = row.Cells[0].Value.ToString();

                // Columns 1 and 2 are FirstName and LastName. We skip those!

                // Column 3 is CourseName
                comboBox_selectCourse.Text = row.Cells[3].Value.ToString();

                // Column 4 is Score
                textBox_Score.Text = row.Cells[4].Value.ToString();

                // Column 5 is Description
                textBox_Description.Text = row.Cells[5].Value.ToString();
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            // Change the grid name to match your actual Manage Score grid!
            dataGridView_manageCourse.DataSource = scoreClass.SearchScore(textBox_search.Text);
        }
    }
}

