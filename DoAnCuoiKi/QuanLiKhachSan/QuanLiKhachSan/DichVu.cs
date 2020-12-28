using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class DichVu
    {
        public string ma_DV { get; set; }
        public string soTien { get; set; }
        public DichVu (string ma_DV,string soTien)
        {
            this.ma_DV = ma_DV;
            this.soTien = soTien;
        }
        public DichVu (DichVu DV)
        {
            this.ma_DV = DV.ma_DV;
            this.soTien = DV.soTien;
        }
    }
}
