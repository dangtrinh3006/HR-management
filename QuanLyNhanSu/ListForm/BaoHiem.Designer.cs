
namespace QuanLyNhanSu.ListForm
{
    partial class BaoHiem
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
            this.txtSo = new System.Windows.Forms.TextBox();
            this.txtNoiCap = new System.Windows.Forms.TextBox();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.dtpNgayHH = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayCap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTB = new System.Windows.Forms.Label();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiBaoHiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.dgvBaoHiem = new System.Windows.Forms.DataGridView();
            this.mnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHiem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(826, 102);
            this.txtSo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(84, 22);
            this.txtSo.TabIndex = 43;
            // 
            // txtNoiCap
            // 
            this.txtNoiCap.Location = new System.Drawing.Point(628, 155);
            this.txtNoiCap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoiCap.Name = "txtNoiCap";
            this.txtNoiCap.Size = new System.Drawing.Size(232, 22);
            this.txtNoiCap.TabIndex = 41;
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Items.AddRange(new object[] {
            "Bảo Hiểm Thân Thể",
            "Bảo Hiểm Y Tế"});
            this.cbLoai.Location = new System.Drawing.Point(514, 102);
            this.cbLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(126, 24);
            this.cbLoai.TabIndex = 40;
            // 
            // dtpNgayHH
            // 
            this.dtpNgayHH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHH.Location = new System.Drawing.Point(408, 158);
            this.dtpNgayHH.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayHH.Name = "dtpNgayHH";
            this.dtpNgayHH.Size = new System.Drawing.Size(137, 22);
            this.dtpNgayHH.TabIndex = 39;
            // 
            // dtpNgayCap
            // 
            this.dtpNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayCap.Location = new System.Drawing.Point(159, 158);
            this.dtpNgayCap.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayCap.Name = "dtpNgayCap";
            this.dtpNgayCap.Size = new System.Drawing.Size(122, 22);
            this.dtpNgayCap.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nơi Cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Ngày Hết Hạn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Ngày Cấp";
            // 
            // lbTB
            // 
            this.lbTB.AutoSize = true;
            this.lbTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTB.ForeColor = System.Drawing.Color.Red;
            this.lbTB.Location = new System.Drawing.Point(545, 204);
            this.lbTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTB.Name = "lbTB";
            this.lbTB.Size = new System.Drawing.Size(0, 20);
            this.lbTB.TabIndex = 34;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Width = 125;
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // LoaiBaoHiem
            // 
            this.LoaiBaoHiem.DataPropertyName = "LoaiBaoHiem";
            this.LoaiBaoHiem.HeaderText = "Loại Bảo Hiểm";
            this.LoaiBaoHiem.MinimumWidth = 6;
            this.LoaiBaoHiem.Name = "LoaiBaoHiem";
            this.LoaiBaoHiem.ReadOnly = true;
            this.LoaiBaoHiem.Width = 250;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Loại Bảo Hiểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(628, 201);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(63, 33);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(676, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Mã Số Thẻ Bảo Hiểm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 39);
            this.label1.TabIndex = 30;
            this.label1.Text = "Bảo Hiểm Nhân Viên";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(817, 199);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(69, 33);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(723, 201);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 33);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.DataPropertyName = "NgayHetHan";
            this.NgayHetHan.HeaderText = "Ngày Hết Hạn";
            this.NgayHetHan.MinimumWidth = 6;
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.ReadOnly = true;
            this.NgayHetHan.Width = 150;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(192, 102);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(158, 22);
            this.txtTen.TabIndex = 42;
            // 
            // dgvBaoHiem
            // 
            this.dgvBaoHiem.AllowUserToAddRows = false;
            this.dgvBaoHiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoHiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoHiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mnv,
            this.tnv,
            this.lbh,
            this.nhh});
            this.dgvBaoHiem.Location = new System.Drawing.Point(84, 262);
            this.dgvBaoHiem.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBaoHiem.Name = "dgvBaoHiem";
            this.dgvBaoHiem.ReadOnly = true;
            this.dgvBaoHiem.RowHeadersWidth = 51;
            this.dgvBaoHiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoHiem.Size = new System.Drawing.Size(935, 239);
            this.dgvBaoHiem.TabIndex = 44;
            this.dgvBaoHiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaoHiem_CellClick_1);
            // 
            // mnv
            // 
            this.mnv.DataPropertyName = "MaNhanVien";
            this.mnv.HeaderText = "Mã Nhân Viên";
            this.mnv.MinimumWidth = 6;
            this.mnv.Name = "mnv";
            this.mnv.ReadOnly = true;
            // 
            // tnv
            // 
            this.tnv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tnv.DataPropertyName = "TenNV";
            this.tnv.HeaderText = "Tên Nhân Viên";
            this.tnv.MinimumWidth = 6;
            this.tnv.Name = "tnv";
            this.tnv.ReadOnly = true;
            // 
            // lbh
            // 
            this.lbh.DataPropertyName = "LoaiBaoHiem";
            this.lbh.HeaderText = "Loại Bảo Hiểm";
            this.lbh.MinimumWidth = 6;
            this.lbh.Name = "lbh";
            this.lbh.ReadOnly = true;
            // 
            // nhh
            // 
            this.nhh.DataPropertyName = "NgayHetHan";
            this.nhh.HeaderText = "Ngày Hết Hạn";
            this.nhh.MinimumWidth = 6;
            this.nhh.Name = "nhh";
            this.nhh.ReadOnly = true;
            // 
            // BaoHiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 543);
            this.Controls.Add(this.dgvBaoHiem);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.txtNoiCap);
            this.Controls.Add(this.cbLoai);
            this.Controls.Add(this.dtpNgayHH);
            this.Controls.Add(this.dtpNgayCap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaoHiem";
            this.Text = "BaoHiem";
            this.Load += new System.EventHandler(this.BaoHiem_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.TextBox txtNoiCap;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.DateTimePicker dtpNgayHH;
        private System.Windows.Forms.DateTimePicker dtpNgayCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiBaoHiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.DataGridView dgvBaoHiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhh;
    }
}