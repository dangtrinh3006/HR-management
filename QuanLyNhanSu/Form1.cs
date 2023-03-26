using System;
using System.Data;
using System.Windows.Forms;
using DAO;

namespace QuanLyNhanSu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (AccountDAO.Instance.AccountInfor().TenQuyenHan == "Admin")
             {
                 btnTaiKhoan.Visible = false;
                 lblTaiKhoan.Visible = false;
             }
             else if (AccountDAO.Instance.AccountInfor().TenQuyenHan == "User")
             {
                 btnTaiKhoan.Visible = false;
                 btnPhongBan.Visible = false;
                 btnChamCong.Visible = false;
                 btnChucVu.Visible = false;
                 btnLuong.Visible = false;
                 btnKhenThuong.Visible = false;
                 btnBaoHiem.Visible = false;
                 btnThongBao.Visible = false;
                 lblTaiKhoan.Visible = false;
                 lblPhongBan.Visible = false;
                 lblChamCong.Visible = false;
                 lblChucVu.Visible = false;
                 lblBangLuong.Visible = false;
                 lblKhenThuong.Visible = false;
                 lblBaoHiem.Visible = false;
                 lblThongBao.Visible = false;
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            ListForm.TaiKhoan Tk = new ListForm.TaiKhoan();
            Tk.TopLevel = false;
            panel.Controls.Add(Tk);
            Tk.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap DN = new DangNhap();
            this.Hide();
            DN.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            ListForm.NhanVien NV = new ListForm.NhanVien();
            NV.TopLevel = false;
            panel.Controls.Add(NV);
            NV.Show();
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            ListForm.PhongBan PB = new ListForm.PhongBan();
            PB.TopLevel = false;
            panel.Controls.Add(PB);
            PB.Show();
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            ListForm.ChucVu CV = new ListForm.ChucVu();
            CV.TopLevel = false;
            panel.Controls.Add(CV);
            CV.Show();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            ListForm.ChamCong CC = new ListForm.ChamCong();
            CC.TopLevel = false;
            panel.Controls.Add(CC);
            CC.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            ListForm.BangLuong BL = new ListForm.BangLuong();
            BL.TopLevel = false;
            panel.Controls.Add(BL);
            BL.Show();
        }

        private void btnTKNhanVien_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            ListForm.TimKiemNhanVien TK = new ListForm.TimKiemNhanVien();
            TK.TopLevel = false;
            panel.Controls.Add(TK);
            TK.Show();
        }

        private void btnDMK_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            ListForm.DoiMatKhau DMK = new ListForm.DoiMatKhau();
            DMK.TopLevel = false;
            panel.Controls.Add(DMK);
            DMK.Show();
        }

        private void btnKhenThuong_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            ListForm.ThuongPhat TP = new ListForm.ThuongPhat();
            TP.TopLevel = false;
            panel.Controls.Add(TP);
            TP.Show();
        }

        private void btnBaoHiem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            ListForm.BaoHiem BH = new ListForm.BaoHiem();
            BH.TopLevel = false;
            panel.Controls.Add(BH);
            BH.Show();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            ListForm.ThongBao TB = new ListForm.ThongBao();
            TB.TopLevel = false;
            panel.Controls.Add(TB);
            TB.Show();
        }

        private void lblBaoHiem_Click(object sender, EventArgs e)
        {

        }
    }
}
