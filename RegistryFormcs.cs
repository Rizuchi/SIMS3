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
    public partial class RegistryFormcs : Form
    {
        StudentClass student = new StudentClass();
        DBConnect connect = new DBConnect();
        public RegistryFormcs()
        {
            InitializeComponent();
           
        }

        private void button_AddStudent_Click(object sender, EventArgs e)
        {

            string fname = textBox_fname.Text.Trim();
            string mname = textBox_Mname.Text.Trim();
            string lname = textBox_LName.Text.Trim();
            string suffix = textBox_Sufix.Text.Trim();
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBox_Number.Text.Trim();
            string address = textBox_Address.Text.Trim();
            string gender = radioButton_Male.Checked ? "Male" : "Female";


            if (string.IsNullOrWhiteSpace(fname) ||
                string.IsNullOrWhiteSpace(lname) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please fill in all mandatory fields (First Name, Last Name, Phone, and Address).", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (pictureBox_Student.Image == null)
            {
                MessageBox.Show("Please upload a student photo before adding.", "Missing Photo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            // 1. Check the age
            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The student age must be between 10 and 100.", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

  
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                pictureBox_Student.Image.Save(ms, pictureBox_Student.Image.RawFormat);
                byte[] img = ms.ToArray();

                if (student.insertStudent(fname, mname, lname, suffix, bdate, gender, phone, address, img))
                {
                    showTable();
                    clear();
                    MessageBox.Show("New Student Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Database Error: Student was not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void clear() 
        {
            textBox_fname.Clear();
            textBox_Mname.Clear();
            textBox_LName.Clear();
            textBox_Sufix.Clear();
            textBox_Number.Clear();
            textBox_Address.Clear();
            radioButton_Male.Checked = false;
            radioButton_Female.Checked = false;
            pictureBox_Student.Image = null;
            dateTimePicker1.Value = DateTime.Now;

        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }


     
        private void button_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                using (var stream = new System.IO.FileStream(opf.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    pictureBox_Student.Image = Image.FromStream(stream);
                }
            }
        }


        public void showTable()
        {
            
            dataGridView_Student.DataSource = student.getStudentlist(new MySqlCommand("SELECT * FROM `student` WHERE `IsActive` = 1 ORDER BY `Student ID` DESC"));
            dataGridView_Student.Columns["IsActive"].Visible = false;

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();


            imageColumn = (DataGridViewImageColumn)dataGridView_Student.Columns[9];

            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView_Student.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

            dataGridView_Student.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void RegistryFormcs_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}