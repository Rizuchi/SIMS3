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
    public partial class PrintScoreForm : Form
    {
        ScoreClass score = new ScoreClass();
       DGVPrinter printer = new DGVPrinter();
        public PrintScoreForm()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            dataGridView_Score.DataSource = score.SearchScore(textBox_search.Text, 1);
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            printer.Title = "SIMS Student Score List";

         
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

            printer.PrintDataGridView(dataGridView_Score);

        }

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            showScore();
        }
        private void showScore()
        {
            string query = "SELECT score.`Student ID` AS `Student ID`, student.FirstName AS `First Name`, student.LastName AS `Last Name`, score.CourseName AS `CourseName`, score.Score, score.Description FROM score INNER JOIN student ON score.`Student ID` = student.`Student ID` WHERE score.IsActive = 1 ORDER BY score.`Score ID` DESC";

            dataGridView_Score.DataSource = score.getlist(new MySqlCommand(query));


            dataGridView_Score.BackgroundColor = Color.FromArgb(34, 40, 64); 
            dataGridView_Score.GridColor = Color.FromArgb(50, 60, 90);      

            // 2. The Header - Let's make it stand out with a lighter Slate Blue
            dataGridView_Score.EnableHeadersVisualStyles = false;
            dataGridView_Score.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94); // Light Slate Blue
            dataGridView_Score.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Score.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView_Score.ColumnHeadersHeight = 40;

            // 3. The Rows - Lighter Navy so the text is easier to read
            dataGridView_Score.DefaultCellStyle.BackColor = Color.FromArgb(44, 51, 80); // Lighter navy row
            dataGridView_Score.DefaultCellStyle.ForeColor = Color.FromArgb(224, 224, 224); // Off-white text (easier on eyes)
            // 4. Alternating Rows - This adds "Zebra Stripes" to make it look much more modern
            dataGridView_Score.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(37, 43, 68);

            // 5. Selection Color - A nice highlight color
            dataGridView_Score.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 120, 180); // Bright selection blue
            dataGridView_Score.DefaultCellStyle.SelectionForeColor = Color.White;

            // Optional: Hide the little row header arrow column on the far left to make it cleaner
            dataGridView_Score.RowHeadersVisible = false;
            dataGridView_Score.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 2. Center all the text inside every single cell in the grid
            dataGridView_Score.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
