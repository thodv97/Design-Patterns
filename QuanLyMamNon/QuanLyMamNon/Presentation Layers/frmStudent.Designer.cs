using QuanLyMamNon.Data_Layers;

namespace QuanLyMamNon
{
    partial class frmStudent
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelephoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txxParentsName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbChungMinhThu = new System.Windows.Forms.CheckBox();
            this.cbSoHoKhau = new System.Windows.Forms.CheckBox();
            this.cbGiayKhaiSinh = new System.Windows.Forms.CheckBox();
            this.dgrvDSHocSinh = new System.Windows.Forms.DataGridView();
            this.MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhuHuynh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BanSaoGiayKhaiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BanSaoSoHoKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BanSaoTCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblHocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyManNonDataSet = new QuanLyMamNon.Data_Layers.QuanLyManNonDataSet();
            this.tblHocSinhTableAdapter = new QuanLyMamNon.Data_Layers.QuanLyManNonDataSetTableAdapters.tblHocSinhTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDSHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHocSinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyManNonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(385, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN HỌC SINH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtClassID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(662, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học sinh";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFemale);
            this.groupBox2.Controls.Add(this.rbMale);
            this.groupBox2.Location = new System.Drawing.Point(391, 83);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(233, 75);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giới tính";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(160, 33);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(61, 29);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(46, 33);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(75, 29);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(497, 39);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 33);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(139, 87);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(230, 33);
            this.txtStudentName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên học sinh:";
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(139, 39);
            this.txtClassID.Margin = new System.Windows.Forms.Padding(4);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(230, 33);
            this.txtClassID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã lớp:";
            // 
            // txtTelephoneNumber
            // 
            this.txtTelephoneNumber.Location = new System.Drawing.Point(164, 85);
            this.txtTelephoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelephoneNumber.Name = "txtTelephoneNumber";
            this.txtTelephoneNumber.Size = new System.Drawing.Size(230, 33);
            this.txtTelephoneNumber.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số điện thoại:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(164, 130);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(230, 33);
            this.txtAddress.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa chỉ:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Location = new System.Drawing.Point(12, 388);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1152, 113);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao tác xử lý";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1008, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(770, 49);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 34);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(294, 46);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(156, 37);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa học sinh";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(551, 46);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 37);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa học sinh";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(35, 46);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm học sinh";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txxParentsName);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtAddress);
            this.groupBox4.Controls.Add(this.txtTelephoneNumber);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(726, 52);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(438, 182);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin phụ huynh";
            // 
            // txxParentsName
            // 
            this.txxParentsName.Location = new System.Drawing.Point(164, 39);
            this.txxParentsName.Margin = new System.Windows.Forms.Padding(4);
            this.txxParentsName.Name = "txxParentsName";
            this.txxParentsName.Size = new System.Drawing.Size(230, 33);
            this.txxParentsName.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tên phụ huynh:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbChungMinhThu);
            this.groupBox5.Controls.Add(this.cbSoHoKhau);
            this.groupBox5.Controls.Add(this.cbGiayKhaiSinh);
            this.groupBox5.Location = new System.Drawing.Point(12, 239);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(1151, 144);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Các loại giấy tờ";
            // 
            // cbChungMinhThu
            // 
            this.cbChungMinhThu.AutoSize = true;
            this.cbChungMinhThu.Location = new System.Drawing.Point(317, 49);
            this.cbChungMinhThu.Margin = new System.Windows.Forms.Padding(4);
            this.cbChungMinhThu.Name = "cbChungMinhThu";
            this.cbChungMinhThu.Size = new System.Drawing.Size(547, 29);
            this.cbChungMinhThu.TabIndex = 3;
            this.cbChungMinhThu.Text = "Bảo sao thẻ căn cước công dân / Chứng minh thư nhân dân";
            this.cbChungMinhThu.UseVisualStyleBackColor = true;
            // 
            // cbSoHoKhau
            // 
            this.cbSoHoKhau.AutoSize = true;
            this.cbSoHoKhau.Location = new System.Drawing.Point(11, 95);
            this.cbSoHoKhau.Margin = new System.Windows.Forms.Padding(4);
            this.cbSoHoKhau.Name = "cbSoHoKhau";
            this.cbSoHoKhau.Size = new System.Drawing.Size(205, 29);
            this.cbSoHoKhau.TabIndex = 2;
            this.cbSoHoKhau.Text = "Bản sao sổ hộ khẩu";
            this.cbSoHoKhau.UseVisualStyleBackColor = true;
            // 
            // cbGiayKhaiSinh
            // 
            this.cbGiayKhaiSinh.AutoSize = true;
            this.cbGiayKhaiSinh.Location = new System.Drawing.Point(11, 49);
            this.cbGiayKhaiSinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbGiayKhaiSinh.Name = "cbGiayKhaiSinh";
            this.cbGiayKhaiSinh.Size = new System.Drawing.Size(231, 29);
            this.cbGiayKhaiSinh.TabIndex = 1;
            this.cbGiayKhaiSinh.Text = "Bản sao giấy khai sinh";
            this.cbGiayKhaiSinh.UseVisualStyleBackColor = true;
            // 
            // dgrvDSHocSinh
            // 
            this.dgrvDSHocSinh.AllowUserToAddRows = false;
            this.dgrvDSHocSinh.AllowUserToDeleteRows = false;
            this.dgrvDSHocSinh.AutoGenerateColumns = false;
            this.dgrvDSHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrvDSHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvDSHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocSinh,
            this.TenHocSinh,
            this.TenPhuHuynh,
            this.MaLop,
            this.GioiTinh,
            this.NgaySinh,
            this.Diachi,
            this.SDT,
            this.BanSaoGiayKhaiSinh,
            this.BanSaoSoHoKhau,
            this.BanSaoTCC});
            this.dgrvDSHocSinh.DataSource = this.tblHocSinhBindingSource;
            this.dgrvDSHocSinh.GridColor = System.Drawing.Color.PapayaWhip;
            this.dgrvDSHocSinh.Location = new System.Drawing.Point(12, 515);
            this.dgrvDSHocSinh.Margin = new System.Windows.Forms.Padding(4);
            this.dgrvDSHocSinh.Name = "dgrvDSHocSinh";
            this.dgrvDSHocSinh.ReadOnly = true;
            this.dgrvDSHocSinh.RowTemplate.Height = 24;
            this.dgrvDSHocSinh.Size = new System.Drawing.Size(1151, 248);
            this.dgrvDSHocSinh.TabIndex = 3;
            this.dgrvDSHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgrvDSHocSinh_CellClick);
            // 
            // MaHocSinh
            // 
            this.MaHocSinh.DataPropertyName = "MaHocSinh";
            this.MaHocSinh.HeaderText = "Mã HS";
            this.MaHocSinh.Name = "MaHocSinh";
            this.MaHocSinh.ReadOnly = true;
            this.MaHocSinh.Width = 103;
            // 
            // TenHocSinh
            // 
            this.TenHocSinh.DataPropertyName = "TenHocSinh";
            this.TenHocSinh.HeaderText = "Tên HS";
            this.TenHocSinh.Name = "TenHocSinh";
            this.TenHocSinh.ReadOnly = true;
            this.TenHocSinh.Width = 108;
            // 
            // TenPhuHuynh
            // 
            this.TenPhuHuynh.DataPropertyName = "TenPhuHuynh";
            this.TenPhuHuynh.HeaderText = "Tên PH";
            this.TenPhuHuynh.Name = "TenPhuHuynh";
            this.TenPhuHuynh.ReadOnly = true;
            this.TenPhuHuynh.Width = 108;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            this.MaLop.Width = 105;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 119;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Width = 129;
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "Diachi";
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.Name = "Diachi";
            this.Diachi.ReadOnly = true;
            this.Diachi.Width = 105;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 83;
            // 
            // BanSaoGiayKhaiSinh
            // 
            this.BanSaoGiayKhaiSinh.DataPropertyName = "BanSaoGiayKhaiSinh";
            this.BanSaoGiayKhaiSinh.HeaderText = "Bản sao GKS";
            this.BanSaoGiayKhaiSinh.Name = "BanSaoGiayKhaiSinh";
            this.BanSaoGiayKhaiSinh.ReadOnly = true;
            this.BanSaoGiayKhaiSinh.Width = 160;
            // 
            // BanSaoSoHoKhau
            // 
            this.BanSaoSoHoKhau.DataPropertyName = "BanSaoSoHoKhau";
            this.BanSaoSoHoKhau.HeaderText = "Bản sao SHK";
            this.BanSaoSoHoKhau.Name = "BanSaoSoHoKhau";
            this.BanSaoSoHoKhau.ReadOnly = true;
            this.BanSaoSoHoKhau.Width = 159;
            // 
            // BanSaoTCC
            // 
            this.BanSaoTCC.DataPropertyName = "BanSaoTCC";
            this.BanSaoTCC.HeaderText = "Bản sao TCC";
            this.BanSaoTCC.Name = "BanSaoTCC";
            this.BanSaoTCC.ReadOnly = true;
            this.BanSaoTCC.Width = 161;
            // 
            // tblHocSinhBindingSource
            // 
            this.tblHocSinhBindingSource.DataMember = "tblHocSinh";
            this.tblHocSinhBindingSource.DataSource = this.quanLyManNonDataSet;
            // 
            // quanLyManNonDataSet
            // 
            this.quanLyManNonDataSet.DataSetName = "QuanLyManNonDataSet";
            this.quanLyManNonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHocSinhTableAdapter
            // 
            this.tblHocSinhTableAdapter.ClearBeforeFill = true;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 774);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgrvDSHocSinh);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin học sinh";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDSHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHocSinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyManNonDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTelephoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txxParentsName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbSoHoKhau;
        private System.Windows.Forms.CheckBox cbGiayKhaiSinh;
        private System.Windows.Forms.CheckBox cbChungMinhThu;
        private System.Windows.Forms.DataGridView dgrvDSHocSinh;
        private QuanLyManNonDataSet quanLyManNonDataSet;
        private System.Windows.Forms.BindingSource tblHocSinhBindingSource;
        private Data_Layers.QuanLyManNonDataSetTableAdapters.tblHocSinhTableAdapter tblHocSinhTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHocSinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHocSinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhuHuynhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn banSaoGiayKhaiSinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn banSaoSoHoKhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn banSaoTCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhuHuynh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BanSaoGiayKhaiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn BanSaoSoHoKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn BanSaoTCC;
    }
}