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
    public class MonHocDao
    {
        DataProvider dp;
        public MonHocDao()
        {
            dp = new DataProvider();
        }
        public List<MonHoc> GetMH(string sql)
        {
            try
            {
                SqlDataReader dr = dp.ExecReader(sql);
                List<MonHoc> list = new List<MonHoc>();
                string mamh, tenmh,sotinchi,sotiet,manganh;
                while (dr.Read())
                {
                    mamh = dr.GetString(0);
                    tenmh = dr.GetString(1);
                    sotinchi = dr.GetString(2);
                    sotiet = dr.GetString(3);
                    manganh = dr.GetString(4);

                    MonHoc mh = new MonHoc(mamh, tenmh, sotinchi, sotiet, manganh);
                    list.Add(mh);

                }
                return list;
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
        public int ThemMH(MonHoc MH)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@mamh", MH.MaMH));
            list.Add(new SqlParameter("@tenmh", MH.TenMH));
            list.Add(new SqlParameter("@sotinchi", MH.SoTinChi));
            list.Add(new SqlParameter("@sotiet", MH.SoTiet));
            list.Add(new SqlParameter("@manganh", MH.MaNganh));
            try
            {
                return (dp.ExcuteNonquery("ThemMH", System.Data.CommandType.StoredProcedure, list));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int XoaMH(string mamh)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@mamh", mamh));
            try
            {
                return (dp.ExcuteNonquery("XoaMH", System.Data.CommandType.StoredProcedure, list));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //           try
        //    {
        //        dp.Con();
        //        //string sql = String.Format("delete from SinhVien where MaSV = {0}", id);
        //        string sql = "delete from MonHoc where MaMH = " + mamh.ToString();
        //        return dp.ExecTest(sql);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }

        //}

        public int SuaMH(MonHoc MH)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@mamh", MH.MaMH));
            list.Add(new SqlParameter("@tenmh", MH.TenMH));
            list.Add(new SqlParameter("@sotinchi", MH.SoTinChi));
            list.Add(new SqlParameter("@sotiet", MH.SoTiet));
            list.Add(new SqlParameter("@manganh", MH.MaNganh));
            try
            {
                return (dp.ExcuteNonquery("SuaMH", System.Data.CommandType.StoredProcedure, list));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

    }
}
