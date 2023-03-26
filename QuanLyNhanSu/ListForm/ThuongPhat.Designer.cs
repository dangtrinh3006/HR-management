
namespace QuanLyNhanSu.ListForm
{
    partial class ThuongPhat
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbNgay = new System.Windows.Forms.Label();
            this.dateNgay = new System.Windows.Forms.DateTimePicker();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.btXem = new System.Windows.Forms.Button();
            this.rdPhat = new System.Windows.Forms.RadioButton();
            this.rdThuong = new System.Windows.Forms.RadioButton();
            this.dgvThuongPhat = new System.Windows.Forms.DataGridView();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuongPhat)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(946, 414);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 34);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1047, 414);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 34);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(839, 414);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 34);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // txtT
            // 
            this.txtT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT.Location = new System.Drawing.Point(881, 337);
            this.txtT.Margin = new System.Windows.Forms.Padding(4);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(144, 26);
            this.txtT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(789, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(817, 340);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1033, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "VND";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(520, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 39);
            this.label9.TabIndex = 4;
            this.label9.Text = "Thưởng Phạt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(545, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Xem theo tháng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(807, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lý do:";
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 60;
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            // 
            // LyDo
            // 
            this.LyDo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "Lý Do";
            this.LyDo.MinimumWidth = 60;
            this.LyDo.Name = "LyDo";
            this.LyDo.ReadOnly = true;
            // 
            // Tien
            // 
            this.Tien.DataPropertyName = "Tien";
            this.Tien.HeaderText = "VND";
            this.Tien.MinimumWidth = 40;
            this.Tien.Name = "Tien";
            this.Tien.ReadOnly = true;
            // 
            // Loai
            // 
            this.Loai.DataPropertyName = "Loai";
            this.Loai.HeaderText = "Thưởng/Phạt";
            this.Loai.MinimumWidth = 60;
            this.Loai.Name = "Loai";
            this.Loai.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNhanVien";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.Location = new System.Drawing.Point(817, 373);
            this.lbNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(52, 20);
            this.lbNgay.TabIndex = 104;
            this.lbNgay.Text = "Ngày:";
            // 
            // dateNgay
            // 
            this.dateNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgay.Location = new System.Drawing.Point(881, 371);
            this.dateNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgay.Name = "dateNgay";
            this.dateNgay.Size = new System.Drawing.Size(144, 22);
            this.dateNgay.TabIndex = 103;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(158, 77);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(304, 26);
            this.txtTen.TabIndex = 15;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(101, 83);
            this.lbTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(37, 20);
            this.lbTen.TabIndex = 14;
            this.lbTen.Text = "Tên";
            // 
            // cbNam
            // 
            this.cbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cbNam.Location = new System.Drawing.Point(811, 98);
            this.cbNam.Margin = new System.Windows.Forms.Padding(4);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(97, 28);
            this.cbNam.TabIndex = 12;
            // 
            // cbThang
            // 
            this.cbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(697, 98);
            this.cbThang.Margin = new System.Windows.Forms.Padding(4);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(84, 28);
            this.cbThang.TabIndex = 12;
            // 
            // btXem
            // 
            this.btXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXem.Location = new System.Drawing.Point(928, 98);
            this.btXem.Margin = new System.Windows.Forms.Padding(4);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(111, 30);
            this.btXem.TabIndex = 11;
            this.btXem.Text = "Xem";
            this.btXem.UseVisualStyleBackColor = true;
            this.btXem.Click += new System.EventHandler(this.btXem_Click_1);
            // 
            // rdPhat
            // 
            this.rdPhat.AutoSize = true;
            this.rdPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPhat.Location = new System.Drawing.Point(997, 148);
            this.rdPhat.Margin = new System.Windows.Forms.Padding(4);
            this.rdPhat.Name = "rdPhat";
            this.rdPhat.Size = new System.Drawing.Size(64, 24);
            this.rdPhat.TabIndex = 10;
            this.rdPhat.Text = "Phạt";
            this.rdPhat.UseVisualStyleBackColor = true;
            // 
            // rdThuong
            // 
            this.rdThuong.AutoSize = true;
            this.rdThuong.Checked = true;
            this.rdThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThuong.Location = new System.Drawing.Point(851, 148);
            this.rdThuong.Margin = new System.Windows.Forms.Padding(4);
            this.rdThuong.Name = "rdThuong";
            this.rdThuong.Size = new System.Drawing.Size(123, 24);
            this.rdThuong.TabIndex = 10;
            this.rdThuong.TabStop = true;
            this.rdThuong.Text = "Khen thưởng";
            this.rdThuong.UseVisualStyleBackColor = true;
            // 
            // dgvThuongPhat
            // 
            this.dgvThuongPhat.AllowUserToAddRows = false;
            this.dgvThuongPhat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuongPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuongPhat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.Loai,
            this.Tien,
            this.LyDo,
            this.Ngay});
            this.dgvThuongPhat.Location = new System.Drawing.Point(105, 134);
            this.dgvThuongPhat.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThuongPhat.Name = "dgvThuongPhat";
            this.dgvThuongPhat.ReadOnly = true;
            this.dgvThuongPhat.RowHeadersWidth = 51;
            this.dgvThuongPhat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuongPhat.Size = new System.Drawing.Size(694, 314);
            this.dgvThuongPhat.TabIndex = 9;
            this.dgvThuongPhat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuongPhat_CellClick_1);
            // 
            // txtLyDo
            // 
            this.txtLyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyDo.Location = new System.Drawing.Point(881, 180);
            this.txtLyDo.Margin = new System.Windows.Forms.Padding(4);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(239, 134);
            this.txtLyDo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbNgay);
            this.panel1.Controls.Add(this.dateNgay);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.lbTen);
            this.panel1.Controls.Add(this.cbNam);
            this.panel1.Controls.Add(this.cbThang);
            this.panel1.Controls.Add(this.btXem);
            this.panel1.Controls.Add(this.rdPhat);
            this.panel1.Controls.Add(this.rdThuong);
            this.panel1.Controls.Add(this.dgvThuongPhat);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtLyDo);
            this.panel1.Location = new System.Drawing.Point(-64, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 543);
            this.panel1.TabIndex = 2;
            // 
            // ThuongPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 543);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThuongPhat";
            this.Text = "ThuongPhat";
            this.Load += new System.EventHandler(this.ThuongPhat_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuongPhat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.DateTimePicker dateNgay;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.RadioButton rdPhat;
        private System.Windows.Forms.RadioButton rdThuong;
        private System.Windows.Forms.DataGridView dgvThuongPhat;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Panel panel1;
    }
}