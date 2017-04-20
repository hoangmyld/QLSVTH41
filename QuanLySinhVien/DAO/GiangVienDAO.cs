using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using DTO;

namespace DAO
{
    public class GiangVienDAO
    {
        DataProvider dp;
        public GiangVienDAO()
        {
            dp = new DataProvider();
        }
        public DataTable getTeacher()
        {
            string sql = @"select * from GiangVien";
            return dp.getDataTable(sql);
        }
        public DataTable getChuyenNganh()
        {
            string sql = @"select * from ChuyenNganh";
            return dp.getDataTable(sql);
        }
        public int insertTeacher(GiangVien gv)
        {
            string sql = @"select * from GiangVien";
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("MaGV", gv.MaGV));
            paras.Add(new SqlParameter("Ho", gv.Ho));
            paras.Add(new SqlParameter("Ten", gv.Ten));
            paras.Add(new SqlParameter("DiaChi", gv.DiaChi));
            paras.Add(new SqlParameter("GioiTinh", gv.GioiTinh));
            paras.Add(new SqlParameter("MaNganh", gv.MaNganh));
            paras.Add(new SqlParameter("HinhGV", gv.HinhGV));
            return dp.InsertTable(sql, paras);
        }
        public int deleteTeacher(int maGV)
        {
            return dp.DeleteTeacher(maGV);
        }
        public int updateTeacher(GiangVien gv)
        {
            string sql = @"select * from GiangVien";
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("MaGV", gv.MaGV));
            paras.Add(new SqlParameter("Ho", gv.Ho));
            paras.Add(new SqlParameter("Ten", gv.Ten));
            paras.Add(new SqlParameter("DiaChi", gv.DiaChi));
            paras.Add(new SqlParameter("GioiTinh", gv.GioiTinh));
            paras.Add(new SqlParameter("MaNganh", gv.MaNganh));
            paras.Add(new SqlParameter("HinhGV", gv.HinhGV));
            return dp.UpdateTable(sql, paras);
        }
        public DataTable SearchTeacher(string sql)
        {
            return dp.getDataTable(sql);
        }
    }
}
