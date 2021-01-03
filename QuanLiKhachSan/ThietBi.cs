using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class ThietBi
    {
        public string ma_TB { get; set; }
        public LoaiThietBi LTB { get; set; }
        public ThietBi(string ma_TB, LoaiThietBi LTB)
        {
            this.ma_TB = ma_TB;
            this.LTB = LTB;
        }
        public ThietBi(ThietBi TB)
        {
            this.ma_TB = TB.ma_TB;
            this.LTB = TB.LTB;
        }
    }
}
