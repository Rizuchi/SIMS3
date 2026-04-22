namespace SIMS3
{
    partial class ManageForm
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
            panel8 = new Panel();
            panel10 = new Panel();
            panel1 = new Panel();
            button_AddStudent = new Button();
            label12 = new Label();
            dataGridView_Student = new DataGridView();
            panel_datagridholder = new Panel();
            label9 = new Label();
            radioButton_Female = new RadioButton();
            radioButton_Male = new RadioButton();
            label1 = new Label();
            label11 = new Label();
            textBox_fname = new TextBox();
            textBox_Number = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label8 = new Label();
            textBox_LName = new TextBox();
            label3 = new Label();
            textBox_Sufix = new TextBox();
            label2 = new Label();
            textBox_Mname = new TextBox();
            label10 = new Label();
            textBox_Address = new TextBox();
            pictureBox_Student = new PictureBox();
            label7 = new Label();
            button_Upload = new Button();
            panel9 = new Panel();
            panel2 = new Panel();
            textBox_ID = new TextBox();
            label6 = new Label();
            button_delete = new Button();
            button_Clear = new Button();
            panel4 = new Panel();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Student).BeginInit();
            panel_datagridholder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Student).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.AutoScroll = true;
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(796, 109);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(26, 716);
            panel6.TabIndex = 25;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 109);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(26, 716);
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
            panel5.Location = new Point(0, 66);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(822, 43);
            panel5.TabIndex = 24;
            // 
            // radioButton_All
            // 
            radioButton_All.AutoSize = true;
            radioButton_All.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_All.ForeColor = Color.White;
            radioButton_All.Location = new Point(215, 12);
            radioButton_All.Margin = new Padding(3, 2, 3, 2);
            radioButton_All.Name = "radioButton_All";
            radioButton_All.Size = new Size(44, 23);
            radioButton_All.TabIndex = 50;
            radioButton_All.TabStop = true;
            radioButton_All.Text = "All";
            radioButton_All.UseVisualStyleBackColor = true;
            // 
            // radioButton_Active
            // 
            radioButton_Active.AutoSize = true;
            radioButton_Active.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_Active.ForeColor = Color.White;
            radioButton_Active.Location = new Point(125, 12);
            radioButton_Active.Margin = new Padding(3, 2, 3, 2);
            radioButton_Active.Name = "radioButton_Active";
            radioButton_Active.Size = new Size(66, 23);
            radioButton_Active.TabIndex = 49;
            radioButton_Active.TabStop = true;
            radioButton_Active.Text = "Active";
            radioButton_Active.UseVisualStyleBackColor = true;
            // 
            // radioButton_Deleted
            // 
            radioButton_Deleted.AutoSize = true;
            radioButton_Deleted.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_Deleted.ForeColor = Color.White;
            radioButton_Deleted.Location = new Point(27, 12);
            radioButton_Deleted.Margin = new Padding(3, 2, 3, 2);
            radioButton_Deleted.Name = "radioButton_Deleted";
            radioButton_Deleted.Size = new Size(75, 23);
            radioButton_Deleted.TabIndex = 48;
            radioButton_Deleted.TabStop = true;
            radioButton_Deleted.Text = "Deleted";
            radioButton_Deleted.UseVisualStyleBackColor = true;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.DarkGray;
            button_search.FlatAppearance.BorderSize = 0;
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(682, 4);
            button_search.Margin = new Padding(2);
            button_search.Name = "button_search";
            button_search.Size = new Size(114, 34);
            button_search.TabIndex = 40;
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
            textBox_search.Location = new Point(548, 10);
            textBox_search.Margin = new Padding(2);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(130, 27);
            textBox_search.TabIndex = 39;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(17, 24, 39);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(822, 66);
            panel3.TabIndex = 23;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(285, 20);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(202, 29);
            label5.TabIndex = 1;
            label5.Text = "Manage Student";
            label5.Click += label5_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel10);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(26, 309);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(770, 31);
            panel8.TabIndex = 29;
            // 
            // panel10
            // 
            panel10.BackColor = Color.RoyalBlue;
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(770, 8);
            panel10.TabIndex = 36;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 49, 90);
            panel1.Controls.Add(button_AddStudent);
            panel1.Controls.Add(label12);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(26, 340);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 48);
            panel1.TabIndex = 28;
            // 
            // button_AddStudent
            // 
            button_AddStudent.Anchor = AnchorStyles.Right;
            button_AddStudent.BackColor = Color.ForestGreen;
            button_AddStudent.FlatAppearance.BorderSize = 0;
            button_AddStudent.FlatStyle = FlatStyle.Flat;
            button_AddStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_AddStudent.ForeColor = Color.White;
            button_AddStudent.Location = new Point(601, 8);
            button_AddStudent.Margin = new Padding(2);
            button_AddStudent.Name = "button_AddStudent";
            button_AddStudent.Size = new Size(158, 34);
            button_AddStudent.TabIndex = 22;
            button_AddStudent.Text = "Update";
            button_AddStudent.UseVisualStyleBackColor = false;
            button_AddStudent.Click += button_AddStudent_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(13, 10);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(215, 30);
            label12.TabIndex = 0;
            label12.Text = "Student Information";
            // 
            // dataGridView_Student
            // 
            dataGridView_Student.AllowUserToAddRows = false;
            dataGridView_Student.AllowUserToDeleteRows = false;
            dataGridView_Student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Student.Dock = DockStyle.Fill;
            dataGridView_Student.Location = new Point(0, 0);
            dataGridView_Student.Margin = new Padding(2);
            dataGridView_Student.Name = "dataGridView_Student";
            dataGridView_Student.RowHeadersWidth = 51;
            dataGridView_Student.RowTemplate.Height = 80;
            dataGridView_Student.Size = new Size(770, 200);
            dataGridView_Student.TabIndex = 30;
            dataGridView_Student.Click += dataGridView_student_Click;
            // 
            // panel_datagridholder
            // 
            panel_datagridholder.Controls.Add(dataGridView_Student);
            panel_datagridholder.Dock = DockStyle.Top;
            panel_datagridholder.Location = new Point(26, 109);
            panel_datagridholder.Margin = new Padding(3, 2, 3, 2);
            panel_datagridholder.Name = "panel_datagridholder";
            panel_datagridholder.Size = new Size(770, 200);
            panel_datagridholder.TabIndex = 32;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(54, 97, 139);
            label9.Location = new Point(456, 104);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(63, 19);
            label9.TabIndex = 16;
            label9.Text = "Gender:";
            // 
            // radioButton_Female
            // 
            radioButton_Female.Anchor = AnchorStyles.None;
            radioButton_Female.AutoSize = true;
            radioButton_Female.BackColor = Color.FromArgb(26, 34, 52);
            radioButton_Female.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            radioButton_Female.ForeColor = Color.White;
            radioButton_Female.Location = new Point(536, 103);
            radioButton_Female.Margin = new Padding(2);
            radioButton_Female.Name = "radioButton_Female";
            radioButton_Female.Size = new Size(70, 21);
            radioButton_Female.TabIndex = 15;
            radioButton_Female.TabStop = true;
            radioButton_Female.Text = "Female";
            radioButton_Female.UseVisualStyleBackColor = false;
            // 
            // radioButton_Male
            // 
            radioButton_Male.Anchor = AnchorStyles.None;
            radioButton_Male.AutoSize = true;
            radioButton_Male.BackColor = Color.FromArgb(26, 34, 52);
            radioButton_Male.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            radioButton_Male.ForeColor = Color.White;
            radioButton_Male.Location = new Point(632, 103);
            radioButton_Male.Margin = new Padding(2);
            radioButton_Male.Name = "radioButton_Male";
            radioButton_Male.Size = new Size(56, 21);
            radioButton_Male.TabIndex = 14;
            radioButton_Male.TabStop = true;
            radioButton_Male.Text = "Male";
            radioButton_Male.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(54, 97, 139);
            label1.Location = new Point(59, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 4;
            label1.Text = "First Name";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(54, 97, 139);
            label11.Location = new Point(59, 81);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(103, 19);
            label11.TabIndex = 23;
            label11.Text = "Phone Number";
            // 
            // textBox_fname
            // 
            textBox_fname.Anchor = AnchorStyles.None;
            textBox_fname.BackColor = Color.FromArgb(17, 24, 39);
            textBox_fname.BorderStyle = BorderStyle.FixedSingle;
            textBox_fname.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_fname.ForeColor = Color.White;
            textBox_fname.Location = new Point(59, 43);
            textBox_fname.Margin = new Padding(2);
            textBox_fname.Name = "textBox_fname";
            textBox_fname.Size = new Size(142, 27);
            textBox_fname.TabIndex = 5;
            // 
            // textBox_Number
            // 
            textBox_Number.Anchor = AnchorStyles.None;
            textBox_Number.BackColor = Color.FromArgb(17, 24, 39);
            textBox_Number.BorderStyle = BorderStyle.FixedSingle;
            textBox_Number.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Number.ForeColor = Color.White;
            textBox_Number.Location = new Point(59, 101);
            textBox_Number.Margin = new Padding(2);
            textBox_Number.Name = "textBox_Number";
            textBox_Number.Size = new Size(142, 27);
            textBox_Number.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(17, 24, 39);
            dateTimePicker1.Location = new Point(221, 104);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(201, 23);
            dateTimePicker1.TabIndex = 32;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(54, 97, 139);
            label4.Location = new Point(614, 14);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 29;
            label4.Text = "Suffix";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(54, 97, 139);
            label8.Location = new Point(221, 81);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(92, 19);
            label8.TabIndex = 31;
            label8.Text = "Date Of Birth";
            // 
            // textBox_LName
            // 
            textBox_LName.Anchor = AnchorStyles.None;
            textBox_LName.BackColor = Color.FromArgb(17, 24, 39);
            textBox_LName.BorderStyle = BorderStyle.FixedSingle;
            textBox_LName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_LName.ForeColor = Color.White;
            textBox_LName.Location = new Point(423, 43);
            textBox_LName.Margin = new Padding(2);
            textBox_LName.Name = "textBox_LName";
            textBox_LName.Size = new Size(142, 27);
            textBox_LName.TabIndex = 28;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(54, 97, 139);
            label3.Location = new Point(423, 14);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 27;
            label3.Text = "Last Name";
            // 
            // textBox_Sufix
            // 
            textBox_Sufix.Anchor = AnchorStyles.None;
            textBox_Sufix.BackColor = Color.FromArgb(17, 24, 39);
            textBox_Sufix.BorderStyle = BorderStyle.FixedSingle;
            textBox_Sufix.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Sufix.ForeColor = Color.White;
            textBox_Sufix.Location = new Point(614, 41);
            textBox_Sufix.Margin = new Padding(2);
            textBox_Sufix.Name = "textBox_Sufix";
            textBox_Sufix.Size = new Size(84, 27);
            textBox_Sufix.TabIndex = 30;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(54, 97, 139);
            label2.Location = new Point(239, 16);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 25;
            label2.Text = "Middle Name";
            // 
            // textBox_Mname
            // 
            textBox_Mname.Anchor = AnchorStyles.None;
            textBox_Mname.BackColor = Color.FromArgb(17, 24, 39);
            textBox_Mname.BorderStyle = BorderStyle.FixedSingle;
            textBox_Mname.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Mname.ForeColor = Color.White;
            textBox_Mname.Location = new Point(239, 43);
            textBox_Mname.Margin = new Padding(2);
            textBox_Mname.Name = "textBox_Mname";
            textBox_Mname.Size = new Size(142, 27);
            textBox_Mname.TabIndex = 26;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(54, 97, 139);
            label10.Location = new Point(59, 136);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(63, 19);
            label10.TabIndex = 33;
            label10.Text = "Address";
            // 
            // textBox_Address
            // 
            textBox_Address.Anchor = AnchorStyles.None;
            textBox_Address.BackColor = Color.FromArgb(17, 24, 39);
            textBox_Address.BorderStyle = BorderStyle.FixedSingle;
            textBox_Address.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Address.ForeColor = Color.White;
            textBox_Address.Location = new Point(59, 161);
            textBox_Address.Margin = new Padding(2);
            textBox_Address.Name = "textBox_Address";
            textBox_Address.Size = new Size(239, 27);
            textBox_Address.TabIndex = 34;
            // 
            // pictureBox_Student
            // 
            pictureBox_Student.Anchor = AnchorStyles.Top;
            pictureBox_Student.BackColor = Color.FromArgb(30, 49, 90);
            pictureBox_Student.Location = new Point(341, 303);
            pictureBox_Student.Margin = new Padding(2);
            pictureBox_Student.Name = "pictureBox_Student";
            pictureBox_Student.Size = new Size(88, 75);
            pictureBox_Student.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Student.TabIndex = 19;
            pictureBox_Student.TabStop = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(306, 237);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(150, 25);
            label7.TabIndex = 0;
            label7.Text = "Upload Picture ";
            // 
            // button_Upload
            // 
            button_Upload.Anchor = AnchorStyles.Top;
            button_Upload.BackColor = Color.ForestGreen;
            button_Upload.FlatAppearance.BorderSize = 0;
            button_Upload.FlatStyle = FlatStyle.Flat;
            button_Upload.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Upload.ForeColor = Color.White;
            button_Upload.Location = new Point(327, 381);
            button_Upload.Margin = new Padding(2);
            button_Upload.Name = "button_Upload";
            button_Upload.Size = new Size(118, 26);
            button_Upload.TabIndex = 20;
            button_Upload.Text = "Upload ";
            button_Upload.UseVisualStyleBackColor = false;
            button_Upload.Click += button_Upload_Click;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel9.BackColor = Color.Silver;
            panel9.Location = new Point(3, 221);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(1364, 5);
            panel9.TabIndex = 35;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(17, 24, 39);
            panel2.Controls.Add(textBox_ID);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(button_delete);
            panel2.Controls.Add(button_Clear);
            panel2.Controls.Add(button_Upload);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(pictureBox_Student);
            panel2.Controls.Add(textBox_Address);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBox_Mname);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox_Sufix);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox_LName);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(textBox_Number);
            panel2.Controls.Add(textBox_fname);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(radioButton_Male);
            panel2.Controls.Add(radioButton_Female);
            panel2.Controls.Add(label9);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(26, 388);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(770, 415);
            panel2.TabIndex = 33;
            // 
            // textBox_ID
            // 
            textBox_ID.Anchor = AnchorStyles.None;
            textBox_ID.BackColor = Color.FromArgb(17, 24, 39);
            textBox_ID.BorderStyle = BorderStyle.FixedSingle;
            textBox_ID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_ID.ForeColor = Color.White;
            textBox_ID.Location = new Point(317, 161);
            textBox_ID.Margin = new Padding(2);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(77, 27);
            textBox_ID.TabIndex = 43;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(54, 97, 139);
            label6.Location = new Point(317, 134);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 42;
            label6.Text = "ID Number";
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.DarkRed;
            button_delete.FlatAppearance.BorderSize = 0;
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(633, 172);
            button_delete.Margin = new Padding(2);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(124, 32);
            button_delete.TabIndex = 37;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_Clear
            // 
            button_Clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Clear.BackColor = Color.DarkGray;
            button_Clear.FlatAppearance.BorderSize = 0;
            button_Clear.FlatStyle = FlatStyle.Flat;
            button_Clear.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Clear.ForeColor = Color.White;
            button_Clear.Location = new Point(474, 172);
            button_Clear.Margin = new Padding(2);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(124, 32);
            button_Clear.TabIndex = 36;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = false;
            button_Clear.Click += button_Clear_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(26, 803);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(770, 22);
            panel4.TabIndex = 35;
            // 
            // ManageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(11, 15, 26);
            ClientSize = new Size(839, 512);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel8);
            Controls.Add(panel_datagridholder);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageForm";
            Load += ManageForm_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel8.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Student).EndInit();
            panel_datagridholder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Student).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private Panel panel7;
        private Panel panel5;
        private Panel panel3;
        private Label label5;
        private Panel panel8;
        private Panel panel10;
        private Panel panel1;
        private Button button_AddStudent;
        private Label label12;
        private DataGridView dataGridView_Student;
        private Panel panel_datagridholder;
        private Panel panel9;
        private Label label9;
        private RadioButton radioButton_Female;
        private RadioButton radioButton_Male;
        private Label label1;
        private Label label11;
        private TextBox textBox_fname;
        private TextBox textBox_Number;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label8;
        private TextBox textBox_LName;
        private Label label3;
        private TextBox textBox_Sufix;
        private Label label2;
        private TextBox textBox_Mname;
        private Label label10;
        private TextBox textBox_Address;
        private PictureBox pictureBox_Student;
        private Label label7;
        private Button button_Upload;
        private Panel panel2;
        private Panel panel4;
        private TextBox textBox_ID;
        private Label label6;
        private Button button_delete;
        private Button button_Clear;
        private Button button_search;
        private TextBox textBox_search;
        private RadioButton radioButton_All;
        private RadioButton radioButton_Active;
        private RadioButton radioButton_Deleted;
    }
}