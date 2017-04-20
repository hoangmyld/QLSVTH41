using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using DAO;
using DTO;

namespace BUS
{
    public class GiangVienBUS
    {
        public DataTable getTeacher() { return new GiangVienDAO().getTeacher();}

        public DataTable getChuyenNganh() { return new GiangVienDAO().getChuyenNganh(); }   
     
        public int insertTeacher(GiangVien gv) { return new GiangVienDAO().insertTeacher(gv); }
        
        public int updateTeacher(GiangVien gv) { return new GiangVienDAO().updateTeacher(gv); }
        
        public int deleteTeacher(int MaGV) { return new GiangVienDAO().deleteTeacher(MaGV); }
        public DataTable searchGV(string sql) { return new GiangVienDAO().SearchTeacher(sql); }
    }
}
