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
        public LoaiPhong LoaiPhong { get; set; }
        public ThietBi[] ThietBi { get; set; }
        public bool DaThue = false;
        public Phong(string soPhong, LoaiPhong LoaiPhong, ThietBi ThietBi)
        {
            this.soPhong = soPhong;
            this.LoaiPhong = LoaiPhong;
            this.ThietBi = new ThietBi[] { ThietBi };
        }
        public Phong(string soPhong, LoaiPhong LoaiPhong, ThietBi ThietBi1, ThietBi ThietBi2, ThietBi ThietBi3)
        {
            this.soPhong = soPhong;
            this.LoaiPhong = LoaiPhong;
            this.ThietBi = new ThietBi[] { ThietBi1, ThietBi2, ThietBi3 };
        }
        public Phong(Phong PH)
        {
            this.soPhong = PH.soPhong;
            this.ThietBi = PH.ThietBi;
            this.LoaiPhong = PH.LoaiPhong;

        }
    }
}
