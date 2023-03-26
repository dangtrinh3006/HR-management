using System;
using System.Data;
using DTO;


namespace DAO
{
    public class ThuongPhatDAO
    {
        private static volatile ThuongPhatDAO instance;
        public static ThuongPhatDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThuongPhatDAO();
                return instance;
            }
        }
        private ThuongPhat thuongphat;
        private ThuongPhatDAO() { }

        public DataTable GetLayNhanVien(DateTime NgayDau, DateTime NgayCuoi)
        {
            string query = "exec LayNhanVienTuMaPB @ngaybatdau , @ngayketthuc";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { NgayDau, NgayCuoi });
            return result;
        }

        public DataTable GetNhanVienMacDinh()
        {
            string query = "exec layMaNVTuTenNV";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }

        public bool UpdateThuongPhat(string MaNhanVien, string Loai, int Tien, string LyDo, DateTime Ngay)
        {
            string query = "exec ThemThuongPhat @manv , @loai , @tien , @lydo , @ngay";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaNhanVien, Loai, Tien, LyDo, Ngay });
            if (rowaffect < 1)
            {
                return false;
            }
            return true;
        }


        public bool DeleteThuongPhat(string MaNhanVien, string Loai, int Tien, string LyDo, DateTime Ngay)
        {
            string query = "exec XoaThuongPhat @manv , @loai , @tien , @lydo , @ngay";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaNhanVien, Loai, Tien, LyDo, Ngay });
            if (rowaffect < 1)
            {
                return false;
            }
            return true;
        }



    }
}
