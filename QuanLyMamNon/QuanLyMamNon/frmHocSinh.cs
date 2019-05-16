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

namespace QuanLyMamNon
{
    public partial class frmHocSinh : Form
    {
        private static DataTable dataTable;
        public frmHocSinh()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string classCode = txtClassCode.Text;
            string studentName = txtStudentName.Text;
            string brithday = "Convert(DATE, '" + dateTimePicker1.Text + "', 103)";
            string address = txtAddress.Text;
            string telephoneNumber = txtTelephoneNumber.Text;
            string gender = "Nữ";
            if (rbMale.Checked) gender = "Nam";
            
            if(classCode == "" || studentName == "" || brithday == "" || address == "" || gender == "" || telephoneNumber == "")
            {
                MessageBox.Show("Thông tin không hợp lệ. Xin kiểm tra lại !", "Message", MessageBoxButtons.OK);
            }
            else
            {
                // Câu lệnh insert
                string query = "INSERT INTO tblHocSinh VALUES(N'" + studentName + "', '" + classCode + "', N'" + gender + "', " + brithday + ", N'"
                    + address + "', '" + telephoneNumber + "');";
                SqlConnection conn = DB_Utilities.GetDBConnection();

                try
                {
                    conn.Open();

                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.ExecuteNonQuery();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM tblHocSinh", conn);
                    dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    dgrvDSHocSinh.DataSource = dataTable;
                    MessageBox.Show("Inserted successful !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void FrmHocSinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyManNonDataSet.tblHocSinh' table. You can move, or remove it, as needed.
            //this.tblHocSinhTableAdapter.Fill(this.quanLyManNonDataSet.tblHocSinh);
            
            SqlConnection conn = DB_Utilities.GetDBConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM tblHocSinh", conn);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dgrvDSHocSinh.DataSource = dataTable;
        }

        private void DgrvDSHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtClassCode.Text = dgrvDSHocSinh.CurrentRow.Cells["MaLop"].Value.ToString();
            txtStudentName.Text = dgrvDSHocSinh.CurrentRow.Cells["TenHocSinh"].Value.ToString();
            dateTimePicker1.Text = dgrvDSHocSinh.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txtAddress.Text = dgrvDSHocSinh.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtTelephoneNumber.Text = dgrvDSHocSinh.CurrentRow.Cells["SDT"].Value.ToString();
            if(dgrvDSHocSinh.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
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
                SqlConnection conn = DB_Utilities.GetDBConnection();

                try
                {
                    conn.Open();

                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.ExecuteNonQuery();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM tblHocSinh", conn);
                    dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    dgrvDSHocSinh.DataSource = dataTable;
                    MessageBox.Show("Deleted successful !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
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

                string classCode = txtClassCode.Text;
                string studentName = txtStudentName.Text;
                string brithday = "Convert(DATE, '" + dateTimePicker1.Text + "', 103)";
                string address = txtAddress.Text;
                string telephoneNumber = txtTelephoneNumber.Text;
                string gender = "Nữ";
                if (rbMale.Checked) gender = "Nam";

                if (classCode == "" || studentName == "" || brithday == "" || address == "" || gender == "" || telephoneNumber == "")
                {
                    MessageBox.Show("Thông tin không hợp lệ. Xin kiểm tra lại !", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    // Câu lệnh update
                    string query = "UPDATE tblHocSinh SET TenHocSinh = N'" + studentName + "', MaLop = '" + classCode + "', GioiTinh = N'" + gender + "', NgaySinh = " + brithday + ", DiaChi = N'"
                        + address + "', SDT = '" + telephoneNumber + "' WHERE MaHocSinh = '" + maHocSinh + "';";
                    SqlConnection conn = DB_Utilities.GetDBConnection();

                    try
                    {
                        conn.Open();

                        SqlCommand sqlCommand = new SqlCommand(query, conn);
                        sqlCommand.ExecuteNonQuery();

                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM tblHocSinh", conn);
                        dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);

                        dgrvDSHocSinh.DataSource = dataTable;
                        MessageBox.Show("Updated successful !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = dataTable.DefaultView;

            dataView.RowFilter = "TenHocSinh LIKE '%" + txtSearch.Text.Trim() + "%' OR DiaChi LIKE '%" + txtSearch.Text.Trim() + "%' OR SDT LIKE '%" + txtSearch.Text.Trim() + "%' OR GioiTinh LIKE '%"
                + txtSearch.Text.Trim() + "%' OR MaLop LIKE '%" + txtSearch.Text.Trim() + "%'";// OR NgaySinh LIKE '%" + txtSearch.Text + "%'";
            dgrvDSHocSinh.DataSource = dataView;
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if(txtSearch.Text.Trim() == "")
            {
                txtSearch.Text = "... Tìm kiếm ...";
                txtSearch.ForeColor = Color.DarkGray;

                SqlConnection conn = DB_Utilities.GetDBConnection();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM tblHocSinh", conn);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dgrvDSHocSinh.DataSource = dataTable;
            }
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "... Tìm kiếm ...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }
    }
}
