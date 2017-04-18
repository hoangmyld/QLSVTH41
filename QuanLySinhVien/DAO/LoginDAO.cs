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
    public class LoginDAO
    {
        DataProvider dp;
        public LoginDAO()
        {
            dp = new DataProvider();
        }
        public int Login(string id, string pass, int choose)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", id));
            paras.Add(new SqlParameter("@pass", pass));
            paras.Add(new SqlParameter("@LuaChon", choose));
            paras.Add(new SqlParameter("@KetQua", SqlDbType.Int));
            paras[3].Direction = ParameterDirection.Output;
            return dp.ExecLogin("DangNhap", CommandType.StoredProcedure, paras);
        }
    }
}
