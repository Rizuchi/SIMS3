namespace SIMS3
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            gradientPanel1 = new GradientPanel();
            panel_login = new Panel();
            button2 = new Button();
            label6 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            textbox_pass = new TextBox();
            textbox_user = new TextBox();
            label4 = new Label();
            btn_login = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gradientPanel1.SuspendLayout();
            panel_login.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(57, 340);
            label3.Name = "label3";
            label3.Size = new Size(393, 31);
            label3.TabIndex = 14;
            label3.Text = "Please use your personal informtion ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(31, 291);
            label2.Name = "label2";
            label2.Size = new Size(447, 31);
            label2.TabIndex = 13;
            label2.Text = "Student Information Management System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(130, 227);
            label1.Name = "label1";
            label1.Size = new Size(251, 54);
            label1.TabIndex = 12;
            label1.Text = "Welcome To";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(194, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 135);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(panel_login);
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Controls.Add(label3);
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1000, 600);
            gradientPanel1.TabIndex = 16;
            // 
            // panel_login
            // 
            panel_login.BackColor = Color.White;
            panel_login.Controls.Add(button2);
            panel_login.Controls.Add(label6);
            panel_login.Controls.Add(label5);
            panel_login.Controls.Add(panel3);
            panel_login.Controls.Add(panel4);
            panel_login.Controls.Add(textbox_pass);
            panel_login.Controls.Add(textbox_user);
            panel_login.Controls.Add(label4);
            panel_login.Controls.Add(btn_login);
            panel_login.Dock = DockStyle.Right;
            panel_login.Location = new Point(512, 0);
            panel_login.Name = "panel_login";
            panel_login.Size = new Size(488, 600);
            panel_login.TabIndex = 18;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(438, 0);
            button2.Name = "button2";
            button2.Size = new Size(50, 29);
            button2.TabIndex = 19;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.MouseEnter += btnexit_MouseEnter;
            button2.MouseLeave += btnexit_MouseLeave;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(75, 280);
            label6.Name = "label6";
            label6.Size = new Size(101, 28);
            label6.TabIndex = 15;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(75, 192);
            label5.Name = "label5";
            label5.Size = new Size(106, 28);
            label5.TabIndex = 14;
            label5.Text = "Username";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = Color.FromArgb(28, 167, 236);
            panel3.Location = new Point(75, 255);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 3);
            panel3.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = Color.FromArgb(28, 167, 236);
            panel4.Location = new Point(75, 340);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 3);
            panel4.TabIndex = 12;
            // 
            // textbox_pass
            // 
            textbox_pass.Anchor = AnchorStyles.Top;
            textbox_pass.BackColor = Color.White;
            textbox_pass.BorderStyle = BorderStyle.None;
            textbox_pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_pass.ForeColor = Color.DimGray;
            textbox_pass.Location = new Point(75, 311);
            textbox_pass.Name = "textbox_pass";
            textbox_pass.Size = new Size(350, 27);
            textbox_pass.TabIndex = 9;
            textbox_pass.UseSystemPasswordChar = true;
            textbox_pass.TextChanged += btn_pass_TextChanged;
            // 
            // textbox_user
            // 
            textbox_user.Anchor = AnchorStyles.Top;
            textbox_user.BackColor = Color.White;
            textbox_user.BorderStyle = BorderStyle.None;
            textbox_user.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_user.ForeColor = Color.DimGray;
            textbox_user.Location = new Point(75, 227);
            textbox_user.Name = "textbox_user";
            textbox_user.Size = new Size(350, 27);
            textbox_user.TabIndex = 7;
            textbox_user.TextChanged += btn_user_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(35, 63);
            label4.Name = "label4";
            label4.Size = new Size(316, 31);
            label4.TabIndex = 6;
            label4.Text = "SIGN IN TO YOUR ACCOUNT";
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.Top;
            btn_login.BackColor = Color.FromArgb(28, 167, 236);
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = SystemColors.ButtonHighlight;
            btn_login.Location = new Point(88, 443);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(319, 59);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            panel_login.ResumeLayout(false);
            panel_login.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private GradientPanel gradientPanel1;
        private Panel panel_login;
        private Button button2;
        private Label label6;
        private Label label5;
        private Panel panel3;
        private Panel panel4;
        private TextBox textbox_pass;
        private TextBox textbox_user;
        private Label label4;
        private Button btn_login;
    }
}