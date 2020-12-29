using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class LAPHOPDONG
    {
        public string ma_KH { get; set; }
        public string soPhong { get; set; }
        public HopDong soHD { get; set; }
        public LAPHOPDONG(string ma_KH,string soPhong,HopDong soHD)
        {
            this.ma_KH = ma_KH;
            this.soHD = soHD;
            this.soPhong = soPhong;
        }
        public LAPHOPDONG(LAPHOPDONG LapHD)
        {
            this.ma_KH = LapHD.ma_KH;
            this.soHD = LapHD.soHD;
            this.soPhong = LapHD.soPhong;
        }
    }
}
