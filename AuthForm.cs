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
    public partial class AuthForm : Form
    {
        DBConnect connect = new DBConnect();
        public AuthForm()
        {
            InitializeComponent();
        }

        private void btnexit_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void btnexit_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(31, 46, 162);
        }

        private void btn_Verify_Click(object sender, EventArgs e)
        {
            try
            {
                connect.openConnect();
                MySqlConnection conn = connect.GetConnection();


                string sql = "SELECT Password FROM user_accounts WHERE Role = 'Admin' AND IsActive = 1 LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string correctPass = result.ToString();
                        if (txtAuthPass.Text == correctPass)
                        {
                            MessageBox.Show("Authorization Successful!", "Verified", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Admin Passkey.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No admin account found at ID 1.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                connect.closeConnect();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
