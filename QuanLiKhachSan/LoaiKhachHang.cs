using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class LoaiKhachHang
    {
        public string ma_LoaiKH { get; set; }
        public string ten_LoaiKH { get; set; }

        public LoaiKhachHang(string ma_LoaiKH, string ten_LoaiKH)
        {
            this.ma_LoaiKH = ma_LoaiKH;
            this.ten_LoaiKH = ten_LoaiKH;
        }
        public LoaiKhachHang(LoaiKhachHang LoaiKH)
        {
            this.ma_LoaiKH = LoaiKH.ma_LoaiKH;
            this.ten_LoaiKH = LoaiKH.ten_LoaiKH;
        }
    }
}
