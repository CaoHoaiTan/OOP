using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class HoaDon
    {
        public string so_HoaDon { get; set; }
        public HopDong so_HD { get; set; }
        public string giaTien { get; set; }
        public string ngayTraTien { get; set; }
        public NhanVien ma_NV { get; set; }
        public KhachHang ma_KH { get; set; }
        public HoaDon(string so_HoaDon,HopDong so_HD,string giaTien,string ngayTraTien,NhanVien ma_NV,KhachHang ma_Kh)
        {
            this.so_HD = so_HD;
            this.so_HoaDon = so_HoaDon;
            this.giaTien = giaTien;
            this.ngayTraTien = ngayTraTien;
            this.ma_NV = ma_NV;
            this.ma_KH = ma_KH;
        }
        public HoaDon(HoaDon HD)
        {
            this.so_HD = HD.so_HD;
            this.so_HoaDon = HD.so_HoaDon;
            this.giaTien = HD.giaTien;
            this.ngayTraTien = HD.ngayTraTien;
            this.ma_NV = HD.ma_NV;
            this.ma_KH = HD.ma_KH;
        }
    }
}
