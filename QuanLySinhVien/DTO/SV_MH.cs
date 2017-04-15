using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SV_MH
    {
        public int MaSV { get; set; }

        public string MaMH { get; set; }

        public double Diem { get; set; }
        
        public SV_MH(int masv, string mamh ,double diem)
        {
            MaSV = masv;
            MaMH = mamh;
            Diem = diem;
        }
    }
}
