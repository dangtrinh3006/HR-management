using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class PhongBan
    {
        string maPhongBan;
        string tenPhongBan;
        public PhongBan(DataRow row)
        {
            this.maPhongBan = (string)row["MaPB"];
            this.tenPhongBan = (string)row["TenPB"];
        }
        public PhongBan(
        string maPB,
        string tenPhongBan)
        { }

        public string MaPhongBan { get => maPhongBan; set => maPhongBan = value; }
        public string TenPhongBan { get => tenPhongBan; set => tenPhongBan = value; }
    }
}
