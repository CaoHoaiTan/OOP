using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class THAOTACDICHVU
    {
        public string ma_NV { get; set; }
        public string ma_DV { get; set; }
        public string ma_CV { get; set; }
        public THAOTACDICHVU(string ma_NV,string ma_DV,string ma_CV)
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
