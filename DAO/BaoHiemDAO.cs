    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class BaoHiemDAO
    {
        private static volatile BaoHiemDAO instance;
        public static BaoHiemDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaoHiemDAO();
                return instance;
            }
        }
        private BaoHiem baohiem;
        private BaoHiemDAO() { }
        public DataTable getBaoHiem(string MaNhanVien, string LoaiBaoHiem)
        {
            string query = "exec LayBaoHiem @manv , @loaibh";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { MaNhanVien, LoaiBaoHiem });
            return result;
        }

        public bool ThemBaoHiem(string MaNhanVien, string LoaiBaohiem, string SoThe, DateTime NgayCap, DateTime NgayHetHan, string NoiCap)
        {
            string query = "exec ThemBaoHiem @manv , @loaibh , @sothe , @ngaycap , @ngayhethan , @noicap";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaNhanVien, LoaiBaohiem, SoThe, NgayCap, NgayHetHan, NoiCap });
            if (rowaffect < 1)
            {
                return false;
            }
            return true;

        }

        public bool XoaBaoHiem(string MaNhanVien, string LoaiBaohiem)
        {
            string query = "exec XoaBaoHiem @manv , @loaibh";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaNhanVien, LoaiBaohiem });
            if (rowaffect < 1)
            {
                return false;
            }
            return true;

        }

        public bool SuaBaoHiem(string MaNhanVien, string LoaiBaohiemCu, String LoaiBaoHiemMoi, string SoThe, DateTime NgayCap, DateTime NgayHetHan, string NoiCap)
        {
            string query = "exec SuaBaoHiem @manv , @loaibhcu , @loaibhmoi , @sothe , @ngaycap , @ngayhethan , @noicap";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaNhanVien, LoaiBaohiemCu, LoaiBaoHiemMoi, SoThe, NgayCap, NgayHetHan, NoiCap });
            if (rowaffect < 1)
            {
                return false;
            }
            return true;

        }

    }
}
