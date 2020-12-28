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
        public string ten_TB { get; set; }
        public ThietBi(string ma_TB,string ten_TB)
        {
            this.ma_TB = ma_TB;
            this.ten_TB = ten_TB;
        }
        public ThietBi(ThietBi TB)
        {
            this.ma_TB = TB.ma_TB;
            this.ten_TB = TB.ten_TB;
        }
    }
}
