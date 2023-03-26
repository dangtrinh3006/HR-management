using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class ChucVu
    {
        string maChucVu;
        string tenChucVu;
        public ChucVu(DataRow row)
        {
            this.maChucVu = (string)row["MaCV"];
            this.tenChucVu = (string)row["TenCV"];
        }
        public ChucVu(
        string maChucVu,
        string tenChucVu)
        { }

        public string MaChucVu { get => maChucVu; set => maChucVu = value; }
        public string TenChucVu { get => tenChucVu; set => tenChucVu = value; }
    }
}
