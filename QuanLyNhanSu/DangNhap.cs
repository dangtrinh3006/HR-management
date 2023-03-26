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

namespace QuanLyNhanSu
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string USN = txtTaiKhoan.Text;
            string PW = txtMatKhau.Text;
            if (AccountDAO.Instance.CheckAccount(USN, PW))
                {
                    this.Hide();
                    Form1 form = new Form1();
                    form.Show();
                }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
