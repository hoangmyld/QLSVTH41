using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class SV_LHBus
    {
        public List<SV_LH> GetSV_LH(string sql)
        {
            try
            {
                return new SV_LHDAO().GetSV_LH(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int ThemSV_LH(SV_LH SV_LH)
        {
            try
            {
                return new SV_LHDAO().ThemSV_LH(SV_LH);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int SuaSV_LH(SV_LH SV_LH)
        {
            try
            {
                return new SV_LHDAO().SuaSV_LH(SV_LH);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int XoaSV_LH(int id,string id2)
        {
            try
            {
                return new SV_LHDAO().XoaSV_LH(id,id2);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
