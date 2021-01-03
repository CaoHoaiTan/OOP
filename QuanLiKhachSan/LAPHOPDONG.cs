using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class LAPHOPDONG
    {
        public KhachHang ma_KH { get; set; }
        public Phong soPhong { get; set; }
        public HopDong soHD { get; set; }
        public LAPHOPDONG(KhachHang ma_KH,Phong soPhong,HopDong soHD)
        {
            this.ma_KH = ma_KH;
            this.soHD = soHD;
            this.soPhong = soPhong;
            soPhong.DaThue = true;
        }
        public LAPHOPDONG(LAPHOPDONG LapHD)
        {
            this.ma_KH = LapHD.ma_KH;
            this.soHD = LapHD.soHD;
            this.soPhong = LapHD.soPhong;
        }
    }
}
