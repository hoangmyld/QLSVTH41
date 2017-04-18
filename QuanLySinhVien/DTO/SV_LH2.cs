using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SV_LH2
    {
        public string MaLop { get; set; }
        public string TenMH { get; set; }

        

        public double DiemGK { get; set; }

        public double DiemCK { get; set; }
      

        public SV_LH2(string malop, string tenmh, double diemgk, double diemck)
        {
            MaLop = malop;
            TenMH = tenmh;
            DiemGK = diemgk;
            DiemCK = diemck;
           
        }
     }
    }


