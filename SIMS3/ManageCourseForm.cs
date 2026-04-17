using Microsoft.VisualBasic.Devices;
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
    public partial class ManageCourseForm : Form
    {
        CourseClass course = new CourseClass();
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            showData();
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

        private void button_Clear_Click(object sender, EventArgs e)
        {
            // Optional: clear the boxes after a successful save
            textBox_Subject.Clear();
            textBox_Hourse.Clear();
            textBox_units.Clear();
            textBox_department.Clear();
            textBox_Description.Clear();
            textBox_ID.Clear();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text == "" || textBox_Subject.Text == "" || textBox_Hourse.Text == "" || textBox_units.Text == "" || textBox_department.Text == "")
            {
                MessageBox.Show("Please fill in all required course data.", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Gather all the data
            int id = Convert.ToInt32(textBox_ID.Text);

            string cName = textBox_Subject.Text;

            // clean "3hrs"
            string hourInput = textBox_Hourse.Text.ToLower().Replace("hrs", "").Trim();
            double chr = Convert.ToDouble(hourInput);

            double units = Convert.ToDouble(textBox_units.Text);
            string dept = textBox_department.Text;
            string desc = textBox_Description.Text;

            // 3. Call UPDATE instead of INSERT
            button_Clear.PerformClick();
            if (course.updateCourse(id, cName, chr, units, dept, desc))
            {
                MessageBox.Show("Course updated successfully!", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                showData();

            }
            else
            {
                MessageBox.Show("Course not updated.", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_ID.Text);

            if (course.deleteCourse(id))
            {
                MessageBox.Show("Course deleted (deactivated) successfully!", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // THIS IS THE MAGIC LINE: It reloads the grid so the checkbox actually disappears!
                showData();

                // Optional: clear the textboxes after deleting
                button_Clear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Course not deleted.", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            dataGridView_Course.DataSource = course.SearchCourse(textBox_search.Text);
        }

        private void dataGridView_Course_Click(object sender, EventArgs e)
        {
            // Safety check: Make sure a row is actually selected before trying to read it
            if (dataGridView_Course.CurrentRow == null) return;

            // 0: CourseId -> textBox_ID
            textBox_ID.Text = dataGridView_Course.CurrentRow.Cells[0].Value.ToString();

            // 1: CourseName -> textBox_Subject
            textBox_Subject.Text = dataGridView_Course.CurrentRow.Cells[1].Value.ToString();

            // 2: CourseHour -> textBox_Hourse
            // Adding " hrs" to match your previous formatting if desired, 
            // or just leave it as the number since your update code cleans it anyway!
            textBox_Hourse.Text = dataGridView_Course.CurrentRow.Cells[2].Value.ToString() + " hrs";

            // 3: CourseUnits -> textBox_units
            dataGridView_Course.Columns["CourseUnits"].DefaultCellStyle.Format = "F1";
            textBox_units.Text = dataGridView_Course.CurrentRow.Cells[3].Value.ToString();

            // 4: Department -> textBox_department
            textBox_department.Text = dataGridView_Course.CurrentRow.Cells[4].Value.ToString();

            // 5: Description -> textBox_Description
            textBox_Description.Text = dataGridView_Course.CurrentRow.Cells[5].Value.ToString();
        }

       
     }
}


