using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.ListForm
{
    public partial class ThuongPhat : Form
    {
        public ThuongPhat()
        {
            InitializeComponent();
        }

        int thang = DateTime.Now.Month, nam = DateTime.Now.Year, flag = 0;
        string loai = null;

        private void ThuongPhat_Load_1(object sender, EventArgs e)
        {
            filldata();
        }

        private void btXem_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbNam.Text))
            {
                if (!string.IsNullOrEmpty(cbThang.Text))
                {

                    flag = 1; // Xem theo Tháng
                    dgvThuongPhat.Refresh();
                    filldata();

                }
                else
                {
                    flag = 2; // Xem theo Năm
                    dgvThuongPhat.Refresh();
                    filldata();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập Năm!");
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            DataTable data = ThuongPhatDAO.Instance.GetNhanVienMacDinh();
            dgvThuongPhat.DataSource = data;
            dgvThuongPhat.Update();
            dgvThuongPhat.Refresh();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string loai;
            string manv = dgvThuongPhat.CurrentRow.Cells["MaNV"].Value.ToString();
            int tien;
            string lydo;
            if (rdPhat.Checked == true)
                loai = "Phạt";
            else loai = "Thưởng";

            if (!string.IsNullOrEmpty(txtLyDo.Text))
            {
                if (!string.IsNullOrEmpty(txtT.Text))
                {
                    tien = Convert.ToInt32(txtT.Text.ToString());
                    lydo = txtLyDo.Text;
                    ThuongPhatDAO.Instance.UpdateThuongPhat(manv, loai, tien, lydo, DateTime.Now);
                    MessageBox.Show("Lưu thành công!");

                }
                else
                {
                    MessageBox.Show("Chưa nhập Tiền!");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập Lý do!");
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string manv = dgvThuongPhat.CurrentRow.Cells["MaNV"].Value.ToString();
            int tien;
            string lydo;
            DateTime ngay;

            if (rdPhat.Checked == true)
                loai = "Phạt";
            else loai = "Thưởng";


            if (MessageBox.Show("Xác nhận Xóa!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                if (!string.IsNullOrEmpty(txtLyDo.Text) && !string.IsNullOrEmpty(txtT.Text))
                {
                    ngay = dateNgay.Value;
                    tien = Convert.ToInt32(txtT.Text.ToString());
                    lydo = txtLyDo.Text;
                    ThuongPhatDAO.Instance.DeleteThuongPhat(manv, loai, tien, lydo, ngay);
                    MessageBox.Show("Xóa thành công!");
                    dgvThuongPhat.Refresh();
                    filldata();

                }
                else
                {
                    MessageBox.Show("Dữ liệu cần xóa rỗng!");
                }

            }
        }

        private void dgvThuongPhat_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtTen.Text = dgvThuongPhat.CurrentRow.Cells["TenNV"].Value.ToString();
            txtLyDo.Text = dgvThuongPhat.CurrentRow.Cells["LyDo"].Value.ToString();
            txtT.Text = dgvThuongPhat.CurrentRow.Cells["Tien"].Value.ToString();
            loai = dgvThuongPhat.CurrentRow.Cells["Loai"].Value.ToString();

            rdThuong.Enabled = true;
            rdPhat.Enabled = true;
            if (loai == "Thưởng")
            {
                rdThuong.Checked = true;
                rdPhat.Checked = false;
            }
            else if (loai == "Phạt")
            {
                rdPhat.Checked = true;
                rdThuong.Checked = false;
            }

            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;

            if (string.IsNullOrEmpty(loai))
            {
                rdPhat.Checked = false;
                rdThuong.Checked = false;
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
            }

            txtLyDo.Enabled = true;
            txtT.Enabled = true;
            dateNgay.Text = dgvThuongPhat.CurrentRow.Cells["Ngay"].Value.ToString();

        }

        private void filldata()
        {
            DateTime ngaydau, ngaycuoi;
            txtLyDo.Enabled = false;
            txtT.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            rdThuong.Enabled = false;
            rdPhat.Enabled = false;

            if (flag == 1)
            {
                ngaydau = Convert.ToDateTime(cbThang.Text + "/" + "01/" + cbNam.Text);
                if (cbThang.Text == "2") //check năm nhuận
                {
                    ngaycuoi = Convert.ToDateTime(cbThang.Text + "/" + "28/" + cbNam.Text);
                }
                else if (cbThang.Text == "2" && Convert.ToInt32(cbNam.Text) % 4 == 0 && Convert.ToInt32(cbNam.Text) % 100 != 0)
                {
                    ngaycuoi = Convert.ToDateTime(cbThang.Text + "/" + "29/" + cbNam.Text);
                }
                else if (cbThang.Text == "4" || cbThang.Text == "6" || cbThang.Text == "9" || cbThang.Text == "11") // check tháng 30 ngày
                {
                    ngaycuoi = Convert.ToDateTime(cbThang.Text + "/" + "30/" + cbNam.Text);
                }
                else
                {
                    ngaycuoi = Convert.ToDateTime(cbThang.Text + "/" + "31/" + cbNam.Text);
                }
            }
            else if (flag == 2)
            {
                ngaydau = Convert.ToDateTime("01" + "/" + "01/" + cbNam.Text);
                ngaycuoi = Convert.ToDateTime("12" + "/" + "31/" + cbNam.Text);
            }
            else
            {
                ngaydau = Convert.ToDateTime("01/01/1900");
                ngaycuoi = Convert.ToDateTime("12" + "/31" + "/" + nam);
            }

            DataTable data = ThuongPhatDAO.Instance.GetLayNhanVien(ngaydau, ngaycuoi);
            dgvThuongPhat.DataSource = data;
        }
    }
}
