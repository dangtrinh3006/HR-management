using System.Data;

namespace DTO
{
    public class ThuongPhat
    {

        private string maNV;
        private string loai;
        private int tien;
        private string lyDo;
        private string Ngay;

        public ThuongPhat(DataRow row)
        {
            this.maNV = (string)row["manv"];
            this.loai = (string)row["loai"];
            this.tien = (int)row["tien"];
            this.lyDo = (string)row["lydo"];
            this.Ngay = (string)row["ngay"];
        }
        public ThuongPhat(string maNV, string loai, int tien, string lyDo, string Ngay) { }

        public string MaNV { get => maNV; set => maNV = value; }
        public string Loai { get => loai; set => loai = value; }
        public int Tien { get => tien; set => tien = value; }
        public string LyDo { get => lyDo; set => lyDo = value; }
        public string NGAY { get => Ngay; set => Ngay = value; }

    }
}
