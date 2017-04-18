using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class SV_LH2DAO
    {
        DataProvider dp;
        public SV_LH2DAO()
        {
            dp = new DataProvider();
        }
        public List<SV_LH2> getSV_LH2(string sql)
        {
            try
            {
                SqlDataReader dr = dp.ExecReader(sql);
                List<SV_LH2> list = new List<SV_LH2>();

                string tenmh;
                string malh;
                double diemgk, diemck;
                while (dr.Read())
                {
                    tenmh = dr.GetString(1);
                    malh = dr.GetString(0);
                    diemgk = dr.GetDouble(2);
                    diemck = dr.GetDouble(3);

                    SV_LH2 slh = new SV_LH2(malh, tenmh, diemgk, diemck);
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

    }
}
