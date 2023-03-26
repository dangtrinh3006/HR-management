
namespace QuanLyNhanSu.ListForm
{
    partial class DoiMatKhau
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
            this.label10 = new System.Windows.Forms.Label();
            this.txtTaiKhoan2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMKNL = new System.Windows.Forms.TextBox();
            this.txtMKM = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(341, 108);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Tài Khoản";
            // 
            // txtTaiKhoan2
            // 
            this.txtTaiKhoan2.Location = new System.Drawing.Point(475, 103);
            this.txtTaiKhoan2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaiKhoan2.Name = "txtTaiKhoan2";
            this.txtTaiKhoan2.Size = new System.Drawing.Size(251, 22);
            this.txtTaiKhoan2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(341, 207);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nhập lại mật khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(341, 154);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mật khẩu mới";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(460, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(266, 38);
            this.label9.TabIndex = 10;
            this.label9.Text = "ĐỔI MẬT KHẨU";
            // 
            // txtMKNL
            // 
            this.txtMKNL.Location = new System.Drawing.Point(475, 207);
            this.txtMKNL.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKNL.Name = "txtMKNL";
            this.txtMKNL.PasswordChar = '~';
            this.txtMKNL.Size = new System.Drawing.Size(251, 22);
            this.txtMKNL.TabIndex = 11;
            // 
            // txtMKM
            // 
            this.txtMKM.Location = new System.Drawing.Point(475, 154);
            this.txtMKM.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.PasswordChar = '~';
            this.txtMKM.Size = new System.Drawing.Size(251, 22);
            this.txtMKM.TabIndex = 7;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(475, 255);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(174, 35);
            this.btnCapNhat.TabIndex = 12;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 543);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTaiKhoan2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMKNL);
            this.Controls.Add(this.txtMKM);
            this.Controls.Add(this.btnCapNhat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoiMatKhau";
            this.Text = "DoiMatKhau";
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTaiKhoan2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMKNL;
        private System.Windows.Forms.TextBox txtMKM;
        private System.Windows.Forms.Button btnCapNhat;
    }
}