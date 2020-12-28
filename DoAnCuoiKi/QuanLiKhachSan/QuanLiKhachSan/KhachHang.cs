using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class KhachHang
    {
        public string ma_KH { get; set; }
        public string ten_KH { get; set; }
        public string sdt_KH { get; set; }
        public string CMND_KH { get; set; }
        public string ma_loaiKH { get; set; }
        public KhachHang(string ma_KH, string ten_KH, string sdt_KH, string CMND_KH, string ma_loaiKH)
        {
            this.ma_KH = ma_KH;
            this.ten_KH = ten_KH;
            this.sdt_KH = sdt_KH;
            this.CMND_KH = CMND_KH;
            this.ma_loaiKH = ma_loaiKH;
        }
        public KhachHang(KhachHang KH)
        {
            this.ma_KH = KH.ma_KH;
            this.ten_KH = KH.ten_KH;
            this.sdt_KH = KH.sdt_KH;
            this.CMND_KH = KH.CMND_KH;
            this.ma_loaiKH = KH.ma_loaiKH;
        }
    }
}
