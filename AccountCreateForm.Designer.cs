namespace SIMS3
{
    partial class AccountCreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel6 = new Panel();
            panel7 = new Panel();
            panel5 = new Panel();
            radioButton_All = new RadioButton();
            radioButton_Active = new RadioButton();
            radioButton_Deleted = new RadioButton();
            button_search = new Button();
            textBox_search = new TextBox();
            panel3 = new Panel();
            label5 = new Label();
            panel1 = new Panel();
            panel8 = new Panel();
            panel10 = new Panel();
            panel2 = new Panel();
            button_addAccount = new Button();
            label12 = new Label();
            panel4 = new Panel();
            comboBox_role = new ComboBox();
            label4 = new Label();
            button_update = new Button();
            button_Delete = new Button();
            button_Clear = new Button();
            textBox_department = new TextBox();
            label3 = new Label();
            textBox_password = new TextBox();
            label2 = new Label();
            textBox_username = new TextBox();
            label10 = new Label();
            textBox_lname = new TextBox();
            textBox_fname = new TextBox();
            label11 = new Label();
            label1 = new Label();
            panel9 = new Panel();
            dataGridView_Teacher = new DataGridView();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Teacher).BeginInit();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.AutoScroll = true;
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(929, 150);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(30, 536);
            panel6.TabIndex = 25;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 150);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(30, 536);
            panel7.TabIndex = 26;
            // 
            // panel5
            // 
            panel5.Controls.Add(radioButton_All);
            panel5.Controls.Add(radioButton_Active);
            panel5.Controls.Add(radioButton_Deleted);
            panel5.Controls.Add(button_search);
            panel5.Controls.Add(textBox_search);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 88);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(959, 62);
            panel5.TabIndex = 24;
            // 
            // radioButton_All
            // 
            radioButton_All.AutoSize = true;
            radioButton_All.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_All.ForeColor = Color.White;
            radioButton_All.Location = new Point(245, 21);
            radioButton_All.Name = "radioButton_All";
            radioButton_All.Size = new Size(50, 27);
            radioButton_All.TabIndex = 47;
            radioButton_All.TabStop = true;
            radioButton_All.Text = "All";
            radioButton_All.UseVisualStyleBackColor = true;
            radioButton_All.CheckedChanged += radioButton_All_CheckedChanged_1;
            // 
            // radioButton_Active
            // 
            radioButton_Active.AutoSize = true;
            radioButton_Active.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_Active.ForeColor = Color.White;
            radioButton_Active.Location = new Point(142, 21);
            radioButton_Active.Name = "radioButton_Active";
            radioButton_Active.Size = new Size(78, 27);
            radioButton_Active.TabIndex = 46;
            radioButton_Active.TabStop = true;
            radioButton_Active.Text = "Active";
            radioButton_Active.UseVisualStyleBackColor = true;
            radioButton_Active.CheckedChanged += radioButton_Active_CheckedChanged_1;
            // 
            // radioButton_Deleted
            // 
            radioButton_Deleted.AutoSize = true;
            radioButton_Deleted.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_Deleted.ForeColor = Color.White;
            radioButton_Deleted.Location = new Point(30, 21);
            radioButton_Deleted.Name = "radioButton_Deleted";
            radioButton_Deleted.Size = new Size(90, 27);
            radioButton_Deleted.TabIndex = 45;
            radioButton_Deleted.TabStop = true;
            radioButton_Deleted.Text = "Deleted";
            radioButton_Deleted.UseVisualStyleBackColor = true;
            radioButton_Deleted.CheckedChanged += radioButton_Deleted_CheckedChanged_1;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.DarkGray;
            button_search.FlatAppearance.BorderSize = 0;
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(799, 11);
            button_search.Margin = new Padding(2, 3, 2, 3);
            button_search.Name = "button_search";
            button_search.Size = new Size(130, 45);
            button_search.TabIndex = 44;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.BackColor = Color.FromArgb(17, 24, 39);
            textBox_search.BorderStyle = BorderStyle.FixedSingle;
            textBox_search.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_search.ForeColor = Color.White;
            textBox_search.Location = new Point(638, 19);
            textBox_search.Margin = new Padding(2, 3, 2, 3);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(148, 31);
            textBox_search.TabIndex = 43;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(17, 24, 39);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(959, 88);
            panel3.TabIndex = 23;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(344, 21);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(271, 37);
            label5.TabIndex = 1;
            label5.Text = "Mange Account";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(30, 656);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 30);
            panel1.TabIndex = 27;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel10);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(30, 346);
            panel8.Name = "panel8";
            panel8.Size = new Size(899, 52);
            panel8.TabIndex = 40;
            // 
            // panel10
            // 
            panel10.BackColor = Color.RoyalBlue;
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(899, 10);
            panel10.TabIndex = 36;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 49, 90);
            panel2.Controls.Add(button_addAccount);
            panel2.Controls.Add(label12);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(30, 398);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(899, 64);
            panel2.TabIndex = 41;
            // 
            // button_addAccount
            // 
            button_addAccount.Anchor = AnchorStyles.Right;
            button_addAccount.BackColor = Color.RoyalBlue;
            button_addAccount.FlatAppearance.BorderSize = 0;
            button_addAccount.FlatStyle = FlatStyle.Flat;
            button_addAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_addAccount.ForeColor = Color.White;
            button_addAccount.Location = new Point(701, 11);
            button_addAccount.Margin = new Padding(2);
            button_addAccount.Name = "button_addAccount";
            button_addAccount.Size = new Size(180, 46);
            button_addAccount.TabIndex = 22;
            button_addAccount.Text = "+ Add Account";
            button_addAccount.UseVisualStyleBackColor = false;
            button_addAccount.Click += button_addAccount_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(15, 14);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(296, 37);
            label12.TabIndex = 0;
            label12.Text = "Accounts Information";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(17, 24, 39);
            panel4.Controls.Add(comboBox_role);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(button_update);
            panel4.Controls.Add(button_Delete);
            panel4.Controls.Add(button_Clear);
            panel4.Controls.Add(textBox_department);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(textBox_password);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(textBox_username);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(textBox_lname);
            panel4.Controls.Add(textBox_fname);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(30, 462);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(899, 194);
            panel4.TabIndex = 42;
            panel4.Paint += panel4_Paint;
            // 
            // comboBox_role
            // 
            comboBox_role.Anchor = AnchorStyles.Top;
            comboBox_role.BackColor = Color.FromArgb(11, 15, 26);
            comboBox_role.FlatStyle = FlatStyle.Flat;
            comboBox_role.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_role.ForeColor = Color.White;
            comboBox_role.FormattingEnabled = true;
            comboBox_role.Location = new Point(248, 142);
            comboBox_role.Margin = new Padding(3, 4, 3, 4);
            comboBox_role.Name = "comboBox_role";
            comboBox_role.Size = new Size(162, 33);
            comboBox_role.TabIndex = 63;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(54, 97, 139);
            label4.Location = new Point(251, 109);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 23);
            label4.TabIndex = 62;
            label4.Text = "Role";
            // 
            // button_update
            // 
            button_update.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_update.BackColor = Color.Green;
            button_update.FlatAppearance.BorderSize = 0;
            button_update.FlatStyle = FlatStyle.Flat;
            button_update.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_update.ForeColor = Color.White;
            button_update.Location = new Point(617, 138);
            button_update.Margin = new Padding(2);
            button_update.Name = "button_update";
            button_update.Size = new Size(122, 42);
            button_update.TabIndex = 59;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // button_Delete
            // 
            button_Delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Delete.BackColor = Color.Maroon;
            button_Delete.FlatAppearance.BorderSize = 0;
            button_Delete.FlatStyle = FlatStyle.Flat;
            button_Delete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Delete.ForeColor = Color.White;
            button_Delete.Location = new Point(759, 138);
            button_Delete.Margin = new Padding(2);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(122, 42);
            button_Delete.TabIndex = 58;
            button_Delete.Text = "Delete";
            button_Delete.UseVisualStyleBackColor = false;
            button_Delete.Click += button_Delete_Click;
            // 
            // button_Clear
            // 
            button_Clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Clear.BackColor = Color.DarkGray;
            button_Clear.FlatAppearance.BorderSize = 0;
            button_Clear.FlatStyle = FlatStyle.Flat;
            button_Clear.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Clear.ForeColor = Color.White;
            button_Clear.Location = new Point(466, 138);
            button_Clear.Margin = new Padding(2);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(124, 42);
            button_Clear.TabIndex = 48;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = false;
            button_Clear.Click += button_Clear_Click;
            // 
            // textBox_department
            // 
            textBox_department.Anchor = AnchorStyles.None;
            textBox_department.BackColor = Color.FromArgb(17, 24, 39);
            textBox_department.BorderStyle = BorderStyle.FixedSingle;
            textBox_department.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_department.ForeColor = Color.White;
            textBox_department.Location = new Point(466, 65);
            textBox_department.Margin = new Padding(2);
            textBox_department.Name = "textBox_department";
            textBox_department.Size = new Size(162, 31);
            textBox_department.TabIndex = 54;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(54, 97, 139);
            label3.Location = new Point(31, 107);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 53;
            label3.Text = "Password";
            // 
            // textBox_password
            // 
            textBox_password.Anchor = AnchorStyles.None;
            textBox_password.BackColor = Color.FromArgb(17, 24, 39);
            textBox_password.BorderStyle = BorderStyle.FixedSingle;
            textBox_password.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_password.ForeColor = Color.White;
            textBox_password.Location = new Point(31, 143);
            textBox_password.Margin = new Padding(2);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(185, 31);
            textBox_password.TabIndex = 52;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(54, 97, 139);
            label2.Location = new Point(466, 29);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 51;
            label2.Text = "Department";
            // 
            // textBox_username
            // 
            textBox_username.Anchor = AnchorStyles.None;
            textBox_username.BackColor = Color.FromArgb(17, 24, 39);
            textBox_username.BorderStyle = BorderStyle.FixedSingle;
            textBox_username.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_username.ForeColor = Color.White;
            textBox_username.Location = new Point(688, 65);
            textBox_username.Margin = new Padding(2);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(185, 31);
            textBox_username.TabIndex = 50;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(54, 97, 139);
            label10.Location = new Point(688, 29);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(89, 23);
            label10.TabIndex = 49;
            label10.Text = "Username";
            // 
            // textBox_lname
            // 
            textBox_lname.Anchor = AnchorStyles.None;
            textBox_lname.BackColor = Color.FromArgb(17, 24, 39);
            textBox_lname.BorderStyle = BorderStyle.FixedSingle;
            textBox_lname.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_lname.ForeColor = Color.White;
            textBox_lname.Location = new Point(248, 65);
            textBox_lname.Margin = new Padding(2);
            textBox_lname.Name = "textBox_lname";
            textBox_lname.Size = new Size(162, 31);
            textBox_lname.TabIndex = 47;
            // 
            // textBox_fname
            // 
            textBox_fname.Anchor = AnchorStyles.None;
            textBox_fname.BackColor = Color.FromArgb(17, 24, 39);
            textBox_fname.BorderStyle = BorderStyle.FixedSingle;
            textBox_fname.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_fname.ForeColor = Color.White;
            textBox_fname.Location = new Point(31, 65);
            textBox_fname.Margin = new Padding(2);
            textBox_fname.Name = "textBox_fname";
            textBox_fname.Size = new Size(162, 31);
            textBox_fname.TabIndex = 45;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(54, 97, 139);
            label11.Location = new Point(248, 29);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(91, 23);
            label11.TabIndex = 46;
            label11.Text = "Last Name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(54, 97, 139);
            label1.Location = new Point(31, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 44;
            label1.Text = "First Name";
            // 
            // panel9
            // 
            panel9.Controls.Add(dataGridView_Teacher);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(30, 150);
            panel9.Name = "panel9";
            panel9.Size = new Size(899, 196);
            panel9.TabIndex = 43;
            // 
            // dataGridView_Teacher
            // 
            dataGridView_Teacher.AllowUserToAddRows = false;
            dataGridView_Teacher.AllowUserToDeleteRows = false;
            dataGridView_Teacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Teacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Teacher.Dock = DockStyle.Fill;
            dataGridView_Teacher.Location = new Point(0, 0);
            dataGridView_Teacher.Margin = new Padding(2);
            dataGridView_Teacher.Name = "dataGridView_Teacher";
            dataGridView_Teacher.RowHeadersWidth = 51;
            dataGridView_Teacher.RowTemplate.Height = 80;
            dataGridView_Teacher.Size = new Size(899, 196);
            dataGridView_Teacher.TabIndex = 19;
            dataGridView_Teacher.CellContentClick += dataGridView_Teacher_CellContentClick;
            dataGridView_Teacher.Click += dataGridView_teacher_Click;
            // 
            // AccountCreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(11, 15, 26);
            ClientSize = new Size(959, 686);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Name = "AccountCreateForm";
            Text = "AccountCreateForm";
            Load += AccountCreateForm_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel8.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Teacher).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private Panel panel7;
        private Panel panel5;
        private Panel panel3;
        private Label label5;
        private Panel panel1;
        private Panel panel8;
        private Panel panel10;
        private Panel panel2;
        private Button button_addAccount;
        private Label label12;
        private Panel panel4;
        private TextBox textBox_department;
        private Label label3;
        private TextBox textBox_password;
        private Label label2;
        private Button button_Clear;
        private TextBox textBox_username;
        private Label label10;
        private TextBox textBox_lname;
        private TextBox textBox_fname;
        private Label label11;
        private Label label1;
        private Panel panel9;
        private DataGridView dataGridView_Teacher;
        private Button button_Delete;
        private Button button_search;
        private TextBox textBox_search;
        private Button button_update;
        private ComboBox comboBox_role;
        private Label label4;
        private RadioButton radioButton_All;
        private RadioButton radioButton_Active;
        private RadioButton radioButton_Deleted;
    }
}