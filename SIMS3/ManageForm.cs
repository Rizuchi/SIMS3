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
    public partial class ManageForm : Form
    {
        StudentClass student = new StudentClass();
        public ManageForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            // Loads the data from your database into the grid
            dataGridView_Student.DataSource = student.searchStudent(textBox_search.Text);

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();

            // ⚠️ CHANGED TO [9] to account for Middle Name and Suffix pushing the Photo column over!
            imageColumn = (DataGridViewImageColumn)dataGridView_Student.Columns[9];

            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        public void showTable()
        {
            // Loads the data from your database into the grid
            dataGridView_Student.DataSource = student.getStudentlist(new MySqlCommand("SELECT * FROM `student`"));

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();

            // ⚠️ CHANGED TO [9] to account for Middle Name and Suffix pushing the Photo column over!
            imageColumn = (DataGridViewImageColumn)dataGridView_Student.Columns[9];

            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView_Student.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

        private void button_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif*) |*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_Student.Image = Image.FromFile(opf.FileName);
        }

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

        //updatebutton forgot to rename
        private void button_AddStudent_Click(object sender, EventArgs e)
        {
            // 1. GRAB THE ID (This is crucial for updating!)
            int id = Convert.ToInt32(textBox_ID.Text);

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
                MessageBox.Show("Please upload a student photo before updating.", "Missing Photo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // to get photo from picture box
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                pictureBox_Student.Image.Save(ms, pictureBox_Student.Image.RawFormat);
                byte[] img = ms.ToArray();

                // we need to check student age between 10 and 100
                int born_year = dateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;

                if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
                {
                    MessageBox.Show("The student age must be between 10 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verify())
                {
                    // 2. CALL updateStudent AND PASS THE ID
                    if (student.updateStudent(id, fname, mname, lname, suffix, bdate, gender, phone, address, img))
                    {
                        showTable();
                        // Changed the message boxes to say "Updated" instead of "Added"
                        MessageBox.Show("Student Data Updated Successfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error - Student Data Not Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            // Clears the radio buttons (unchecks both)
            radioButton_Male.Checked = false;
            radioButton_Female.Checked = false; // Double-check this name matches your properties!

            // Clears the photo
            pictureBox_Student.Image = null;

            // Resets the date picker to today's date
            dateTimePicker1.Value = DateTime.Now;
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void dataGridView_student_Click(object sender, EventArgs e)
        {
            // 0: Student ID
            textBox_ID.Text = dataGridView_Student.CurrentRow.Cells[0].Value.ToString();

            // 1: First Name
            textBox_fname.Text = dataGridView_Student.CurrentRow.Cells[1].Value.ToString();

            // 2: Middle Name (Your modification!)
            textBox_Mname.Text = dataGridView_Student.CurrentRow.Cells[2].Value.ToString();

            // 3: Last Name (Shifted due to Middle Name)
            textBox_LName.Text = dataGridView_Student.CurrentRow.Cells[3].Value.ToString();

            // 4: Suffix (Your modification!)
            textBox_Sufix.Text = dataGridView_Student.CurrentRow.Cells[4].Value.ToString();

            // 5: Birthdate 
            dateTimePicker1.Value = (DateTime)dataGridView_Student.CurrentRow.Cells[5].Value;

            // 6: Gender 
            if (dataGridView_Student.CurrentRow.Cells[6].Value.ToString() == "Male")
            {
                radioButton_Male.Checked = true;
            }
            else
            {
                // It's good practice to make sure the female button gets checked if it's not male!
                radioButton_Female.Checked = true;
            }

            // 7: Phone 
            textBox_Number.Text = dataGridView_Student.CurrentRow.Cells[7].Value.ToString();

            // 8: Address 
            textBox_Address.Text = dataGridView_Student.CurrentRow.Cells[8].Value.ToString();

            // 9: Photo 
            byte[] img = (byte[])dataGridView_Student.CurrentRow.Cells[9].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox_Student.Image = Image.FromStream(ms);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // Assuming the text box for ID Number is named textBox_IDNumber
            if (textBox_ID.Text == "")
            {
                MessageBox.Show("Please select a student to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(textBox_ID.Text);

            // Confirmation (VERY IMPORTANT)
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Assuming your student class instance is named 'student'
                if (student.softDeleteStudent(id))
                {
                    MessageBox.Show("Student deleted successfully!", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showTable();

                    // Clear all fields shown in the UI
                    textBox_fname.Clear();
                    textBox_Mname.Clear();
                    textBox_LName.Clear();
                    textBox_Sufix.Clear();
                    textBox_Number.Clear();
                    textBox_Address.Clear();
                    textBox_ID.Clear();

                    // Reset Gender radio buttons
                    radioButton_Female.Checked = false;
                    radioButton_Male.Checked = false;

                    // Reset Date of Birth to today
                    dateTimePicker1.Value = DateTime.Now;

                    // Clear the picture box
                    pictureBox_Student.Image = null;

                    // IMPORTANT: Call your method to refresh the DataGridView here 
                    // so the deleted student disappears from the list.
                    // Example: LoadStudentData(); 
                }
                else
                {
                    MessageBox.Show("Student not deleted.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
