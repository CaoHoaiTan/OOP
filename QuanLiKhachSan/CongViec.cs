using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class CongViec
    {
        public string ma_CV { get; set; }
        public string ten_CV { get; set; }
        public NhomCongViec ma_nhomCV { get; set; }
        public CongViec(string ma_CV, string ten_CV, NhomCongViec ma_nhomCV)
        {
            this.ma_CV = ma_CV;
            this.ten_CV = ten_CV;
            this.ma_nhomCV = ma_nhomCV;
        }
        public CongViec(CongViec CV)
        {
            this.ma_CV = CV.ma_CV;
            this.ten_CV = CV.ten_CV;
            this.ma_nhomCV = CV.ma_nhomCV;
        }
    }
}
