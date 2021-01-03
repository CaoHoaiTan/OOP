using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class THAOTACDICHVU
    {
        public NhanVien ma_NV { get; set; }
        public DichVu ma_DV { get; set; }
        public CongViec ma_CV { get; set; }
        public THAOTACDICHVU(NhanVien ma_NV, DichVu ma_DV, CongViec ma_CV)
        {
            this.ma_NV = ma_NV;
            this.ma_DV = ma_DV;
            this.ma_CV = ma_CV;
        }
        public THAOTACDICHVU(THAOTACDICHVU DV)
        {
            this.ma_NV = DV.ma_NV;
            this.ma_DV = DV.ma_DV;
            this.ma_CV = DV.ma_CV;
        }
    }
}
