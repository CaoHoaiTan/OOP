using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class LoaiThietBi
    {
        public string ma_LoaiTB { get; set; }
        public string ten_LoaiTB { get; set; }
        public LoaiThietBi(string ma_TB, string ten_TB)
        {
            this.ma_LoaiTB = ma_TB;
            this.ten_LoaiTB = ten_TB;
        }
        public LoaiThietBi(LoaiThietBi LoaiTB)
        {
            this.ma_LoaiTB = LoaiTB.ma_LoaiTB;
            this.ten_LoaiTB = LoaiTB.ten_LoaiTB;
        }
    }

}
