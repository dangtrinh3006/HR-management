using DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhanSu.ListForm
{
    public partial class TimKiemNhanVien : Form
    {
        public TimKiemNhanVien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            filldata();
        }
        private void filldata()
        {
            DataTable data = NhanVienDAO.Instance.GetAllNhanVien();
            dgSearch.DataSource = data;

        }

        private void TimKiemNhanVien_Load(object sender, EventArgs e)
        {
            filldata();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Hãy Nhập từ khoá!!!");
            }
            else
            {
                DataTable data = SearchDAO.Instance.Search(txtSearch.Text);
                dgSearch.DataSource = data;
            }
        }

        private void lbHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Từ khoá liên quan đến tên nhân viên, Số điện thoại, số chứng minh, học vấn, tên chức vụ, địa chỉ, tên phòng ban, email");
        }
    }
}
