using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;


namespace DAO
{
    public class GV_LHDAO
    {
        DataProvider dp;
        public GV_LHDAO()
        {
            dp = new DataProvider();
        }
        public List<GV_LH> GetGV_LH(string sql)
        {
            try
            {
                SqlDataReader dr = dp.ExecReader(sql);
                List<GV_LH> list = new List<GV_LH>();
                int magv;
                string lophoc;
      
                while (dr.Read())
                {
                    magv = dr.GetInt32(0);
                    lophoc = dr.GetString(1);
                    GV_LH gvlh = new GV_LH(magv,lophoc);
                    list.Add(gvlh);

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
        public int ThemGV_LH(GV_LH GH)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@magv", GH.MaGV));
            list.Add(new SqlParameter("@malop", GH.MaLop));
          
            try
            {
                return (dp.ExcuteNonquery("ThemGV_LH", System.Data.CommandType.StoredProcedure, list));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SuaGV_LH(GV_LH GH)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@magv", GH.MaGV));
            list.Add(new SqlParameter("@malop", GH.MaLop));

            try
            {
                return (dp.ExcuteNonquery("SuaGV_LH", System.Data.CommandType.StoredProcedure, list));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int XoaGV_LH(int magv,string malop)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@magv", malop));
            list.Add(new SqlParameter("@malop", malop));
            try
            {
                return (dp.ExcuteNonquery("XoaGV_LH", System.Data.CommandType.StoredProcedure, list));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

}