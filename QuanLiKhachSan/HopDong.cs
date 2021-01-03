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
        public KhachHang KH { get; set; }
        public DangKiDV DangKiDV { get; set; }
        public Phong Phong { get; set; }
        public NhanVien NhanVien { get; set; }
        public string phuongThucThanhToan { get; set; }
        public double giaTien { get; set; }
        public string ngayNhanPhong { get; set; }
        public string ngayTraPhong { get; set; }
        public int songaythue { get; set; }
        public HopDong(string so_HD, KhachHang KH, DangKiDV DangKiDV, Phong Phong, string phuongThucThanhToan,
          string ngayNhanPhong, int songaythue, string ngayTraPhong, NhanVien NhanVien)
        {
            this.so_HD = so_HD;
            this.songaythue = songaythue;
            this.KH = KH;
            this.DangKiDV = DangKiDV;
            this.Phong = Phong;
            this.phuongThucThanhToan = phuongThucThanhToan;
            this.giaTien = DangKiDV.giaTien * songaythue + Phong.LoaiPhong.giaTien * songaythue;
            if (KH.ma_loaiKH.ten_LoaiKH == "VIP")
            {
                this.giaTien *= 0.95;
            }
            this.ngayNhanPhong = ngayNhanPhong;
            this.ngayTraPhong = ngayTraPhong;
            this.NhanVien = NhanVien;
            this.Phong.DaThue = true;
        }
        public HopDong(HopDong HD)
        {
            this.so_HD = HD.so_HD;
            this.KH = HD.KH;
            this.DangKiDV = HD.DangKiDV;
            this.Phong = HD.Phong;
            this.phuongThucThanhToan = HD.phuongThucThanhToan;
            this.giaTien = HD.giaTien;
            this.ngayNhanPhong = HD.ngayNhanPhong;
            this.ngayTraPhong = HD.ngayTraPhong;
            this.NhanVien = NhanVien;
        }
        public override string ToString()
        {
            return "So Hop dong: " + so_HD
                + "\nNhan vien Lap hop dong: " + NhanVien.ten_NV
                + "\nTen khach hang: " + KH.ten_KH
                + "\nNgay nhan: " + ngayNhanPhong
                + "\nNgay tra: " + ngayTraPhong
                + "\nSo phong: " + Phong.soPhong;
        }
    }
}
