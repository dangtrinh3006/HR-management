using System;
using System.Data;
using DTO;


namespace DAO
{
    public class BangLuongDAO
    {
        private static volatile BangLuongDAO instance;

        public static BangLuongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BangLuongDAO();
                return instance;
            }
        }
        private BangLuong bangluong;
        private BangLuongDAO() { }

        public DataTable GetTongLuong(string MaNhanVien)
        {
            string query = "exec TongLuongNV @manv";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { MaNhanVien });
            return result;
        }

        public DataTable GetSoNgayDiLam(string MaNhanVien, DateTime NgayDau, DateTime NgayCuoi)
        {
            string query = "exec DemSoNgayLam @manv , @ngaydau , @ngaycuoi";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { MaNhanVien, NgayDau, NgayCuoi });
            return result;
        }

        public DataTable GetTienThuong(string MaNhanVien, string Loai, DateTime NgayDau, DateTime NgayCuoi)
        {
            string query = "exec LayTienThuong @manv , @loai , @ngaydau , @ngaycuoi";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { MaNhanVien, Loai, NgayDau, NgayCuoi });
            return result;
        }

        public DataTable GetChucVu(string MaNhanVien)
        {
            string query = "exec LayChucVuTuMaNV @manv";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { MaNhanVien });
            return result;
        }

        public bool UpdateMucLuong(int hesoluong, int luongcb)
        {
            string query = "exec CapNhatLuong @hesoluong , @luongcb";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] { hesoluong , luongcb });
            if (rowaffect < 1)
            {
                return false;
            }
            return true;

        }
        public DataTable GetLuongTuHSL(int heSL)
        {
            string query = "exec LayLuongCBTuHSL @hsl";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { heSL });
            return result;
        }
    }
}
