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
        public CongViec[] CongViec { get; set; }
        public DichVu(string ma_DV, string TenDV, double giaTien, CongViec CongViec)
        {
            this.ma_DV = ma_DV;
            this.giaTien = giaTien;
            this.TenDV = TenDV;
            this.CongViec = new CongViec[] { CongViec };
        }
        public DichVu(string ma_DV, string TenDV, double giaTien, CongViec CongViec1 , CongViec CongViec2)
        {
            this.ma_DV = ma_DV;
            this.giaTien = giaTien;
            this.TenDV = TenDV;
            this.CongViec = new CongViec[] { CongViec1, CongViec2 };
        }
        public DichVu (DichVu DV)
        {
            this.ma_DV = DV.ma_DV;
            this.giaTien = DV.giaTien;
        }
    }
}
