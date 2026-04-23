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

            string query = "SELECT UserID, FirstName, LastName, Username, Password, Department, Role, IsActive FROM `user_accounts` WHERE CONCAT_WS(' ', `UserID`, `FirstName`, `LastName`, `Username`, `Department`, `Role`) LIKE @search AND `IsActive` = 1 ORDER BY UserID DESC";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@search", "%" + textBox_search.Text.Trim() + "%");
            dataGridView_Teacher.DataSource = teacherClass.getlist(command);

            dataGridView_Teacher.BackgroundColor = Color.FromArgb(34, 40, 64);
            dataGridView_Teacher.GridColor = Color.FromArgb(50, 60, 90);

            dataGridView_Teacher.EnableHeadersVisualStyles = false;
            dataGridView_Teacher.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dataGridView_Teacher.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Teacher.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView_Teacher.ColumnHeadersHeight = 40;


            dataGridView_Teacher.DefaultCellStyle.BackColor = Color.FromArgb(44, 51, 80);
            dataGridView_Teacher.DefaultCellStyle.ForeColor = Color.FromArgb(224, 224, 224);

            dataGridView_Teacher.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(37, 43, 68);


            dataGridView_Teacher.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 120, 180);
            dataGridView_Teacher.DefaultCellStyle.SelectionForeColor = Color.White;


            dataGridView_Teacher.RowHeadersVisible = false;
            dataGridView_Teacher.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_Teacher.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void clearFields()
        {
            textBox_fname.Clear();
            textBox_lname.Clear();
            textBox_username.Clear();
            textBox_password.Clear();
            textBox_department.Clear();
            radioButton_Active.Checked = false;
            radioButton_Deleted.Checked = false;
            radioButton_All.Checked = false;

            comboBox_role.SelectedIndex = -1;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            int filter = 2;
            if (radioButton_Active.Checked)
            {
                filter = 1;
            }
            else if (radioButton_Deleted.Checked)
            {
                filter = 0;
            }

            dataGridView_Teacher.DataSource = teacherClass.searchTeacher(textBox_search.Text, filter);
           clearFields();
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


            if (IsAuthorized())
            {
                // Get the role from your ComboBox
                string role = comboBox_role.SelectedItem?.ToString() ?? "Teacher";

                if (teacherClass.insertTeacher(fname, lname, username, password, dept, role))
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
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (currentTeacherId == 0)
            {
                MessageBox.Show("Please select a teacher from the table to disable.", "Select Teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (MessageBox.Show("Are you sure you want to disable this account?", "Disable Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                if (IsAuthorized())
                {
                    if (teacherClass.disableAccount(currentTeacherId))
                    {
                        MessageBox.Show("Account successfully disabled.", "Disable Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showTeacher();
                        clearFields();
                        currentTeacherId = 0;
                    }
                    else
                    {
                        MessageBox.Show("Error disabling account.", "Disable Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void AccountCreateForm_Load(object sender, EventArgs e)
        {

            comboBox_role.Items.Add("Admin");
            comboBox_role.Items.Add("Teacher");

            clearFields();
            showTeacher();
        }


        private bool IsAuthorized()
        {
            using (AuthForm authForm = new AuthForm())
            {

                if (authForm.ShowDialog() == DialogResult.OK)
                {
                    return true;
                }
            }
            return false;
        }
        private void button_update_Click(object sender, EventArgs e)
        {

            if (currentTeacherId == 0)
            {
                MessageBox.Show("Please select an account from the table first.", "Select Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fname = textBox_fname.Text;
            string lname = textBox_lname.Text;
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            string dept = textBox_department.Text;
            string role = comboBox_role.SelectedItem?.ToString() ?? "Teacher";

            if (teacherClass.checkDuplicateUsername(username, currentTeacherId))
            {
                MessageBox.Show($"This Username is already being used by another {role}! Please choose a different one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsAuthorized())
            {
                if (teacherClass.Teacherupdate(currentTeacherId, fname, lname, username, password, dept, role))
                {

                    MessageBox.Show($"{role} Account Updated Successfully!", "Update Account", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    currentTeacherId = 0;
                    showTeacher();
                    clearFields();
                }
                else
                {

                    MessageBox.Show($"Error updating {role} account.", "Update Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

                comboBox_role.Text = dataGridView_Teacher.CurrentRow.Cells[6].Value?.ToString();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton_Deleted_CheckedChanged_1(object sender, EventArgs e)
        {
     
        }

        private void radioButton_Active_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton_All_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
