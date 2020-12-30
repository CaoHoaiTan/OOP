using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class Program
    {
        public static List<KhachHang> dsKHACHHANG =
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
               public static void TaoDanhSachCongViec()
        {
            dsCongViec.Add(new CongViec("001", "DVS", dsNhomCongViec[0]));
            dsCongViec.Add(new CongViec("002", "BV", dsNhomCongViec[1]));
            dsCongViec.Add(new CongViec("003", "SCTB", dsNhomCongViec[2]));
        }
        public static void TaoDanhSachDichVu()
        {
            dsDichVu.Add(new DichVu("001", "1000000"));
            dsDichVu.Add(new DichVu("002", "2000000"));
            dsDichVu.Add(new DichVu("003", "3000000"));
        }
        public static void TaoDanhSachHoaDon()
        {
            dsHoaDon.Add(new HoaDon("001", dsHopDong[0], "300000", "1/1/2021", dsNhanVien[0], dsKhachHang[0]));
            dsHoaDon.Add(new HoaDon("002", dsHopDong[1], "300000", "1/1/2021", dsNhanVien[1], dsKhachHang[1]));
            dsHoaDon.Add(new HoaDon("003", dsHopDong[2], "300000", "1/1/2021", dsNhanVien[2], dsKhachHang[2]));
            dsHoaDon.Add(new HoaDon("004", dsHopDong[3], "300000", "1/1/2021", dsNhanVien[3], dsKhachHang[3]));
            dsHoaDon.Add(new HoaDon("005", dsHopDong[4], "300000", "1/1/2021", dsNhanVien[4], dsKhachHang[4]));
        }
        public static void TaoDanhSachHopDong()
        {
            dsHopDong.Add(new HopDong("001", dsKhachHang[0], dsDichVu[0], "A101", "Chuyen Khoang", "500000", "1/1/2021", "10/1/2021"));
            dsHopDong.Add(new HopDong("002", dsKhachHang[1], dsDichVu[1], "A102", "Tien Mat", "500000", "2/1/2021", "11/1/2021"));
            dsHopDong.Add(new HopDong("003", dsKhachHang[2], dsDichVu[2], "A103", "Quet The", "500000", "3/1/2021", "12/1/2021"));
        }
        public static void TaoDanhSachKhachHang()
        {
            dsKhachHang.Add(new KhachHang("001", "Thai Thanh Nam", "0123456789", "0971549714", "thuong"));
            dsKhachHang.Add(new KhachHang("002", "Cao Hoai Tan", "0123456789", "0971549714", "thuong"));
            dsKhachHang.Add(new KhachHang("003", "Phan Nguyen Chu Kiet", "0123456789", "0971549714", "VIP"));
        }
        public static void TaodsLHD()
        {
            dsLHD.Add(new LAPHOPDONG(dsKhachHang[0], dsPhong[0], dsHopDong[0]));
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
            dsLoaiPhong.Add(new LoaiPhong("T123", "Thuong", "2", "223456"));
            dsLoaiPhong.Add(new LoaiPhong("T143", "Thuong", "4", "500000"));
            dsLoaiPhong.Add(new LoaiPhong("V324", "Vip", "2", "500000"));
            dsLoaiPhong.Add(new LoaiPhong("v243", "Vip", "4", "700000"));
        }
        public static void TaodsLoaiThietBi()
        {
            dsLoaiThietBi.Add(new LoaiThietBi("ML235", "May Lanh"));
            dsLoaiThietBi.Add(new LoaiThietBi("TL215", "Tu Lanh"));
            dsLoaiThietBi.Add(new LoaiThietBi("ML543", "May Lanh"));
            dsLoaiThietBi.Add(new LoaiThietBi("TL455", "Tu Lanh"));
        }
        public static void TaodsNhanVien()
        {
            dsNhanVien.Add(new NhanVien("NV235", "Cao Hoai Tan", "0918451202", "2343342342", dsNhomNhanVien[1]));
            dsNhanVien.Add(new NhanVien("NV125", "Thai Thanh Nam", "0913581202", "2344342342", dsNhomNhanVien[0]));
            dsNhanVien.Add(new NhanVien("NV455", "Phan Nguyen Chu Kiet", "0943181202", "2345342342", dsNhomNhanVien[1]));
            dsNhanVien.Add(new NhanVien("NV175", "Nguyen Ngoc Trung", "096781202", "2343342342", dsNhomNhanVien[3]));
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
