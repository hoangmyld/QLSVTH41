﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DAO
{
    public class DataProvider
    {
        string str;
        SqlConnection cn;
        public DataProvider()
        {
            str = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(str);
        }
        private void Con()
        {
            try
            {
                if (cn != null && cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }
        public void disCon()
        {
            try
            {
                if (cn != null && cn.State != System.Data.ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public SqlDataReader ExecReader(string sql)
        {
            Con();
            try
            {
                SqlCommand cm = new SqlCommand(sql, cn);
                return cm.ExecuteReader();
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
            
        }
    }
}
