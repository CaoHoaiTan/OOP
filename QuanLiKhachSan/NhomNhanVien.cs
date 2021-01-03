using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class NhomNhanVien
    {
        public string ma_nhomNV { get; set; }
        public string ma_truongNhom { get; set; }

        public NhomNhanVien(string ma_nhomNV, string ma_truongNhom)
        {
            this.ma_nhomNV = ma_nhomNV;
            this.ma_truongNhom = ma_truongNhom;
        }
        public NhomNhanVien(NhomNhanVien nhomNV)
        {
            this.ma_truongNhom = nhomNV.ma_truongNhom;
            this.ma_nhomNV = nhomNV.ma_nhomNV;
        }
    }
}
