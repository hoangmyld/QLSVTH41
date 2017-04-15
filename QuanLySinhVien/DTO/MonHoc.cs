using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHoc
    {

        public string MaMH { get; set; }

        public string TenMH { get; set; }

        public string SoTinChi { get; set; }

        public string SoTiet { get; set; }

        public string MaNganh { get; set; }

        public MonHoc(string mamh, string tenmh, string sotinchi, string sotiet, string manganh)
        {
            MaMH = mamh;
            TenMH = tenmh;
            SoTinChi = sotinchi;
            SoTiet = sotiet;
            MaNganh = manganh;
        }

    }
   
}
