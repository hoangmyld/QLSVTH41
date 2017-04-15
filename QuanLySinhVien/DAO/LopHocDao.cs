using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class LopHocDao
    {
        
        DataProvider dp;
        public LopHocDao()
        {
            dp = new DataProvider();
        }
        public List<LopHoc> GetLH(string sql)
        {
            try
            {
                SqlDataReader dr = dp.ExecReader(sql);
                List<LopHoc> list = new List<LopHoc>();
                string malh, mamh1 ;
                DateTime tgbd, tgkt;
                int mahk, tinhtrang;
                while (dr.Read())
                {
                    malh = dr.GetString(0);
                    mamh1 = dr.GetString(1);
                    mahk = dr.GetInt32(2);
                    tgbd = dr.GetDateTime(3);
                    tgkt = dr.GetDateTime(4);
                    tinhtrang = dr.GetInt32(5);

                    LopHoc lh = new LopHoc(malh, mamh1, mahk, tgbd, tgkt, tinhtrang);
                    list.Add(lh);

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
        public int ThemLH(LopHoc LH)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@malop", LH.MaLH));
            list.Add(new SqlParameter("@mamh1", LH.MaMH));
            list.Add(new SqlParameter("@mahk", LH.MaHK));
            list.Add(new SqlParameter("@tgbatdau", LH.ThoiGianBatDau));
            list.Add(new SqlParameter("@tgketthuc", LH.ThoiGianKetThuc));
            list.Add(new SqlParameter("@tinhtrang", LH.TinhTrang));
            try
            {
                return (dp.ExcuteNonquery("ThemLH", System.Data.CommandType.StoredProcedure, list));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
         public int SuaLH(LopHoc LH)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@malop", LH.MaLH));
            list.Add(new SqlParameter("@mamh1", LH.MaMH));
            list.Add(new SqlParameter("@mahk", LH.MaHK));
            list.Add(new SqlParameter("@tgbatdau", LH.ThoiGianBatDau));
            list.Add(new SqlParameter("@tgketthuc", LH.ThoiGianKetThuc));
            list.Add(new SqlParameter("@tinhtrang", LH.TinhTrang));
            try
            {
                return (dp.ExcuteNonquery("SuaLH", System.Data.CommandType.StoredProcedure, list));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
         public int XoaLH(string malop)
         {
             List<SqlParameter> list = new List<SqlParameter>();
             list.Add(new SqlParameter("@malop", malop));
             try
             {               
                 return (dp.ExcuteNonquery("XoaLH", System.Data.CommandType.StoredProcedure, list));
             }
             catch (Exception ex)
             {

                 throw ex;
             }
         }
    }
}
