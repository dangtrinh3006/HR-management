
namespace QuanLyNhanSu.ListForm
{
    partial class TaiKhoan
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
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTTNV = new System.Windows.Forms.Label();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.dg2 = new System.Windows.Forms.DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuyenHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaNv = new System.Windows.Forms.TextBox();
            this.lbmaNV = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtReMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.cbQuyenHan = new System.Windows.Forms.ComboBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTaiKhoan2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMKNL = new System.Windows.Forms.TextBox();
            this.txtMKM = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg1
            // 
            this.dg1.AllowUserToAddRows = false;
            this.dg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.ChucVu});
            this.dg1.Location = new System.Drawing.Point(22, 102);
            this.dg1.Margin = new System.Windows.Forms.Padding(4);
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowHeadersWidth = 51;
            this.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg1.Size = new System.Drawing.Size(581, 157);
            this.dg1.TabIndex = 31;
            this.dg1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg1_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNhanVien";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Nhân Viên";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNV";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Nhân Viên";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "TenCV";
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            // 
            // lbTTNV
            // 
            this.lbTTNV.AutoSize = true;
            this.lbTTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTTNV.Location = new System.Drawing.Point(360, 9);
            this.lbTTNV.Name = "lbTTNV";
            this.lbTTNV.Size = new System.Drawing.Size(312, 32);
            this.lbTTNV.TabIndex = 30;
            this.lbTTNV.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(119, 278);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(179, 28);
            this.btnDoiMatKhau.TabIndex = 29;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // dg2
            // 
            this.dg2.AllowUserToAddRows = false;
            this.dg2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenDangNhap,
            this.MatKhau,
            this.QuyenHan,
            this.TenNV});
            this.dg2.Location = new System.Drawing.Point(119, 354);
            this.dg2.Margin = new System.Windows.Forms.Padding(4);
            this.dg2.Name = "dg2";
            this.dg2.ReadOnly = true;
            this.dg2.RowHeadersWidth = 51;
            this.dg2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg2.Size = new System.Drawing.Size(854, 149);
            this.dg2.TabIndex = 28;
            this.dg2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg2_CellClick);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.TenDangNhap.MinimumWidth = 6;
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.ReadOnly = true;
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            // 
            // QuyenHan
            // 
            this.QuyenHan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuyenHan.DataPropertyName = "TenQuyenHan";
            this.QuyenHan.HeaderText = "Quyền Hạn";
            this.QuyenHan.MinimumWidth = 6;
            this.QuyenHan.Name = "QuyenHan";
            this.QuyenHan.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(340, 278);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(179, 28);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xoá Tài Khoản";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaNv);
            this.panel1.Controls.Add(this.lbmaNV);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.txtReMatKhau);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTaiKhoan);
            this.panel1.Controls.Add(this.cbQuyenHan);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(622, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 262);
            this.panel1.TabIndex = 32;
            // 
            // txtMaNv
            // 
            this.txtMaNv.Location = new System.Drawing.Point(180, 16);
            this.txtMaNv.Name = "txtMaNv";
            this.txtMaNv.Size = new System.Drawing.Size(252, 22);
            this.txtMaNv.TabIndex = 38;
            // 
            // lbmaNV
            // 
            this.lbmaNV.AutoSize = true;
            this.lbmaNV.Location = new System.Drawing.Point(35, 19);
            this.lbmaNV.Name = "lbmaNV";
            this.lbmaNV.Size = new System.Drawing.Size(97, 17);
            this.lbmaNV.TabIndex = 37;
            this.lbmaNV.Text = "Mã Nhân Viên";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(180, 233);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(171, 26);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.Text = "Thêm Tài Khoản";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtReMatKhau
            // 
            this.txtReMatKhau.Location = new System.Drawing.Point(180, 153);
            this.txtReMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtReMatKhau.Name = "txtReMatKhau";
            this.txtReMatKhau.PasswordChar = '~';
            this.txtReMatKhau.Size = new System.Drawing.Size(252, 22);
            this.txtReMatKhau.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Xác Nhận Mật Khẩu";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(180, 58);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(252, 22);
            this.txtTaiKhoan.TabIndex = 33;
            // 
            // cbQuyenHan
            // 
            this.cbQuyenHan.FormattingEnabled = true;
            this.cbQuyenHan.Items.AddRange(new object[] {
            "Super Admin",
            "Admin",
            "User"});
            this.cbQuyenHan.Location = new System.Drawing.Point(180, 199);
            this.cbQuyenHan.Margin = new System.Windows.Forms.Padding(4);
            this.cbQuyenHan.Name = "cbQuyenHan";
            this.cbQuyenHan.Size = new System.Drawing.Size(252, 24);
            this.cbQuyenHan.TabIndex = 28;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(181, 106);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '~';
            this.txtMatKhau.Size = new System.Drawing.Size(252, 22);
            this.txtMatKhau.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Quyền Hạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mật Khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Nhấn vào bảng nếu muốn thêm tài khoản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Danh sách nhân viên đã có tài khoản";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtTaiKhoan2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtMKNL);
            this.panel2.Controls.Add(this.txtMKM);
            this.panel2.Controls.Add(this.btnCapNhat);
            this.panel2.Location = new System.Drawing.Point(610, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 269);
            this.panel2.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 75);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tài Khoản";
            // 
            // txtTaiKhoan2
            // 
            this.txtTaiKhoan2.Location = new System.Drawing.Point(188, 76);
            this.txtTaiKhoan2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaiKhoan2.Name = "txtTaiKhoan2";
            this.txtTaiKhoan2.Size = new System.Drawing.Size(260, 22);
            this.txtTaiKhoan2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 170);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nhập lại mật khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mật khẩu mới";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(159, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "ĐỔI MẬT KHẨU";
            // 
            // txtMKNL
            // 
            this.txtMKNL.Location = new System.Drawing.Point(188, 170);
            this.txtMKNL.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKNL.Name = "txtMKNL";
            this.txtMKNL.PasswordChar = '~';
            this.txtMKNL.Size = new System.Drawing.Size(260, 22);
            this.txtMKNL.TabIndex = 3;
            // 
            // txtMKM
            // 
            this.txtMKM.Location = new System.Drawing.Point(188, 123);
            this.txtMKM.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.PasswordChar = '~';
            this.txtMKM.Size = new System.Drawing.Size(260, 22);
            this.txtMKM.TabIndex = 2;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(158, 233);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(183, 37);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1080, 525);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.lbTTNV);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.dg2);
            this.Controls.Add(this.btnXoa);
            this.Name = "TaiKhoan";
            this.ShowIcon = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.Label lbTTNV;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.DataGridView dg2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtReMatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.ComboBox cbQuyenHan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtMaNv;
        private System.Windows.Forms.Label lbmaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMKNL;
        private System.Windows.Forms.TextBox txtMKM;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTaiKhoan2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuyenHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
    }
}