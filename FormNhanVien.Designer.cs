namespace DA_QuanLiCuaHangTivi
{
    partial class FormNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            label1 = new Label();
            txtManv = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            txtTennv = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label2 = new Label();
            label6 = new Label();
            rdaNam = new RadioButton();
            rdaNu = new RadioButton();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            btnTim = new Button();
            txtSearch = new TextBox();
            menuStrip1 = new MenuStrip();
            memuThem = new ToolStripMenuItem();
            menuSua = new ToolStripMenuItem();
            xoáToolStripMenuItem = new ToolStripMenuItem();
            menuXoatrang = new ToolStripMenuItem();
            menuThoat = new ToolStripMenuItem();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(29, 92);
            label1.Name = "label1";
            label1.Size = new Size(116, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            // 
            // txtManv
            // 
            txtManv.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtManv.Location = new Point(170, 84);
            txtManv.Name = "txtManv";
            txtManv.Size = new Size(234, 30);
            txtManv.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(565, 87);
            label3.Name = "label3";
            label3.Size = new Size(68, 22);
            label3.TabIndex = 0;
            label3.Text = "Địa chỉ";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox4.Location = new Point(706, 81);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 30);
            textBox4.TabIndex = 1;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(29, 136);
            label4.Name = "label4";
            label4.Size = new Size(120, 22);
            label4.TabIndex = 0;
            label4.Text = "Tên nhân viên";
            // 
            // txtTennv
            // 
            txtTennv.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTennv.Location = new Point(170, 128);
            txtTennv.Name = "txtTennv";
            txtTennv.Size = new Size(234, 30);
            txtTennv.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label5.Location = new Point(565, 131);
            label5.Name = "label5";
            label5.Size = new Size(114, 22);
            label5.TabIndex = 0;
            label5.Text = "Số điện thoại";
            label5.Click += label5_Click;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox6.Location = new Point(706, 123);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(250, 30);
            textBox6.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(29, 179);
            label2.Name = "label2";
            label2.Size = new Size(81, 22);
            label2.TabIndex = 0;
            label2.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label6.Location = new Point(565, 175);
            label6.Name = "label6";
            label6.Size = new Size(88, 22);
            label6.TabIndex = 0;
            label6.Text = "Ngày sinh";
            label6.Click += label5_Click;
            // 
            // rdaNam
            // 
            rdaNam.AutoSize = true;
            rdaNam.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            rdaNam.Location = new Point(145, 175);
            rdaNam.Name = "rdaNam";
            rdaNam.Size = new Size(68, 26);
            rdaNam.TabIndex = 2;
            rdaNam.TabStop = true;
            rdaNam.Text = "Nam";
            rdaNam.UseVisualStyleBackColor = true;
            // 
            // rdaNu
            // 
            rdaNu.AutoSize = true;
            rdaNu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            rdaNu.Location = new Point(255, 175);
            rdaNu.Name = "rdaNu";
            rdaNu.Size = new Size(56, 26);
            rdaNu.TabIndex = 2;
            rdaNu.TabStop = true;
            rdaNu.Text = "Nữ";
            rdaNu.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1000, 355);
            dataGridView1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(706, 170);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label7.Location = new Point(600, 591);
            label7.Name = "label7";
            label7.Size = new Size(151, 22);
            label7.TabIndex = 0;
            label7.Text = "Tìm kiếm theo tên";
            label7.Click += label5_Click;
            // 
            // btnTim
            // 
            btnTim.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnTim.Location = new Point(935, 580);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 44);
            btnTim.TabIndex = 5;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtSearch.Location = new Point(757, 588);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(169, 30);
            txtSearch.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { memuThem, menuSua, xoáToolStripMenuItem, menuXoatrang, menuThoat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1052, 30);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // memuThem
            // 
            memuThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            memuThem.Image = (Image)resources.GetObject("memuThem.Image");
            memuThem.Name = "memuThem";
            memuThem.Size = new Size(88, 26);
            memuThem.Text = "Thêm";
            // 
            // menuSua
            // 
            menuSua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            menuSua.Image = (Image)resources.GetObject("menuSua.Image");
            menuSua.Name = "menuSua";
            menuSua.Size = new Size(75, 26);
            menuSua.Text = "Sửa";
            // 
            // xoáToolStripMenuItem
            // 
            xoáToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            xoáToolStripMenuItem.Image = (Image)resources.GetObject("xoáToolStripMenuItem.Image");
            xoáToolStripMenuItem.Name = "xoáToolStripMenuItem";
            xoáToolStripMenuItem.Size = new Size(77, 26);
            xoáToolStripMenuItem.Tag = "menuXoa";
            xoáToolStripMenuItem.Text = "Xoá";
            // 
            // menuXoatrang
            // 
            menuXoatrang.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            menuXoatrang.Image = (Image)resources.GetObject("menuXoatrang.Image");
            menuXoatrang.Name = "menuXoatrang";
            menuXoatrang.Size = new Size(121, 26);
            menuXoatrang.Text = "Xóa trắng";
            // 
            // menuThoat
            // 
            menuThoat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            menuThoat.Image = (Image)resources.GetObject("menuThoat.Image");
            menuThoat.Name = "menuThoat";
            menuThoat.Size = new Size(89, 26);
            menuThoat.Text = "Thoát";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.Location = new Point(348, 30);
            label8.Name = "label8";
            label8.Size = new Size(321, 38);
            label8.TabIndex = 8;
            label8.Text = "Danh mục nhân viên";
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1052, 636);
            Controls.Add(label8);
            Controls.Add(txtSearch);
            Controls.Add(btnTim);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(rdaNu);
            Controls.Add(rdaNam);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(txtTennv);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(txtManv);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormNhanVien";
            Text = "FormNhanVien";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtManv;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox txtTennv;
        private Label label5;
        private TextBox textBox6;
        private Label label2;
        private Label label6;
        private RadioButton rdaNam;
        private RadioButton rdaNu;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Button btnTim;
        private TextBox txtSearch;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem memuThem;
        private ToolStripMenuItem menuSua;
        private ToolStripMenuItem xoáToolStripMenuItem;
        private ToolStripMenuItem menuXoatrang;
        private ToolStripMenuItem menuThoat;
        private Label label8;
    }
}