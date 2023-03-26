using System.Data;

namespace DTO
{
    public class NhanVien
    {
        private string maNV;
        private string maPB;
        private string maHD;
        private int heSoLuong;
        private string tenNV;
        private string gioiTinh;
        private string ngaySinh;
        private string soCM;
        private string DienThoai;
        private string trinhDoHV;
        private string diaChi;
        private string email;
        private string ngayvaolam;
        

        public NhanVien(DataRow row)
        {
            this.maNV = (string)row["MaNhanVien"];
            this.maPB = (string)row["MaPB"] ;
            this.maHD = (string)row["maHD"];
            this.heSoLuong = (int)row["heSoLuong"];
            this.tenNV = (string)row["tenNV"];
            this.gioiTinh = (string)row["gioiTinh"];
            this.ngaySinh = (string)row["ngaySinh"];
            this.soCM = (string)row["soCM"];
            this.DienThoai = (string)row["DienThoai"];
            this.trinhDoHV = (string)row["trinhDoHV"];
            this.diaChi = (string)row["diaChi"];
            this.email = (string)row["email"];
            this.Ngayvaolam = (string)row["ngayvaolam"];
        }
        public NhanVien(
        string maNV,
        string maPB,
        string maHD,
        int heSoLuong,
        string tenNV,
        string gioiTinh,
        string ngaySinh,
        string soCM,
        string DienThoai,
        string trinhDoHV,
        string diaChi,
        string email,
        string ngayvaolam){}

        public string MaNV { get => maNV; set => maNV = value; }
        public string MaPB { get => maPB; set => maPB = value; }
        public string MaHD { get => maHD; set => maHD = value; }
        public int HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string SoCM { get => soCM; set => soCM = value; }
        public string DienThoai1 { get => DienThoai; set => DienThoai = value; }
        public string TrinhDoHV { get => trinhDoHV; set => trinhDoHV = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
        public string Ngayvaolam { get => ngayvaolam; set => ngayvaolam = value; }
    }
}
