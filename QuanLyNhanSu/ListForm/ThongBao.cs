using DAO;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyNhanSu.ListForm
{
    public partial class ThongBao : Form
    {
        Attachment attach = null;
        public ThongBao()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            string path = "";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                txtDinhKem.Text = dialog.FileName;
                path = dialog.FileName.ToString();
                path = path.Replace(@"\", @"\\");
            }
        }

        private void btnGui_Click(object sender, EventArgs e)
        {

            string text = txtNoiDung.Text;
            Thread thread = new Thread(delegate () {
                attach = null;
                try
                {
                    FileInfo file = new FileInfo(txtDinhKem.Text);
                    attach = new Attachment(txtDinhKem.Text);
                }
                catch { }
                Sendmail(txtTDN.Text, txtTo.Text, txtSubject.Text, text);
            }
            );
            thread.Start();
            MessageBox.Show("Đã gửi, Xin check email để kiểm tra kết quả");


        }
        public void Sendmail(string from, string to, string sub, string message, Attachment file = null)
        {
            attach = null;
            try
            {
                FileInfo file1 = new FileInfo(txtDinhKem.Text);
                attach = new Attachment(txtDinhKem.Text);
            }
            catch { }
            MailMessage mess = new MailMessage(from, to, sub, message);
            if (attach != null)
            {
                mess.Attachments.Add(attach);
            }
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(txtTDN.Text, txtMK.Text);
            client.Send(mess);

        }

        private void ThongBao_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Chắc chắn rằng bạn đã bật cho phép kết nối ứng dụng kém an toàn trên email.", "Lưu ý!",MessageBoxButtons.OK, MessageBoxIcon.Question);
            DataTable data = NhanVienDAO.Instance.GetNhanVienTB();
            dgEmal.DataSource = data;
        }
        private void btnChonAll_Click(object sender, EventArgs e)
        {
            string text = txtNoiDung.Text;
            Thread thread = new Thread(delegate () {
                using (TextWriter tw = new StreamWriter("email.txt"))
                {
                    for (int i = 0; i < dgEmal.Rows.Count - 1; i++)
                    {
                        for (int j = 1; j < dgEmal.Columns.Count; j++)
                        {
                            tw.Write($"{dgEmal.Rows[i].Cells[j].Value.ToString()}");
                            Sendmail(txtTDN.Text, dgEmal.Rows[i].Cells[j].Value.ToString(), txtSubject.Text, text);

                        }
                        tw.WriteLine();
                    }
                }
            }
            );
            thread.Start();
            MessageBox.Show("Đã gửi, Xin check email để kiểm tra kết quả");
        }

        private void dgEmal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTo.Text = dgEmal.CurrentRow.Cells["email"].Value.ToString();
        }
    }
}
