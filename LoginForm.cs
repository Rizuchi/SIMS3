using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class LoginForm : Form
    {

        DBConnect connect = new DBConnect();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            string username = textbox_user.Text.Trim();
            string password = textbox_pass.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both a username and a password.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connect.openConnect();
                MySqlConnection conn = connect.GetConnection();

                string sql = "SELECT FirstName, Role FROM user_accounts WHERE Username=@user AND Password=@pass AND IsActive = 1";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // grab name and role 
                            string fName = reader["FirstName"].ToString();
                            string dbRole = reader["Role"].ToString();
                            Form1 homeDash = new Form1(fName, dbRole);
                            homeDash.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                connect.closeConnect();
            }
        }

        private void btn_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnexit_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(255, 0, 0); // Change to red on hover
        }

        private void btnexit_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White; // Revert to original color when not hovering

        }
    }
}
