namespace QuanLiKhachSan
{
    public class HoaDon
    {
        public string so_HoaDon { get; set; }
        public HopDong HD { get; set; }
        public string ngayTraTien { get; set; }
        public NhanVien ma_NV { get; set; }
        public KhachHang ma_KH { get; set; }
        public HoaDon(string so_HoaDon, HopDong HD, string ngayTraTien, NhanVien ma_NV, KhachHang KH)
        {
            this.HD = HD;
            this.so_HoaDon = so_HoaDon;
            this.ngayTraTien = ngayTraTien;
            this.ma_NV = ma_NV;
            this.ma_KH = KH;
            HD.Phong.DaThue = false;
        }
        public HoaDon(HoaDon HD)
        {
            this.HD = HD.HD;
            this.so_HoaDon = HD.so_HoaDon;
            this.ngayTraTien = HD.ngayTraTien;
            this.ma_NV = HD.ma_NV;
            this.ma_KH = HD.ma_KH;
        }
    }
}
