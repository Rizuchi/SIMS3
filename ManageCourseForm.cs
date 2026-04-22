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
        private int currentDbId = -1;
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

            dataGridView_Course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course` WHERE `IsActive` = 1 ORDER BY `Course ID` DESC"));
            dataGridView_Course.Columns["CourseUnits"].DefaultCellStyle.Format = "0.0";
            dataGridView_Course.BackgroundColor = Color.FromArgb(34, 40, 64);
            dataGridView_Course.GridColor = Color.FromArgb(50, 60, 90);

            dataGridView_Course.EnableHeadersVisualStyles = false;
            dataGridView_Course.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dataGridView_Course.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Course.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView_Course.ColumnHeadersHeight = 40;

            dataGridView_Course.DefaultCellStyle.BackColor = Color.FromArgb(44, 51, 80);
            dataGridView_Course.DefaultCellStyle.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridView_Course.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(37, 43, 68);

            dataGridView_Course.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 120, 180);
            dataGridView_Course.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridView_Course.RowHeadersVisible = false;
            dataGridView_Course.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_Course.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }



        private void clear()
        {
            textBox_Subject.Clear();
            textBox_Hourse.Clear();
            textBox_units.Clear();
            textBox_department.Clear();
            textBox_Description.Clear();
            textBox_ID.Clear();
            textBox_search.Clear();
            radioButton_Deleted.Checked = false;
            radioButton_Active.Checked = false;
            radioButton_All.Checked = false;
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (currentDbId == -1 || currentDbId == 0)
            {
                MessageBox.Show("Please select a course from the table first.", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = currentDbId;


                string cCode = textBox_ID.Text.Trim();
                string cName = textBox_Subject.Text.Trim();
                string dept = textBox_department.Text.Trim();
                string desc = textBox_Description.Text.Trim();

                string hourInput = textBox_Hourse.Text.ToLower().Replace("hrs", "").Trim();
                double chr = Convert.ToDouble(hourInput);
                double units = Convert.ToDouble(textBox_units.Text.Trim());


                if (string.IsNullOrWhiteSpace(cCode) || string.IsNullOrWhiteSpace(cName) || string.IsNullOrWhiteSpace(dept))
                {
                    MessageBox.Show("Please fill in all required fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (course.updateCourse(id, cCode, cName, chr, units, dept, desc))
                {
                    MessageBox.Show("Course updated successfully!", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    button_Clear.PerformClick();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure Hours and Units contain valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (currentDbId == -1 || currentDbId == 0)
            {
                MessageBox.Show("Please select a course from the table to delete.", "Select Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this course?", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int id = currentDbId;

                    if (course.deleteCourse(id))
                    {
                        MessageBox.Show("Course deleted (deactivated) successfully!", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                        clear();
                        currentDbId = 0;
                    }
                    else
                    {
                        MessageBox.Show("Course not deleted.", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
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

            dataGridView_Course.DataSource = course.SearchCourse(textBox_search.Text, filter);
            clear();
        }

        private void dataGridview_Manage_Clcik(object sender, EventArgs e)
        {
            if (dataGridView_Course.CurrentRow == null) return;
            currentDbId = Convert.ToInt32(dataGridView_Course.CurrentRow.Cells[0].Value);
            textBox_ID.Text = dataGridView_Course.CurrentRow.Cells[1].Value.ToString();
            textBox_Subject.Text = dataGridView_Course.CurrentRow.Cells[2].Value.ToString();
            textBox_Hourse.Text = dataGridView_Course.CurrentRow.Cells[3].Value.ToString() + " hrs";
            textBox_units.Text = dataGridView_Course.CurrentRow.Cells[4].Value.ToString();
            textBox_department.Text = dataGridView_Course.CurrentRow.Cells[5].Value.ToString();
            textBox_Description.Text = dataGridView_Course.CurrentRow.Cells[6].Value.ToString();
        }

        private void textBox_Hourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_units_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void radioButton_All_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_Active_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_Deleted_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}


