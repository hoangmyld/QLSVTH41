using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class SV_MHBus
    {
        public List<SV_MH> GetSV_MH(string sql)
        {
            try
            {
                return new SV_MHDAO().GetSV_MH(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    
       public int ThemSV_MH(SV_MH SV_MH)
       {
           try
           {
               return new SV_MHDAO().ThemSV_MH(SV_MH);
           }
           catch (Exception ex)
           {

               throw ex;
           }

       }
       public int SuaSV_MH(SV_MH SV_MH)
       {
           try
           {
               return new SV_MHDAO().SuaSV_MH(SV_MH);
           }
           catch (Exception ex)
           {

               throw ex;
           }

       }
       public int XoaSV_MH(int msv, string mmh)
       {
           try
           {
               return new SV_MHDAO().XoaSV_MH(msv, mmh);
           }
           catch (Exception ex)
           {

               throw ex;
           }

       }
    }
}
