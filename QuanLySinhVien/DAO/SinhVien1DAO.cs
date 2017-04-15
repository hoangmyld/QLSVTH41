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
    public class SinhVien1DAO
    {
        DataProvider dp;
        public SinhVien1DAO()
        {
            dp = new DataProvider();
        }
        public List<SinhVien> getStudent1(string sql)
        {
            try
            {
                SqlDataReader dr = dp.ExecReader(sql);
                List<SinhVien> list = new List<SinhVien>();
                int id;
                string LName, FName, phone, address, sex, email, facity;
                while (dr.Read())
                {
                    id = dr.GetInt32(0);
                    LName = dr.GetString(1);
                    FName = dr.GetString(2);
                    phone = dr.GetString(3);
                    address = dr.GetString(4);
                    sex = dr.GetString(5);
                    email = dr.GetString(6);
                    facity = dr.GetString(7);
                    SinhVien sv = new SinhVien(id, LName, FName, phone, address, sex, email, facity);
                    list.Add(sv);
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
    }
}
