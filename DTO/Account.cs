using System.Data;

namespace DTO
{
    public class Account
    {
        private string maNV;
        private string tenDangNhap;
        private string matKhau;
        private string tenQuyenHan;
  
        public Account(DataRow row)
        { 
            this.MaNV = (string)row["MaNhanVien"];
            this.TenDangNhap = (string)row["TenDangNhap"];
            this.MatKhau = (string)row["MatKhau"];
            this.TenQuyenHan = (string)row["TenQuyenHan"];

        }
        public Account(string tenDangNhap, string matKhau, string tenQuyenHan, string maNV)
        {
            
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string TenQuyenHan { get => tenQuyenHan; set => tenQuyenHan = value; }
    }
}
