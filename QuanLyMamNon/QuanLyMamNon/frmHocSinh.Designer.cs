﻿namespace QuanLyMamNon
{
    partial class frmHocSinh
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
            this.txtTelephoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClassCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgrvDSHocSinh = new System.Windows.Forms.DataGridView();
            this.tblHocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyManNonDataSet = new QuanLyMamNon.QuanLyManNonDataSet();
            this.tblHocSinhTableAdapter = new QuanLyMamNon.QuanLyManNonDataSetTableAdapters.tblHocSinhTableAdapter();
            this.maHocSinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHocSinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDSHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHocSinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyManNonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(464, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN HỌC SINH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtTelephoneNumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtClassCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1096, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học sinh";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFemale);
            this.groupBox2.Controls.Add(this.rbMale);
            this.groupBox2.Location = new System.Drawing.Point(720, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 66);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giới tính";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(151, 29);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(56, 26);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(42, 29);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(68, 26);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtTelephoneNumber
            // 
            this.txtTelephoneNumber.Location = new System.Drawing.Point(855, 32);
            this.txtTelephoneNumber.Name = "txtTelephoneNumber";
            this.txtTelephoneNumber.Size = new System.Drawing.Size(195, 30);
            this.txtTelephoneNumber.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(727, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số điện thoại:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(491, 88);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(195, 30);
            this.txtAddress.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa chỉ:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(491, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 30);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(144, 85);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(195, 30);
            this.txtStudentName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên học sinh:";
            // 
            // txtClassCode
            // 
            this.txtClassCode.Location = new System.Drawing.Point(144, 32);
            this.txtClassCode.Name = "txtClassCode";
            this.txtClassCode.Size = new System.Drawing.Size(195, 30);
            this.txtClassCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã lớp:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Location = new System.Drawing.Point(13, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1096, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao tác xử lý";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(947, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 32);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(677, 43);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(256, 30);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(442, 41);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(143, 32);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa học sinh";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(238, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 32);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa học sinh";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm học sinh";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // dgrvDSHocSinh
            // 
            this.dgrvDSHocSinh.AllowUserToAddRows = false;
            this.dgrvDSHocSinh.AllowUserToDeleteRows = false;
            this.dgrvDSHocSinh.AutoGenerateColumns = false;
            this.dgrvDSHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvDSHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHocSinhDataGridViewTextBoxColumn,
            this.tenHocSinhDataGridViewTextBoxColumn,
            this.maLopDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn});
            this.dgrvDSHocSinh.DataSource = this.tblHocSinhBindingSource;
            this.dgrvDSHocSinh.Location = new System.Drawing.Point(13, 316);
            this.dgrvDSHocSinh.Name = "dgrvDSHocSinh";
            this.dgrvDSHocSinh.ReadOnly = true;
            this.dgrvDSHocSinh.RowTemplate.Height = 24;
            this.dgrvDSHocSinh.Size = new System.Drawing.Size(1096, 302);
            this.dgrvDSHocSinh.TabIndex = 3;
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
            // maHocSinhDataGridViewTextBoxColumn
            // 
            this.maHocSinhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.maHocSinhDataGridViewTextBoxColumn.DataPropertyName = "MaHocSinh";
            this.maHocSinhDataGridViewTextBoxColumn.HeaderText = "Mã học sinh";
            this.maHocSinhDataGridViewTextBoxColumn.Name = "maHocSinhDataGridViewTextBoxColumn";
            this.maHocSinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.maHocSinhDataGridViewTextBoxColumn.Width = 135;
            // 
            // tenHocSinhDataGridViewTextBoxColumn
            // 
            this.tenHocSinhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.tenHocSinhDataGridViewTextBoxColumn.DataPropertyName = "TenHocSinh";
            this.tenHocSinhDataGridViewTextBoxColumn.HeaderText = "Tên học sinh";
            this.tenHocSinhDataGridViewTextBoxColumn.Name = "tenHocSinhDataGridViewTextBoxColumn";
            this.tenHocSinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenHocSinhDataGridViewTextBoxColumn.Width = 5;
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "Mã lớp";
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            this.maLopDataGridViewTextBoxColumn.ReadOnly = true;
            this.maLopDataGridViewTextBoxColumn.Width = 90;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.gioiTinhDataGridViewTextBoxColumn.Width = 101;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaySinhDataGridViewTextBoxColumn.Width = 108;
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "Diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            this.diachiDataGridViewTextBoxColumn.ReadOnly = true;
            this.diachiDataGridViewTextBoxColumn.Width = 5;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDTDataGridViewTextBoxColumn.Width = 96;
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 630);
            this.Controls.Add(this.dgrvDSHocSinh);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHocSinh";
            this.Text = "Thông tin học sinh";
            this.Load += new System.EventHandler(this.FrmHocSinh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.TextBox txtClassCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgrvDSHocSinh;
        private QuanLyManNonDataSet quanLyManNonDataSet;
        private System.Windows.Forms.BindingSource tblHocSinhBindingSource;
        private QuanLyManNonDataSetTableAdapters.tblHocSinhTableAdapter tblHocSinhTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHocSinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHocSinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
    }
}