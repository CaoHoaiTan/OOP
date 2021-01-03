using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class NhomCongViec
    {
        public string ma_nhomCV { get; set; }
        public string ten_nhomCV { get; set; }
        public NhomCongViec(string ma_nhomCV, string ten_nhomCV)
        {
            this.ma_nhomCV = ma_nhomCV;
            this.ten_nhomCV = ten_nhomCV;
        }
        public NhomCongViec(NhomCongViec nhomCV)
        {
            this.ma_nhomCV = nhomCV.ma_nhomCV;
            this.ten_nhomCV = nhomCV.ten_nhomCV;
        }
    }
}
