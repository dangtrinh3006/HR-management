
namespace QuanLyNhanSu.ListForm
{
    partial class NhanVien
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.cbPhongBan = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTrinhDo = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHeSoLuong = new System.Windows.Forms.TextBox();
            this.txtSoCM = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.lblNgayVaoLam = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTrinhDo = new System.Windows.Forms.Label();
            this.lblHeSoLuong = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblSoCM = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.lbllMaNhanVien = new System.Windows.Forms.Label();
            this.dgNhanVien = new System.Windows.Forms.DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dateNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(935, 312);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(67, 31);
            this.btnXoa.TabIndex = 100;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(818, 312);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 31);
            this.btnSua.TabIndex = 98;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(710, 312);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(67, 31);
            this.btnThem.TabIndex = 97;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbGioiTinh.Location = new System.Drawing.Point(201, 242);
            this.cbGioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(169, 24);
            this.cbGioiTinh.TabIndex = 93;
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Items.AddRange(new object[] {
            "Giám Đốc",
            "Phó Giám Đốc",
            "Trưởng Phòng",
            "Phó Phòng",
            "Nhân Viên"});
            this.cbChucVu.Location = new System.Drawing.Point(201, 205);
            this.cbChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(169, 24);
            this.cbChucVu.TabIndex = 92;
            // 
            // cbPhongBan
            // 
            this.cbPhongBan.FormattingEnabled = true;
            this.cbPhongBan.Items.AddRange(new object[] {
            "Phòng Giám Đốc",
            "Phòng Phó Giám Đốc",
            "Phòng Kế Toán",
            "Phòng Kinh Doanh",
            "Phòng Kỹ Thuật"});
            this.cbPhongBan.Location = new System.Drawing.Point(201, 162);
            this.cbPhongBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPhongBan.Name = "cbPhongBan";
            this.cbPhongBan.Size = new System.Drawing.Size(169, 24);
            this.cbPhongBan.TabIndex = 91;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(653, 64);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(408, 68);
            this.txtDiaChi.TabIndex = 90;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(891, 154);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(169, 22);
            this.txtEmail.TabIndex = 88;
            // 
            // txtTrinhDo
            // 
            this.txtTrinhDo.Location = new System.Drawing.Point(653, 237);
            this.txtTrinhDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTrinhDo.Name = "txtTrinhDo";
            this.txtTrinhDo.Size = new System.Drawing.Size(169, 22);
            this.txtTrinhDo.TabIndex = 87;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(653, 199);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(169, 22);
            this.txtSDT.TabIndex = 86;
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Location = new System.Drawing.Point(935, 199);
            this.txtHeSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.Size = new System.Drawing.Size(125, 22);
            this.txtHeSoLuong.TabIndex = 89;
            // 
            // txtSoCM
            // 
            this.txtSoCM.Location = new System.Drawing.Point(653, 154);
            this.txtSoCM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoCM.Name = "txtSoCM";
            this.txtSoCM.Size = new System.Drawing.Size(169, 22);
            this.txtSoCM.TabIndex = 85;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(201, 117);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(169, 22);
            this.txtTenNhanVien.TabIndex = 84;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(201, 72);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(169, 22);
            this.txtMaNhanVien.TabIndex = 83;
            // 
            // lblNgayVaoLam
            // 
            this.lblNgayVaoLam.AutoSize = true;
            this.lblNgayVaoLam.Location = new System.Drawing.Point(502, 271);
            this.lblNgayVaoLam.Name = "lblNgayVaoLam";
            this.lblNgayVaoLam.Size = new System.Drawing.Size(98, 17);
            this.lblNgayVaoLam.TabIndex = 81;
            this.lblNgayVaoLam.Text = "Ngày vào làm:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(52, 286);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(79, 17);
            this.lblNgaySinh.TabIndex = 80;
            this.lblNgaySinh.Text = "Ngày sinh: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(839, 157);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 79;
            this.lblEmail.Text = "Email:";
            // 
            // lblTrinhDo
            // 
            this.lblTrinhDo.AutoSize = true;
            this.lblTrinhDo.Location = new System.Drawing.Point(502, 243);
            this.lblTrinhDo.Name = "lblTrinhDo";
            this.lblTrinhDo.Size = new System.Drawing.Size(69, 17);
            this.lblTrinhDo.TabIndex = 78;
            this.lblTrinhDo.Text = "Trình độ: ";
            // 
            // lblHeSoLuong
            // 
            this.lblHeSoLuong.AutoSize = true;
            this.lblHeSoLuong.Location = new System.Drawing.Point(839, 202);
            this.lblHeSoLuong.Name = "lblHeSoLuong";
            this.lblHeSoLuong.Size = new System.Drawing.Size(92, 17);
            this.lblHeSoLuong.TabIndex = 77;
            this.lblHeSoLuong.Text = "Hệ số lương: ";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(502, 206);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(99, 17);
            this.lblSoDienThoai.TabIndex = 76;
            this.lblSoDienThoai.Text = "Số điện thoại: ";
            // 
            // lblSoCM
            // 
            this.lblSoCM.AutoSize = true;
            this.lblSoCM.Location = new System.Drawing.Point(502, 164);
            this.lblSoCM.Name = "lblSoCM";
            this.lblSoCM.Size = new System.Drawing.Size(57, 17);
            this.lblSoCM.TabIndex = 75;
            this.lblSoCM.Text = "Số CM: ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(332, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(343, 38);
            this.label6.TabIndex = 74;
            this.label6.Text = "Thông Tin Nhân Viên";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(502, 70);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(59, 17);
            this.lblDiaChi.TabIndex = 73;
            this.lblDiaChi.Text = "Địa chỉ: ";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(52, 249);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(68, 17);
            this.lblGioiTinh.TabIndex = 72;
            this.lblGioiTinh.Text = "Giới tính: ";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(52, 211);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(67, 17);
            this.lblChucVu.TabIndex = 71;
            this.lblChucVu.Text = "Chức vụ: ";
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Location = new System.Drawing.Point(52, 165);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(85, 17);
            this.lblPhongBan.TabIndex = 70;
            this.lblPhongBan.Text = "Phòng ban: ";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Location = new System.Drawing.Point(52, 122);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(107, 17);
            this.lblTenNhanVien.TabIndex = 82;
            this.lblTenNhanVien.Text = "Tên nhân viên: ";
            // 
            // lbllMaNhanVien
            // 
            this.lbllMaNhanVien.AutoSize = true;
            this.lbllMaNhanVien.Location = new System.Drawing.Point(52, 75);
            this.lbllMaNhanVien.Name = "lbllMaNhanVien";
            this.lbllMaNhanVien.Size = new System.Drawing.Size(101, 17);
            this.lbllMaNhanVien.TabIndex = 69;
            this.lbllMaNhanVien.Text = "Mã nhân viên: ";
            // 
            // dgNhanVien
            // 
            this.dgNhanVien.AllowUserToAddRows = false;
            this.dgNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.GioiTinh,
            this.ChucVu});
            this.dgNhanVien.Location = new System.Drawing.Point(26, 349);
            this.dgNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgNhanVien.Name = "dgNhanVien";
            this.dgNhanVien.ReadOnly = true;
            this.dgNhanVien.RowHeadersWidth = 51;
            this.dgNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNhanVien.Size = new System.Drawing.Size(1057, 192);
            this.dgNhanVien.TabIndex = 101;
            this.dgNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNhanVien_CellClick);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNhanVien.DataPropertyName = "TenNV";
            this.TenNhanVien.HeaderText = "Tên Nhân Viên";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "TenCV";
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaySinh.Location = new System.Drawing.Point(201, 281);
            this.dateNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(233, 22);
            this.dateNgaySinh.TabIndex = 102;
            // 
            // dateNgayVaoLam
            // 
            this.dateNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayVaoLam.Location = new System.Drawing.Point(652, 271);
            this.dateNgayVaoLam.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayVaoLam.Name = "dateNgayVaoLam";
            this.dateNgayVaoLam.Size = new System.Drawing.Size(233, 22);
            this.dateNgayVaoLam.TabIndex = 103;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 543);
            this.ControlBox = false;
            this.Controls.Add(this.dateNgayVaoLam);
            this.Controls.Add(this.dateNgaySinh);
            this.Controls.Add(this.dgNhanVien);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.cbChucVu);
            this.Controls.Add(this.cbPhongBan);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTrinhDo);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtHeSoLuong);
            this.Controls.Add(this.txtSoCM);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.lblNgayVaoLam);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTrinhDo);
            this.Controls.Add(this.lblHeSoLuong);
            this.Controls.Add(this.lblSoDienThoai);
            this.Controls.Add(this.lblSoCM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.lblPhongBan);
            this.Controls.Add(this.lblTenNhanVien);
            this.Controls.Add(this.lbllMaNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "NhanVien";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.ComboBox cbPhongBan;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTrinhDo;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.TextBox txtSoCM;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lblNgayVaoLam;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTrinhDo;
        private System.Windows.Forms.Label lblHeSoLuong;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblSoCM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label lbllMaNhanVien;
        private System.Windows.Forms.DataGridView dgNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.DateTimePicker dateNgayVaoLam;
    }
}