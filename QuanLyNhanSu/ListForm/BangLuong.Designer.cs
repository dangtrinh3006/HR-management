
namespace QuanLyNhanSu.ListForm
{
    partial class BangLuong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTongLuong = new System.Windows.Forms.Button();
            this.lbCV = new System.Windows.Forms.Label();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLCB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHeSoLuong = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.lbTen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBangLuong = new System.Windows.Forms.Label();
            this.dgvBangLuong = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXem = new System.Windows.Forms.Button();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXuat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTongLuong);
            this.panel1.Controls.Add(this.lbCV);
            this.panel1.Controls.Add(this.lbChucVu);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtLCB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbHeSoLuong);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.lbTen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbBangLuong);
            this.panel1.Controls.Add(this.dgvBangLuong);
            this.panel1.Location = new System.Drawing.Point(-87, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 517);
            this.panel1.TabIndex = 1;
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(444, 471);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(151, 35);
            this.btnXuat.TabIndex = 16;
            this.btnXuat.Text = "Xuất Bảng Lương";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(696, 489);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nhập Tháng / Năm ";
            // 
            // btnTongLuong
            // 
            this.btnTongLuong.Location = new System.Drawing.Point(167, 471);
            this.btnTongLuong.Margin = new System.Windows.Forms.Padding(4);
            this.btnTongLuong.Name = "btnTongLuong";
            this.btnTongLuong.Size = new System.Drawing.Size(106, 35);
            this.btnTongLuong.TabIndex = 15;
            this.btnTongLuong.Text = "Tổng Lương";
            this.btnTongLuong.UseVisualStyleBackColor = true;
            this.btnTongLuong.Click += new System.EventHandler(this.btnTongLuong_Click);
            // 
            // lbCV
            // 
            this.lbCV.AutoSize = true;
            this.lbCV.Location = new System.Drawing.Point(129, 139);
            this.lbCV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCV.Name = "lbCV";
            this.lbCV.Size = new System.Drawing.Size(65, 17);
            this.lbCV.TabIndex = 10;
            this.lbCV.Text = "Chức Vụ:";
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucVu.Location = new System.Drawing.Point(210, 138);
            this.lbChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(63, 17);
            this.lbChucVu.TabIndex = 9;
            this.lbChucVu.Text = "ChucVu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(696, 452);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bảng Lương theo Tháng hoặc Năm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Chức Vụ:";
            // 
            // txtLCB
            // 
            this.txtLCB.Location = new System.Drawing.Point(777, 98);
            this.txtLCB.Margin = new System.Windows.Forms.Padding(4);
            this.txtLCB.Name = "txtLCB";
            this.txtLCB.Size = new System.Drawing.Size(123, 22);
            this.txtLCB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(908, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "VND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(677, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lương Cơ Bản";
            // 
            // cbHeSoLuong
            // 
            this.cbHeSoLuong.FormattingEnabled = true;
            this.cbHeSoLuong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbHeSoLuong.Location = new System.Drawing.Point(512, 94);
            this.cbHeSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.cbHeSoLuong.Name = "cbHeSoLuong";
            this.cbHeSoLuong.Size = new System.Drawing.Size(83, 24);
            this.cbHeSoLuong.TabIndex = 5;
            this.cbHeSoLuong.SelectedIndexChanged += new System.EventHandler(this.cbHeSoLuong_SelectedIndexChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(969, 90);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(142, 34);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(235, 97);
            this.lbTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(57, 17);
            this.lbTen.TabIndex = 2;
            this.lbTen.Text = "TenNV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhân Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hệ số lương";
            // 
            // lbBangLuong
            // 
            this.lbBangLuong.AutoSize = true;
            this.lbBangLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBangLuong.Location = new System.Drawing.Point(437, 0);
            this.lbBangLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBangLuong.Name = "lbBangLuong";
            this.lbBangLuong.Size = new System.Drawing.Size(390, 39);
            this.lbBangLuong.TabIndex = 1;
            this.lbBangLuong.Text = "Bảng Lương Nhân Viên";
            // 
            // dgvBangLuong
            // 
            this.dgvBangLuong.AllowUserToAddRows = false;
            this.dgvBangLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.TenNV,
            this.HeSoLuong,
            this.SNL,
            this.T,
            this.P,
            this.TL});
            this.dgvBangLuong.Location = new System.Drawing.Point(167, 179);
            this.dgvBangLuong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBangLuong.Name = "dgvBangLuong";
            this.dgvBangLuong.ReadOnly = true;
            this.dgvBangLuong.RowHeadersWidth = 51;
            this.dgvBangLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangLuong.Size = new System.Drawing.Size(944, 269);
            this.dgvBangLuong.TabIndex = 0;
            this.dgvBangLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangLuong_CellClick);
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "MaNhanVien";
            this.Ma.HeaderText = "Mã Nhân Viên";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // HeSoLuong
            // 
            this.HeSoLuong.DataPropertyName = "HeSoLuong";
            this.HeSoLuong.HeaderText = "Hệ Số Lương";
            this.HeSoLuong.MinimumWidth = 6;
            this.HeSoLuong.Name = "HeSoLuong";
            this.HeSoLuong.ReadOnly = true;
            // 
            // SNL
            // 
            this.SNL.DataPropertyName = "NL";
            this.SNL.HeaderText = "Số Ngày Làm";
            this.SNL.MinimumWidth = 6;
            this.SNL.Name = "SNL";
            this.SNL.ReadOnly = true;
            // 
            // T
            // 
            this.T.DataPropertyName = "T";
            this.T.HeaderText = "Tiền Thưởng";
            this.T.MinimumWidth = 6;
            this.T.Name = "T";
            this.T.ReadOnly = true;
            // 
            // P
            // 
            this.P.DataPropertyName = "P";
            this.P.HeaderText = "Tiền Phạt";
            this.P.MinimumWidth = 6;
            this.P.Name = "P";
            this.P.ReadOnly = true;
            // 
            // TL
            // 
            this.TL.DataPropertyName = "TL";
            this.TL.HeaderText = "Tổng Lương";
            this.TL.MinimumWidth = 6;
            this.TL.Name = "TL";
            this.TL.ReadOnly = true;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(941, 495);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(83, 29);
            this.btnXem.TabIndex = 14;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(776, 498);
            this.txtThang.Margin = new System.Windows.Forms.Padding(4);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(45, 22);
            this.txtThang.TabIndex = 10;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(841, 498);
            this.txtNam.Margin = new System.Windows.Forms.Padding(4);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(91, 22);
            this.txtNam.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(822, 495);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "/";
            // 
            // BangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 543);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BangLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "BangLuong";
            this.Load += new System.EventHandler(this.BangLuong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCV;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHeSoLuong;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbBangLuong;
        private System.Windows.Forms.DataGridView dgvBangLuong;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTongLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn T;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn TL;
        private System.Windows.Forms.Button btnXuat;
    }
}