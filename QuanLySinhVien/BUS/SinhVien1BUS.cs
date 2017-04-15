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
    public class SinhVien1BUS
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

        public int ThemSV(SinhVien SV)
        {
            try
            {

                SinhVien1DAO svdao = new SinhVien1DAO();
                return svdao.ThemSV(SV);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int XoaSV(int id)
        {
            try
            {
                return new SinhVien1DAO().XoaSV(id);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public int SuaSV(SinhVien SV)
        {
            try
            {
                return new SinhVien1DAO().SuaSV(SV);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
          
        }
        public SinhVien getAStudent(string sql)
        {
            try
            {
                return new SinhVien1DAO().getAStudent(sql);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
