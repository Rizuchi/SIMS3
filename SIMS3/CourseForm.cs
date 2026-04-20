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
            string cCode = courseCode.Text.Trim();
            string cName = textBox_Subject.Text.Trim();
            string dept = textBox_department.Text.Trim();
            string desc = textBox_Description.Text.Trim();
            string hourInput = textBox_Hourse.Text.ToLower().Replace("hrs", "").Trim();
            string unitsInput = textBox_units.Text.Trim();

   
            if (string.IsNullOrWhiteSpace(cCode) || string.IsNullOrWhiteSpace(cName) ||
                string.IsNullOrWhiteSpace(hourInput) || string.IsNullOrWhiteSpace(unitsInput) ||
                string.IsNullOrWhiteSpace(dept))
            {
                MessageBox.Show("Please fill in all required course data.", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                double chr = Convert.ToDouble(hourInput);
                double units = Convert.ToDouble(unitsInput);

       
                if (course.insertCourse(cCode, cName, chr, units, dept, desc))
                {
                    MessageBox.Show("New course inserted successfully!", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData(); // This will now show the course since IsActive = 1!
                    clear();
                }
                else
                {
                    MessageBox.Show("Course not inserted due to a database error.", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }



        private void clear()
        {
            textBox_Subject.Clear();
            textBox_Hourse.Clear();
            textBox_units.Clear();
            textBox_department.Clear();
            textBox_Description.Clear();
            courseCode.Clear();
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }


        public void showData()
        {
            dataGridView_Course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course` ORDER BY `Course ID` DESC"));
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

        private void CourseForm_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void textbox_CourseUnits_Keypress(object sender, KeyPressEventArgs e)
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

        private void textbox_Hours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

