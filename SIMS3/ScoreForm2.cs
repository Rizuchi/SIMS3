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

            dataGridView_score1.DataSource = scoreClass.getlist(new MySqlCommand("SELECT * FROM `score`"));
            dataGridView_score1.Columns["IsActive"].Visible = false;

            dataGridView_score1.BackgroundColor = Color.FromArgb(34, 40, 64);
            dataGridView_score1.GridColor = Color.FromArgb(50, 60, 90);

            // 2. The Header - Let's make it stand out with a lighter Slate Blue
            dataGridView_score1.EnableHeadersVisualStyles = false;
            dataGridView_score1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94); // Light Slate Blue
            dataGridView_score1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_score1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView_score1.ColumnHeadersHeight = 40;

            // 3. The Rows - Lighter Navy so the text is easier to read
            dataGridView_score1.DefaultCellStyle.BackColor = Color.FromArgb(44, 51, 80); // Lighter navy row
            dataGridView_score1.DefaultCellStyle.ForeColor = Color.FromArgb(224, 224, 224); // Off-white text (easier on eyes)
                                                                                            // 4. Alternating Rows - This adds "Zebra Stripes" to make it look much more modern
            dataGridView_score1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(37, 43, 68);

            // 5. Selection Color - A nice highlight color
            dataGridView_score1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 120, 180); // Bright selection blue
            dataGridView_score1.DefaultCellStyle.SelectionForeColor = Color.White;

            // Optional: Hide the little row header arrow column on the far left to make it cleaner
            dataGridView_score1.RowHeadersVisible = false;
            dataGridView_score1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 2. Center all the text inside every single cell in the grid
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
            dataGridView_score1.DataSource = student.getlist(new MySqlCommand("SELECT `Student ID`, `FirstName`, `MiddleName`, `LastName`, `Suffix` FROM `student`"));
            dataGridView_score1.BackgroundColor = Color.FromArgb(34, 40, 64); // Slightly lighter than the background
            dataGridView_score1.GridColor = Color.FromArgb(50, 60, 90);      // Visible but soft grid lines

            // 2. The Header - Let's make it stand out with a lighter Slate Blue
            dataGridView_score1.EnableHeadersVisualStyles = false;
            dataGridView_score1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94); // Light Slate Blue
            dataGridView_score1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_score1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView_score1.ColumnHeadersHeight = 40;

            // 3. The Rows - Lighter Navy so the text is easier to read
            dataGridView_score1.DefaultCellStyle.BackColor = Color.FromArgb(44, 51, 80); // Lighter navy row
            dataGridView_score1.DefaultCellStyle.ForeColor = Color.FromArgb(224, 224, 224); // Off-white text (easier on eyes)
                                                                                            // 4. Alternating Rows - This adds "Zebra Stripes" to make it look much more modern
            dataGridView_score1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(37, 43, 68);

            // 5. Selection Color - A nice highlight color
            dataGridView_score1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 120, 180); // Bright selection blue
            dataGridView_score1.DefaultCellStyle.SelectionForeColor = Color.White;

            // Optional: Hide the little row header arrow column on the far left to make it cleaner
            dataGridView_score1.RowHeadersVisible = false;
            dataGridView_score1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 2. Center all the text inside every single cell in the grid
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
                // 2. Gather all the data from your inputs
                // Assuming your combobox is named comboBox_course based on your Form_Load code
                int stdId = Convert.ToInt32(textBox_ID.Text);
                string cName = comboBox_selectCourse.Text;
                double score = Convert.ToDouble(textBox_Score.Text);
                string desc = textBox_description.Text;

                // 3. CHECK IF THE SCORE ALREADY EXISTS FIRST
                if (!scoreClass.checkScore(stdId, cName))
                {
                    // 4. IF IT DOES NOT EXIST, INSERT IT
                    // (Note: using your exact method name 'insertCourse' from the screenshot)
                    if (scoreClass.insertCourse(stdId, cName, score, desc))
                    {
                        MessageBox.Show("New score inserted successfully!", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        showScore();
                        clearFields();
                    }
                    else
                    {
                        // Always good to have an error message if the insert fails!
                        MessageBox.Show("Score not inserted.", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // 5. IF IT ALREADY EXISTS, SHOW THIS WARNING INSTEAD
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
            // 1. Clear all the typing boxes
            textBox_ID.Clear();
            textBox_Score.Clear();
            textBox_description.Clear();

            // 2. Reset the dropdown menu so nothing is selected
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
            textBox_ID.Text = dataGridView_score1.CurrentRow.Cells[0].Value.ToString();

        }

        private void comboBox_selectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
