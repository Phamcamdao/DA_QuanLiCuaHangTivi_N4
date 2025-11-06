using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace DA_QuanLiCuaHangTivi
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng hoặc mật khẩu", "Thông báo");
                txtUser.Focus();
            }
            else
            {
                if (txtUser.Text == "admin" && txtPass.Text == "123")
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");

                    // Mở Form2
                    FormMENU f2 = new FormMENU();
                    f2.Show();  // Show form mới

                    this.Hide(); // Ẩn form đăng nhập (Form1)
                }
                else
                {
                    MessageBox.Show("Tên và mật khẩu không đúng, hãy nhập lại", "Thông báo");
                    txtUser.Clear();
                    txtPass.Clear();
                    txtUser.Focus();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
