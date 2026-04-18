using DGVPrinterHelper;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;



namespace SIMS3
{
    public partial class PrintStudent : Form
    {
        StudentClass student = new StudentClass();
        CourseClass course = new CourseClass();
        DGVPrinter printer = new DGVPrinter();
        public PrintStudent()
        {
            InitializeComponent();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        public void showData(MySqlCommand command)
        {

            // 1. Change the query to ONLY select active students (IsActive = 1)
            string studentQuery = "SELECT * FROM `student` WHERE `IsActive` = 1";
            dataGridView_Student.DataSource = student.getStudentlist(new MySqlCommand(studentQuery));

            // 2. Hide the IsActive column so it doesn't show up on the screen/printout
            // Note: Make sure "dataGridView_Student" matches the actual name of your grid!
            dataGridView_Student.Columns["IsActive"].Visible = false;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            dataGridView_Student.DataSource = student.getlist(command);

            imageColumn = (DataGridViewImageColumn)dataGridView_Student.Columns[9];

            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dataGridView_Student.BackgroundColor = Color.FromArgb(34, 40, 64); // Slightly lighter than the background
            dataGridView_Student.GridColor = Color.FromArgb(50, 60, 90);      // Visible but soft grid lines

            // 2. The Header - Let's make it stand out with a lighter Slate Blue
            dataGridView_Student.EnableHeadersVisualStyles = false;
            dataGridView_Student.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94); // Light Slate Blue
            dataGridView_Student.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Student.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView_Student.ColumnHeadersHeight = 40;

            // 3. The Rows - Lighter Navy so the text is easier to read
            dataGridView_Student.DefaultCellStyle.BackColor = Color.FromArgb(44, 51, 80); // Lighter navy row
            dataGridView_Student.DefaultCellStyle.ForeColor = Color.FromArgb(224, 224, 224); // Off-white text (easier on eyes)

            // 4. Alternating Rows - This adds "Zebra Stripes" to make it look much more modern
            dataGridView_Student.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(37, 43, 68);

            // 5. Selection Color - A nice highlight color
            dataGridView_Student.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 120, 180); // Bright selection blue
            dataGridView_Student.DefaultCellStyle.SelectionForeColor = Color.White;

            // Optional: Hide the little row header arrow column on the far left to make it cleaner
            dataGridView_Student.RowHeadersVisible = false;

            dataGridView_Student.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 2. Center all the text inside every single cell in the grid
            dataGridView_Student.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }

        private void PrintStudent_Load(object sender, EventArgs e)
        {

           //populate the combobox with courses name
            comboBox1.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            comboBox1.DisplayMember = "CourseName";
            comboBox1.ValueMember = "CourseName";
        

            showData(new MySqlCommand("SELECT * FROM `student`"));

            clearFields();

        }

        //btnSearch forgot again to rename, but this is the search button for filtering the students based on the selected criteria
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM `student` WHERE `IsActive` = 1";
  
            if (radioButton_Male.Checked)
            {              
               query += " AND `Gender` = 'Male'";
            }
            else if (!radioButton_all.Checked)
            {        
                query += " AND `Gender` = 'Female'";
            }
        
            if (comboBox1.Text != "")
            {
                query += " AND `Student ID` IN (SELECT `Student ID` FROM `score` WHERE `CourseName` = @cName)";
            }

            MySqlCommand command = new MySqlCommand(query);

            if (comboBox1.Text != "")
            {
                command.Parameters.AddWithValue("@cName", comboBox1.Text);
            }

            showData(command);

            clearFields();

        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            //We need DGVprinter helper for print pdf file
            printer.Title = "SIMS Student List";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "SIMS3";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView_Student);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearFields()
        {
            comboBox1.SelectedIndex = -1;
            radioButton_all.Checked = false;
            radioButton_Male.Checked = false;
            radioButton_Female.Checked = false;
        }

    }
}
