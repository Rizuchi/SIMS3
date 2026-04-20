namespace SIMS3
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            gradientPanel1 = new GradientPanel();
            button2 = new Button();
            btn_Verify = new Button();
            label1 = new Label();
            label2 = new Label();
            txtAuthPass = new TextBox();
            pictureBox1 = new PictureBox();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(button2);
            gradientPanel1.Controls.Add(btn_Verify);
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Controls.Add(txtAuthPass);
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(914, 600);
            gradientPanel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(864, 0);
            button2.Name = "button2";
            button2.Size = new Size(50, 29);
            button2.TabIndex = 20;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseEnter += btnexit_MouseEnter;
            button2.MouseLeave += btnexit_MouseLeave;
            // 
            // btn_Verify
            // 
            btn_Verify.BackColor = Color.FromArgb(28, 167, 236);
            btn_Verify.FlatAppearance.BorderSize = 0;
            btn_Verify.FlatStyle = FlatStyle.Flat;
            btn_Verify.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Verify.ForeColor = SystemColors.ButtonHighlight;
            btn_Verify.Location = new Point(264, 459);
            btn_Verify.Name = "btn_Verify";
            btn_Verify.Size = new Size(387, 100);
            btn_Verify.TabIndex = 19;
            btn_Verify.Text = "Authenticate";
            btn_Verify.UseVisualStyleBackColor = false;
            btn_Verify.Click += btn_Verify_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(53, 395);
            label1.Name = "label1";
            label1.Size = new Size(808, 31);
            label1.TabIndex = 18;
            label1.Text = "Please show this to an admin for them to authorize you to create an account.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(187, 343);
            label2.Name = "label2";
            label2.Size = new Size(541, 31);
            label2.TabIndex = 17;
            label2.Text = "An admin passkey is required to create an account.";
            // 
            // txtAuthPass
            // 
            txtAuthPass.Font = new Font("Segoe UI", 45F);
            txtAuthPass.Location = new Point(74, 202);
            txtAuthPass.Margin = new Padding(3, 4, 3, 4);
            txtAuthPass.Name = "txtAuthPass";
            txtAuthPass.Size = new Size(766, 107);
            txtAuthPass.TabIndex = 16;
            txtAuthPass.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(393, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 132);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AuthForm";
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel gradientPanel1;
        private Button btn_Verify;
        private Label label1;
        private Label label2;
        private TextBox txtAuthPass;
        private PictureBox pictureBox1;
        private Button button2;
    }
}