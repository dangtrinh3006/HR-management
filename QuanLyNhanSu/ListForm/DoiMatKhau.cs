using System;
using System.Windows.Forms;
using DAO;

namespace QuanLyNhanSu.ListForm
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string TK = txtTaiKhoan2.Text;
            string MKM = txtMKM.Text;
            if(string.IsNullOrEmpty(txtMKM.Text) || string.IsNullOrEmpty(txtMKNL.Text))
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
            

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTaiKhoan2.Text = AccountDAO.Instance.AccountInfor().TenDangNhap;
            txtTaiKhoan2.ReadOnly = true;
        }
    }
}
