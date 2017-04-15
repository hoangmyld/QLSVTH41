using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class LopHocBus
    {
       public List<LopHoc> GetLH(string sql)
        {
            try
            {
                return new LopHocDao().GetLH(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
       public int ThemLH(LopHoc LH)
       {
           try
           {
               return new LopHocDao().ThemLH(LH);
           }
           catch (Exception ex)
           {

               throw ex;
           }

       }
       public int SuaLH(LopHoc LH)
       {
           try
           {
               return new LopHocDao().SuaLH(LH);
           }
           catch (Exception ex)
           {

               throw ex;
           }

       }
       public int XoaLH(string malop)
       {
           try
           {
               return new LopHocDao().XoaLH(malop);
           }
           catch (Exception ex)
           {

               throw ex;
           }

       }
    }
}
