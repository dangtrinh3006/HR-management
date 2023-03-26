using DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhanSu.ListForm
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
       
        private void filldata()
        {
            DataTable data = NhanVienDAO.Instance.GetAllNhanVien();
            DataTable datapb = PhongBanDAO.Instance.GetAllPhongBan();
            DataTable datacv = ChucVuDAO.Instance.GetAllChucVu();
            dgNhanVien.DataSource = data;
            cbPhongBan.DataSource = datapb;
            cbPhongBan.DisplayMember = "TenPB";
            cbChucVu.DataSource = datacv;
            cbChucVu.DisplayMember = "TenCV";


        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.AccountInfor().TenQuyenHan == "User")
            {
                btnSua.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
            filldata();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
                int HeSoLuong = 0;
                try
                {
                    HeSoLuong = Int32.Parse(txtHeSoLuong.Text);
                }
                catch
                {
                    MessageBox.Show("Hệ số lương phải là số nguyên");
                }
                string MaNhanVien = txtMaNhanVien.Text;
                string TenNV = txtTenNhanVien.Text;
                string MaPB = PhongBanDAO.Instance.GetMaPhongBan(cbPhongBan.Text).Rows[0][0].ToString();
                string GioiTinh = cbGioiTinh.Text;
                string NgaySinh = dateNgaySinh.Text;
                string SoCM = txtSoCM.Text;
                string DienThoai = txtSDT.Text;
                string TrinhDoHV = txtTrinhDo.Text;
                string DiaChi = txtDiaChi.Text;
                string Email = txtEmail.Text;
                string ngayvaolam = dateNgayVaoLam.Text;
                string maCV = ChucVuDAO.Instance.getMaChucVu(cbChucVu.Text).Rows[0][0].ToString();
                if (string.IsNullOrEmpty(txtMaNhanVien.Text) || string.IsNullOrEmpty(txtTenNhanVien.Text) || string.IsNullOrEmpty(cbPhongBan.Text) || string.IsNullOrEmpty(txtHeSoLuong.Text) || string.IsNullOrEmpty(cbGioiTinh.Text) || string.IsNullOrEmpty(dateNgaySinh.Text) || string.IsNullOrEmpty(txtSoCM.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtTrinhDo.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(dateNgayVaoLam.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    try
                    {
                        NhanVienDAO.Instance.AddNhanVien(MaNhanVien, TenNV, MaPB, HeSoLuong, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, ngayvaolam, maCV);
                        MessageBox.Show("Thêm nhân viên thành công");
                        filldata();
                    }
                    catch
                    {
                        MessageBox.Show("Thêm nhân viên không thành công");
                    }
                } 
        }
        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ID;
            string manv;
            foreach (DataGridViewRow row in dgNhanVien.SelectedRows)
            {
                ID = row.Cells[0].Value.ToString();
                txtMaNhanVien.Text = ID;
            }
            manv = txtMaNhanVien.Text;
            try
            {
                if (MessageBox.Show("Bạn thật sự muốn xóa nhân viên này!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {

                    if (txtMaNhanVien.Text == AccountDAO.Instance.AccountInfor().MaNV)
                    {
                        MessageBox.Show("Bạn không thể xoá chính mình", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        NhanVienDAO.Instance.DelNhanVien(manv);
                        MessageBox.Show("Xoá thành công");
                        filldata();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Xoá nhân viên không thành công");
            }
        }

        private void dgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID;
            foreach (DataGridViewRow row in dgNhanVien.SelectedRows)
            {
                ID = row.Cells[0].Value.ToString();
                DataTable select = NhanVienDAO.Instance.GetNhanVien(ID);
                txtMaNhanVien.Text = select.Rows[0][0].ToString();
                txtTenNhanVien.Text = select.Rows[0][1].ToString();
                cbPhongBan.Text = select.Rows[0][2].ToString();
                cbChucVu.Text = select.Rows[0][3].ToString();
                cbGioiTinh.Text = select.Rows[0][4].ToString();
                txtDiaChi.Text  = select.Rows[0][5].ToString();
                txtSoCM.Text = select.Rows[0][6].ToString();
                txtSDT.Text = select.Rows[0][7].ToString();
                txtTrinhDo.Text = select.Rows[0][8].ToString();
                txtEmail.Text = select.Rows[0][9].ToString();
                txtHeSoLuong.Text = select.Rows[0][10].ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaNhanVien = txtMaNhanVien.Text;
            string TenNV = txtTenNhanVien.Text;
            string MaPB = PhongBanDAO.Instance.GetMaPhongBan(cbPhongBan.Text).Rows[0][0].ToString();
            int HeSoLuong = Int32.Parse(txtHeSoLuong.Text);
            string GioiTinh = cbGioiTinh.Text;
            string NgaySinh = dateNgaySinh.Text;
            string SoCM = txtSoCM.Text;
            string DienThoai = txtSDT.Text;
            string TrinhDoHV = txtTrinhDo.Text;
            string DiaChi = txtDiaChi.Text;
            string Email = txtEmail.Text;
            string ngayvaolam = dateNgayVaoLam.Text;
            string maCV = ChucVuDAO.Instance.getMaChucVu(cbChucVu.Text).Rows[0][0].ToString();
            if (string.IsNullOrEmpty(txtMaNhanVien.Text) || string.IsNullOrEmpty(txtTenNhanVien.Text) || string.IsNullOrEmpty(cbPhongBan.Text) || string.IsNullOrEmpty(txtHeSoLuong.Text) || string.IsNullOrEmpty(cbGioiTinh.Text) || string.IsNullOrEmpty(dateNgaySinh.Text) || string.IsNullOrEmpty(txtSoCM.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtTrinhDo.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(dateNgayVaoLam.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                try
                {
                    NhanVienDAO.Instance.UpNhanVien(MaNhanVien, TenNV, MaPB, HeSoLuong, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, ngayvaolam, maCV);
                    MessageBox.Show("Cập nhật nhân viên thành công");
                    filldata();
                }
                catch
                {
                    MessageBox.Show("Cập nhật nhân viên không thành công");
                }
            }
        }
    }
}
