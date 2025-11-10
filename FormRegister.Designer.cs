namespace DA_QuanLiCuaHangTivi
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            labelLogin = new Label();
            label3 = new Label();
            txtChangePass = new TextBox();
            btnDangnhap = new Button();
            txtPass = new TextBox();
            txtUser = new TextBox();
            label2 = new Label();
            btnThoat = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(labelLogin);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtChangePass);
            panel2.Controls.Add(btnDangnhap);
            panel2.Controls.Add(txtPass);
            panel2.Controls.Add(txtUser);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(134, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(537, 374);
            panel2.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(111, 242);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(111, 203);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(111, 159);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(207, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.BackColor = Color.White;
            labelLogin.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelLogin.ForeColor = SystemColors.Highlight;
            labelLogin.Location = new Point(250, 340);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(94, 19);
            labelLogin.TabIndex = 3;
            labelLogin.Text = "Sign In Here";
            labelLogin.Click += labelLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(91, 340);
            label3.Name = "label3";
            label3.Size = new Size(153, 19);
            label3.TabIndex = 3;
            label3.Text = "Have no account yet?";
            // 
            // txtChangePass
            // 
            txtChangePass.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtChangePass.Location = new Point(157, 242);
            txtChangePass.Name = "txtChangePass";
            txtChangePass.PasswordChar = '*';
            txtChangePass.Size = new Size(237, 30);
            txtChangePass.TabIndex = 1;
            // 
            // btnDangnhap
            // 
            btnDangnhap.BackColor = Color.Silver;
            btnDangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDangnhap.Location = new Point(111, 278);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(283, 47);
            btnDangnhap.TabIndex = 2;
            btnDangnhap.Text = "SignUp";
            btnDangnhap.UseVisualStyleBackColor = false;
            btnDangnhap.Click += btnDangnhap_Click_1;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPass.Location = new Point(157, 203);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(237, 30);
            txtPass.TabIndex = 1;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtUser.Location = new Point(157, 157);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(237, 30);
            txtUser.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(148, 116);
            label2.Name = "label2";
            label2.Size = new Size(215, 32);
            label2.TabIndex = 0;
            label2.Text = "Register Account";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThoat.Location = new Point(671, 21);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(67, 31);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "x";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(768, 513);
            Controls.Add(panel2);
            Controls.Add(btnThoat);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegister";
            Load += FormDangNhap_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label labelLogin;
        private Label label3;
        private Button btnDangnhap;
        private TextBox txtPass;
        private TextBox txtUser;
        private Label label2;
        private Button btnThoat;
        private PictureBox pictureBox4;
        private TextBox txtChangePass;
    }
}