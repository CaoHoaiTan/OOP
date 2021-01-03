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
        public static List<DangKiDV> dsDKDV =
            new List<DangKiDV>();

        public static void TaodsCongViec()
        {
            dsCongViec.Add(new CongViec("DVS001", "Lau phong", dsNhomCongViec[0]));
            dsCongViec.Add(new CongViec("DVS002", "Sap xep do dac", dsNhomCongViec[0]));
            dsCongViec.Add(new CongViec("DVS003", "Hut bui", dsNhomCongViec[0]));
            dsCongViec.Add(new CongViec("DVS004", "Thay moi cac do dung mot lan", dsNhomCongViec[0]));
            dsCongViec.Add(new CongViec("BV001", "Giu xe", dsNhomCongViec[1]));
            dsCongViec.Add(new CongViec("BV002", "Tang 1", dsNhomCongViec[1]));
            dsCongViec.Add(new CongViec("BV003", "Tang 2", dsNhomCongViec[1]));
            dsCongViec.Add(new CongViec("BV004", "Tang 3", dsNhomCongViec[1]));
            dsCongViec.Add(new CongViec("BV005", "Bao ve cong", dsNhomCongViec[1]));
            dsCongViec.Add(new CongViec("BV006", "Giam sat CAMERA", dsNhomCongViec[1]));
            dsCongViec.Add(new CongViec("BT001", "Tang 1", dsNhomCongViec[2]));
            dsCongViec.Add(new CongViec("BT002", "Tang 2", dsNhomCongViec[2]));
            dsCongViec.Add(new CongViec("BT003", "Tang 3", dsNhomCongViec[2]));
            dsCongViec.Add(new CongViec("BT004", "Thang may", dsNhomCongViec[2]));
            dsCongViec.Add(new CongViec("BT005", "CAMERA", dsNhomCongViec[2]));
            dsCongViec.Add(new CongViec("CS001", "Giat ui", dsNhomCongViec[3]));
            dsCongViec.Add(new CongViec("CS002", "Dat xe", dsNhomCongViec[3]));
            dsCongViec.Add(new CongViec("CS003", "SPA", dsNhomCongViec[3]));
            dsCongViec.Add(new CongViec("CS004", "GYM", dsNhomCongViec[3]));
            dsCongViec.Add(new CongViec("CS005", "Giu tre", dsNhomCongViec[3]));
            dsCongViec.Add(new CongViec("TT001", "Le tan", dsNhomCongViec[4]));
        }
        public static void TaodsNhomCongViec()
        {
            dsNhomCongViec.Add(new NhomCongViec("DVS", "Don ve sinh"));
            dsNhomCongViec.Add(new NhomCongViec("BV", "Bao ve"));
            dsNhomCongViec.Add(new NhomCongViec("BT", "Bao tri Thiet bi"));
            dsNhomCongViec.Add(new NhomCongViec("CS", "Cham soc KH"));
            dsNhomCongViec.Add(new NhomCongViec("TT", "Tiep thi"));
        }
        public static void TaodsDichVu()
        {
            dsDichVu.Add(new DichVu("DV001", "Cham soc suc khoe", 1000000));
            dsDichVu.Add(new DichVu("DV002", "Ho tro di chuyen", 200000));
            dsDichVu.Add(new DichVu("DV003", "Giat ui", 300000));
            dsDichVu.Add(new DichVu("DV004", "Giu tre", 500000));
        }
        public static void TaodsHoaDon()
        {
            dsHoaDon.Add(new HoaDon("H001", dsHopDong[0], "1/1/2021", dsNhanVien[0], dsKhachHang[0]));
            dsHoaDon.Add(new HoaDon("H002", dsHopDong[1], "1/1/2021", dsNhanVien[1], dsKhachHang[1]));
            dsHoaDon.Add(new HoaDon("H003", dsHopDong[2], "1/1/2021", dsNhanVien[2], dsKhachHang[2]));
            dsHoaDon.Add(new HoaDon("H004", dsHopDong[3], "1/1/2021", dsNhanVien[3], dsKhachHang[3]));
            dsHoaDon.Add(new HoaDon("H005", dsHopDong[4], "1/1/2021", dsNhanVien[4], dsKhachHang[4]));
            dsHoaDon.Add(new HoaDon("H006", dsHopDong[5], "1/1/2021", dsNhanVien[5], dsKhachHang[5]));
        }
        public static void TaodsHopDong()
        {
            dsHopDong.Add(new HopDong("HD001", dsKhachHang[0], dsDKDV[0], dsPhong[0], "Chuyen Khoang", "1/1/2021", 1, "2/1/2021", dsNhanVien[0]));
            dsHopDong.Add(new HopDong("HD002", dsKhachHang[1], dsDKDV[1], dsPhong[10], "Tien Mat", "2/12/2021", 31, "2/1/2021", dsNhanVien[2]));
            dsHopDong.Add(new HopDong("HD003", dsKhachHang[2], dsDKDV[2], dsPhong[23], "Quet The", "15/12/2020", 18, "2/1/2021", dsNhanVien[1]));
            dsHopDong.Add(new HopDong("HD004", dsKhachHang[3], dsDKDV[3], dsPhong[20], "Chuyen Khoang", "2/12/2020", 32, "3/1/2021", dsNhanVien[0]));
            dsHopDong.Add(new HopDong("HD005", dsKhachHang[4], dsDKDV[4], dsPhong[14], "Tien Mat", "25/12/2020", 7, "1/1/2021", dsNhanVien[1]));
            dsHopDong.Add(new HopDong("HD006", dsKhachHang[5], dsDKDV[5], dsPhong[15], "Quet The", "27/12/2020", 7, "3/1/2021", dsNhanVien[1]));
            dsHopDong.Add(new HopDong("HD007", dsKhachHang[3], dsDKDV[6], dsPhong[26], "Chuyen Khoang", "30/12/2020", 12, "10/1/2021", dsNhanVien[0]));
            dsHopDong.Add(new HopDong("HD008", dsKhachHang[4], dsDKDV[7], dsPhong[18], "Tien Mat", "31/12/2020", 12, "11/1/2021", dsNhanVien[1]));
            dsHopDong.Add(new HopDong("HD009", dsKhachHang[5], dsDKDV[8], dsPhong[16], "Quet The", "31/12/2020", 13, "12/1/2021", dsNhanVien[1]));
            dsHopDong.Add(new HopDong("HD010", dsKhachHang[3], dsDKDV[9], dsPhong[19], "Chuyen Khoang", "26/1/2020", 25, "10/1/2021", dsNhanVien[0]));
            dsHopDong.Add(new HopDong("HD011", dsKhachHang[4], dsDKDV[10], dsPhong[9], "Tien Mat", "28/12/2020", 14, "11/1/2021", dsNhanVien[1]));
            dsHopDong.Add(new HopDong("HD012", dsKhachHang[5], dsDKDV[11], dsPhong[22], "Quet The", "27/12/2020", 16, "12/1/2021", dsNhanVien[1]));
        }
        public static void TaodsDKDV()
        {
            dsDKDV.Add(new DangKiDV("HD001", new List<DichVu> { dsDichVu[0] }));
            dsDKDV.Add(new DangKiDV("HD002", new List<DichVu> { }));
            dsDKDV.Add(new DangKiDV("HD003", new List<DichVu> { dsDichVu[0], dsDichVu[1] }));
            dsDKDV.Add(new DangKiDV("HD004", new List<DichVu> { dsDichVu[1], dsDichVu[3] }));
            dsDKDV.Add(new DangKiDV("HD005", new List<DichVu> { }));
            dsDKDV.Add(new DangKiDV("HD006", new List<DichVu> { dsDichVu[2], dsDichVu[1] }));
            dsDKDV.Add(new DangKiDV("HD007", new List<DichVu> { dsDichVu[0], dsDichVu[3] }));
            dsDKDV.Add(new DangKiDV("HD008", new List<DichVu> { }));
            dsDKDV.Add(new DangKiDV("HD009", new List<DichVu> { dsDichVu[3], dsDichVu[1] }));
            dsDKDV.Add(new DangKiDV("HD010", new List<DichVu> { dsDichVu[2], dsDichVu[3] }));
            dsDKDV.Add(new DangKiDV("HD011", new List<DichVu> { }));
            dsDKDV.Add(new DangKiDV("HD012", new List<DichVu> { dsDichVu[1] }));

        }
        public static void TaodsKhachHang()
        {
            dsKhachHang.Add(new KhachHang("KH001", "Nguyen Ngoc Trung", "0123456789", "0971549714", dsLoaiKhachHang[0]));
            dsKhachHang.Add(new KhachHang("KH002", "Truong Ngoc Phuong", "0123456789", "0971549714", dsLoaiKhachHang[0]));
            dsKhachHang.Add(new KhachHang("KH003", "Tran Thi My Huyen", "0123456789", "0971549714", dsLoaiKhachHang[1]));
            dsKhachHang.Add(new KhachHang("KH004", "Tran Luu The Anh", "0123456789", "0971549714", dsLoaiKhachHang[1]));
            dsKhachHang.Add(new KhachHang("KH005", "Trinh Xuan Phuong", "0123456789", "0971549714", dsLoaiKhachHang[0]));
            dsKhachHang.Add(new KhachHang("KH006", "Le Thi Nhung", "0123456789", "0971549714", dsLoaiKhachHang[1]));
        }
        public static void TaodsLHD()
        {
            dsLHD.Add(new LAPHOPDONG(dsKhachHang[0], dsPhong[0], dsHopDong[0]));
            dsLHD.Add(new LAPHOPDONG(dsKhachHang[1], dsPhong[1], dsHopDong[1]));
            dsLHD.Add(new LAPHOPDONG(dsKhachHang[2], dsPhong[23], dsHopDong[2]));
            dsLHD.Add(new LAPHOPDONG(dsKhachHang[3], dsPhong[20], dsHopDong[3]));
            dsLHD.Add(new LAPHOPDONG(dsKhachHang[4], dsPhong[14], dsHopDong[4]));
            dsLHD.Add(new LAPHOPDONG(dsKhachHang[5], dsPhong[15], dsHopDong[5]));
            dsLHD.Add(new LAPHOPDONG(dsKhachHang[3], dsPhong[26], dsHopDong[6]));
            dsLHD.Add(new LAPHOPDONG(dsKhachHang[4], dsPhong[18], dsHopDong[7]));
            dsLHD.Add(new LAPHOPDONG(dsKhachHang[5], dsPhong[16], dsHopDong[8]));
            dsLHD.Add(new LAPHOPDONG(dsKhachHang[3], dsPhong[19], dsHopDong[9]));
            dsLHD.Add(new LAPHOPDONG(dsKhachHang[4], dsPhong[9], dsHopDong[10]));
            dsLHD.Add(new LAPHOPDONG(dsKhachHang[5], dsPhong[22], dsHopDong[11]));
        }
        public static void TaodsLoaiKhachHang()
        {
            dsLoaiKhachHang.Add(new LoaiKhachHang("KH_T", "Thuong"));
            dsLoaiKhachHang.Add(new LoaiKhachHang("KH_V", "VIP"));
        }
        public static void TaodsLoaiPhong()
        {
            dsLoaiPhong.Add(new LoaiPhong("V2", "VIP", "2", 500000));
            dsLoaiPhong.Add(new LoaiPhong("V4", "VIP", "4", 700000));
            dsLoaiPhong.Add(new LoaiPhong("V6", "VIP", "6", 900000));
            dsLoaiPhong.Add(new LoaiPhong("T2", "Thuong", "2", 250000));
            dsLoaiPhong.Add(new LoaiPhong("T4", "Thuong", "4", 500000));
            dsLoaiPhong.Add(new LoaiPhong("T6", "Thuong", "6", 700000));
        }
        public static void TaodsPhong()
        {
            dsPhong.Add(new Phong("101V", dsLoaiPhong[0], dsThietBi[0], dsThietBi[1], dsThietBi[2]));
            dsPhong.Add(new Phong("102V", dsLoaiPhong[1], dsThietBi[0], dsThietBi[1], dsThietBi[2]));
            dsPhong.Add(new Phong("103V", dsLoaiPhong[2], dsThietBi[0], dsThietBi[1], dsThietBi[2]));
            dsPhong.Add(new Phong("104T", dsLoaiPhong[3], dsThietBi[2]));
            dsPhong.Add(new Phong("105T", dsLoaiPhong[3], dsThietBi[2]));
            dsPhong.Add(new Phong("106T", dsLoaiPhong[4], dsThietBi[2]));
            dsPhong.Add(new Phong("107T", dsLoaiPhong[4], dsThietBi[2]));
            dsPhong.Add(new Phong("108T", dsLoaiPhong[5], dsThietBi[2]));
            dsPhong.Add(new Phong("109T", dsLoaiPhong[5], dsThietBi[2]));
            dsPhong.Add(new Phong("201V", dsLoaiPhong[0], dsThietBi[0], dsThietBi[1], dsThietBi[2]));
            dsPhong.Add(new Phong("202V", dsLoaiPhong[1], dsThietBi[0], dsThietBi[1], dsThietBi[2]));
            dsPhong.Add(new Phong("203V", dsLoaiPhong[2], dsThietBi[0], dsThietBi[1], dsThietBi[2]));
            dsPhong.Add(new Phong("204T", dsLoaiPhong[3], dsThietBi[2]));
            dsPhong.Add(new Phong("205T", dsLoaiPhong[3], dsThietBi[2]));
            dsPhong.Add(new Phong("206T", dsLoaiPhong[4], dsThietBi[2]));
            dsPhong.Add(new Phong("207T", dsLoaiPhong[4], dsThietBi[2]));
            dsPhong.Add(new Phong("208T", dsLoaiPhong[5], dsThietBi[2]));
            dsPhong.Add(new Phong("209T", dsLoaiPhong[5], dsThietBi[2]));
            dsPhong.Add(new Phong("301V", dsLoaiPhong[0], dsThietBi[0], dsThietBi[1], dsThietBi[2]));
            dsPhong.Add(new Phong("302V", dsLoaiPhong[1], dsThietBi[0], dsThietBi[1], dsThietBi[2]));
            dsPhong.Add(new Phong("303V", dsLoaiPhong[2], dsThietBi[0], dsThietBi[1], dsThietBi[2]));
            dsPhong.Add(new Phong("304T", dsLoaiPhong[3], dsThietBi[2]));
            dsPhong.Add(new Phong("305T", dsLoaiPhong[3], dsThietBi[2]));
            dsPhong.Add(new Phong("306T", dsLoaiPhong[4], dsThietBi[2]));
            dsPhong.Add(new Phong("307T", dsLoaiPhong[4], dsThietBi[2]));
            dsPhong.Add(new Phong("308T", dsLoaiPhong[5], dsThietBi[2]));
            dsPhong.Add(new Phong("309T", dsLoaiPhong[5], dsThietBi[2]));
        }
        public static void TaodsLoaiThietBi()
        {
            dsLoaiThietBi.Add(new LoaiThietBi("ML", "May lanh"));
            dsLoaiThietBi.Add(new LoaiThietBi("TL", "Tu lanh"));
            dsLoaiThietBi.Add(new LoaiThietBi("TV", "Ti vi"));
        }
        public static void TaodsNhanVien()
        {
            dsNhanVien.Add(new NhanVien("NV001", "Cao Hoai Tan", "0918451202", "2343342342", dsNhomNhanVien[10], dsCongViec[20]));
            dsNhanVien.Add(new NhanVien("NV002", "Thai Thanh Nam", "0913581202", "2344342342", dsNhomNhanVien[10], dsCongViec[20]));
            dsNhanVien.Add(new NhanVien("NV003", "Phan Nguyen Chu Kiet", "0943181202", "2345342342", dsNhomNhanVien[10], dsCongViec[20]));
            dsNhanVien.Add(new NhanVien("NV004", "Nguyen Van A", "0918451202", "2343342342", dsNhomNhanVien[3], dsCongViec[0]));
            dsNhanVien.Add(new NhanVien("NV005", "Phan Van B", "0913581202", "2344342342", dsNhomNhanVien[4], dsCongViec[0]));
            dsNhanVien.Add(new NhanVien("NV006", "Phan Chu C", "0943181202", "2345342342", dsNhomNhanVien[5], dsCongViec[0]));
            dsNhanVien.Add(new NhanVien("NV007", "Cao Hoai Linh", "0918451202", "2343342342", dsNhomNhanVien[6], dsCongViec[0]));
            dsNhanVien.Add(new NhanVien("NV008", "Thai Thanh Soi", "0913581202", "2344342342", dsNhomNhanVien[7], dsCongViec[0]));
            dsNhanVien.Add(new NhanVien("NV009", "Phan Nguyen Chu", "0943181202", "2345342342", dsNhomNhanVien[8], dsCongViec[0]));
            dsNhanVien.Add(new NhanVien("NV010", "Cao Hoai Lam", "0918451202", "2343342342", dsNhomNhanVien[9], dsCongViec[0]));
            dsNhanVien.Add(new NhanVien("NV011", "Thai Duoi", "0913581202", "2344342342", dsNhomNhanVien[10], dsCongViec[0]));
            dsNhanVien.Add(new NhanVien("NV012", "Thai Tao Lao", "0943181202", "2345342342", dsNhomNhanVien[0], dsCongViec[0]));
            dsNhanVien.Add(new NhanVien("NV013", "Cao Ba Quat", "0918451202", "2343342342", dsNhomNhanVien[0], dsCongViec[0]));
            dsNhanVien.Add(new NhanVien("NV014", "Thai Binh Duong", "0913581202", "2344342342", dsNhomNhanVien[1], dsCongViec[0]));
            dsNhanVien.Add(new NhanVien("NV015", "Phan Xi Phan", "0943181202", "2345342342", dsNhomNhanVien[2], dsCongViec[0]));
            dsNhanVien.Add(new NhanVien("NV016", "Thai Duong", "0913581202", "2344342342", dsNhomNhanVien[3], dsCongViec[0]));
            dsNhanVien.Add(new NhanVien("NV012", "Thai Giam", "0943181202", "2345342342", dsNhomNhanVien[4], dsCongViec[0]));
            dsNhanVien.Add(new NhanVien("NV013", "Cao Xuan Tai", "0918451202", "2343342342", dsNhomNhanVien[5], dsCongViec[0]));
            dsNhanVien.Add(new NhanVien("NV014", "Thai Thai Thai", "0913581202", "2344342342", dsNhomNhanVien[6], dsCongViec[0]));
            dsNhanVien.Add(new NhanVien("NV015", "Phan Dinh Giot", "0943181202", "2345342342", dsNhomNhanVien[7], dsCongViec[0]));
        }
        public static void TaodsNhomNhanVien()
        {
            dsNhomNhanVien.Add(new NhomNhanVien("VS01", "NV012"));
            dsNhomNhanVien.Add(new NhomNhanVien("VS02", "NV013"));
            dsNhomNhanVien.Add(new NhomNhanVien("VS03", "NV014"));
            dsNhomNhanVien.Add(new NhomNhanVien("BT01", "NV004"));
            dsNhomNhanVien.Add(new NhomNhanVien("BT02", "NV005"));
            dsNhomNhanVien.Add(new NhomNhanVien("BT03", "NV006"));
            dsNhomNhanVien.Add(new NhomNhanVien("BV03", "NV007"));
            dsNhomNhanVien.Add(new NhomNhanVien("BV02", "NV008"));
            dsNhomNhanVien.Add(new NhomNhanVien("BV01", "NV009"));
            dsNhomNhanVien.Add(new NhomNhanVien("CS", "NV010"));
            dsNhomNhanVien.Add(new NhomNhanVien("TT", "NV003"));
        }
        public static void TaodsTTDV()
        {
            dsTTDV.Add(new THAOTACDICHVU(dsNhanVien[0], dsDichVu[1], dsCongViec[2]));
            dsTTDV.Add(new THAOTACDICHVU(dsNhanVien[1], dsDichVu[1], dsCongViec[2]));
            dsTTDV.Add(new THAOTACDICHVU(dsNhanVien[2], dsDichVu[1], dsCongViec[2]));
        }
        public static void TaodsThietBi()
        {
            dsThietBi.Add(new ThietBi("ML101", dsLoaiThietBi[0]));
            dsThietBi.Add(new ThietBi("TL101", dsLoaiThietBi[1]));
            dsThietBi.Add(new ThietBi("TV101", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("ML102", dsLoaiThietBi[0]));
            dsThietBi.Add(new ThietBi("TL102", dsLoaiThietBi[1]));
            dsThietBi.Add(new ThietBi("TV102", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("ML103", dsLoaiThietBi[0]));
            dsThietBi.Add(new ThietBi("TL103", dsLoaiThietBi[1]));
            dsThietBi.Add(new ThietBi("TV103", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("TV104", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("TV104", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("TV104", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("TV104", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("TV104", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("TV104", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("ML201", dsLoaiThietBi[0]));
            dsThietBi.Add(new ThietBi("TL201", dsLoaiThietBi[1]));
            dsThietBi.Add(new ThietBi("TV201", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("ML202", dsLoaiThietBi[0]));
            dsThietBi.Add(new ThietBi("TL202", dsLoaiThietBi[1]));
            dsThietBi.Add(new ThietBi("TV202", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("ML203", dsLoaiThietBi[0]));
            dsThietBi.Add(new ThietBi("TL203", dsLoaiThietBi[1]));
            dsThietBi.Add(new ThietBi("TV203", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("TV204", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("TV204", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("TV204", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("TV204", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("TV204", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("TV204", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("ML301", dsLoaiThietBi[0]));
            dsThietBi.Add(new ThietBi("TL301", dsLoaiThietBi[1]));
            dsThietBi.Add(new ThietBi("TV301", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("ML302", dsLoaiThietBi[0]));
            dsThietBi.Add(new ThietBi("TL302", dsLoaiThietBi[1]));
            dsThietBi.Add(new ThietBi("TV302", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("ML303", dsLoaiThietBi[0]));
            dsThietBi.Add(new ThietBi("TL303", dsLoaiThietBi[1]));
            dsThietBi.Add(new ThietBi("TV303", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("TV304", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("TV304", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("TV304", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("TV304", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("TV304", dsLoaiThietBi[2]));
            dsThietBi.Add(new ThietBi("TV304", dsLoaiThietBi[2]));
        }
        public static void Nam1()
        {
            // Xuat ra danh sach cac phong thue vao ngay 1/1/2021
            var ph =
                from hd in dsHopDong
                where hd.ngayNhanPhong == "1/1/2021"
                select new { sp = hd.Phong.soPhong, lp = hd.Phong.LoaiPhong };
            Console.WriteLine("_________________________________________");
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
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Cac Hop dong thue phong VIP:");
            foreach (var h in hd)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine(h.ToString());
            }
        }
        public static void Tan1()
        {
            // Liet ke danh sach phong theo loai phong
            var nhomLoaiPhong = from ph in dsPhong
                                group ph by ph.LoaiPhong;
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Danh sach cac loai phong:");
            foreach (var nhomlp in nhomLoaiPhong)
            {
                Console.WriteLine(nhomlp.Key.ma_LoaiPhong);
                foreach (Phong p in nhomlp)
                {
                    Console.WriteLine("    {0}", p.soPhong);
                }
            }
        }
        public static void Nam2()
        {
            // Sap xep Ten khach hang theo gia tien giam dan
            var dsKHGiamDan =
                from hd in dsHopDong
                orderby hd.giaTien descending
                select hd;
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Danh sach Khach hang giam dan theo so tien:");
            foreach (var h in dsKHGiamDan)
            {
                Console.WriteLine("\tTen Khach hang: {0}, So tien: {1:0,0.0}", h.KH.ten_KH, h.giaTien);
            }
        }
        public static void Kiet2()
        {
            // Liet ke danh sach phong theo tinh trang thue phong
            var nhomLoaiPhong = from ph in dsPhong
                                group ph by ph.DaThue;
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Danh sach cac loai phong:");
            foreach (var nhomlp in nhomLoaiPhong)
            {
                if (nhomlp.Key == true)
                    Console.WriteLine("Da thue:");
                else
                    Console.WriteLine("Chua thue:");
                foreach (Phong p in nhomlp)
                {
                    Console.WriteLine("    {0}", p.soPhong);
                }
            }
        }
        public static void Tan2()
        {
            //xuat khach hang tra tien nhieu nhat
            var max = dsHopDong.Max(p => p.giaTien);
            var kh = from k in dsHopDong
                     where k.giaTien == max
                     select k;

            Console.WriteLine("_________________________________________");
            Console.WriteLine("Gia tien khach hang tra lon nhat: {0:0.0,0}", max);
            foreach (var n in kh)
            {
                Console.WriteLine(n);
            }
        }
        public static void Tan3()
        {
            //Xuat so Phong con trong theo loai
            var phong =
                from p in dsPhong
                where p.DaThue == false
                group p by p.LoaiPhong.ten_LoaiPhong into g
                select new { Phong = g.Key, PhongCount = g.Count() };

            Console.WriteLine("_______________________________________");
            Console.WriteLine("Danh sach phong con trong: ");
            foreach (var p in phong)
            {

                Console.WriteLine("Phong: " + p.Phong + "         " + "So phong: " + p.PhongCount);
            }
        }
        public static void Tan4()
        {
            // Xuat cac phong con trong
            var ph =
                from p in dsPhong
                where p.DaThue == false
                select p;
            Console.WriteLine("_______________________________________");
            foreach (var k in ph)
            {
                Console.WriteLine("soPhong: " + k.soPhong + " LoaiPhong: " + k.LoaiPhong.ten_LoaiPhong + " SoNguoi: " + k.LoaiPhong.soNguoi);
            }

        }
        public static void Tan5()
        {
            //Xuat tong danh thu cua khach san
            var s = dsHopDong.Sum(p => p.giaTien);
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Tong danh thu cua khach san: {0:0.0,0}", s);

        }
        public static void Tan6()
        {
            //Xuất ra thông tin những nhân viên là nhân viên le tan
            var nv =
                from p in dsNhanVien
                where p.CongViec.ten_CV == "Le tan"
                select p;
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Danh sach nhan vien le tan:");
           foreach(var n in nv)
            {
                Console.WriteLine("Ten nhan vien: {0}   Ma nhan vien: {1}   Ma nhom nhan vien: {2}  Cong viec: {3} ",
                    n.ten_NV,n.ma_NV,n.ma_nhomNV.ma_nhomNV,n.CongViec.ten_CV);
            }
           
        }
        public static void Tan7()
        {
            // Xuat cac hinh thuc thanh toan cua khach hang
            var dv = from p in dsHopDong
                     group p by p.phuongThucThanhToan into g
                     select new { phuongthuc = g.Key, number = g.Count() };
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Cach hinh thuc thanh toan: ");
            foreach (var d in dv)
            {
                Console.WriteLine("Thanh toan bang: {0}      so nguoi:{1} ", d.phuongthuc, d.number);
            }
        }
        public static void Tan8()
        {
            //So hop dong nhan vien ki duoc sap xep tang dan
            var nv = from p in dsHopDong
                      group p by p.NhanVien into g
                      orderby g.Count()
                      select new { nhanVien = g.Key, soHD = g.Count() };
                     
            Console.WriteLine("_________________________________________");
            Console.WriteLine("So hop dong nhan vien ki duoc:");
            foreach (var n in nv)
            {
                Console.WriteLine("Nhan vien: {0}       soHD:{1}", n.nhanVien.ten_NV, n.soHD); 
            }
        }
        public static void Tan9()
        {
            //Nhan vien ki duoc nhieu hop dong nhat
            //Dich vu duoc dang ki nhieu nhat
            //cac thiet bi co trong phong
            // Khach hang thue nhieu nhat
            // danh sach khach hang vs so lan thue
            var kh = from p in dsHopDong
                     group p by p.KH into g
                     let max = g.Max(p => p.KH)
                     select new { khachhang = g.Key, solan = g.Count() };
            Console.WriteLine("_________________________________________");
            foreach (var i in kh)
            {
                Console.WriteLine("Khach hang: {0}   solan: {1}", i.khachhang.ten_KH, i.solan);
            }


        }
        static void Main()
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
            TaodsDKDV();
            TaodsHopDong();
            TaodsTTDV();
            TaodsLHD();
            TaodsHoaDon();

            Nam1();
            Kiet1();
            Tan1();
            Nam2();
            Kiet2();
            Tan2();
            Tan3();
            Tan4();
            Tan5();
            Tan6();
            Tan7();
            Tan8();
            Tan9();
            Console.ReadKey();
        }
    }
}
