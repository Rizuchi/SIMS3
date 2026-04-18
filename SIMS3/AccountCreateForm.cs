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
    public partial class AccountCreateForm : Form
    {
        AccountClass teacherClass = new AccountClass();
        int currentTeacherId = 0;
        public AccountCreateForm()
        {
            InitializeComponent();
            
        }
        public void showTeacher()
        {
            // Make sure your DataGridView name matches exactly what is on your UI
            dataGridView_Teacher.DataSource = teacherClass.getlist(new MySqlCommand("SELECT * FROM `teacher_account`"));
            dataGridView_Teacher.BackgroundColor = Color.FromArgb(34, 40, 64); // Slightly lighter than the background
            dataGridView_Teacher.GridColor = Color.FromArgb(50, 60, 90);      // Visible but soft grid lines

            // 2. The Header - Let's make it stand out with a lighter Slate Blue
            dataGridView_Teacher.EnableHeadersVisualStyles = false;
            dataGridView_Teacher.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94); // Light Slate Blue
            dataGridView_Teacher.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Teacher.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView_Teacher.ColumnHeadersHeight = 40;

            // 3. The Rows - Lighter Navy so the text is easier to read
            dataGridView_Teacher.DefaultCellStyle.BackColor = Color.FromArgb(44, 51, 80); // Lighter navy row
            dataGridView_Teacher.DefaultCellStyle.ForeColor = Color.FromArgb(224, 224, 224); // Off-white text (easier on eyes)
            // 4. Alternating Rows - This adds "Zebra Stripes" to make it look much more modern
            dataGridView_Teacher.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(37, 43, 68);

            // 5. Selection Color - A nice highlight color
            dataGridView_Teacher.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 120, 180); // Bright selection blue
            dataGridView_Teacher.DefaultCellStyle.SelectionForeColor = Color.White;

            // Optional: Hide the little row header arrow column on the far left to make it cleaner
            dataGridView_Teacher.RowHeadersVisible = false;
            dataGridView_Teacher.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 2. Center all the text inside every single cell in the grid
            dataGridView_Teacher.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void clearFields()
        {
            textBox_fname.Clear();
            textBox_lname.Clear();
            textBox_username.Clear();
            textBox_password.Clear();
            textBox_department.Clear();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            dataGridView_Teacher.DataSource = teacherClass.searchTeacher(textBox_search.Text);
        }

        private void button_addAccount_Click(object sender, EventArgs e)
        {
            string fname = textBox_fname.Text;
            string lname = textBox_lname.Text;
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            string dept = textBox_department.Text;


            if (fname == "" || lname == "" || username == "" || password == "" || dept == "")
            {
                MessageBox.Show("Please fill in all the fields before adding an account.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (teacherClass.checkDuplicateUsername(username))
            {
                MessageBox.Show("This Username is already taken! Please choose a different one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (teacherClass.insertTeacher(fname, lname, username, password, dept))
            {
                MessageBox.Show("New Teacher Account added successfully!", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showTeacher();
                clearFields();
            }
            else
            {
                MessageBox.Show("Error adding the teacher account.", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (currentTeacherId == 0)
            {
                MessageBox.Show("Please select a teacher from the table to disable.", "Select Teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Ask for confirmation before disabling
            if (MessageBox.Show("Are you sure you want to disable this account?", "Disable Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // 3. Pass currentTeacherId to the disable function instead of the old 'id'
                if (teacherClass.disableAccount(currentTeacherId))
                {
                    MessageBox.Show("Account successfully disabled.", "Disable Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showTeacher();
                    clearFields();

                    // 4. Reset the memory variable back to 0 so they don't accidentally delete someone twice!
                    currentTeacherId = 0;
                }
                else
                {
                    MessageBox.Show("Error disabling account.", "Disable Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void AccountCreateForm_Load(object sender, EventArgs e)
        {
            clearFields();
            showTeacher();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (currentTeacherId == 0)
            {
                MessageBox.Show("Please select a teacher from the table first.", "Select Teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fname = textBox_fname.Text;
            string lname = textBox_lname.Text;
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            string dept = textBox_department.Text;

            // DUPLICATE CHECKER: Pass both the username AND their current ID
            // Notice how it now says 'currentTeacherId' at the end of this line!
            if (teacherClass.checkDuplicateUsername(username, currentTeacherId))
            {
                MessageBox.Show("This Username is already being used by another teacher! Please choose a different one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Since your update method already takes the password variable, whatever is in the text box right now will overwrite the old password!
            if (teacherClass.updateTeacher(currentTeacherId, fname, lname, username, password, dept))
            {
                MessageBox.Show("Teacher Account Updated Successfully!", "Update Account", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // We also want to reset the memory variable back to 0 after a successful update!
                currentTeacherId = 0;

                showTeacher();
                clearFields();
            }
            else
            {
                MessageBox.Show("Error updating teacher account.", "Update Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_Teacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_teacher_Click(object sender, EventArgs e)
        {
            if (dataGridView_Teacher.CurrentRow != null && dataGridView_Teacher.CurrentRow.Index != -1)
            {
              
                currentTeacherId = Convert.ToInt32(dataGridView_Teacher.CurrentRow.Cells[0].Value);

             
                textBox_fname.Text = dataGridView_Teacher.CurrentRow.Cells[1].Value?.ToString();
                textBox_lname.Text = dataGridView_Teacher.CurrentRow.Cells[2].Value?.ToString();
                textBox_username.Text = dataGridView_Teacher.CurrentRow.Cells[3].Value?.ToString();
                textBox_password.Text = dataGridView_Teacher.CurrentRow.Cells[4].Value?.ToString();
                textBox_department.Text = dataGridView_Teacher.CurrentRow.Cells[5].Value?.ToString();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
