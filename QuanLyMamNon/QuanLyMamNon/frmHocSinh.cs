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
                    MessageBox.Show("Inserted successful !");

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM tblHocSinh", conn);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    dgrvDSHocSinh.DataSource = dataTable;
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
            this.tblHocSinhTableAdapter.Fill(this.quanLyManNonDataSet.tblHocSinh);
            SqlConnection conn = DB_Utilities.GetDBConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM tblHocSinh", conn);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dgrvDSHocSinh.DataSource = dataTable;
        }
    }
}
