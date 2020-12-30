using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class NhanVien
    {
        public string ma_NV { get; set; }
        public string ten_NV { get; set; }
        public string sdt_NV { get; set; }
        public string CMND_NV { get; set; }
        public NhomNhanVien ma_nhomNV { get; set; }
        public NhanVien(string ma_NV,string ten_NV,string sdt_NV,string CMND_NV,NhomNhanVien ma_nhomNV)
        {
            this.ma_NV = ma_NV;
            this.ten_NV = ten_NV;
            this.sdt_NV = sdt_NV;
            this.CMND_NV = CMND_NV;
            this.ma_nhomNV = ma_nhomNV;
           
        }
        public NhanVien(NhanVien NV)
        {
            this.ma_NV = NV.ma_NV;
            this.ten_NV = NV.ten_NV;
            this.sdt_NV = NV.sdt_NV;
            this.CMND_NV = NV.CMND_NV;
            this.ma_nhomNV = NV.ma_nhomNV;
        }
    }
}
