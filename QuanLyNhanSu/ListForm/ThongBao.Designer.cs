
namespace QuanLyNhanSu.ListForm
{
    partial class ThongBao
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.btnGui = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDinhKem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTDN = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.dgEmal = new System.Windows.Forms.DataGridView();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChonAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmal)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(154, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(356, 38);
            this.label6.TabIndex = 29;
            this.label6.Text = "Thông Báo Qua Email";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(15, 381);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(588, 151);
            this.txtNoiDung.TabIndex = 28;
            this.txtNoiDung.Text = "";
            // 
            // btnGui
            // 
            this.btnGui.Location = new System.Drawing.Point(183, 334);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(94, 31);
            this.btnGui.TabIndex = 27;
            this.btnGui.Text = "Gửi";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(473, 109);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(100, 28);
            this.btnAttach.TabIndex = 26;
            this.btnAttach.Text = "Đính kèm";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Đính Kèm";
            // 
            // txtDinhKem
            // 
            this.txtDinhKem.Location = new System.Drawing.Point(183, 112);
            this.txtDinhKem.Name = "txtDinhKem";
            this.txtDinhKem.ReadOnly = true;
            this.txtDinhKem.Size = new System.Drawing.Size(266, 22);
            this.txtDinhKem.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Chủ Đề";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Người Nhận";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(183, 298);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '•';
            this.txtMK.Size = new System.Drawing.Size(266, 22);
            this.txtMK.TabIndex = 19;
            // 
            // txtTDN
            // 
            this.txtTDN.Location = new System.Drawing.Point(183, 252);
            this.txtTDN.Name = "txtTDN";
            this.txtTDN.Size = new System.Drawing.Size(266, 22);
            this.txtTDN.TabIndex = 18;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(183, 205);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(266, 22);
            this.txtSubject.TabIndex = 17;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(183, 158);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(266, 22);
            this.txtTo.TabIndex = 16;
            // 
            // dgEmal
            // 
            this.dgEmal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEmal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNV,
            this.email});
            this.dgEmal.Location = new System.Drawing.Point(619, 49);
            this.dgEmal.Name = "dgEmal";
            this.dgEmal.RowHeadersWidth = 51;
            this.dgEmal.RowTemplate.Height = 24;
            this.dgEmal.Size = new System.Drawing.Size(476, 329);
            this.dgEmal.TabIndex = 30;
            this.dgEmal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmal_CellClick);
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            // 
            // btnChonAll
            // 
            this.btnChonAll.Location = new System.Drawing.Point(302, 334);
            this.btnChonAll.Name = "btnChonAll";
            this.btnChonAll.Size = new System.Drawing.Size(100, 31);
            this.btnChonAll.TabIndex = 31;
            this.btnChonAll.Text = "Gửi Tất Cả";
            this.btnChonAll.UseVisualStyleBackColor = true;
            this.btnChonAll.Click += new System.EventHandler(this.btnChonAll_Click);
            // 
            // ThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 543);
            this.Controls.Add(this.btnChonAll);
            this.Controls.Add(this.dgEmal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDinhKem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTDN);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtTo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongBao";
            this.Text = "ThongBao";
            this.Load += new System.EventHandler(this.ThongBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtNoiDung;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDinhKem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTDN;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.DataGridView dgEmal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Button btnChonAll;
    }
}