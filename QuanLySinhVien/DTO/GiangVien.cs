using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiangVien
    {
        public int MaGV { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string MaNganh { get; set; }
        public byte[] HinhGV { get; set; }

        public GiangVien(int maGV, string Ho, string Ten, string DiaChi, string GioiTinh, string MaNganh, byte[] HinhGV)
        {
            MaGV = maGV;
            this.Ho = Ho;
            this.Ten = Ten;
            this.DiaChi = DiaChi;
            this.GioiTinh = GioiTinh;
            this.MaNganh = MaNganh;
            this.HinhGV = HinhGV;
        }
    }
}
