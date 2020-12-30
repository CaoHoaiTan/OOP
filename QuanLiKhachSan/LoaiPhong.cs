using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class LoaiPhong
    {
        public string ma_LoaiPhong { get; set; }
        public string ten_LoaiPhong { get; set; }
        public string soNguoi { get; set; }
        public string giaTien { get; set; }
        public LoaiPhong(string ma_LoaiPhong,string ten_LoaiPhong,string soNguoi,string giaTien)
        {
            this.ma_LoaiPhong = ma_LoaiPhong;
            this.ten_LoaiPhong = ten_LoaiPhong;
            this.soNguoi = soNguoi;
            this.giaTien = giaTien;
        }
        public LoaiPhong(LoaiPhong LoaiPH)
        {
            this.ma_LoaiPhong = LoaiPH.ma_LoaiPhong;
            this.ten_LoaiPhong = LoaiPH.ten_LoaiPhong;
            this.soNguoi = LoaiPH.soNguoi;
            this.giaTien = LoaiPH.giaTien;
        }
    }
}
