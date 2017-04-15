using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopHoc
    {
        public string MaLH { get; set; }

        public string MaMH { get; set; }

        public int MaHK { get; set; }

        public DateTime ThoiGianBatDau { get; set; }

        public DateTime ThoiGianKetThuc { get; set; }

        public int TinhTrang { get; set; }

        public LopHoc (string malh, string mamh, int mahk, DateTime tgbd, DateTime tgkt ,int tinhtrang)
        {
            MaLH = malh;
            MaMH = mamh;
            MaHK = mahk;
            ThoiGianBatDau = tgbd;
            ThoiGianKetThuc = tgkt;
            TinhTrang = tinhtrang;
        }
    }
}
