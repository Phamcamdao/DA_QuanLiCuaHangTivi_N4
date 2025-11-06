namespace DA_QuanLiCuaHangTivi
{
    partial class FormMENU
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMaSP = new TextBox();
            txtTenSP = new TextBox();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            menuStrip1 = new MenuStrip();
            thêmToolStripMenuItem = new ToolStripMenuItem();
            sửaToolStripMenuItem = new ToolStripMenuItem();
            xóaToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 39);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(184, 420);
            label2.Name = "label2";
            label2.Size = new Size(146, 21);
            label2.TabIndex = 1;
            label2.Text = "Tìm kiếm theo tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 72);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 2;
            label3.Text = "Tên sản phẩm";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(180, 37);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(150, 23);
            txtMaSP.TabIndex = 3;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(180, 70);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(150, 23);
            txtTenSP.TabIndex = 4;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(336, 418);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(150, 23);
            txtTimKiem.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimKiem.Location = new Point(520, 415);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(124, 28);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { thêmToolStripMenuItem, sửaToolStripMenuItem, xóaToolStripMenuItem, thoátToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // thêmToolStripMenuItem
            // 
            thêmToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            thêmToolStripMenuItem.Size = new Size(54, 20);
            thêmToolStripMenuItem.Text = "Thêm ";
            // 
            // sửaToolStripMenuItem
            // 
            sửaToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            sửaToolStripMenuItem.Size = new Size(40, 20);
            sửaToolStripMenuItem.Text = "Sửa";
            // 
            // xóaToolStripMenuItem
            // 
            xóaToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            xóaToolStripMenuItem.Size = new Size(40, 20);
            xóaToolStripMenuItem.Text = "Xóa";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(51, 20);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 280);
            dataGridView1.TabIndex = 8;
            // 
            // FormMENU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(txtTenSP);
            Controls.Add(txtMaSP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMENU";
            Text = "Danh mục sản phẩm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMaSP;
        private TextBox txtTenSP;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem thêmToolStripMenuItem;
        private ToolStripMenuItem sửaToolStripMenuItem;
        private ToolStripMenuItem xóaToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private DataGridView dataGridView1;
    }
}