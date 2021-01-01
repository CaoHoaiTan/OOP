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
        public static void TaodsCongViec()
        {
            dsCongViec.Add(new CongViec("DVS001", "Don ve sinh", dsNhomCongViec[0]));
            dsCongViec.Add(new CongViec("BV002", "Bao ve", dsNhomCongViec[1]));
            dsCongViec.Add(new CongViec("BT003", "Bao tri Thiet bi", dsNhomCongViec[2]));
        }
        public static void TaodsDichVu()
        {
            dsDichVu.Add(new DichVu("DV001", "1000000"));
            dsDichVu.Add(new DichVu("DV002", "2000000"));
            dsDichVu.Add(new DichVu("DV003", "3000000"));
        }
        public static void TaodsHoaDon()
        {
            dsHoaDon.Add(new HoaDon("H001", dsHopDong[0], "300000", "1/1/2021", dsNhanVien[0], dsKhachHang[0]));
            dsHoaDon.Add(new HoaDon("H002", dsHopDong[1], "300000", "1/1/2021", dsNhanVien[1], dsKhachHang[1]));
            dsHoaDon.Add(new HoaDon("H003", dsHopDong[2], "300000", "1/1/2021", dsNhanVien[2], dsKhachHang[2]));
        }
        public static void TaodsHopDong()
        {
            dsHopDong.Add(new HopDong("HD001", dsKhachHang[0], dsDichVu[0], dsPhong[1], "Chuyen Khoang", "5000000", "1/1/2021", "10/1/2021", dsNhanVien[0]));
            dsHopDong.Add(new HopDong("HD002", dsKhachHang[1], dsDichVu[1], dsPhong[3], "Tien Mat", "2500000", "2/1/2021", "11/1/2021", dsNhanVien[2]));
            dsHopDong.Add(new HopDong("HD003", dsKhachHang[2], dsDichVu[2], dsPhong[4], "Quet The", "1500000", "1/1/2021", "12/1/2021", dsNhanVien[1]));
        }
        public static void TaodsKhachHang()
        {
            dsKhachHang.Add(new KhachHang("KH001", "Thai Thanh Nam", "0123456789", "0971549714", dsLoaiKhachHang[1]));
            dsKhachHang.Add(new KhachHang("KH002", "Cao Hoai Tan", "0123456789", "0971549714", dsLoaiKhachHang[1]));
            dsKhachHang.Add(new KhachHang("KH003", "Phan Nguyen Chu Kiet", "0123456789", "0971549714", dsLoaiKhachHang[0]));
        }
        public static void TaodsLHD()
        {
            dsLHD.Add(new LAPHOPDONG(dsKhachHang[0], dsPhong[0], dsHopDong[0]));
            dsLHD.Add(new LAPHOPDONG(dsKhachHang[1], dsPhong[1], dsHopDong[1]));
            dsLHD.Add(new LAPHOPDONG(dsKhachHang[2], dsPhong[2], dsHopDong[2]));
        }
        public static void TaodsLoaiKhachHang()
        {
            dsLoaiKhachHang.Add(new LoaiKhachHang("KH_T", "Thuong"));
            dsLoaiKhachHang.Add(new LoaiKhachHang("KH_V", "VIP"));
        }
        public static void TaodsLoaiPhong()
        {
            dsLoaiPhong.Add(new LoaiPhong("T2", "Thuong", "2", "223456"));
            dsLoaiPhong.Add(new LoaiPhong("T4", "Thuong", "4", "500000"));
            dsLoaiPhong.Add(new LoaiPhong("V2", "VIP", "2", "500000"));
            dsLoaiPhong.Add(new LoaiPhong("V4", "VIP", "4", "700000"));
        }
        public static void TaodsLoaiThietBi()
        {
            dsLoaiThietBi.Add(new LoaiThietBi("ML", "May lanh"));
            dsLoaiThietBi.Add(new LoaiThietBi("TL", "Tu lanh"));
            dsLoaiThietBi.Add(new LoaiThietBi("TV", "Ti vi"));
        }
        public static void TaodsNhanVien()
        {
            dsNhanVien.Add(new NhanVien("NV235", "Cao Hoai Tan", "0918451202", "2343342342", dsNhomNhanVien[1]));
            dsNhanVien.Add(new NhanVien("NV125", "Thai Thanh Nam", "0913581202", "2344342342", dsNhomNhanVien[0]));
            dsNhanVien.Add(new NhanVien("NV455", "Phan Nguyen Chu Kiet", "0943181202", "2345342342", dsNhomNhanVien[1]));
            dsNhanVien.Add(new NhanVien("NV175", "Nguyen Ngoc Trung", "096781202", "2343342342", dsNhomNhanVien[3]));
        }
        public static void TaodsNhomCongViec()
        {
            dsNhomCongViec.Add(new NhomCongViec("VS", "Ve sinh"));
            dsNhomCongViec.Add(new NhomCongViec("BV", "Bao ve"));
            dsNhomCongViec.Add(new NhomCongViec("BT", "Bao tri Thiet bi"));
        }
        public static void TaodsNhomNhanVien()
        {
            dsNhomNhanVien.Add(new NhomNhanVien("VS02", "NV121"));
            dsNhomNhanVien.Add(new NhomNhanVien("VS03", "NV110"));
            dsNhomNhanVien.Add(new NhomNhanVien("BV03", "NV102"));
            dsNhomNhanVien.Add(new NhomNhanVien("BV01", "NV071"));
            dsNhomNhanVien.Add(new NhomNhanVien("BT02", "NV011"));
            dsNhomNhanVien.Add(new NhomNhanVien("BT01", "NV001"));
        }
        public static void TaodsPhong()
        {
            dsPhong.Add(new Phong("101T", dsLoaiPhong[0], dsThietBi[0]));
            dsPhong.Add(new Phong("106V", dsLoaiPhong[2], dsThietBi[2]));
            dsPhong.Add(new Phong("103T", dsLoaiPhong[1], dsThietBi[1]));
            dsPhong.Add(new Phong("201V", dsLoaiPhong[3], dsThietBi[3]));
            dsPhong.Add(new Phong("208T", dsLoaiPhong[0], dsThietBi[4]));
        }
        public static void TaodsTTDV()
        {
            dsTTDV.Add(new THAOTACDICHVU(dsNhanVien[1], dsDichVu[1], dsCongViec[2]));
        }
        public static void TaodsThietBi()
        {
            dsThietBi.Add(new ThietBi("TV101", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("TL201", dsLoaiThietBi[1]));
            dsThietBi.Add(new ThietBi("ML103", dsLoaiThietBi[0]));
            dsThietBi.Add(new ThietBi("TV102", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("TL202", dsLoaiThietBi[1]));
            dsThietBi.Add(new ThietBi("ML101", dsLoaiThietBi[0]));
        }

        public static void Nam1()
        {
            // Xuat ra danh sach cac phong thue vao ngay 1/1/2021
            var ph =
                from hd in dsHopDong
                where hd.ngayNhanPhong == "1/1/2021"
                select new { sp = hd.Phong.soPhong, lp = hd.Phong.LoaiPhong };
            Console.WriteLine("Cac phong thue ngay 1/1/2021:");
            foreach (var p in ph)
            {
                Console.WriteLine("\t+ So phong: {0}, Loai phong: {1}", p.sp, p.lp.ten_LoaiPhong);
            }
        }
        public static void Kiet1()
        {
            // Xuat ra danh sach cac Hop dong thue phong VIP
            var hd =
                from h in dsHopDong
                where h.Phong.LoaiPhong.ten_LoaiPhong == "VIP"
                select h;
            Console.WriteLine("Cac Hop dong thue phong VIP:");
            foreach (var h in hd)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine(h.ToString());
            }
        }

        public static void Tan1()
        {
            //Xuat so Phong 
            var phong =
                from p in dsPhong
                group p by p.LoaiPhong.ten_LoaiPhong  into g
                select new { Phong = g.Key, PhongCount = g.Count()};

            foreach(var p in phong)
            {
                Console.WriteLine("Phong: " + p.Phong+"         " + "So phong: " + p.PhongCount );
            }
        }
        static void Main(string[] args)
        {
            TaodsNhomCongViec();
            TaodsNhomNhanVien();
            TaodsLoaiKhachHang();
            TaodsLoaiPhong();
            TaodsLoaiThietBi();
            TaodsCongViec();
            TaodsKhachHang();
            TaodsNhanVien();
            TaodsThietBi();
            TaodsPhong();
            TaodsDichVu();
            TaodsHopDong();
            TaodsTTDV();
            TaodsLHD();
            TaodsHoaDon();

            //Nam1();
            //Kiet1();
            Tan1();
            Console.ReadKey();
        }
    }
}
