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
            dataGridView_Student.DataSource = student.getStudentlist(command);
            dataGridView_Student.Columns["IsActive"].Visible = false;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView_Student.Columns[9];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            imageColumn = (DataGridViewImageColumn)dataGridView_Student.Columns[9];

            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dataGridView_Student.BackgroundColor = Color.FromArgb(34, 40, 64);
            dataGridView_Student.GridColor = Color.FromArgb(50, 60, 90);


            dataGridView_Student.EnableHeadersVisualStyles = false;
            dataGridView_Student.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dataGridView_Student.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Student.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView_Student.ColumnHeadersHeight = 40;


            dataGridView_Student.DefaultCellStyle.BackColor = Color.FromArgb(44, 51, 80);
            dataGridView_Student.DefaultCellStyle.ForeColor = Color.FromArgb(224, 224, 224);


            dataGridView_Student.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(37, 43, 68);


            dataGridView_Student.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 120, 180);
            dataGridView_Student.DefaultCellStyle.SelectionForeColor = Color.White;


            dataGridView_Student.RowHeadersVisible = false;

            dataGridView_Student.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 2. Center all the text inside every single cell in the grid
            dataGridView_Student.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }

        private void PrintStudent_Load(object sender, EventArgs e)
        {
            MySqlCommand defaultCommand = new MySqlCommand("SELECT * FROM `student` WHERE `IsActive` = 1 ORDER BY `Student ID` DESC");

            showData(defaultCommand);

            //populate the combobox with courses name
            comboBox1.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            comboBox1.DisplayMember = "CourseName";
            comboBox1.ValueMember = "CourseName";


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
            else if (radioButton_Female.Checked)
            {
                query += " AND `Gender` = 'Female'";
            }

            if (!string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                query += " AND `Student ID` IN (SELECT `Student ID` FROM `score` WHERE TRIM(`CourseName`) = TRIM(@cName) AND `IsActive` = 1)";
            }

            MySqlCommand command = new MySqlCommand(query);

            if (!string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                command.Parameters.AddWithValue("@cName", comboBox1.Text.Trim());
            }

            showData(command);

            clearFields();

        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            printer.Title = "SIMS Student List";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToString("MMMM dd, yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.RowHeight = DGVPrinter.RowHeightSetting.CellHeight;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "SIMS3";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.printDocument.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(30, 30, 30, 30);
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

        private void radioButton_all_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
