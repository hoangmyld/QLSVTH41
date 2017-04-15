using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class SV_LH
     {
        public int MaSV { get; set; }

        public string MaLop { get; set; }

        public double DiemGK { get; set; }

        public double DiemCK { get; set; }

        public SV_LH(int masv, string malop, double diemgk, double diemck)
        {
            MaSV = masv;
            MaLop = malop;
            DiemGK = diemgk;
            DiemCK = diemck;
        }
     }
}
