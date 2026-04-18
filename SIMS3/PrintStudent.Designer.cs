namespace SIMS3
{
    partial class PrintStudent
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            panel3 = new Panel();
            label5 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            dataGridView_Student = new DataGridView();
            panel4 = new Panel();
            panel1 = new Panel();
            button_Print = new Button();
            radioButton_all = new RadioButton();
            radioButton_Male = new RadioButton();
            radioButton_Female = new RadioButton();
            label9 = new Label();
            panel8 = new Panel();
            panel10 = new Panel();
            panel_holder = new Panel();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Student).BeginInit();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel_holder.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(button1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 88);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(959, 57);
            panel5.TabIndex = 26;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(54, 97, 139);
            label1.Location = new Point(482, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 28);
            label1.TabIndex = 43;
            label1.Text = "Select Class:";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Right;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(614, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 36);
            comboBox1.TabIndex = 42;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.BackColor = Color.ForestGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(801, 10);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(128, 36);
            button1.TabIndex = 41;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            panel3.TabIndex = 25;
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
            label5.Size = new Size(114, 37);
            label5.TabIndex = 1;
            label5.Text = "Print";
            // 
            // panel6
            // 
            panel6.AutoScroll = true;
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(929, 145);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(30, 538);
            panel6.TabIndex = 31;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 145);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(30, 538);
            panel7.TabIndex = 32;
            // 
            // dataGridView_Student
            // 
            dataGridView_Student.AllowUserToAddRows = false;
            dataGridView_Student.AllowUserToDeleteRows = false;
            dataGridView_Student.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Student.Dock = DockStyle.Fill;
            dataGridView_Student.Location = new Point(0, 0);
            dataGridView_Student.Margin = new Padding(2);
            dataGridView_Student.Name = "dataGridView_Student";
            dataGridView_Student.RowHeadersWidth = 51;
            dataGridView_Student.RowTemplate.Height = 80;
            dataGridView_Student.Size = new Size(899, 420);
            dataGridView_Student.TabIndex = 34;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(30, 653);
            panel4.Name = "panel4";
            panel4.Size = new Size(899, 30);
            panel4.TabIndex = 36;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 24, 39);
            panel1.Controls.Add(button_Print);
            panel1.Controls.Add(radioButton_all);
            panel1.Controls.Add(radioButton_Male);
            panel1.Controls.Add(radioButton_Female);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(30, 565);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 88);
            panel1.TabIndex = 38;
            // 
            // button_Print
            // 
            button_Print.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Print.BackColor = Color.ForestGreen;
            button_Print.FlatAppearance.BorderSize = 0;
            button_Print.FlatStyle = FlatStyle.Flat;
            button_Print.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Print.ForeColor = Color.White;
            button_Print.Location = new Point(704, 37);
            button_Print.Margin = new Padding(2);
            button_Print.Name = "button_Print";
            button_Print.Size = new Size(180, 46);
            button_Print.TabIndex = 23;
            button_Print.Text = "Print";
            button_Print.UseVisualStyleBackColor = false;
            button_Print.Click += button_Print_Click;
            // 
            // radioButton_all
            // 
            radioButton_all.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_all.AutoSize = true;
            radioButton_all.BackColor = Color.FromArgb(26, 34, 52);
            radioButton_all.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            radioButton_all.ForeColor = Color.White;
            radioButton_all.Location = new Point(127, 26);
            radioButton_all.Margin = new Padding(2);
            radioButton_all.Name = "radioButton_all";
            radioButton_all.Size = new Size(53, 27);
            radioButton_all.TabIndex = 20;
            radioButton_all.TabStop = true;
            radioButton_all.Text = "All";
            radioButton_all.UseVisualStyleBackColor = false;
            // 
            // radioButton_Male
            // 
            radioButton_Male.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_Male.AutoSize = true;
            radioButton_Male.BackColor = Color.FromArgb(26, 34, 52);
            radioButton_Male.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            radioButton_Male.ForeColor = Color.White;
            radioButton_Male.Location = new Point(309, 26);
            radioButton_Male.Margin = new Padding(2);
            radioButton_Male.Name = "radioButton_Male";
            radioButton_Male.Size = new Size(70, 27);
            radioButton_Male.TabIndex = 17;
            radioButton_Male.TabStop = true;
            radioButton_Male.Text = "Male";
            radioButton_Male.UseVisualStyleBackColor = false;
            // 
            // radioButton_Female
            // 
            radioButton_Female.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_Female.AutoSize = true;
            radioButton_Female.BackColor = Color.FromArgb(26, 34, 52);
            radioButton_Female.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            radioButton_Female.ForeColor = Color.White;
            radioButton_Female.Location = new Point(201, 26);
            radioButton_Female.Margin = new Padding(2);
            radioButton_Female.Name = "radioButton_Female";
            radioButton_Female.Size = new Size(88, 27);
            radioButton_Female.TabIndex = 18;
            radioButton_Female.TabStop = true;
            radioButton_Female.Text = "Female";
            radioButton_Female.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(54, 97, 139);
            label9.Location = new Point(19, 24);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(96, 30);
            label9.TabIndex = 19;
            label9.Text = "Gender:";
            label9.Click += label9_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel10);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(30, 524);
            panel8.Name = "panel8";
            panel8.Size = new Size(899, 41);
            panel8.TabIndex = 39;
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
            // panel_holder
            // 
            panel_holder.Controls.Add(dataGridView_Student);
            panel_holder.Dock = DockStyle.Fill;
            panel_holder.Location = new Point(30, 145);
            panel_holder.Name = "panel_holder";
            panel_holder.Size = new Size(899, 420);
            panel_holder.TabIndex = 40;
            // 
            // PrintStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(11, 15, 26);
            ClientSize = new Size(959, 683);
            Controls.Add(panel8);
            Controls.Add(panel_holder);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Name = "PrintStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrintStudent";
            Load += PrintStudent_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Student).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel_holder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Button button_search;
        private Panel panel3;
        private Label label5;
        private Panel panel6;
        private Panel panel7;
        private DataGridView dataGridView_Student;
        private Panel panel4;
        private Panel panel1;
        private RadioButton radioButton_all;
        private RadioButton radioButton_Male;
        private RadioButton radioButton_Female;
        private Label label9;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button_Print;
        private Panel panel8;
        private Panel panel10;
        private Panel panel_holder;
    }
}