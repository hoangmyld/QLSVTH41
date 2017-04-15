using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using DTO;
using DAO;

namespace BUS
{
    public class SinVien1BUS
    {
        public List<SinhVien> getStudent1(string sql)
        {
            try
            {
                return new SinhVien1DAO().getStudent1(sql);
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }
    }
}
