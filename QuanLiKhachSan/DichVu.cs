using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class DichVu
    {
        public string ma_DV { get; set; }
        public double giaTien { get; set; }
        public string TenDV { get; set; }
        public DichVu(string ma_DV, string TenDV, double giaTien)
        {
            this.ma_DV = ma_DV;
            this.giaTien = giaTien;
            this.TenDV = TenDV;
        }
        public DichVu (DichVu DV)
        {
            this.ma_DV = DV.ma_DV;
            this.giaTien = DV.giaTien;
        }
    }
}
