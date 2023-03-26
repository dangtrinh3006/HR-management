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
    public partial class BangLuong : Form
    {
        int thang = DateTime.Now.Month, nam = DateTime.Now.Year, ngay = DateTime.Now.Day, flag = 0;

        public BangLuong()
        {
            InitializeComponent();
        }

        private void BangLuong_Load(object sender, EventArgs e)
        {
            filldata();
        }

        private void filldata()
        {
            btnCapNhat.Enabled = false;
            lbTen.Text = null;
            lbChucVu.Text = null;

            DataTable data = BangLuongDAO.Instance.GetTongLuong("0");
            dgvBangLuong.DataSource = data;


            DateTime ngaydau, ngaycuoi;
            ngaydau = Convert.ToDateTime(thang + "/" + "01/" + nam);
            if (thang.ToString() == "2") //check năm nhuận
            {
                ngaycuoi = Convert.ToDateTime(thang + "/" + "28/" + nam);
            }
            else if (thang.ToString() == "2" && Convert.ToInt32(txtNam.Text) % 4 == 0 && Convert.ToInt32(txtNam.Text) % 100 != 0)
            {
                ngaycuoi = Convert.ToDateTime(thang + "/" + "29/" + nam);
            }
            else if (thang.ToString() == "4" || txtThang.Text == "6" || txtThang.Text == "9" || txtThang.Text == "11") // check tháng 30 ngày
            {
                ngaycuoi = Convert.ToDateTime(thang + "/" + "30/" + nam);
            }
            else
            {
                ngaycuoi = Convert.ToDateTime(thang + "/" + "31/" + nam);
            }


            if (flag == 1)
            {
                ngaydau = Convert.ToDateTime(txtThang.Text + "/" + "01/" + txtNam.Text);
                if (txtThang.Text == "2") //check năm nhuận
                {
                    ngaycuoi = Convert.ToDateTime(txtThang.Text + "/" + "28/" + txtNam.Text);
                }
                else if (txtThang.Text == "2" && Convert.ToInt32(txtNam.Text) % 4 == 0 && Convert.ToInt32(txtNam.Text) % 100 != 0)
                {
                    ngaycuoi = Convert.ToDateTime(txtThang.Text + "/" + "29/" + txtNam.Text);
                }
                else if (txtThang.Text == "4" || txtThang.Text == "6" || txtThang.Text == "9" || txtThang.Text == "11") // check tháng 30 ngày
                {
                    ngaycuoi = Convert.ToDateTime(txtThang.Text + "/" + "30/" + txtNam.Text);
                }
                else
                {
                    ngaycuoi = Convert.ToDateTime(txtThang.Text + "/" + "31/" + txtNam.Text);
                }

            }
            if (flag == 2)
            {
                ngaydau = Convert.ToDateTime("01/01/1900");
                ngaycuoi = Convert.ToDateTime("12" + "/" + "31/" + nam);
            }
            if (flag == 3)
            {
                ngaydau = Convert.ToDateTime("01" + "/" + "01/" + txtNam.Text);
                ngaycuoi = Convert.ToDateTime("12" + "/" + "31/" + txtNam.Text);
            }


            for (int i = 0; i < dgvBangLuong.RowCount; i++)
            {
                string manv = dgvBangLuong.Rows[i].Cells["Ma"].Value.ToString();
                dgvBangLuong.Rows[i].Cells["SNL"].Value = LaySoNgayLam(manv,ngaydau,ngaycuoi);
                dgvBangLuong.Rows[i].Cells["T"].Value = TienThuong(manv,"T",ngaydau, ngaycuoi);
                dgvBangLuong.Rows[i].Cells["P"].Value = TienThuong(manv, "P", ngaydau, ngaycuoi);
                int tongluong = TongLuong(manv,LaySoNgayLam(manv, ngaydau, ngaycuoi), TienThuong(manv, "T", ngaydau, ngaycuoi), TienThuong(manv, "P", ngaydau, ngaycuoi));
                dgvBangLuong.Rows[i].Cells["TL"].Value = String.Format("{0:0,0}", tongluong);
            }

        }

        private void btnTongLuong_Click(object sender, EventArgs e)
        {
            flag = 2;
            dgvBangLuong.Refresh();
            filldata();
            flag = 0;
        }

        private void cbHeSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            int hsl = Convert.ToInt32(cbHeSoLuong.Text);
            DataTable lg = BangLuongDAO.Instance.GetLuongTuHSL(hsl);
            string tmp = lg.Rows[0][0].ToString();
            txtLCB.Text = tmp;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNam.Text))
            {
                if (!string.IsNullOrEmpty(txtThang.Text))
                {
                    if (Convert.ToInt32(txtThang.Text) > 12 || Convert.ToInt32(txtThang.Text) < 1)
                    {
                        MessageBox.Show("Tháng không hợp lệ!");
                    }
                    else
                    {
                        flag = 1;
                        dgvBangLuong.Refresh();
                        filldata();
                    }
                }
                else
                {
                    flag = 3;
                    dgvBangLuong.Refresh();
                    filldata();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập Năm!");
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int hsl = Convert.ToInt32(cbHeSoLuong.Text);
            int lcb = Convert.ToInt32(txtLCB.Text);
            if (!string.IsNullOrEmpty(cbHeSoLuong.Text))
            {
                if (!string.IsNullOrEmpty(txtLCB.Text))
                {
                    if (hsl > 0 && hsl < 11)
                    {
                        if (BangLuongDAO.Instance.UpdateMucLuong(hsl, lcb))
                        {

                            MessageBox.Show("Cập nhật thành công");
                            filldata();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Hệ số lương không tồn tại!");
                        cbHeSoLuong.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập Lương cơ bản!");
                    txtLCB.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập Hệ số lương!");
                cbHeSoLuong.Focus();
            }
            filldata();
        }

        // hàm hỗ trợ
        private int LaySoNgayLam(string manv, DateTime ngaydau, DateTime ngaycuoi)
        {
            DataTable data1 = BangLuongDAO.Instance.GetSoNgayDiLam(manv,ngaydau,ngaycuoi);
            int songaylam = data1.Rows.Count;
            return songaylam;
        }

        private int TienThuong(string manv, string loai, DateTime ngaydau, DateTime ngaycuoi)
        {

            int t = 0;
            try
            {
                DataTable data2 = BangLuongDAO.Instance.GetTienThuong(manv, loai, ngaydau, ngaycuoi);
                string a = data2.Rows[0][0].ToString();
                t = Convert.ToInt32(a);
            }
            catch (Exception)
            {
                t = 0;
            }
            return t;
        }

        private int LuongCoBan(string manv)
        {
            int luongcoban = 0;
            try
            {
                DataTable data3 = BangLuongDAO.Instance.GetTongLuong(manv);
                string a = data3.Rows[0][0].ToString();
                luongcoban = Convert.ToInt32(a);
            }
            catch (Exception)
            {
                luongcoban = 0;
            }
            return luongcoban;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

                app.Visible = true;
                worksheet = workbook.Sheets["Trang_tính1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Exported from gridview";
                for (int i = 1; i < dgvBangLuong.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvBangLuong.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvBangLuong.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvBangLuong.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvBangLuong.Rows[i].Cells[j].Value.ToString();
                    }

                }
            }
            catch { }
        }

        private int TongLuong(string manv, int soNgayLam, int tienThuong, int tienPhat)
        {
            int lcb = LuongCoBan(manv);
            int snl = soNgayLam;
            int t = tienThuong;
            int p = tienPhat;
            int tongluong = (lcb / 26) * snl + t - p;
            return tongluong;
        }
        private string LayChucVu(string manv)
        {
            DataTable data4 = NhanVienDAO.Instance.GetNhanVien(manv);
            string cv = data4.Rows[0][3].ToString();
            return cv;
        }

        private void dgvBangLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbTen.Text = dgvBangLuong.CurrentRow.Cells["TenNV"].Value.ToString();
            cbHeSoLuong.Text = dgvBangLuong.CurrentRow.Cells["HeSoLuong"].Value.ToString();
            btnCapNhat.Enabled = true;
            string manv = dgvBangLuong.CurrentRow.Cells["Ma"].Value.ToString();
            txtLCB.Text = LuongCoBan(manv).ToString();
            lbChucVu.Text = LayChucVu(manv);
        }

    }
}
