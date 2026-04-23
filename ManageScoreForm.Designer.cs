namespace SIMS3
{
    partial class ManageScoreForm
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
            panel5 = new Panel();
            radioButton_All = new RadioButton();
            radioButton_Active = new RadioButton();
            button_search = new Button();
            radioButton_Deleted = new RadioButton();
            textBox_search = new TextBox();
            panel6 = new Panel();
            panel7 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            panel1 = new Panel();
            dataGridView_manageCourse = new DataGridView();
            panel8 = new Panel();
            panel10 = new Panel();
            panel2 = new Panel();
            button_AddScore = new Button();
            label12 = new Label();
            panel4 = new Panel();
            comboBox_selectCourse = new ComboBox();
            label3 = new Label();
            label10 = new Label();
            textBox_Score = new TextBox();
            textBox_ID = new TextBox();
            label11 = new Label();
            label1 = new Label();
            button_Delete = new Button();
            button_Clear = new Button();
            textBox_Description = new TextBox();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_manageCourse).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Controls.Add(radioButton_All);
            panel5.Controls.Add(radioButton_Active);
            panel5.Controls.Add(button_search);
            panel5.Controls.Add(radioButton_Deleted);
            panel5.Controls.Add(textBox_search);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(26, 66);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(787, 46);
            panel5.TabIndex = 36;
            // 
            // radioButton_All
            // 
            radioButton_All.AutoSize = true;
            radioButton_All.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_All.ForeColor = Color.White;
            radioButton_All.Location = new Point(188, 16);
            radioButton_All.Margin = new Padding(3, 2, 3, 2);
            radioButton_All.Name = "radioButton_All";
            radioButton_All.Size = new Size(44, 23);
            radioButton_All.TabIndex = 56;
            radioButton_All.TabStop = true;
            radioButton_All.Text = "All";
            radioButton_All.UseVisualStyleBackColor = true;
            // 
            // radioButton_Active
            // 
            radioButton_Active.AutoSize = true;
            radioButton_Active.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_Active.ForeColor = Color.White;
            radioButton_Active.Location = new Point(98, 16);
            radioButton_Active.Margin = new Padding(3, 2, 3, 2);
            radioButton_Active.Name = "radioButton_Active";
            radioButton_Active.Size = new Size(66, 23);
            radioButton_Active.TabIndex = 55;
            radioButton_Active.TabStop = true;
            radioButton_Active.Text = "Active";
            radioButton_Active.UseVisualStyleBackColor = true;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.DarkGray;
            button_search.FlatAppearance.BorderSize = 0;
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(660, 9);
            button_search.Margin = new Padding(2);
            button_search.Name = "button_search";
            button_search.Size = new Size(114, 34);
            button_search.TabIndex = 42;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // radioButton_Deleted
            // 
            radioButton_Deleted.AutoSize = true;
            radioButton_Deleted.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_Deleted.ForeColor = Color.White;
            radioButton_Deleted.Location = new Point(0, 16);
            radioButton_Deleted.Margin = new Padding(3, 2, 3, 2);
            radioButton_Deleted.Name = "radioButton_Deleted";
            radioButton_Deleted.Size = new Size(75, 23);
            radioButton_Deleted.TabIndex = 54;
            radioButton_Deleted.TabStop = true;
            radioButton_Deleted.Text = "Deleted";
            radioButton_Deleted.UseVisualStyleBackColor = true;
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.BackColor = Color.FromArgb(17, 24, 39);
            textBox_search.BorderStyle = BorderStyle.FixedSingle;
            textBox_search.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_search.ForeColor = Color.White;
            textBox_search.Location = new Point(527, 15);
            textBox_search.Margin = new Padding(2);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(130, 27);
            textBox_search.TabIndex = 41;
            // 
            // panel6
            // 
            panel6.AutoScroll = true;
            panel6.BackColor = Color.FromArgb(11, 15, 26);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(813, 66);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(26, 448);
            panel6.TabIndex = 37;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 66);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(26, 448);
            panel7.TabIndex = 38;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(17, 24, 39);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(839, 66);
            panel3.TabIndex = 35;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(312, 20);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(182, 29);
            label5.TabIndex = 1;
            label5.Text = "Manage Score";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(26, 492);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(787, 22);
            panel1.TabIndex = 39;
            // 
            // dataGridView_manageCourse
            // 
            dataGridView_manageCourse.AllowUserToAddRows = false;
            dataGridView_manageCourse.AllowUserToDeleteRows = false;
            dataGridView_manageCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_manageCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_manageCourse.Dock = DockStyle.Fill;
            dataGridView_manageCourse.Location = new Point(26, 112);
            dataGridView_manageCourse.Margin = new Padding(2);
            dataGridView_manageCourse.Name = "dataGridView_manageCourse";
            dataGridView_manageCourse.RowHeadersWidth = 51;
            dataGridView_manageCourse.RowTemplate.Height = 80;
            dataGridView_manageCourse.Size = new Size(787, 186);
            dataGridView_manageCourse.TabIndex = 41;
            dataGridView_manageCourse.CellClick += dtaGridView_ManageScre_CellClick;
            dataGridView_manageCourse.Click += dataGridView_ManageScore_Click;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(26, 259);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(787, 39);
            panel8.TabIndex = 42;
            // 
            // panel10
            // 
            panel10.BackColor = Color.RoyalBlue;
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(26, 251);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(787, 8);
            panel10.TabIndex = 36;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 49, 90);
            panel2.Controls.Add(button_AddScore);
            panel2.Controls.Add(label12);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(26, 298);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(787, 48);
            panel2.TabIndex = 43;
            // 
            // button_AddScore
            // 
            button_AddScore.Anchor = AnchorStyles.Right;
            button_AddScore.BackColor = Color.RoyalBlue;
            button_AddScore.FlatAppearance.BorderSize = 0;
            button_AddScore.FlatStyle = FlatStyle.Flat;
            button_AddScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_AddScore.ForeColor = Color.White;
            button_AddScore.Location = new Point(616, 8);
            button_AddScore.Margin = new Padding(2);
            button_AddScore.Name = "button_AddScore";
            button_AddScore.Size = new Size(158, 34);
            button_AddScore.TabIndex = 23;
            button_AddScore.Text = "+ Update Score";
            button_AddScore.UseVisualStyleBackColor = false;
            button_AddScore.Click += button_AddScore_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(13, 10);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(192, 30);
            label12.TabIndex = 0;
            label12.Text = "Score Information";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(17, 24, 39);
            panel4.Controls.Add(comboBox_selectCourse);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(textBox_Score);
            panel4.Controls.Add(textBox_ID);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(button_Delete);
            panel4.Controls.Add(button_Clear);
            panel4.Controls.Add(textBox_Description);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(26, 346);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(787, 146);
            panel4.TabIndex = 44;
            // 
            // comboBox_selectCourse
            // 
            comboBox_selectCourse.Anchor = AnchorStyles.Top;
            comboBox_selectCourse.BackColor = Color.FromArgb(17, 24, 39);
            comboBox_selectCourse.FlatStyle = FlatStyle.Flat;
            comboBox_selectCourse.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_selectCourse.ForeColor = Color.White;
            comboBox_selectCourse.FormattingEnabled = true;
            comboBox_selectCourse.Location = new Point(27, 40);
            comboBox_selectCourse.Margin = new Padding(3, 2, 3, 2);
            comboBox_selectCourse.Name = "comboBox_selectCourse";
            comboBox_selectCourse.Size = new Size(198, 27);
            comboBox_selectCourse.TabIndex = 64;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(54, 97, 139);
            label3.Location = new Point(27, 80);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 62;
            label3.Text = "Description";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(54, 97, 139);
            label10.Location = new Point(27, 14);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(99, 19);
            label10.TabIndex = 61;
            label10.Text = "Select Course";
            // 
            // textBox_Score
            // 
            textBox_Score.Anchor = AnchorStyles.None;
            textBox_Score.BackColor = Color.FromArgb(17, 24, 39);
            textBox_Score.BorderStyle = BorderStyle.FixedSingle;
            textBox_Score.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Score.ForeColor = Color.White;
            textBox_Score.Location = new Point(451, 41);
            textBox_Score.Margin = new Padding(2);
            textBox_Score.Name = "textBox_Score";
            textBox_Score.Size = new Size(142, 27);
            textBox_Score.TabIndex = 60;
            // 
            // textBox_ID
            // 
            textBox_ID.Anchor = AnchorStyles.None;
            textBox_ID.BackColor = Color.FromArgb(17, 24, 39);
            textBox_ID.BorderStyle = BorderStyle.FixedSingle;
            textBox_ID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_ID.ForeColor = Color.White;
            textBox_ID.Location = new Point(269, 41);
            textBox_ID.Margin = new Padding(2);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(142, 27);
            textBox_ID.TabIndex = 58;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(54, 97, 139);
            label11.Location = new Point(451, 14);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(44, 19);
            label11.TabIndex = 59;
            label11.Text = "Score";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(54, 97, 139);
            label1.Location = new Point(269, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 57;
            label1.Text = "Student ID";
            // 
            // button_Delete
            // 
            button_Delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Delete.BackColor = Color.Maroon;
            button_Delete.FlatAppearance.BorderSize = 0;
            button_Delete.FlatStyle = FlatStyle.Flat;
            button_Delete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Delete.ForeColor = Color.White;
            button_Delete.Location = new Point(649, 110);
            button_Delete.Margin = new Padding(2);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(124, 32);
            button_Delete.TabIndex = 56;
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
            button_Clear.Location = new Point(502, 110);
            button_Clear.Margin = new Padding(2);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(124, 32);
            button_Clear.TabIndex = 56;
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
            textBox_Description.Location = new Point(27, 99);
            textBox_Description.Margin = new Padding(2);
            textBox_Description.Multiline = true;
            textBox_Description.Name = "textBox_Description";
            textBox_Description.Size = new Size(311, 33);
            textBox_Description.TabIndex = 50;
            // 
            // ManageScoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 15, 26);
            ClientSize = new Size(839, 514);
            Controls.Add(panel10);
            Controls.Add(panel8);
            Controls.Add(dataGridView_manageCourse);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageScoreForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageScoreForm";
            Load += ManageScoreForm_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_manageCourse).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Button button_search;
        private TextBox textBox_search;
        private Panel panel6;
        private Panel panel7;
        private Panel panel3;
        private Label label5;
        private Panel panel1;
        private DataGridView dataGridView_manageCourse;
        private Panel panel8;
        private Panel panel10;
        private Panel panel2;
        private Label label12;
        private Panel panel4;
        private Button button_Delete;
        private Button button_Clear;
        private TextBox textBox_Description;
        private ComboBox comboBox_selectCourse;
        private Label label3;
        private Label label10;
        private TextBox textBox_Score;
        private TextBox textBox_ID;
        private Label label11;
        private Label label1;
        private Button button_AddScore;
        private RadioButton radioButton_All;
        private RadioButton radioButton_Active;
        private RadioButton radioButton_Deleted;
    }
}