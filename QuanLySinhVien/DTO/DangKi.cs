using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangKi
    {
        public string MaLop { get; set; }
        public string TenMH { get; set; }
        public string SoTinChi { get; set; }
        public DangKi(string mLop, string tenMH, string soTinChi)
        {
            MaLop = mLop;
            TenMH = tenMH;
            SoTinChi = soTinChi;
        }
    }
}
