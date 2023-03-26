using DAO;
using System;
using System.Data;
using System.Windows.Forms;
namespace QuanLyNhanSu.ListForm
{
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }
        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            filldata();
            panel1.Hide();
            panel2.Hide();
            btnDoiMatKhau.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void filldata()
        {
            DataTable data1 = AccountDAO.Instance.GetNonAllUser();
            DataTable data2 = AccountDAO.Instance.GetAllUser();
            dg1.DataSource = data1;
            dg2.DataSource = data2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ID;
            string manv;
            foreach (DataGridViewRow row in dg2.SelectedRows)
            {
                ID = row.Cells[0].Value.ToString();
                txtMaNv.Text = ID;
            }
            manv = txtMaNv.Text;
            if(txtMaNv.Text == AccountDAO.Instance.AccountInfor().MaNV){
                MessageBox.Show("Bạn không thể xoá tài khoản đang đăng nhập được");
            }
            else if(MessageBox.Show("Bạn thật sự muốn xóa tài khoản này!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (AccountDAO.Instance.DelUser(manv))
                {
                    MessageBox.Show("Xoá thành công");
                    dg1.Refresh();
                    filldata();
                    dg1.Update();
                }
                else
                {
                    MessageBox.Show("Xoá Thất bại");
                }
            }
            
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            string matkhau = txtMatKhau.Text;
            string taikhoan = txtTaiKhoan.Text;
            string quyenhan = cbQuyenHan.Text;
            string manv = txtMaNv.Text;
            if (string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrEmpty(txtTaiKhoan.Text) || string.IsNullOrEmpty(cbQuyenHan.Text) || string.IsNullOrEmpty(txtReMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (txtMatKhau.Text != txtReMatKhau.Text)
            {
                MessageBox.Show("Xác thực mật khẩu không chính xác");
            }
            else { 
                if (AccountDAO.Instance.AddUser(manv, taikhoan, matkhau, quyenhan))
                {
                    MessageBox.Show("Thêm thành công");
                    filldata();
                    panel1.Hide();
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }  
            }
        }

        private void dg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID;
            panel2.Hide();
            panel1.Show();
            txtMaNv.ReadOnly = true;
            foreach (DataGridViewRow row in dg1.SelectedRows)
            {
               ID = row.Cells[0].Value.ToString();
               txtMaNv.Text = ID;
            }
        }

        private void dg2_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            
            string TK;
            btnDoiMatKhau.Enabled = true;
            btnXoa.Enabled = true;
            panel1.Hide();
            foreach (DataGridViewRow row in dg2.SelectedRows)
            {
                TK = row.Cells[2].Value.ToString();
                txtTaiKhoan2.Text = TK;
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            panel2.Show();
            txtTaiKhoan2.ReadOnly = true;
        }

    

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string TK = txtTaiKhoan2.Text;
            string MKM = txtMKM.Text;
            if (string.IsNullOrEmpty(txtMKM.Text) || string.IsNullOrEmpty(txtMKNL.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (txtMKM.Text != txtMKNL.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp");
            }
            else
            {
                if (AccountDAO.Instance.UpdateUser(TK, MKM))
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu không thành công");
                }
            }
        }
    }
}
