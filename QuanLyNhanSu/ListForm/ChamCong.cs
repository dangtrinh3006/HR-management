using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;


namespace QuanLyNhanSu.ListForm
{
    public partial class ChamCong : Form
    {
        public ChamCong()
        {
            InitializeComponent();
        }

        private void ChamCong_Load(object sender, EventArgs e)
        {
            filldata();
        }
        DateTime Ngay = DateTime.Now;
        private void filldata()
        {
            
            DataTable data = ChamCongDAO.Instance.GetInforChamCong(Ngay);
            lbMa.Text = null;
            lbTen.Text = null;
            lbTinhTrang.Text = null;
            lbNgayThang.Text = DateTime.Now.ToString();
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;

            if (data.Rows.Count == 0)
            {
                data = ChamCongDAO.Instance.ChamCong_MacDinh(Ngay);
            }
            dgvChamCong.DataSource = data;

        }

        private void dgvChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbMa.Text = dgvChamCong.CurrentRow.Cells["Ma"].Value.ToString();
            lbTen.Text = dgvChamCong.CurrentRow.Cells["Ten"].Value.ToString();
            lbTinhTrang.Text = dgvChamCong.CurrentRow.Cells["TinhTrang"].Value.ToString();
 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn xóa?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (ChamCongDAO.Instance.Delete_ChamCong(DateTime.Now))
                {
                    MessageBox.Show("Xóa chấm công thành công");
                    filldata();
                }
                else
                {
                    MessageBox.Show("Xoá không thành công");

                }
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int d = 0;
            for (int i = 0; i < dgvChamCong.RowCount; i++)
            {
                if (dgvChamCong.Rows[i].Cells["TinhTrang"].Value != DBNull.Value )
                {
                    d++;
                }
            }
            if (d == 0) MessageBox.Show("Dữ liệu rỗng, vui lòng cập nhật lại!");
            if ( d != 0)
            {
                for (int i = 0; i < dgvChamCong.RowCount; i++)
                {
                    string TinhTrang = dgvChamCong.Rows[i].Cells["TinhTrang"].Value.ToString();
                    string MaNhanVien = dgvChamCong.Rows[i].Cells["Ma"].Value.ToString();
                    ChamCongDAO.Instance.Add_ChamCong(MaNhanVien, DateTime.Now, TinhTrang);
                }
                MessageBox.Show("Cập nhật thành công!");
            }
            filldata();

        }

        private void cbCC_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCC.Checked == true)
                for (int i = 0; i < dgvChamCong.RowCount; i++)
                    dgvChamCong.Rows[i].Cells["TinhTrang"].Value = "Đi Làm";
            else
                for (int i = 0; i < dgvChamCong.RowCount; i++)
                    dgvChamCong.Rows[i].Cells["TinhTrang"].Value = "";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Ngay = dtpNgayCham.Value;
            DataTable data = ChamCongDAO.Instance.GetInforChamCong(Ngay);
            dgvChamCong.DataSource = data;
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!");
            }
        }
    }
}
