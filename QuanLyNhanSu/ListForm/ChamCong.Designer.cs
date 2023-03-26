
namespace QuanLyNhanSu.ListForm
{
    partial class ChamCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChamCong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Xem = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.dtpNgayCham = new System.Windows.Forms.DateTimePicker();
            this.lbNgayThang = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbNgay = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbCC = new System.Windows.Forms.CheckBox();
            this.lbTinhTrang = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Xem);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.dtpNgayCham);
            this.panel1.Controls.Add(this.lbNgayThang);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbNgay);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.cbCC);
            this.panel1.Controls.Add(this.lbTinhTrang);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbTen);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbMa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvChamCong);
            this.panel1.Controls.Add(this.btnCapNhat);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // Xem
            // 
            resources.ApplyResources(this.Xem, "Xem");
            this.Xem.Name = "Xem";
            // 
            // btnXem
            // 
            resources.ApplyResources(this.btnXem, "btnXem");
            this.btnXem.Name = "btnXem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dtpNgayCham
            // 
            this.dtpNgayCham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtpNgayCham, "dtpNgayCham");
            this.dtpNgayCham.Name = "dtpNgayCham";
            // 
            // lbNgayThang
            // 
            resources.ApplyResources(this.lbNgayThang, "lbNgayThang");
            this.lbNgayThang.Name = "lbNgayThang";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lbNgay
            // 
            resources.ApplyResources(this.lbNgay, "lbNgay");
            this.lbNgay.Name = "lbNgay";
            // 
            // btnXoa
            // 
            resources.ApplyResources(this.btnXoa, "btnXoa");
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbCC
            // 
            resources.ApplyResources(this.cbCC, "cbCC");
            this.cbCC.Name = "cbCC";
            this.cbCC.UseVisualStyleBackColor = true;
            this.cbCC.CheckedChanged += new System.EventHandler(this.cbCC_CheckedChanged);
            // 
            // lbTinhTrang
            // 
            resources.ApplyResources(this.lbTinhTrang, "lbTinhTrang");
            this.lbTinhTrang.Name = "lbTinhTrang";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lbTen
            // 
            resources.ApplyResources(this.lbTen, "lbTen");
            this.lbTen.Name = "lbTen";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lbMa
            // 
            resources.ApplyResources(this.lbMa, "lbMa");
            this.lbMa.Name = "lbMa";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.AllowUserToAddRows = false;
            this.dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamCong.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChamCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.Ten,
            this.TinhTrang});
            resources.ApplyResources(this.dgvChamCong, "dgvChamCong");
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamCong_CellClick);
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "MaNhanVien";
            resources.ApplyResources(this.Ma, "Ma");
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten.DataPropertyName = "TenNV";
            resources.ApplyResources(this.Ten, "Ten");
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            resources.ApplyResources(this.TinhTrang, "TinhTrang");
            this.TinhTrang.Items.AddRange(new object[] {
            "Đi Làm",
            "Nghỉ Có Phép",
            "Nghỉ Không Phép"});
            this.TinhTrang.Name = "TinhTrang";
            // 
            // btnCapNhat
            // 
            resources.ApplyResources(this.btnCapNhat, "btnCapNhat");
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // ChamCong
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChamCong";
            this.Load += new System.EventHandler(this.ChamCong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.CheckBox cbCC;
        private System.Windows.Forms.Label lbTinhTrang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewComboBoxColumn TinhTrang;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label lbNgayThang;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.DateTimePicker dtpNgayCham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Xem;
        private System.Windows.Forms.Button btnXem;
    }
}