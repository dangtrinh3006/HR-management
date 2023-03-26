using System.Data;

namespace DTO
{
    public class ChamCong
    {
        private string maNV;
        private string ngayChamCong;
        private string tinhTrang;

        public ChamCong(DataRow row)
        {
            this.maNV = (string)row["MaNhanVien"];
            this.ngayChamCong = (string)row["Ngay"];
            this.tinhTrang = (string)row["TinhTrang"];
        }
        public ChamCong(string maNV, string ngayChamCong, string tinhTrang) { }

        public string MaNV { get => maNV; set => maNV = value; }
        public string NgayChamCong { get => ngayChamCong; set => ngayChamCong = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
