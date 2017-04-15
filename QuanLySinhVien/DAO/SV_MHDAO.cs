using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class SV_MHDAO
    {
         
        DataProvider dp;
        public SV_MHDAO()
        {
            dp = new DataProvider();
        }
        public List<SV_MH> GetSV_MH(string sql)
        {
            try
            {
                SqlDataReader dr = dp.ExecReader(sql);
                List<SV_MH> list = new List<SV_MH>();
                int masv;
                string mamh;
                double diem;
                while (dr.Read())
                {
                    masv = dr.GetInt32(0);
                    mamh = dr.GetString(1);
                    diem = dr.GetDouble(2);

                    SV_MH smh = new SV_MH(masv , mamh , diem);
                    list.Add(smh);

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
        public int ThemSV_MH(SV_MH SH)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@masv", SH.MaSV));
            list.Add(new SqlParameter("@mamh", SH.MaMH));
            list.Add(new SqlParameter("@diem", SH.Diem));
        
            try
            {
                return (dp.ExcuteNonquery("ThemSV_MH", System.Data.CommandType.StoredProcedure, list));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int SuaSV_MH(SV_MH SV_MH)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@masv", SV_MH.MaSV));
            list.Add(new SqlParameter("@mamh", SV_MH.MaMH));
            list.Add(new SqlParameter("@diem", SV_MH.Diem));
            try
            {
                return (dp.ExcuteNonquery("SuaSV_MH", System.Data.CommandType.StoredProcedure, list));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int XoaSV_MH(int msv, string mmh)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@masv", msv));
            list.Add(new SqlParameter("@mamh", mmh));
            try
            {
                return (dp.ExcuteNonquery("XoaSV_MH", System.Data.CommandType.StoredProcedure, list));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
