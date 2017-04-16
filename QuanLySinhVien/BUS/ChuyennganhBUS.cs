using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class ChuyennganhBUS
    {
        public List<Chuyennganh> getchuyennganh(string sql)
        {
            try
            {
                return new ChuyennganhDAO().getchuyennganh(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int Addchuyennganh(Chuyennganh cn)
        {
            try
            {
                return new ChuyennganhDAO().addchuyennganh(cn);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }
        public int xoachuyennganh(string manganh)
        {
            try
            {
                return new ChuyennganhDAO().xoachuyennganh(manganh);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
         
        }
        public int Suachuyennganh(Chuyennganh cn)
        {
            try
            {
                return new ChuyennganhDAO().Suachuyennganh(cn);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }


        }
    }
}
