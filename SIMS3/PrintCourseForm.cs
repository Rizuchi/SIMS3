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
            dataGridView_Course.DataSource = course.SearchCourse(textBox_search.Text);
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            //We need DGVprinter helper for print pdf file
            printer.Title = "SIMS Course List";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "SIMS";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView_Course);
        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            dataGridView_Course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            ApplyGridStyle();
        }

        private void ApplyGridStyle()
        {
            string courseQuery = "SELECT * FROM `course` WHERE `IsActive` = 1";
            dataGridView_Course.DataSource = course.getCourse(new MySqlCommand(courseQuery));

            // 2. Hide the IsActive column
            // Note: Make sure "dataGridView_course" matches the actual name of your grid!
            dataGridView_Course.Columns["IsActive"].Visible = false;
            // 1. General Grid Appearance
            dataGridView_Course.BackgroundColor = Color.FromArgb(34, 40, 64); // Slightly lighter than the background
            dataGridView_Course.GridColor = Color.FromArgb(50, 60, 90);       // Visible but soft grid lines

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
            //column sizez
            dataGridView_Course.Columns["Course ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_Course.Columns["CourseHour"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_Course.Columns["CourseUnits"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_Course.Columns["IsActive"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Added IsActive!
            // 3. Force the Description column to take up all the remaining leftover space
            dataGridView_Course.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // 4. Force the number columns to always show one decimal place (e.g., 3.0)
            dataGridView_Course.Columns["CourseUnits"].DefaultCellStyle.Format = "0.0";
            dataGridView_Course.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 2. Center all the text inside every single cell in the grid
            dataGridView_Course.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
    }
}
