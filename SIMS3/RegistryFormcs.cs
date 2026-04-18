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
        public RegistryFormcs()
        {
            InitializeComponent();
        }

        private void button_AddStudent_Click(object sender, EventArgs e)
        {
            string fname = textBox_fname.Text;
            string mname = textBox_Mname.Text;   
            string lname = textBox_LName.Text;
            string suffix = textBox_Sufix.Text; 
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBox_Number.Text;
            string address = textBox_Address.Text;
            string gender = radioButton_Male.Checked ? "Male" : "Female";

            if (pictureBox_Student.Image == null)
            {
                MessageBox.Show("Please upload a student photo before adding.", "Missing Photo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
 
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                pictureBox_Student.Image.Save(ms, pictureBox_Student.Image.RawFormat);
                byte[] img = ms.ToArray();

               
                int born_year = dateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;

                if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
                {
                    MessageBox.Show("The student age must be between 10 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verify())
                {
                  
                    if (student.insertStudent(fname, mname, lname, suffix, bdate, gender, phone, address, img))
                    {
                        showTable();
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error - Student Don't add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
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


        // create a function to verify
        bool verify()
        {
            if ((textBox_fname.Text == "") || (textBox_LName.Text == "") ||
                (textBox_Number.Text == "") || (textBox_Address.Text == "") ||
                (pictureBox_Student.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void button_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif*) |*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_Student.Image = Image.FromFile(opf.FileName);

        }


        public void showTable()
        {
            // Loads the data from your database into the grid
            dataGridView_Student.DataSource = student.getStudentlist(new MySqlCommand("SELECT * FROM `student`"));
            dataGridView_Student.Columns["IsActive"].Visible = false;

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();

            // ⚠️ CHANGED TO [9] to account for Middle Name and Suffix pushing the Photo column over!
            imageColumn = (DataGridViewImageColumn)dataGridView_Student.Columns[9];

            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView_Student.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView_Student.BackgroundColor = Color.FromArgb(34, 40, 64);
            dataGridView_Student.GridColor = Color.FromArgb(50, 60, 90);     

            // 2. The Header - Let's make it stand out with a lighter Slate Blue
            dataGridView_Student.EnableHeadersVisualStyles = false;
            dataGridView_Student.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94); 
            dataGridView_Student.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Student.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView_Student.ColumnHeadersHeight = 40;

            // 3. The Rows - Lighter Navy so the text is easier to read
            dataGridView_Student.DefaultCellStyle.BackColor = Color.FromArgb(44, 51, 80); 
            dataGridView_Student.DefaultCellStyle.ForeColor = Color.FromArgb(224, 224, 224); 

            // 4. Alternating Rows - This adds "Zebra Stripes" to make it look much more modern
            dataGridView_Student.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(37, 43, 68);

            // 5. Selection Color - A nice highlight color
            dataGridView_Student.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 120, 180); 
            dataGridView_Student.DefaultCellStyle.SelectionForeColor = Color.White;

            // Optional: Hide the little row header arrow column on the far left to make it cleaner
            dataGridView_Student.RowHeadersVisible = false;
            dataGridView_Student.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 2. Center all the text inside every single cell in the grid
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