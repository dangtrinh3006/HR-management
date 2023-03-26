using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class AccountDAO
    {
        private static volatile AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
        }
        private Account account;
        private AccountDAO() { }
        public bool CheckAccount(string username, string password)
        {
            string query = "exec DangNhap @taikhoan , @matkhau";
            DataTable result =  DataProvider.Instance.ExecuteQuery(query, new object[]{username, password });
            if (result.Rows.Count > 0)
                account = new Account(result.Rows[0]);
            return result.Rows.Count > 0;
        }
        public Account AccountInfor()
        {
            return account;
        }
        public DataTable GetNonAllUser()
        {
            string query = "exec NvcTaiKhoan";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable GetAllUser()
        {
            string query = "exec NvCoTk";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public bool AddUser(string mnv, string tk, string mk, string QH)
        {
            string query = "exec ThemTaiKhoan @manv , @taikhoan , @matkhau , @tenquyenhan";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mnv, tk, mk, QH});
            if (rowaffect < 1)
            {
                return false;
            }
            return true;
        }
        public bool DelUser(string mnv)
        {
            string query = "exec XoaTk @ma";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] {mnv});
            if (rowaffect < 1)
            {
                return false;
            }
            return true;
        }
        public bool UpdateUser(string TK, string MKM)
        {
            string query = "exec DoiMatKhau @taikhoan , @matKhaumoi";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] {TK, MKM });
            if (rowaffect < 1)
            {
                return false;
            }
            return true;
        }
    }
}
