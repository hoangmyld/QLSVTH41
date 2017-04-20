using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class DichVuSVDAO
    {
        DataProvider dp;
        public DichVuSVDAO()
        {
            dp = new DataProvider();
        }
        public DataTable getChuyenNganh()
        {
            string sql = @"select * from ChuyenNganh";
            return dp.getDataTable(sql);
        }
        public List<HienThi> getHienThi(int MaHK, string MaBan, string MaNganh, int TinhTrang)
        {
            string sql = string.Format(@"select LopHoc.MaLop, MonHoc.MaMH, TenMH, SoTinChi
                            from LopHoc, MonHoc
                            where LopHoc.MaMH = MonHoc.MaMH                            
                            and MaHK = {0}"  ,MaHK.ToString(), TinhTrang.ToString());
            if (MaBan != null) { sql += String.Format(@" and LopHoc.MaLop like N'{0}'", MaBan); } else sql += " and null is null";
            if (MaNganh != null) { sql += String.Format(@" and MaNganh = N'{0}'", MaNganh); } else sql += " and null is null ";
            if (TinhTrang != 0) { sql += String.Format(@" and TinhTrang = {0}", TinhTrang.ToString()); } 
            sql += @" group by  LopHoc.MaLop, MonHoc.MaMH, TenMH, SoTinChi";
            try
            {
                SqlDataReader dr = dp.ExecReader(sql);
                List<HienThi> list = new List<HienThi>();
                
                string MaLop, MaMH, TenMH, STC;
                while (dr.Read())
                {
                    
                    MaLop = dr.GetString(0);
                    MaMH = dr.GetString(1);
                    TenMH = dr.GetString(2);
                    STC = dr.GetString(3);
                    HienThi ht = new HienThi(MaLop, MaMH, TenMH, STC);
                    list.Add(ht);
                }
                return list;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            finally{dp.disCon();}
            
        }
        public List<DangKi> getDangKi(int MSSV, int MaHK)
        {
            string sql = String.Format(@"select LopHoc.MaLop, TenMH, SoTinChi
                            from LopHoc, MonHoc, SV_LH
                            where LopHoc.MaMH = MonHoc.MaMH
                            and LopHoc.MaLop = SV_LH.MaLop
                            and MaHK = {0}
                            and MaSV = {1}", MaHK, MSSV);
            try
            {
                SqlDataReader dr = dp.ExecReader(sql);
                List<DangKi> list = new List<DangKi>();               
                string MaLop, TenMH, STC;
                while (dr.Read())
                {                   
                    MaLop = dr.GetString(0);                    
                    TenMH = dr.GetString(1);
                    STC = dr.GetString(2);
                    DangKi ht = new DangKi(MaLop, TenMH, STC);
                    list.Add(ht);
                }
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        public DataTable getHocKi()
        {
            string sql = @"select * from HK order by MaHK desc";
            return dp.getDataTable(sql);
        }
        public int ThemSV_LH(SV_LH SLH)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@masv", SLH.MaSV));
            list.Add(new SqlParameter("@malop", SLH.MaLop));
            list.Add(new SqlParameter("@diemGk", SLH.DiemGK));
            list.Add(new SqlParameter("@diemCk", SLH.DiemCK));

            try
            {
                return (dp.ExcuteNonquery("ThemSV_LH", System.Data.CommandType.StoredProcedure, list));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int XoaSV_LH(int id, string id1)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@masv", id));
            list.Add(new SqlParameter("@malop", id1));
            try
            {

                return (dp.ExcuteNonquery("XoaSV_LH", System.Data.CommandType.StoredProcedure, list));
            }
            catch (Exception)
            {

                return 0;
            }

        }
        
    }
}
