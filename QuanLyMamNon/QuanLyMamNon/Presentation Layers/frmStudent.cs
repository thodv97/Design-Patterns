using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyMamNon
{
    public partial class frmStudent : Form
    {
        private static DataTable dataTable;
        public frmStudent()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string classID = txtClassID.Text;
            string telephoneNumber = txtTelephoneNumber.Text;
            string studentName = XuLyChuoi.StringHandling(txtStudentName.Text);
            string address = XuLyChuoi.StringHandling(txtAddress.Text);
            string parentsName = XuLyChuoi.StringHandling(txxParentsName.Text);
            string brithday = "Convert(DATE, '" + dateTimePicker1.Text + "', 103)";
            string gender = "Nữ"; 
            if (rbMale.Checked) gender = "Nam";
            string soHoKhau = "Chưa nộp";
            if (cbSoHoKhau.Checked) soHoKhau = "Đã nộp";
            string giayKhaiSinh = "Chưa nộp";
            if (cbGiayKhaiSinh.Checked) giayKhaiSinh = "Đã nộp";
            string chungMinhThu = "Chưa nộp";
            if (cbChungMinhThu.Checked) chungMinhThu = "Đã nộp";

            if (classID == "" || studentName == "" || address == "" || telephoneNumber == "" || parentsName == "")
            {
                MessageBox.Show("Thông tin không hợp lệ. Xin kiểm tra lại !", "Message", MessageBoxButtons.OK);
            }
            else
            {
                // Câu lệnh insert
                string query = "INSERT INTO tblHocSinh VALUES(N'" + studentName + "', '" + classID + "', N'" + gender + "', " + brithday + ", N'"
                    + address + "', '" + telephoneNumber + "', N'" + parentsName + "', N'" + giayKhaiSinh + "', N'" +
                    soHoKhau + "', N'" + chungMinhThu + "');";

                try
                {
                    SingletonDB.ExcuteQuery(query);

                    // Refresh DB
                    dataTable = SingletonDB.GetDataToDataTable("SELECT * FROM tblHocSinh");
                    dgrvDSHocSinh.DataSource = dataTable;

                    // Cell Click
                    DataDisplay();
                    MessageBox.Show("Inserted successful !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            tblHocSinhTableAdapter.Fill(quanLyManNonDataSet.tblHocSinh);

            dataTable = quanLyManNonDataSet.tblHocSinh;
            DataDisplay();
        }

        private void DgrvDSHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataDisplay();

            txtSearch.SelectAll();
            txtSearch.Focus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn xóa ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                // Do nothing !
            }
            else
            {
                // Câu lệnh delete
                string maHocSinh = dgrvDSHocSinh.CurrentRow.Cells["MaHocSinh"].Value.ToString();
                string query = "DELETE tblHocSinh WHERE MaHocSinh = '" + maHocSinh + "'";

                try
                {
                    SingletonDB.ExcuteQuery(query);

                    // Refresh database
                    dgrvDSHocSinh.DataSource = SingletonDB.GetDataToDataTable("SELECT * FROM tblHocSinh");

                    // Cell Click
                    DataDisplay();
                    MessageBox.Show("Delete successful !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            txtSearch.SelectAll();
            txtSearch.Focus();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn sửa ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.No)
            {
                // Do nothing !
            }
            else
            {
                string maHocSinh = dgrvDSHocSinh.CurrentRow.Cells["MaHocSinh"].Value.ToString();

                string classID = txtClassID.Text;
                string telephoneNumber = txtTelephoneNumber.Text;
                string studentName = XuLyChuoi.StringHandling(txtStudentName.Text);
                string address = XuLyChuoi.StringHandling(txtAddress.Text);
                string parentsName = XuLyChuoi.StringHandling(txxParentsName.Text);
                string brithday = "Convert(DATE, '" + dateTimePicker1.Text + "', 103)";
                string gender = "Nữ";
                if (rbMale.Checked) gender = "Nam";
                string soHoKhau = "Chưa nộp";
                if (cbSoHoKhau.Checked) soHoKhau = "Đã nộp";
                string giayKhaiSinh = "Chưa nộp";
                if (cbGiayKhaiSinh.Checked) giayKhaiSinh = "Đã nộp";
                string chungMinhThu = "Chưa nộp";
                if (cbChungMinhThu.Checked) chungMinhThu = "Đã nộp";

                if (classID == "" || studentName == "" || address == "" || telephoneNumber == "" || parentsName == "")
                {
                    MessageBox.Show("Thông tin không hợp lệ. Xin kiểm tra lại !", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    // Câu lệnh update
                    string query = "UPDATE tblHocSinh SET TenHocSinh = N'" + studentName + "', MaLop = '" + classID + "', GioiTinh = N'" + gender + "', NgaySinh = " + brithday + ", DiaChi = N'"
                        + address + "', SDT = '" + telephoneNumber + "', TenPhuHuynh = N'" + parentsName + "', BanSaoGiayKhaiSinh = N'" + 
                        giayKhaiSinh + "', BanSaoSoHoKhau = N'" + soHoKhau + "', BanSaoTCC = N'" + chungMinhThu + "' WHERE MaHocSinh = '" + maHocSinh + "';";            

                    try
                    {
                        SingletonDB.ExcuteQuery(query);

                        // Refresh DB
                        dataTable = SingletonDB.GetDataToDataTable("SELECT * FROM tblHocSinh");

                        // Cell Click
                        DataView dataView = dataTable.DefaultView;

                        dataView.RowFilter = "TenHocSinh LIKE '%" + txtSearch.Text.Trim() + "%' OR DiaChi LIKE '%" + txtSearch.Text.Trim() + "%' OR SDT LIKE '%" + txtSearch.Text.Trim() + "%' OR GioiTinh LIKE '%"
                            + txtSearch.Text.Trim() + "%' OR MaLop LIKE '%" + txtSearch.Text.Trim() + "%'";
                        dgrvDSHocSinh.DataSource = dataView;

                        DataDisplay();
                        MessageBox.Show("Updated successful !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            txtSearch.SelectAll();
            txtSearch.Focus();
        }

        private void DataDisplay()
        {
            if (dgrvDSHocSinh.Rows.Count > 0)
            {
                txtClassID.Text = dgrvDSHocSinh.CurrentRow.Cells["MaLop"].Value.ToString();
                txtStudentName.Text = dgrvDSHocSinh.CurrentRow.Cells["TenHocSinh"].Value.ToString();
                dateTimePicker1.Text = dgrvDSHocSinh.CurrentRow.Cells["NgaySinh"].Value.ToString();
                txtAddress.Text = dgrvDSHocSinh.CurrentRow.Cells["DiaChi"].Value.ToString();
                txtTelephoneNumber.Text = dgrvDSHocSinh.CurrentRow.Cells["SDT"].Value.ToString();
                txxParentsName.Text = dgrvDSHocSinh.CurrentRow.Cells["TenPhuHuynh"].Value.ToString(); ;
                if (dgrvDSHocSinh.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam")
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }

                if (dgrvDSHocSinh.CurrentRow.Cells["BanSaoGiayKhaiSinh"].Value.ToString() == "Đã nộp")
                {
                    cbGiayKhaiSinh.Checked = true;
                }
                else
                {
                    cbGiayKhaiSinh.Checked = false;
                }

                if (dgrvDSHocSinh.CurrentRow.Cells["BanSaoSoHoKhau"].Value.ToString() == "Đã nộp")
                {
                    cbSoHoKhau.Checked = true;
                }
                else
                {
                    cbSoHoKhau.Checked = false;
                }

                if (dgrvDSHocSinh.CurrentRow.Cells["BanSaoTCC"].Value.ToString() == "Đã nộp")
                {
                    cbChungMinhThu.Checked = true;
                }
                else
                {
                    cbChungMinhThu.Checked = false;
                }
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            // Searching          
            DataView dataView = dataTable.DefaultView;

            dataView.RowFilter = "TenHocSinh LIKE '%" + txtSearch.Text.Trim() + "%' OR DiaChi LIKE '%" + txtSearch.Text.Trim() + "%' OR SDT LIKE '%" + txtSearch.Text.Trim() + "%' OR GioiTinh LIKE '%"
                + txtSearch.Text.Trim() + "%' OR MaLop LIKE '%" + txtSearch.Text.Trim() + "%' OR TenPhuHuynh LIKE '%" + txtSearch.Text.Trim() + "%'";

            dgrvDSHocSinh.DataSource = dataView;
            DataDisplay();          
        }

    }
}
