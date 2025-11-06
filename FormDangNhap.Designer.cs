namespace DA_QuanLiCuaHangTivi
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnDangnhap = new Button();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(391, 579);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aqua;
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(391, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 110);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(70, 32);
            label1.Name = "label1";
            label1.Size = new Size(489, 38);
            label1.TabIndex = 0;
            label1.Text = "Phần mềm quản lý cửa hàng TV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(527, 134);
            label2.Name = "label2";
            label2.Size = new Size(124, 22);
            label2.TabIndex = 2;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(527, 219);
            label3.Name = "label3";
            label3.Size = new Size(82, 22);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // btnDangnhap
            // 
            btnDangnhap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnDangnhap.Location = new Point(526, 317);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(125, 44);
            btnDangnhap.TabIndex = 4;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(527, 168);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(394, 27);
            txtUser.TabIndex = 5;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(527, 260);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(394, 27);
            txtPass.TabIndex = 6;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThoat.Location = new Point(797, 317);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(124, 44);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1052, 575);
            Controls.Add(btnThoat);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(btnDangnhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDangNhap";
            Load += FormDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnDangnhap;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnThoat;
    }
}