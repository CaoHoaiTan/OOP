using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class DangKiDV
    {
        public string so_HD;
        public List<DichVu> dsDichvu;
        public double giaTien = 0;
        public DangKiDV(string so_HD, List<DichVu> dsDichvu)
        {
            this.so_HD = so_HD;
            this.dsDichvu = dsDichvu;
            foreach ( var i in dsDichvu)
            {
                this.giaTien += i.giaTien;
            }
        }
        public DangKiDV(DangKiDV DKDV)
        {
            this.so_HD = DKDV.so_HD;
            this.dsDichvu = DKDV.dsDichvu;
        }
    }
}