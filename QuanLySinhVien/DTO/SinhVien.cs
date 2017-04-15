using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class SinhVien
    {
        public int MaSV { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string Email { get; set; }
        public string MaNganh { get; set; }
    
        public SinhVien(int maSV, string ho, string ten, string sdt, string diachi, string gioiTinh, string email, string maNganh)
        {
            MaSV = maSV;
            Ho = ho;
            Ten = ten;
            SDT = sdt;
            GioiTinh = gioiTinh;
            Email = email;
            MaNganh = maNganh;
            DiaChi = diachi;
        }
    }
}
