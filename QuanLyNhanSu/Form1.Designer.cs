
namespace QuanLyNhanSu
{
    partial class Form1
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
            System.Windows.Forms.Button btnThoat;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblDoiMatKhau = new System.Windows.Forms.Label();
            this.btnDMK = new System.Windows.Forms.Button();
            this.lblThoat = new System.Windows.Forms.Label();
            this.lblDangXuat = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblBaoHiem = new System.Windows.Forms.Label();
            this.lblKhenThuong = new System.Windows.Forms.Label();
            this.lblBangLuong = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblChamCong = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.btnBaoHiem = new System.Windows.Forms.Button();
            this.btnKhenThuong = new System.Windows.Forms.Button();
            this.btnLuong = new System.Windows.Forms.Button();
            this.btnChucVu = new System.Windows.Forms.Button();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnPhongBan = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.lblTKNhanVien = new System.Windows.Forms.Label();
            this.btnThongBao = new System.Windows.Forms.Button();
            this.btnTKNhanVien = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            btnThoat = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            btnThoat.Location = new System.Drawing.Point(539, 13);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(112, 110);
            btnThoat.TabIndex = 8;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1105, 178);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "a";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.lblDoiMatKhau);
            this.tabPage1.Controls.Add(this.btnDMK);
            this.tabPage1.Controls.Add(this.lblThoat);
            this.tabPage1.Controls.Add(this.lblDangXuat);
            this.tabPage1.Controls.Add(this.lblTaiKhoan);
            this.tabPage1.Controls.Add(btnThoat);
            this.tabPage1.Controls.Add(this.btnDangXuat);
            this.tabPage1.Controls.Add(this.btnTaiKhoan);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1097, 148);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hệ Thống";
            // 
            // lblDoiMatKhau
            // 
            this.lblDoiMatKhau.AutoSize = true;
            this.lblDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoiMatKhau.Location = new System.Drawing.Point(202, 127);
            this.lblDoiMatKhau.Name = "lblDoiMatKhau";
            this.lblDoiMatKhau.Size = new System.Drawing.Size(93, 17);
            this.lblDoiMatKhau.TabIndex = 15;
            this.lblDoiMatKhau.Text = "Đổi Mật Khẩu";
            // 
            // btnDMK
            // 
            this.btnDMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDMK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDMK.Image = ((System.Drawing.Image)(resources.GetObject("btnDMK.Image")));
            this.btnDMK.Location = new System.Drawing.Point(199, 13);
            this.btnDMK.Name = "btnDMK";
            this.btnDMK.Size = new System.Drawing.Size(113, 112);
            this.btnDMK.TabIndex = 14;
            this.btnDMK.UseVisualStyleBackColor = true;
            this.btnDMK.Click += new System.EventHandler(this.btnDMK_Click);
            // 
            // lblThoat
            // 
            this.lblThoat.AutoSize = true;
            this.lblThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoat.Location = new System.Drawing.Point(566, 126);
            this.lblThoat.Name = "lblThoat";
            this.lblThoat.Size = new System.Drawing.Size(45, 17);
            this.lblThoat.TabIndex = 13;
            this.lblThoat.Text = "Thoát";
            // 
            // lblDangXuat
            // 
            this.lblDangXuat.AutoSize = true;
            this.lblDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangXuat.Location = new System.Drawing.Point(382, 127);
            this.lblDangXuat.Name = "lblDangXuat";
            this.lblDangXuat.Size = new System.Drawing.Size(75, 17);
            this.lblDangXuat.TabIndex = 12;
            this.lblDangXuat.Text = "Đăng Xuất";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.Location = new System.Drawing.Point(48, 126);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(73, 17);
            this.lblTaiKhoan.TabIndex = 10;
            this.lblTaiKhoan.Text = "Tài Khoản";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.Location = new System.Drawing.Point(367, 13);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(113, 112);
            this.btnDangXuat.TabIndex = 7;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.Image")));
            this.btnTaiKhoan.Location = new System.Drawing.Point(32, 13);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(113, 112);
            this.btnTaiKhoan.TabIndex = 5;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AllowDrop = true;
            this.tabPage2.AutoScrollMargin = new System.Drawing.Size(2000, 1000);
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Controls.Add(this.lblBaoHiem);
            this.tabPage2.Controls.Add(this.lblKhenThuong);
            this.tabPage2.Controls.Add(this.lblBangLuong);
            this.tabPage2.Controls.Add(this.lblChucVu);
            this.tabPage2.Controls.Add(this.lblChamCong);
            this.tabPage2.Controls.Add(this.lblNhanVien);
            this.tabPage2.Controls.Add(this.lblPhongBan);
            this.tabPage2.Controls.Add(this.btnBaoHiem);
            this.tabPage2.Controls.Add(this.btnKhenThuong);
            this.tabPage2.Controls.Add(this.btnLuong);
            this.tabPage2.Controls.Add(this.btnChucVu);
            this.tabPage2.Controls.Add(this.btnChamCong);
            this.tabPage2.Controls.Add(this.btnNhanVien);
            this.tabPage2.Controls.Add(this.btnPhongBan);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1097, 148);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản Lý";
            // 
            // lblBaoHiem
            // 
            this.lblBaoHiem.AutoSize = true;
            this.lblBaoHiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoHiem.Location = new System.Drawing.Point(984, 125);
            this.lblBaoHiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaoHiem.Name = "lblBaoHiem";
            this.lblBaoHiem.Size = new System.Drawing.Size(69, 17);
            this.lblBaoHiem.TabIndex = 17;
            this.lblBaoHiem.Text = "Bảo Hiểm";
            // 
            // lblKhenThuong
            // 
            this.lblKhenThuong.AutoSize = true;
            this.lblKhenThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhenThuong.Location = new System.Drawing.Point(818, 125);
            this.lblKhenThuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhenThuong.Name = "lblKhenThuong";
            this.lblKhenThuong.Size = new System.Drawing.Size(94, 17);
            this.lblKhenThuong.TabIndex = 11;
            this.lblKhenThuong.Text = "Khen Thưởng";
            // 
            // lblBangLuong
            // 
            this.lblBangLuong.AutoSize = true;
            this.lblBangLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBangLuong.Location = new System.Drawing.Point(666, 125);
            this.lblBangLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBangLuong.Name = "lblBangLuong";
            this.lblBangLuong.Size = new System.Drawing.Size(85, 17);
            this.lblBangLuong.TabIndex = 12;
            this.lblBangLuong.Text = "Bảng Lương";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(512, 124);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(61, 17);
            this.lblChucVu.TabIndex = 13;
            this.lblChucVu.Text = "Chức Vụ";
            // 
            // lblChamCong
            // 
            this.lblChamCong.AutoSize = true;
            this.lblChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChamCong.Location = new System.Drawing.Point(342, 124);
            this.lblChamCong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChamCong.Name = "lblChamCong";
            this.lblChamCong.Size = new System.Drawing.Size(81, 17);
            this.lblChamCong.TabIndex = 14;
            this.lblChamCong.Text = "Chấm Công";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(187, 125);
            this.lblNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(74, 17);
            this.lblNhanVien.TabIndex = 15;
            this.lblNhanVien.Text = "Nhân Viên";
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongBan.Location = new System.Drawing.Point(44, 125);
            this.lblPhongBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(78, 17);
            this.lblPhongBan.TabIndex = 16;
            this.lblPhongBan.Text = "Phòng Ban";
            // 
            // btnBaoHiem
            // 
            this.btnBaoHiem.BackColor = System.Drawing.Color.White;
            this.btnBaoHiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBaoHiem.BackgroundImage")));
            this.btnBaoHiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoHiem.Location = new System.Drawing.Point(967, 12);
            this.btnBaoHiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaoHiem.MinimumSize = new System.Drawing.Size(93, 86);
            this.btnBaoHiem.Name = "btnBaoHiem";
            this.btnBaoHiem.Size = new System.Drawing.Size(112, 112);
            this.btnBaoHiem.TabIndex = 9;
            this.btnBaoHiem.UseVisualStyleBackColor = false;
            this.btnBaoHiem.Click += new System.EventHandler(this.btnBaoHiem_Click);
            // 
            // btnKhenThuong
            // 
            this.btnKhenThuong.BackColor = System.Drawing.Color.White;
            this.btnKhenThuong.Cursor = System.Windows.Forms.Cursors.No;
            this.btnKhenThuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhenThuong.Image = ((System.Drawing.Image)(resources.GetObject("btnKhenThuong.Image")));
            this.btnKhenThuong.Location = new System.Drawing.Point(809, 12);
            this.btnKhenThuong.Margin = new System.Windows.Forms.Padding(4);
            this.btnKhenThuong.Name = "btnKhenThuong";
            this.btnKhenThuong.Size = new System.Drawing.Size(112, 112);
            this.btnKhenThuong.TabIndex = 3;
            this.btnKhenThuong.UseVisualStyleBackColor = false;
            this.btnKhenThuong.Click += new System.EventHandler(this.btnKhenThuong_Click);
            // 
            // btnLuong
            // 
            this.btnLuong.BackColor = System.Drawing.Color.White;
            this.btnLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuong.Image = ((System.Drawing.Image)(resources.GetObject("btnLuong.Image")));
            this.btnLuong.Location = new System.Drawing.Point(651, 12);
            this.btnLuong.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuong.Name = "btnLuong";
            this.btnLuong.Size = new System.Drawing.Size(112, 112);
            this.btnLuong.TabIndex = 4;
            this.btnLuong.UseVisualStyleBackColor = false;
            this.btnLuong.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnChucVu
            // 
            this.btnChucVu.BackColor = System.Drawing.Color.White;
            this.btnChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChucVu.Image = ((System.Drawing.Image)(resources.GetObject("btnChucVu.Image")));
            this.btnChucVu.Location = new System.Drawing.Point(494, 12);
            this.btnChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.Size = new System.Drawing.Size(112, 112);
            this.btnChucVu.TabIndex = 5;
            this.btnChucVu.UseVisualStyleBackColor = false;
            this.btnChucVu.Click += new System.EventHandler(this.btnChucVu_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.BackColor = System.Drawing.Color.White;
            this.btnChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamCong.Image = ((System.Drawing.Image)(resources.GetObject("btnChamCong.Image")));
            this.btnChamCong.Location = new System.Drawing.Point(337, 11);
            this.btnChamCong.Margin = new System.Windows.Forms.Padding(4);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(112, 112);
            this.btnChamCong.TabIndex = 6;
            this.btnChamCong.UseVisualStyleBackColor = false;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.White;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.Location = new System.Drawing.Point(179, 12);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(112, 112);
            this.btnNhanVien.TabIndex = 7;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.AutoSize = true;
            this.btnPhongBan.BackColor = System.Drawing.Color.White;
            this.btnPhongBan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPhongBan.BackgroundImage")));
            this.btnPhongBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhongBan.Location = new System.Drawing.Point(30, 12);
            this.btnPhongBan.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.Size = new System.Drawing.Size(112, 112);
            this.btnPhongBan.TabIndex = 8;
            this.btnPhongBan.UseVisualStyleBackColor = false;
            this.btnPhongBan.Click += new System.EventHandler(this.btnPhongBan_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage3.Controls.Add(this.lblThongBao);
            this.tabPage3.Controls.Add(this.lblTKNhanVien);
            this.tabPage3.Controls.Add(this.btnThongBao);
            this.tabPage3.Controls.Add(this.btnTKNhanVien);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1097, 148);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Chức Năng Phụ";
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Location = new System.Drawing.Point(188, 122);
            this.lblThongBao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(106, 17);
            this.lblThongBao.TabIndex = 12;
            this.lblThongBao.Text = "Thông báo Mail";
            // 
            // lblTKNhanVien
            // 
            this.lblTKNhanVien.AutoSize = true;
            this.lblTKNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTKNhanVien.Location = new System.Drawing.Point(41, 122);
            this.lblTKNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTKNhanVien.Name = "lblTKNhanVien";
            this.lblTKNhanVien.Size = new System.Drawing.Size(64, 17);
            this.lblTKNhanVien.TabIndex = 13;
            this.lblTKNhanVien.Text = "Tìm kiếm";
            // 
            // btnThongBao
            // 
            this.btnThongBao.BackColor = System.Drawing.Color.White;
            this.btnThongBao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThongBao.BackgroundImage")));
            this.btnThongBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongBao.Location = new System.Drawing.Point(184, 7);
            this.btnThongBao.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(112, 112);
            this.btnThongBao.TabIndex = 9;
            this.btnThongBao.UseVisualStyleBackColor = false;
            this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
            // 
            // btnTKNhanVien
            // 
            this.btnTKNhanVien.BackColor = System.Drawing.Color.White;
            this.btnTKNhanVien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTKNhanVien.BackgroundImage")));
            this.btnTKNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTKNhanVien.Location = new System.Drawing.Point(26, 7);
            this.btnTKNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnTKNhanVien.Name = "btnTKNhanVien";
            this.btnTKNhanVien.Size = new System.Drawing.Size(112, 112);
            this.btnTKNhanVien.TabIndex = 10;
            this.btnTKNhanVien.UseVisualStyleBackColor = false;
            this.btnTKNhanVien.Click += new System.EventHandler(this.btnTKNhanVien_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.RosyBrown;
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.Location = new System.Drawing.Point(8, 179);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1098, 543);
            this.panel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1118, 734);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "QUẢN LÝ NHÂN SỰ ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Label lblThoat;
        private System.Windows.Forms.Label lblDangXuat;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblKhenThuong;
        private System.Windows.Forms.Label lblBangLuong;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblChamCong;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.Button btnBaoHiem;
        private System.Windows.Forms.Button btnKhenThuong;
        private System.Windows.Forms.Button btnLuong;
        private System.Windows.Forms.Button btnChucVu;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label lblTKNhanVien;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblDoiMatKhau;
        private System.Windows.Forms.Button btnDMK;
        private System.Windows.Forms.Button btnThongBao;
        private System.Windows.Forms.Button btnTKNhanVien;
        private System.Windows.Forms.Label lblBaoHiem;
        private System.Windows.Forms.Button btnPhongBan;
    }
}

