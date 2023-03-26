using DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhanSu.ListForm
{
    public partial class BaoHiem : Form
    {
        public BaoHiem()
        {
            InitializeComponent();
        }


        private void filldata()
        {

            DataTable data = BaoHiemDAO.Instance.getBaoHiem("0", "0");
            dgvBaoHiem.DataSource = data;
            cbLoai.Text = null;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
        }
        string manv = null, loai = null;



        private void BaoHiem_Load_1(object sender, EventArgs e)
        {
            filldata();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            manv = dgvBaoHiem.CurrentRow.Cells["mnv"].Value.ToString();
            loai = dgvBaoHiem.CurrentRow.Cells["lbh"].Value.ToString();

            if (!string.IsNullOrEmpty(txtTen.Text) && !string.IsNullOrEmpty(cbLoai.Text) && !string.IsNullOrEmpty(txtSo.Text) && !string.IsNullOrEmpty(txtNoiCap.Text))
            {
                if (cbLoai.Text == loai)
                {
                    MessageBox.Show("Đã tồn tại bảo hiểm. Hãy chọn Cập Nhật!");
                }
                else
                {
                    BaoHiemDAO.Instance.ThemBaoHiem(manv, cbLoai.Text, txtSo.Text, dtpNgayCap.Value, dtpNgayHH.Value, txtNoiCap.Text);
                    MessageBox.Show("Thêm thành công!");
                    filldata();
                }

            }
            else
            {
                MessageBox.Show("Thiếu thông tin! Vui lòng nhập lại");

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            manv = dgvBaoHiem.CurrentRow.Cells["mnv"].Value.ToString();
            string loaibhcu = dgvBaoHiem.CurrentRow.Cells["lbh"].Value.ToString();
            if (!string.IsNullOrEmpty(txtTen.Text) && !string.IsNullOrEmpty(cbLoai.Text) && !string.IsNullOrEmpty(txtSo.Text) && !string.IsNullOrEmpty(txtNoiCap.Text))
            {
                string loaibhmoi = cbLoai.Text;
                BaoHiemDAO.Instance.SuaBaoHiem(manv, loaibhcu, loaibhmoi, txtSo.Text, dtpNgayCap.Value, dtpNgayHH.Value, txtNoiCap.Text);
                MessageBox.Show("Sửa thành công!");
                filldata();
            }
            else
            {
                MessageBox.Show("Thiếu thông tin! Vui lòng nhập lại");

            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            manv = dgvBaoHiem.CurrentRow.Cells["mnv"].Value.ToString();

            if (!string.IsNullOrEmpty(txtTen.Text) && !string.IsNullOrEmpty(cbLoai.Text) && !string.IsNullOrEmpty(txtSo.Text) && !string.IsNullOrEmpty(txtNoiCap.Text))
            {
                if (MessageBox.Show("Bạn thật sự muốn xóa!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    BaoHiemDAO.Instance.XoaBaoHiem(manv, cbLoai.Text);
                    MessageBox.Show("Xóa thành công!");
                    filldata();
                }
            }
            else
            {
                MessageBox.Show("Thông tin trống!");

            }
        }

        private void dgvBaoHiem_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            manv = dgvBaoHiem.CurrentRow.Cells["mnv"].Value.ToString();
            loai = dgvBaoHiem.CurrentRow.Cells["lbh"].Value.ToString();

            txtTen.Text = dgvBaoHiem.CurrentRow.Cells["tnv"].Value.ToString();
            cbLoai.Text = dgvBaoHiem.CurrentRow.Cells["lbh"].Value.ToString();
            dtpNgayHH.Text = dgvBaoHiem.CurrentRow.Cells["nhh"].Value.ToString();

            DataTable data = BaoHiemDAO.Instance.getBaoHiem(manv, loai);
            if (string.IsNullOrEmpty(cbLoai.Text)) // không có dữ liệu bảo hiểm

            {
                txtSo.Text = null;
                txtNoiCap.Text = null;
                dtpNgayCap.Text = null;
                dtpNgayHH.Text = null;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;


            }

            if (!string.IsNullOrEmpty(cbLoai.Text))
            {
                txtSo.Text = data.Rows[0][3].ToString();
                txtNoiCap.Text = data.Rows[0][6].ToString();
                dtpNgayCap.Text = data.Rows[0][4].ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }
    }
}
