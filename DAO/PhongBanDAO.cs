using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class PhongBanDAO
    {
        private static volatile PhongBanDAO instance;
        public static PhongBanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhongBanDAO();
                return instance;
            }
        }
        private PhongBan phongban;
        private PhongBanDAO() { }
        public DataTable GetMaPhongBan(string tenpb)
        {
            string query = "exec laymapbtutenpb @tenpb";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { tenpb });
            return result;
        }
        public DataTable GetAllPhongBan()
        {
            string query = "exec HienPhongBan ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public bool AddPhongBan(string tenpb, string mapb)
        {
            string query = "exec ThemPhongBan @maphong , @tenphong";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenpb, mapb});
            if (rowaffect < 1)
            {
                return false;
            }
            return true;
        }
        public bool DelPhongBan(string MaPB)
        {
            string query = "exec XoaPhongBan @maphong";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaPB });
            if (rowaffect < 1)
            {
                return false;
            }
            return true;
        }
        public bool UpPhongBan(string maPBOld, String maPBNew, string tenPB)
        {
            string query = "exec CapNhatPhongBan @maphongold , @maphongnew , @tenphong";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maPBOld, maPBNew,  tenPB });
            if (rowaffect < 1)
            {
                return false;
            }
            return true;
        }

    }
}
