namespace SIMS3
{
    partial class ScoreForm2
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
            panel1 = new Panel();
            panel5 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel6 = new Panel();
            panel7 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            button_AddScore = new Button();
            label12 = new Label();
            panel4 = new Panel();
            button_Clear = new Button();
            comboBox_selectCourse = new ComboBox();
            textBox_description = new TextBox();
            label3 = new Label();
            label10 = new Label();
            textBox_Score = new TextBox();
            textBox_ID = new TextBox();
            label11 = new Label();
            label1 = new Label();
            dataGridView_score1 = new DataGridView();
            panel_holder = new Panel();
            panel10 = new Panel();
            panel8 = new Panel();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_score1).BeginInit();
            panel_holder.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(30, 656);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 30);
            panel1.TabIndex = 37;
            // 
            // panel5
            // 
            panel5.Controls.Add(button2);
            panel5.Controls.Add(button1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(30, 88);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(899, 61);
            panel5.TabIndex = 34;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.BackColor = Color.RoyalBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(764, 18);
            button2.Name = "button2";
            button2.Size = new Size(135, 40);
            button2.TabIndex = 1;
            button2.Text = "Show Score";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 18);
            button1.Name = "button1";
            button1.Size = new Size(135, 40);
            button1.TabIndex = 0;
            button1.Text = "Show Student";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel6
            // 
            panel6.AutoScroll = true;
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(929, 88);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(30, 598);
            panel6.TabIndex = 35;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 88);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(30, 598);
            panel7.TabIndex = 36;
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
            panel3.TabIndex = 33;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(422, 26);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 37);
            label5.TabIndex = 2;
            label5.Text = "Score";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 49, 90);
            panel2.Controls.Add(button_AddScore);
            panel2.Controls.Add(label12);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(30, 395);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(899, 64);
            panel2.TabIndex = 38;
            // 
            // button_AddScore
            // 
            button_AddScore.Anchor = AnchorStyles.Right;
            button_AddScore.BackColor = Color.RoyalBlue;
            button_AddScore.FlatAppearance.BorderSize = 0;
            button_AddScore.FlatStyle = FlatStyle.Flat;
            button_AddScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_AddScore.ForeColor = Color.White;
            button_AddScore.Location = new Point(691, 11);
            button_AddScore.Margin = new Padding(2);
            button_AddScore.Name = "button_AddScore";
            button_AddScore.Size = new Size(180, 46);
            button_AddScore.TabIndex = 22;
            button_AddScore.Text = "+ Add Score";
            button_AddScore.UseVisualStyleBackColor = false;
            button_AddScore.Click += button_AddScore_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(15, 14);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(250, 37);
            label12.TabIndex = 0;
            label12.Text = "Score Information";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(17, 24, 39);
            panel4.Controls.Add(button_Clear);
            panel4.Controls.Add(comboBox_selectCourse);
            panel4.Controls.Add(textBox_description);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(textBox_Score);
            panel4.Controls.Add(textBox_ID);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(30, 459);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(899, 197);
            panel4.TabIndex = 39;
            // 
            // button_Clear
            // 
            button_Clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Clear.BackColor = Color.DarkGray;
            button_Clear.FlatAppearance.BorderSize = 0;
            button_Clear.FlatStyle = FlatStyle.Flat;
            button_Clear.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Clear.ForeColor = Color.White;
            button_Clear.Location = new Point(712, 138);
            button_Clear.Margin = new Padding(2);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(142, 42);
            button_Clear.TabIndex = 48;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = false;
            button_Clear.Click += button_Clear_Click;
            // 
            // comboBox_selectCourse
            // 
            comboBox_selectCourse.Anchor = AnchorStyles.Top;
            comboBox_selectCourse.BackColor = Color.FromArgb(17, 24, 39);
            comboBox_selectCourse.FlatStyle = FlatStyle.Flat;
            comboBox_selectCourse.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_selectCourse.ForeColor = Color.White;
            comboBox_selectCourse.FormattingEnabled = true;
            comboBox_selectCourse.Location = new Point(29, 51);
            comboBox_selectCourse.Name = "comboBox_selectCourse";
            comboBox_selectCourse.Size = new Size(226, 33);
            comboBox_selectCourse.TabIndex = 55;
            comboBox_selectCourse.SelectedIndexChanged += comboBox_selectCourse_SelectedIndexChanged;
            // 
            // textBox_description
            // 
            textBox_description.Anchor = AnchorStyles.None;
            textBox_description.BackColor = Color.FromArgb(17, 24, 39);
            textBox_description.BorderStyle = BorderStyle.FixedSingle;
            textBox_description.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_description.ForeColor = Color.White;
            textBox_description.Location = new Point(29, 130);
            textBox_description.Margin = new Padding(2);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(388, 50);
            textBox_description.TabIndex = 54;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(54, 97, 139);
            label3.Location = new Point(29, 105);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 53;
            label3.Text = "Description";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(54, 97, 139);
            label10.Location = new Point(29, 17);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(117, 23);
            label10.TabIndex = 49;
            label10.Text = "Select Course";
            // 
            // textBox_Score
            // 
            textBox_Score.Anchor = AnchorStyles.None;
            textBox_Score.BackColor = Color.FromArgb(17, 24, 39);
            textBox_Score.BorderStyle = BorderStyle.FixedSingle;
            textBox_Score.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Score.ForeColor = Color.White;
            textBox_Score.Location = new Point(514, 53);
            textBox_Score.Margin = new Padding(2);
            textBox_Score.Name = "textBox_Score";
            textBox_Score.Size = new Size(162, 31);
            textBox_Score.TabIndex = 47;
            // 
            // textBox_ID
            // 
            textBox_ID.Anchor = AnchorStyles.None;
            textBox_ID.BackColor = Color.FromArgb(17, 24, 39);
            textBox_ID.BorderStyle = BorderStyle.FixedSingle;
            textBox_ID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_ID.ForeColor = Color.White;
            textBox_ID.Location = new Point(306, 53);
            textBox_ID.Margin = new Padding(2);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(162, 31);
            textBox_ID.TabIndex = 45;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(54, 97, 139);
            label11.Location = new Point(514, 17);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(52, 23);
            label11.TabIndex = 46;
            label11.Text = "Score";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(54, 97, 139);
            label1.Location = new Point(306, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 44;
            label1.Text = "Student ID";
            // 
            // dataGridView_score1
            // 
            dataGridView_score1.AllowUserToAddRows = false;
            dataGridView_score1.AllowUserToDeleteRows = false;
            dataGridView_score1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_score1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_score1.Dock = DockStyle.Fill;
            dataGridView_score1.Location = new Point(0, 0);
            dataGridView_score1.Margin = new Padding(2);
            dataGridView_score1.Name = "dataGridView_score1";
            dataGridView_score1.RowHeadersWidth = 51;
            dataGridView_score1.RowTemplate.Height = 80;
            dataGridView_score1.Size = new Size(899, 246);
            dataGridView_score1.TabIndex = 40;
            dataGridView_score1.Click += dataGridView_Score1_Click;
            // 
            // panel_holder
            // 
            panel_holder.Controls.Add(dataGridView_score1);
            panel_holder.Dock = DockStyle.Fill;
            panel_holder.Location = new Point(30, 149);
            panel_holder.Name = "panel_holder";
            panel_holder.Size = new Size(899, 246);
            panel_holder.TabIndex = 40;
            // 
            // panel10
            // 
            panel10.BackColor = Color.RoyalBlue;
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(30, 333);
            panel10.Name = "panel10";
            panel10.Size = new Size(899, 10);
            panel10.TabIndex = 43;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(30, 343);
            panel8.Name = "panel8";
            panel8.Size = new Size(899, 52);
            panel8.TabIndex = 42;
            // 
            // ScoreForm2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 15, 26);
            ClientSize = new Size(959, 686);
            Controls.Add(panel10);
            Controls.Add(panel8);
            Controls.Add(panel_holder);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel3);
            Name = "ScoreForm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ScoreForm2";
            Load += ScoreForm2_Load;
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_score1).EndInit();
            panel_holder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Button button2;
        private Button button1;
        private Panel panel6;
        private Panel panel7;
        private Panel panel3;
        private Label label5;
        private Panel panel2;
        private Button button_AddScore;
        private Label label12;
        private Panel panel4;
        private ComboBox comboBox_selectCourse;
        private TextBox textBox_description;
        private Label label3;
        private Button button_Clear;
        private Label label10;
        private TextBox textBox_Score;
        private TextBox textBox_ID;
        private Label label11;
        private Label label1;
        private DataGridView dataGridView_score1;
        private Panel panel_holder;
        private Panel panel10;
        private Panel panel8;
    }
}