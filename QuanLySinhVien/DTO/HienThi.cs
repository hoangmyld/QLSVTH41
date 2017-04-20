using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HienThi
    {
        public string MaLop { get; set; }
        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public string SoTinChi { get; set; }
        //public int SoNguoiDK {get; set;}
        public HienThi(string mLop, string maMH, string tenMH, string soTinChi)
        {
            MaLop = mLop;
            MaMH = maMH;
            TenMH = tenMH;
            SoTinChi = soTinChi;
            //SoNguoiDK = soNguoiDK;
        }
    }
}
