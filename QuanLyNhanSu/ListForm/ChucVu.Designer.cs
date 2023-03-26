
namespace QuanLyNhanSu.ListForm
{
    partial class ChucVu
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
            this.dgChucVu = new System.Windows.Forms.DataGridView();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgChucVu
            // 
            this.dgChucVu.AllowUserToAddRows = false;
            this.dgChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCV,
            this.TenCV});
            this.dgChucVu.Location = new System.Drawing.Point(530, 210);
            this.dgChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.dgChucVu.Name = "dgChucVu";
            this.dgChucVu.ReadOnly = true;
            this.dgChucVu.RowHeadersWidth = 51;
            this.dgChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChucVu.Size = new System.Drawing.Size(522, 180);
            this.dgChucVu.TabIndex = 5;
            this.dgChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgChucVu_CellClick);
            // 
            // MaCV
            // 
            this.MaCV.DataPropertyName = "MaCV";
            this.MaCV.HeaderText = "Mã Chức Vụ";
            this.MaCV.MinimumWidth = 6;
            this.MaCV.Name = "MaCV";
            this.MaCV.ReadOnly = true;
            // 
            // TenCV
            // 
            this.TenCV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenCV.DataPropertyName = "TenCV";
            this.TenCV.HeaderText = "Tên Chức Vụ";
            this.TenCV.MinimumWidth = 6;
            this.TenCV.Name = "TenCV";
            this.TenCV.ReadOnly = true;
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(174, 176);
            this.txtMaCV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(167, 22);
            this.txtMaCV.TabIndex = 10;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(174, 241);
            this.txtTenCV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(316, 22);
            this.txtTenCV.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Chức Vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã Chức Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chức Vụ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(390, 362);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(220, 362);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 28);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(48, 362);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 543);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaCV);
            this.Controls.Add(this.txtTenCV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgChucVu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChucVu";
            this.Text = "ChucVu";
            this.Load += new System.EventHandler(this.ChucVu_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChucVu_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}