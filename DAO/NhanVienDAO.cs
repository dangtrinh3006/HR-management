using System.Data;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        private static volatile NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
        }
        private NhanVien nhanvien;
        private NhanVienDAO() { }
        public DataTable GetAllNhanVien()
        {
            string query = "exec LayThongTinNV";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable GetNhanVien(string MaNhanVien)
        {
            string query = "exec ThongTinNhanVien @MaNhanVien";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { MaNhanVien });
            return result;
        }
        public DataTable GetNhanVienTB()
        {
            string query = "exec ThongTinNhanVien1";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public bool AddNhanVien(string MaNhanVien, string TenNV, string MaPB, int HeSoLuong, string GioiTinh, string NgaySinh, string SoCM, string DienThoai, string TrinhDoHV, string DiaChi, string Email, string ngayvaolam, string macv)
        {
            string query = "exec ThemNhanVien @manv , @tennv , @mapb , @hesoluong , @gioitinh , @ngaysinh , @socm , @sodt , @trinhdo , @diachi , @email , @ngayvaolam , @macv";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaNhanVien, TenNV, MaPB, HeSoLuong, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, ngayvaolam, macv});
            if (rowaffect < 1)
            {
                return false;
            }
            return true;
        }
        public bool DelNhanVien(string MaNhanVien)
        {
            string query = "exec XoaNhanVien @manv";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaNhanVien});
            if (rowaffect < 1)
            {
                return false;
            }
            return true;
        }
        public bool UpNhanVien(string MaNhanVien, string TenNV, string MaPB, int HeSoLuong, string GioiTinh, string NgaySinh, string SoCM, string DienThoai, string TrinhDoHV, string DiaChi, string Email, string ngayvaolam, string macv)
        {
            string query = "exec SuaNhanVien @manv , @tennv , @mapb , @hesoluong , @gioitinh , @ngaysinh , @socm , @sodt , @trinhdo , @diachi , @email , @ngayvaolam , @macv";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaNhanVien, TenNV, MaPB, HeSoLuong, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, ngayvaolam, macv });
            if (rowaffect < 1)
            {
                return false;
            }
            return true;
        }


    }
    
}
