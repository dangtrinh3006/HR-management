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
    public partial class PhongBan : Form
    {
        public PhongBan()
        {
            InitializeComponent();
        }

        private void PhongBan_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            filldata();
        }
        private void filldata()
        {
            DataTable data = PhongBanDAO.Instance.GetAllPhongBan();
            dgPhongBan.DataSource = data;

        }

        private void dgPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tpb;
            string snv;
            string mpb;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            foreach (DataGridViewRow row in dgPhongBan.SelectedRows)
            {
                mpb = row.Cells[0].Value.ToString();
                tpb = row.Cells[1].Value.ToString();
                snv = row.Cells[2].Value.ToString();
                txtSoNhanVien.Text = snv;
                txtTen.Text = tpb;
                txtMaPB.Text = mpb;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPB = txtMaPB.Text;
            string tenPB = txtTen.Text;
            try { 
                PhongBanDAO.Instance.AddPhongBan(maPB, tenPB);
                MessageBox.Show("Thêm phòng ban thành công");
                filldata();
            }
            catch
            {
                MessageBox.Show("Thêm phòng không thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPB = txtMaPB.Text;
            if (MessageBox.Show("Bạn thật sự muốn xóa phong ban này!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                if(PhongBanDAO.Instance.DelPhongBan(maPB))
                {
                    MessageBox.Show("Xoá thành công");
                    filldata();
                }
                else
                {
                    MessageBox.Show("Xoá không thành công");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPBNew = txtMaPB.Text;
            string tenPB = txtTen.Text;
            string maPBOld  = "";
            foreach (DataGridViewRow row in dgPhongBan.SelectedRows)
            {
                maPBOld = row.Cells[0].Value.ToString();
            }
                try 
            {
                PhongBanDAO.Instance.UpPhongBan(maPBOld, maPBNew, tenPB);
                MessageBox.Show("Cập nhật thành công");
                filldata();
            }
            catch
            {
                MessageBox.Show("Cập nhật không thành công");
            }
        }

        private void PhongBan_MouseClick(object sender, MouseEventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
    }
}
