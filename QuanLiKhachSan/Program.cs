using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class Program
    {
        public static List<KhachHang> dsKhachHang =
            new List<KhachHang>();
        public static List<LoaiKhachHang> dsLoaiKhachHang =
            new List<LoaiKhachHang>();
        public static List<CongViec> dsCongViec =
            new List<CongViec>();
        public static List<DichVu> dsDichVu =
            new List<DichVu>();
        public static List<HoaDon> dsHoaDon =
            new List<HoaDon>();
        public static List<HopDong> dsHopDong =
            new List<HopDong>();
        public static List<LAPHOPDONG> dsLHD =
            new List<LAPHOPDONG>();
        public static List<LoaiPhong> dsLoaiPhong =
            new List<LoaiPhong>();
        public static List<LoaiThietBi> dsLoaiThietBi =
            new List<LoaiThietBi>();
        public static List<NhanVien> dsNhanVien =
            new List<NhanVien>();
        public static List<NhomCongViec> dsNhomCongViec =
            new List<NhomCongViec>();
        public static List<NhomNhanVien> dsNhomNhanVien =
            new List<NhomNhanVien>();
        public static List<Phong> dsPhong =
            new List<Phong>();
        public static List<THAOTACDICHVU> dsTTDV =
            new List<THAOTACDICHVU>();
        public static List<ThietBi> dsThietBi =
            new List<ThietBi>();

        public static void TaodsLHD()
        {
            dsLHD.Add(new LAPHOPDONG(dsKhachHang[1], dsPhong[0], dsHopDong[0]));
            dsLHD.Add(new LAPHOPDONG(dsKhachHang[1], dsPhong[1], dsHopDong[3]));
            dsLHD.Add(new LAPHOPDONG(dsKhachHang[2], dsPhong[2], dsHopDong[2]));
            dsLHD.Add(new LAPHOPDONG(dsKhachHang[3], dsPhong[3], dsHopDong[1]));
        }
        public static void TaodsLoaiKhachHang()
        {
            dsLoaiKhachHang.Add(new LoaiKhachHang("KH01", "Thuong"));
            dsLoaiKhachHang.Add(new LoaiKhachHang("KH02", "Thuong"));
            dsLoaiKhachHang.Add(new LoaiKhachHang("KH11", "Vip"));
            dsLoaiKhachHang.Add(new LoaiKhachHang("KH12", "Vip"));
        }
        public static void TaodsLoaiPhong()
        {
            dsLoaiPhong.Add(new LoaiPhong("B101", "Thuong", "4", "500000"));
            dsLoaiPhong.Add(new LoaiPhong("B302", "Thuong", "2", "300000"));
            dsLoaiPhong.Add(new LoaiPhong("V103", "Vip", "4", "700000"));
            dsLoaiPhong.Add(new LoaiPhong("V402", "Vip", "4", "700000"));
        }
        public static void TaodsLoaiThietBi()
        {
            dsLoaiThietBi.Add(new LoaiThietBi("ML128", "May lanh"));
            dsLoaiThietBi.Add(new LoaiThietBi("TL132", "Tu lanh"));
            dsLoaiThietBi.Add(new LoaiThietBi("TV128", "Tivi"));
            dsLoaiThietBi.Add(new LoaiThietBi("TV134", "Tivi"));
            dsLoaiThietBi.Add(new LoaiThietBi("TV113", "Tivi"));
        }
        public static void TaodsNhanVien()
        {
            dsNhanVien.Add(new NhanVien("NV148", "Cao Hoai Tan", "0789123456","2322324", dsNhomNhanVien[0]));
            dsNhanVien.Add(new NhanVien("NV123", "Phan Nguyen Chu Kiet", "0789088356", "2322324", dsNhomNhanVien[1]));
            dsNhanVien.Add(new NhanVien("NV145", "Thai Thanh Nam", "0783454456", "2322324", dsNhomNhanVien[1]));
            dsNhanVien.Add(new NhanVien("NV143", "Nguyen Ngoc Trung", "0783458356", "2322324", dsNhomNhanVien[2]));
        }
        public static void TaoDsNhomCongViec()
        {
            dsNhomCongViec.Add(new NhomCongViec("VS", "Ve sinh"));
            dsNhomCongViec.Add(new NhomCongViec("BV", "Bao ve"));
            dsNhomCongViec.Add(new NhomCongViec("BT", "Bao tri Thiet bi"));
        }
        public static void TaoDsNhomNhanVien()
        {
            dsNhomNhanVien.Add(new NhomNhanVien("VS02", "NV121"));
            dsNhomNhanVien.Add(new NhomNhanVien("VS03", "NV110"));
            dsNhomNhanVien.Add(new NhomNhanVien("BV03", "NV102"));
            dsNhomNhanVien.Add(new NhomNhanVien("BV01", "NV071"));
            dsNhomNhanVien.Add(new NhomNhanVien("BT02", "NV011"));
            dsNhomNhanVien.Add(new NhomNhanVien("BT01", "NV001"));
        }
        public static void TaoDsPhong()
        {
            dsPhong.Add(new Phong("101", "VIP", "ML101"));
            dsPhong.Add(new Phong("103", "VIP", "ML103"));
            dsPhong.Add(new Phong("106", "Thuong", "TL106"));
            dsPhong.Add(new Phong("201", "VIP", "ML201"));
            dsPhong.Add(new Phong("208", "Thuong", "TL201"));
        }
        public static void TaoDSTTDV()
        {
            dsTTDV.Add(new THAOTACDICHVU(dsNhanVien[1], dsDichVu[1], dsCongViec[2]));
        }
        public static void TaoDsThietBi()
        {
            dsThietBi.Add(new ThietBi("TV101", "Tivi"));
            dsThietBi.Add(new ThietBi("TL201", "Tu Lanh"));
            dsThietBi.Add(new ThietBi("ML103", "May Lanh"));
        }
        static void Main(string[] args)
        {

        }
    }
}
