namespace SIMS3
{
    partial class PrintCourseForm
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
            panel6 = new Panel();
            panel7 = new Panel();
            panel1 = new Panel();
            textBox_search = new TextBox();
            button1 = new Button();
            panel2 = new Panel();
            panel8 = new Panel();
            panel10 = new Panel();
            dataGridView_Course = new DataGridView();
            panel_dataholder = new Panel();
            panel4 = new Panel();
            button_Print = new Button();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Course).BeginInit();
            panel_dataholder.SuspendLayout();
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
            panel3.TabIndex = 32;
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
            panel6.BackColor = Color.FromArgb(11, 15, 26);
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
            // panel1
            // 
            panel1.Controls.Add(textBox_search);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(30, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 57);
            panel1.TabIndex = 37;
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Right;
            textBox_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_search.Location = new Point(571, 12);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(181, 34);
            textBox_search.TabIndex = 45;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.BackColor = Color.ForestGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(757, 10);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(128, 36);
            button1.TabIndex = 44;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(30, 656);
            panel2.Name = "panel2";
            panel2.Size = new Size(899, 30);
            panel2.TabIndex = 38;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(30, 516);
            panel8.Name = "panel8";
            panel8.Size = new Size(899, 52);
            panel8.TabIndex = 40;
            // 
            // panel10
            // 
            panel10.BackColor = Color.RoyalBlue;
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(30, 506);
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
            dataGridView_Course.Size = new Size(899, 511);
            dataGridView_Course.TabIndex = 39;
            // 
            // panel_dataholder
            // 
            panel_dataholder.Controls.Add(dataGridView_Course);
            panel_dataholder.Dock = DockStyle.Fill;
            panel_dataholder.Location = new Point(30, 145);
            panel_dataholder.Name = "panel_dataholder";
            panel_dataholder.Size = new Size(899, 511);
            panel_dataholder.TabIndex = 41;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(17, 24, 39);
            panel4.Controls.Add(button_Print);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(30, 568);
            panel4.Name = "panel4";
            panel4.Size = new Size(899, 88);
            panel4.TabIndex = 42;
            // 
            // button_Print
            // 
            button_Print.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Print.BackColor = Color.ForestGreen;
            button_Print.FlatAppearance.BorderSize = 0;
            button_Print.FlatStyle = FlatStyle.Flat;
            button_Print.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Print.ForeColor = Color.White;
            button_Print.Location = new Point(702, 22);
            button_Print.Margin = new Padding(2);
            button_Print.Name = "button_Print";
            button_Print.Size = new Size(180, 46);
            button_Print.TabIndex = 23;
            button_Print.Text = "Print";
            button_Print.UseVisualStyleBackColor = false;
            button_Print.Click += button_Print_Click;
            // 
            // PrintCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 15, 26);
            ClientSize = new Size(959, 686);
            Controls.Add(panel10);
            Controls.Add(panel8);
            Controls.Add(panel4);
            Controls.Add(panel_dataholder);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel3);
            Name = "PrintCourseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrintCourseForm";
            Load += PrintCourseForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Course).EndInit();
            panel_dataholder.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel1;
        private Panel panel2;
        private Panel panel8;
        private Panel panel10;
        private DataGridView dataGridView_Course;
        private Panel panel_dataholder;
        private Panel panel4;
        private Button button1;
        private TextBox textBox_search;
        private Button button_Print;
    }
}