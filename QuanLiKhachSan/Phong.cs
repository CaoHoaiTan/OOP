using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class Phong
    {
        public string soPhong { get; set; }
        public string ma_LoaiPhong { get; set; }
        public string ma_ThietBi { get; set; }
        public Phong(string soPhong,string ma_LoaiPhong,string ma_ThietBi)
        {
            this.soPhong = soPhong;
            this.ma_LoaiPhong = ma_LoaiPhong;
            this.ma_ThietBi = ma_ThietBi;
        }
        public Phong(Phong PH)
        {
            this.soPhong = PH.soPhong;
            this.ma_ThietBi = PH.ma_ThietBi;
            this.ma_LoaiPhong = PH.ma_LoaiPhong;

        }
    }
}
