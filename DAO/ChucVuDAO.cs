using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class ChucVuDAO
    {
        private static volatile ChucVuDAO instance;
        public static ChucVuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChucVuDAO();
                return instance;
            }
        }
        private ChucVu chucvu;
        private ChucVuDAO() { }
        public DataTable getMaChucVu(string tencv)
        {
            string query = "exec laymacvtutencv @tencv";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { tencv});
            return result;
        }
        public DataTable GetAllChucVu()
        {
            string query = "exec LayChucVu ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public bool AddChucVu(string macv, string tencv)
        {
            string query = "exec ThemChucVu @macv , @tencv";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] { macv, tencv });
            if (rowaffect < 1)
            {
                return false;
            }
            return true;
        }
        public bool DelChucVu(string maCV)
        {
            string query = "exec XoaChucVu @macv";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maCV });
            if (rowaffect < 1)
            {
                return false;
            }
            return true;
        }
        public bool UpChucVu(string maCVOld, string maCVNew, string tenCV)
        {
            string query = "exec CapNhatChucVu @macvold , @macvnew , @tencv";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maCVOld, maCVNew, tenCV });
            if (rowaffect < 1)
            {
                return false;
            }
            return true;
        }
    }
}
