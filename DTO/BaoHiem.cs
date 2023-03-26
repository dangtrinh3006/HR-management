using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class BaoHiem
    {
        string maNhanVien;
        string loaiBaoHiem;
        string soThe;
        string ngayCap;
        string ngayHetHan;
        string noiCap;
        public BaoHiem(DataRow row)
        {
            this.maNhanVien = (string)row["MaNV"];
            this.loaiBaoHiem = (string)row["LoaiBH"];
            this.soThe = (string)row["SoThe"];
            this.ngayCap = (string)row["NgayCap"];
            this.ngayHetHan = (string)row["NgayHH"];
            this.noiCap = (string)row["NoiCap"];
        }
        public BaoHiem(
        string maNhanVien,
        string loaiBaoHiem,
        string soThe, string ngayCap, string ngayHetHan, string noiCap
            )
        { }

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string LoaiBaoHiem { get => loaiBaoHiem; set => loaiBaoHiem = value; }

        public string SoTheBH { get => soThe; set => soThe = value; }

        public string NgayCapBH { get => ngayCap; set => ngayCap = value; }
        public string NgayHetHanBH { get => ngayHetHan; set => ngayHetHan = value; }
        public string NoiCapBH { get => noiCap; set => noiCap = value; }



    }
}
