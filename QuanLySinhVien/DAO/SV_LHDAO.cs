using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class SV_LHDAO
    {

        DataProvider dp;
        public SV_LHDAO()
        {
            dp = new DataProvider();
        }
        public List<SV_LH> GetSV_LH(string sql)
        {
            try
            {
                SqlDataReader dr = dp.ExecReader(sql);
                List<SV_LH> list = new List<SV_LH>();
                int masv;
                string malh;
                double diemgk, diemck;
                while (dr.Read())
                {
                    masv = dr.GetInt32(0);
                    malh = dr.GetString(1);
                    diemgk = dr.GetDouble(2);
                    diemck = dr.GetDouble(3);
                    SV_LH slh = new SV_LH(masv, malh, diemgk, diemck);
                    list.Add(slh);
                }
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dp.disCon();
            }
        }
        public int ThemSV_LH(SV_LH SLH)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@masv", SLH.MaSV));
            list.Add(new SqlParameter("@malop", SLH.MaLop));
            list.Add(new SqlParameter("@diemgk", SLH.DiemGK));
            list.Add(new SqlParameter("@diemck", SLH.DiemCK));

            try
            {
                return (dp.ExcuteNonquery("ThemSV_LH", System.Data.CommandType.StoredProcedure, list));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int SuaSV_LH(SV_LH SLH)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@masv", SLH.MaSV));
            list.Add(new SqlParameter("@malop", SLH.MaLop));
            list.Add(new SqlParameter("@diemgk", SLH.DiemGK));
            list.Add(new SqlParameter("@diemck", SLH.DiemCK));

            try
            {
                return (dp.ExcuteNonquery("SuaSV_LH", System.Data.CommandType.StoredProcedure, list));
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
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public SV_LH get1diemhocki(string sql)
        {
            try
            {
                SqlDataReader dr = dp.ExecReader(sql);

                int masv;
                string malh;
                double diemgk, diemck;
                SV_LH svlh;
                dr.Read();
                {
                    masv = dr.GetInt32(0);
                    malh = dr.GetString(1);
                    diemgk = dr.GetDouble(2);
                    diemck = dr.GetDouble(3);
                    svlh = new SV_LH(masv, malh, diemgk, diemck);

                    return svlh;
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                dp.disCon();
            }
        }
    }
}
    
