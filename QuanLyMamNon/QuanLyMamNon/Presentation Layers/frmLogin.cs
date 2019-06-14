using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMamNon.Presentation_Layers
{
    public partial class frmLogin : Form
    {
        frmStudent CBTS;
        //frmReport MGR;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string taiKhoan, matKhau, chucVu;
            string query = "SELECT * FROM tblTaiKhoan WHERE TaiKhoan = '" + userName + "'";
            
            try
            {
                SqlDataReader reader = SingletonDB.GetDataReader(query);
                reader.Read();
                taiKhoan = reader["TaiKhoan"].ToString();
                matKhau = reader["MatKhau"].ToString();
                chucVu = reader["ChucVu"].ToString();

                if(password == matKhau)
                {
                    if(chucVu == "Cán bộ tuyển sinh")
                    {
                        CBTS = new frmStudent();
                        CBTS.Show();
                    }
                    else if (chucVu == "Ban giám hiệu")
                    {
                        //MGR = new frmReport();
                        //MGR.Show();
                    }
                    Hide();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không chính xác", "Kết Quả Đăng Nhập", MessageBoxButtons.OK);
                }
            }
            catch 
            {
                MessageBox.Show("Tên Đăng Nhập Không Hợp Lệ", "Kết Quả Đăng Nhập", MessageBoxButtons.OK);
            }

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void BtnQuenMatKhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liên hệ trực tiếp Quản trị viên để được cấp lại!", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
