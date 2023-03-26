using System;
using System.Data;
using DTO;


namespace DAO
{
    public class ChamCongDAO
    {
        private static volatile ChamCongDAO instance;
        public static ChamCongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChamCongDAO();
                return instance;
            }
        }
        private ChamCong chamcong;
        private ChamCongDAO() { }
    
        public DataTable GetInforChamCong(DateTime Ngay)
        {
            string query = "exec LayChamCong @ngay";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { Ngay });
            return result;
        }


        public DataTable ChamCong_MacDinh(DateTime Ngay)
        {
            string query = "exec ThemChamCong_MacDinh @ngay";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { Ngay });
            return result;
        }

        public bool Delete_ChamCong(DateTime Ngay)
        {
            string query = "exec XoaChamCongTheoNgay @ngay";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] { Ngay });
            if (rowaffect < 1)
            {
                return false;
            }
            return true;
        }

        public bool Add_ChamCong(string MaNhanVien, DateTime Ngay, string TinhTrang)
        {
            string query = "exec ThemChamCong @manv , @ngay , @tinhtrang";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaNhanVien, Ngay, TinhTrang });
            if (rowaffect < 1)
            {
                return false;
            }
            return true;
        }


    }
}
