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
        public int ExcuteNonquery(string sql, CommandType type, List<SqlParameter> paras)
        {
            Con();
            try
            {
                SqlCommand cm = new SqlCommand(sql, cn);
                cm.CommandType = type;
                if (paras != null)
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
        public int ExecTest(string sql)
        {
            Con();
            SqlCommand cm = new SqlCommand(sql, cn);
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            disCon();
            return 1;


        }
        //Phi ket noi
        public DataTable InitDTTable(SqlDataAdapter da)
        {

            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            return dt;
        }
        public DataTable getDataTable(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = InitDTTable(da);
            return dt;
        }
        public int UpdateTable(string sql, List<SqlParameter> paras)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = InitDTTable(da);
            DataRow dr = dt.Rows.Find(paras[0].Value);
            if (dr == null) { return 0; }
            int i = 1;
            foreach (SqlParameter para in paras)
            {
                if (para != paras[0])
                {
                    dr[i++] = para.Value;
                }
            }
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(dt);
            return 1;
        }
        public int InsertTable(string sql, List<SqlParameter> paras)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = InitDTTable(da);
            da.Fill(dt);
            DataRow dr = dt.Rows.Find(paras[0].Value);
            if (dr != null)
                return 0;
            else dr = dt.NewRow();
            int i = 0;
            foreach (SqlParameter para in paras)
            {
                dr[i++] = para.Value;
            }
            dt.Rows.Add(dr);
            SqlCommandBuilder db = new SqlCommandBuilder(da);
            da.Update(dt);
            return 1;
        }
        public int DeleteTeacher(int maGV)
        {
            string sql = @"select * from GiangVien";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = InitDTTable(da);            
            DataRow dr = dt.Rows.Find(maGV);
            if (dr == null) return 0;
            dr.Delete();
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(dt);
            return 1;
        }
    }
}


