using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SIMS3
{
    public partial class CourseForm : Form
    {
        CourseClass course = new CourseClass();
        public CourseForm()
        {
            InitializeComponent();
        }

        //btn Subject button forgot to rename 
        private void button_AddStudent_Click(object sender, EventArgs e)
        {
            if (textBox_Subject.Text == "" || textBox_Hourse.Text == "" || textBox_units.Text == "" || textBox_department.Text == "")
            {
                MessageBox.Show("Please fill in all required course data.", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // "F1" means "Fixed-point with 1 decimal place" (e.g., 3.0, 4.5)
            dataGridView_Course.Columns["CourseUnits"].DefaultCellStyle.Format = "F1";
            // 2. Gather all the data from your textboxes
            string cName = textBox_Subject.Text;
            string hourInput = textBox_Hourse.Text.ToLower().Replace("hrs", "").Trim();
            double chr = Convert.ToDouble(hourInput);
            double units = Convert.ToDouble(textBox_units.Text);
            string dept = textBox_department.Text;
            string desc = textBox_Description.Text;

            // 3. Send the data to your updated CourseClass method
            if (course.insertCourse(cName, chr, units, dept, desc))
            {
                button_Clear.PerformClick();
                MessageBox.Show("New course inserted successfully!", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                showData();
            }
            else
            {
                MessageBox.Show("Course not inserted.", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            // Optional: clear the boxes after a successful save
            textBox_Subject.Clear();
            textBox_Hourse.Clear();
            textBox_units.Clear();
            textBox_department.Clear();
            textBox_Description.Clear();
        }


        public void showData()
        {
            dataGridView_Course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            dataGridView_Course.Columns["CourseUnits"].DefaultCellStyle.Format = "0.0";
            dataGridView_Course.BackgroundColor = Color.FromArgb(34, 40, 64); // Slightly lighter than the background
            dataGridView_Course.GridColor = Color.FromArgb(50, 60, 90);      // Visible but soft grid lines

            // 2. The Header - Let's make it stand out with a lighter Slate Blue
            dataGridView_Course.EnableHeadersVisualStyles = false;
            dataGridView_Course.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94); // Light Slate Blue
            dataGridView_Course.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Course.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView_Course.ColumnHeadersHeight = 40;

            // 3. The Rows - Lighter Navy so the text is easier to read
            dataGridView_Course.DefaultCellStyle.BackColor = Color.FromArgb(44, 51, 80); // Lighter navy row
            dataGridView_Course.DefaultCellStyle.ForeColor = Color.FromArgb(224, 224, 224); // Off-white text (easier on eyes)
            // 4. Alternating Rows - This adds "Zebra Stripes" to make it look much more modern
            dataGridView_Course.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(37, 43, 68);

            // 5. Selection Color - A nice highlight color
            dataGridView_Course.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 120, 180); // Bright selection blue
            dataGridView_Course.DefaultCellStyle.SelectionForeColor = Color.White;

            // Optional: Hide the little row header arrow column on the far left to make it cleaner
            dataGridView_Course.RowHeadersVisible = false;
            dataGridView_Course.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 2. Center all the text inside every single cell in the grid
            dataGridView_Course.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            showData();
        }
    }
}

