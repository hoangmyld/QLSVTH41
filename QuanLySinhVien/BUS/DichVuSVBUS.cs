using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using DAO;
using DTO;

namespace BUS
{
    public class DichVuSVBUS
    {
        public DataTable getChuyenNganh() { return new DichVuSVDAO().getChuyenNganh();}
        public List<HienThi> getHienThi(int MaHK, string MaBan, string MaNganh, int tt) { return new DichVuSVDAO().getHienThi(MaHK, MaBan, MaNganh, tt); }
        public List<DangKi> getDangKi(int MSSV, int MaHK) { return new DichVuSVDAO().getDangKi(MSSV, MaHK); }
        public DataTable getHK() { return new DichVuSVDAO().getHocKi(); }
        public int ThemSV_LH(SV_LH SV_LH)
        {           
                return new DichVuSVDAO().ThemSV_LH(SV_LH);            
        }
        public int XoaSV_LH(int id, string id2)
        {
                return new SV_LHDAO().XoaSV_LH(id, id2);         
        }
        
    }
}
