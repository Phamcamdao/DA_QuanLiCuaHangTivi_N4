using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Data.SqlClient;
using Microsoft.VisualBasic;


namespace DA_QuanLiCuaHangTivi
{
    public partial class FormRegister : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-4N8UEI6E\SQLEXPRESS;Initial Catalog=QuanLyCuaHangTivi;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

        public FormRegister()
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

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            Form1 Login = new Form1();
            Login.Show();
            this.Hide();
        }

        private void btnDangnhap_Click_1(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "" || txtChangePass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string chechUsername = "SELECT *   FROM TaiKhoan WHERE Username = @usern";
                        using (SqlCommand cmd = new SqlCommand(chechUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", txtUser.Text.Trim());
                            SqlDataAdapter apadapter = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            apadapter.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                MessageBox.Show(txtUser.Text.Trim()
                                    + "Đã được thực hiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (txtPass.Text.Length < 8)
                            {
                                MessageBox.Show("Mật khẩu không hợp lệ, cần ít nhất 8 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (txtPass.Text.Trim() != txtChangePass.Text.Trim())
                            {
                                MessageBox.Show("Mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO TaiKhoan (Username, Password, Role, Status, date) " +
                                  " VALUES(@usern, @pass, @role, @status, @date)";
                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@usern", txtUser.Text.Trim());
                                    insertD.Parameters.AddWithValue("@pass", txtPass.Text.Trim());
                                    insertD.Parameters.AddWithValue("@role", "active");
                                    insertD.Parameters.AddWithValue("@status", "Approval");

                                    DataTime today = DataTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Form1 Login = new Form1();
                                    Login.Show();
                                    this.Hide();
                                }
                            }
                        }



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
        public bool checkConnection()
        {
            if(connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}