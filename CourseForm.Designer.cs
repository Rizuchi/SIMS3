namespace SIMS3
{
    partial class CourseForm
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
            panel3 = new Panel();
            label5 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel10 = new Panel();
            dataGridView_Course = new DataGridView();
            panel_holder3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            button_AddStudent = new Button();
            label12 = new Label();
            panel4 = new Panel();
            courseCode = new TextBox();
            label4 = new Label();
            textBox_department = new TextBox();
            label3 = new Label();
            textBox_units = new TextBox();
            label2 = new Label();
            button_Clear = new Button();
            textBox_Description = new TextBox();
            label10 = new Label();
            textBox_Hourse = new TextBox();
            textBox_Subject = new TextBox();
            label11 = new Label();
            label1 = new Label();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Course).BeginInit();
            panel_holder3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
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
            panel3.TabIndex = 20;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(411, 26);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(137, 37);
            label5.TabIndex = 1;
            label5.Text = "Course";
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 88);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(959, 44);
            panel5.TabIndex = 21;
            // 
            // panel6
            // 
            panel6.AutoScroll = true;
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(929, 132);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(30, 554);
            panel6.TabIndex = 23;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 132);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(30, 554);
            panel7.TabIndex = 24;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel10);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(30, 346);
            panel8.Name = "panel8";
            panel8.Size = new Size(899, 52);
            panel8.TabIndex = 26;
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
            // dataGridView_Course
            // 
            dataGridView_Course.AllowUserToAddRows = false;
            dataGridView_Course.AllowUserToDeleteRows = false;
            dataGridView_Course.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Course.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Course.Dock = DockStyle.Fill;
            dataGridView_Course.Location = new Point(0, 0);
            dataGridView_Course.Margin = new Padding(2);
            dataGridView_Course.Name = "dataGridView_Course";
            dataGridView_Course.RowHeadersWidth = 51;
            dataGridView_Course.RowTemplate.Height = 80;
            dataGridView_Course.Size = new Size(899, 554);
            dataGridView_Course.TabIndex = 25;
            // 
            // panel_holder3
            // 
            panel_holder3.Controls.Add(dataGridView_Course);
            panel_holder3.Dock = DockStyle.Fill;
            panel_holder3.Location = new Point(30, 132);
            panel_holder3.Name = "panel_holder3";
            panel_holder3.Size = new Size(899, 554);
            panel_holder3.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(30, 656);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 30);
            panel1.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 49, 90);
            panel2.Controls.Add(button_AddStudent);
            panel2.Controls.Add(label12);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(30, 398);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(899, 64);
            panel2.TabIndex = 29;
            // 
            // button_AddStudent
            // 
            button_AddStudent.Anchor = AnchorStyles.Right;
            button_AddStudent.BackColor = Color.RoyalBlue;
            button_AddStudent.FlatAppearance.BorderSize = 0;
            button_AddStudent.FlatStyle = FlatStyle.Flat;
            button_AddStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_AddStudent.ForeColor = Color.White;
            button_AddStudent.Location = new Point(694, 9);
            button_AddStudent.Margin = new Padding(2);
            button_AddStudent.Name = "button_AddStudent";
            button_AddStudent.Size = new Size(180, 46);
            button_AddStudent.TabIndex = 22;
            button_AddStudent.Text = "+ Add Subject";
            button_AddStudent.UseVisualStyleBackColor = false;
            button_AddStudent.Click += button_AddStudent_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(15, 14);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(274, 37);
            label12.TabIndex = 0;
            label12.Text = "Subject Information";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(17, 24, 39);
            panel4.Controls.Add(courseCode);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(textBox_department);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(textBox_units);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(button_Clear);
            panel4.Controls.Add(textBox_Description);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(textBox_Hourse);
            panel4.Controls.Add(textBox_Subject);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(30, 462);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(899, 194);
            panel4.TabIndex = 30;
            // 
            // courseCode
            // 
            courseCode.Anchor = AnchorStyles.None;
            courseCode.BackColor = Color.FromArgb(17, 24, 39);
            courseCode.BorderStyle = BorderStyle.FixedSingle;
            courseCode.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseCode.ForeColor = Color.White;
            courseCode.Location = new Point(461, 129);
            courseCode.Margin = new Padding(2, 3, 2, 3);
            courseCode.Name = "courseCode";
            courseCode.Size = new Size(162, 31);
            courseCode.TabIndex = 56;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(54, 97, 139);
            label4.Location = new Point(461, 93);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(108, 23);
            label4.TabIndex = 55;
            label4.Text = "Course Code";
            // 
            // textBox_department
            // 
            textBox_department.Anchor = AnchorStyles.None;
            textBox_department.BackColor = Color.FromArgb(17, 24, 39);
            textBox_department.BorderStyle = BorderStyle.FixedSingle;
            textBox_department.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_department.ForeColor = Color.White;
            textBox_department.Location = new Point(233, 129);
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
            label3.Location = new Point(233, 93);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 23);
            label3.TabIndex = 53;
            label3.Text = "Department";
            // 
            // textBox_units
            // 
            textBox_units.Anchor = AnchorStyles.None;
            textBox_units.BackColor = Color.FromArgb(17, 24, 39);
            textBox_units.BorderStyle = BorderStyle.FixedSingle;
            textBox_units.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_units.ForeColor = Color.White;
            textBox_units.Location = new Point(15, 129);
            textBox_units.Margin = new Padding(2);
            textBox_units.Name = "textBox_units";
            textBox_units.Size = new Size(162, 31);
            textBox_units.TabIndex = 52;
            textBox_units.KeyPress += textbox_CourseUnits_Keypress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(54, 97, 139);
            label2.Location = new Point(15, 93);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 23);
            label2.TabIndex = 51;
            label2.Text = "Course Units";
            // 
            // button_Clear
            // 
            button_Clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Clear.BackColor = Color.DarkGray;
            button_Clear.FlatAppearance.BorderSize = 0;
            button_Clear.FlatStyle = FlatStyle.Flat;
            button_Clear.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Clear.ForeColor = Color.White;
            button_Clear.Location = new Point(732, 138);
            button_Clear.Margin = new Padding(2);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(142, 42);
            button_Clear.TabIndex = 48;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = false;
            button_Clear.Click += button_Clear_Click;
            // 
            // textBox_Description
            // 
            textBox_Description.Anchor = AnchorStyles.None;
            textBox_Description.BackColor = Color.FromArgb(17, 24, 39);
            textBox_Description.BorderStyle = BorderStyle.FixedSingle;
            textBox_Description.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Description.ForeColor = Color.White;
            textBox_Description.Location = new Point(461, 49);
            textBox_Description.Margin = new Padding(2);
            textBox_Description.Name = "textBox_Description";
            textBox_Description.Size = new Size(273, 31);
            textBox_Description.TabIndex = 50;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(54, 97, 139);
            label10.Location = new Point(452, 13);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(102, 23);
            label10.TabIndex = 49;
            label10.Text = "Description";
            // 
            // textBox_Hourse
            // 
            textBox_Hourse.Anchor = AnchorStyles.None;
            textBox_Hourse.BackColor = Color.FromArgb(17, 24, 39);
            textBox_Hourse.BorderStyle = BorderStyle.FixedSingle;
            textBox_Hourse.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Hourse.ForeColor = Color.White;
            textBox_Hourse.Location = new Point(233, 49);
            textBox_Hourse.Margin = new Padding(2);
            textBox_Hourse.Name = "textBox_Hourse";
            textBox_Hourse.Size = new Size(162, 31);
            textBox_Hourse.TabIndex = 47;
            textBox_Hourse.KeyPress += textbox_Hours_KeyPress;
            // 
            // textBox_Subject
            // 
            textBox_Subject.Anchor = AnchorStyles.None;
            textBox_Subject.BackColor = Color.FromArgb(17, 24, 39);
            textBox_Subject.BorderStyle = BorderStyle.FixedSingle;
            textBox_Subject.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Subject.ForeColor = Color.White;
            textBox_Subject.Location = new Point(15, 49);
            textBox_Subject.Margin = new Padding(2);
            textBox_Subject.Name = "textBox_Subject";
            textBox_Subject.Size = new Size(162, 31);
            textBox_Subject.TabIndex = 45;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(54, 97, 139);
            label11.Location = new Point(233, 13);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(56, 23);
            label11.TabIndex = 46;
            label11.Text = "Hours";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(54, 97, 139);
            label1.Location = new Point(15, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 44;
            label1.Text = "Course Name";
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(11, 15, 26);
            ClientSize = new Size(959, 686);
            Controls.Add(panel8);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel_holder3);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Name = "CourseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CourseForm";
            Load += CourseForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Course).EndInit();
            panel_holder3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label5;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel10;
        private DataGridView dataGridView_Course;
        private Panel panel_holder3;
        private Panel panel1;
        private Panel panel2;
        private Button button_AddStudent;
        private Label label12;
        private Panel panel4;
        private Button button_Clear;
        private TextBox textBox_Description;
        private Label label10;
        private TextBox textBox_Hourse;
        private TextBox textBox_Subject;
        private Label label11;
        private Label label1;
        private TextBox textBox_department;
        private Label label3;
        private TextBox textBox_units;
        private Label label2;
        private TextBox courseCode;
        private Label label4;
    }
}