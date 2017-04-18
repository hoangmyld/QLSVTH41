using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using DTO;
using System.Data;
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
        public void Con()
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

        public int ExecLogin(string sql, CommandType type, List<SqlParameter> paras)
        {
            Con();
            try
            {
                SqlCommand cm = new SqlCommand(sql, cn);
                cm.CommandType = type;
                if (paras != null)
                {
                    foreach (SqlParameter para in paras)
                    {
                        cm.Parameters.Add(para);
                    }
                }
                cm.ExecuteNonQuery();
                return int.Parse(cm.Parameters["@KetQua"].Value.ToString());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int ExcuteNonquery (string sql, CommandType type , List<SqlParameter> paras)
        {
            Con();
            try 
	        {	        
		          SqlCommand cm = new SqlCommand (sql,cn);
                  cm.CommandType = type;
                if(paras != null)
                    foreach (SqlParameter para in paras)
                    {
                        cm.Parameters.Add(para);
                    }
             
                  cm.ExecuteNonQuery();
                  return 1;
            }
	        catch (Exception ex)
	        {
		
		        throw ex;
	        }
            finally
            {
                disCon();
            }             
        }
      public  int ExecTest(string sql)
        {
            Con();
            SqlCommand cm = new SqlCommand(sql,cn);
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            disCon();
            return 1;
          

        }
    }
}

