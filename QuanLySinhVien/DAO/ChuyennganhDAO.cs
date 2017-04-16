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
    public class ChuyennganhDAO
    {
        DataProvider dp;
        public ChuyennganhDAO()
        {
            dp = new DataProvider();

        }
        public List<Chuyennganh> getchuyennganh(string sql)
        {
            try
            {
                string manganh, tennganh;
                List<Chuyennganh> list = new List<Chuyennganh>();
                SqlDataReader dr = dp.ExecReader(sql);
                while (dr.Read())
                {
                    manganh = dr.GetString(0);
                    tennganh = dr.GetString(1);
                    Chuyennganh cn = new Chuyennganh(manganh, tennganh);
                    list.Add(cn);
                }
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public int addchuyennganh(Chuyennganh cn)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaCN", cn.MaNganh));
            paras.Add(new SqlParameter("@TenCN", cn.TenNganh));
            return dp.ExcuteNonquery("addchuyennganh", CommandType.StoredProcedure, paras);
        }
        public int xoachuyennganh(string manganh)
        {
            try
            {
                string sql = @"delete from ChuyenNganh where MaNganh='" +manganh+"'";
                return dp.ExcuteNonquery(sql, CommandType.Text, null);
            }
            catch (Exception ex)
            {
                
                throw ex;
            } 
        }
            public int Suachuyennganh(Chuyennganh cn)
          {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@MaNganh", cn.MaNganh));
            list.Add(new SqlParameter("@TenNganh", cn.TenNganh));
            
            try
            {
                return (dp.ExcuteNonquery("Suachuyennganh", CommandType.StoredProcedure,list));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        }
    }

