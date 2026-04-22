using DGVPrinterHelper;
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
    public partial class PrintCourseForm : Form
    {
        CourseClass course = new CourseClass();
        DGVPrinter printer = new DGVPrinter();
        public PrintCourseForm()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView_Course.DataSource = course.SearchCourse(textBox_search.Text, 1);
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            printer.Title = "SIMS Course List";

          
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToString("MMMM dd, yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.RowHeight = DGVPrinter.RowHeightSetting.CellHeight;

            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "SIMS";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;

           
            printer.printDocument.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(30, 30, 30, 30);

            printer.PrintDataGridView(dataGridView_Course);
        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            dataGridView_Course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            ApplyGridStyle();
        }

        private void ApplyGridStyle()
        {
            string courseQuery = "SELECT * FROM `course` WHERE `IsActive` = 1 ORDER BY `Course ID` DESC";
dataGridView_Course.DataSource = course.getCourse(new MySqlCommand(courseQuery));

            dataGridView_Course.BackgroundColor = Color.FromArgb(34, 40, 64); 
            dataGridView_Course.GridColor = Color.FromArgb(50, 60, 90);      

            dataGridView_Course.EnableHeadersVisualStyles = false;
            dataGridView_Course.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94); // Light Slate Blue
            dataGridView_Course.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Course.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView_Course.ColumnHeadersHeight = 40;

            dataGridView_Course.DefaultCellStyle.BackColor = Color.FromArgb(44, 51, 80); // Lighter navy row
            dataGridView_Course.DefaultCellStyle.ForeColor = Color.FromArgb(224, 224, 224); 
            dataGridView_Course.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(37, 43, 68);

            dataGridView_Course.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 120, 180); 
            dataGridView_Course.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridView_Course.RowHeadersVisible = false;
            //column sizez
            dataGridView_Course.Columns["Course ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_Course.Columns["CourseHour"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_Course.Columns["CourseUnits"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_Course.Columns["IsActive"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; 
            dataGridView_Course.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView_Course.Columns["CourseUnits"].DefaultCellStyle.Format = "0.0";
            dataGridView_Course.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_Course.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
    }
}
