using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class HopDong
    {
        public string so_HD { get; set; }
        public KhachHang ma_KH { get; set; }
        public DichVu ma_DV { get; set; }
        public string soPhong { get; set; }
        public string phuongThucThanhToan { get; set; }
        public string giaTien { get; set; }
        public string ngayNhanPhong { get; set; }
        public string ngayTraPhong { get; set; }
        public HopDong(string so_HD,KhachHang ma_KH,DichVu ma_DV,string soPhong,string phuongThucThanhToan,
            string giaTien,string ngayNhanPhong,string ngayTraPhong)
        {
            this.so_HD = so_HD;
            this.ma_KH = ma_KH;
            this.ma_DV = ma_DV;
            this.soPhong = soPhong;
            this.phuongThucThanhToan = phuongThucThanhToan;
            this.giaTien = giaTien;
            this.ngayNhanPhong = ngayNhanPhong;
            this.ngayTraPhong = ngayTraPhong;
        }
        public HopDong (HopDong HD)
        {
            this.so_HD = HD.so_HD;
            this.ma_KH = HD.ma_KH;
            this.ma_DV = HD.ma_DV;
            this.soPhong = HD.soPhong;
            this.phuongThucThanhToan = HD.phuongThucThanhToan;
            this.giaTien = HD.giaTien;
            this.ngayNhanPhong = HD.ngayNhanPhong;
            this.ngayTraPhong = HD.ngayTraPhong;
        }
    }
}
