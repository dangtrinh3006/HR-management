using System.Data;

namespace DTO
{
    public class BangLuong
    {
        private int heSL;
        private int luongCB;

        public BangLuong(DataRow row)
        {
            this.heSL = (int)row["hesoluong"];
            this.luongCB = (int)row["luongcb"];
        }
        public BangLuong(int heSL, int luongCB) { }

        public int HeSL { get => heSL; set => heSL = value; }
        public int LuongCB { get => luongCB; set => luongCB = value; }

    }
}
