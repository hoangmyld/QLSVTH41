using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class GV_LHBUS
    {
        public List<GV_LH> GetGV_LH(string sql)
        {
            try
            {
                return new GV_LHDAO().GetGV_LH(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int ThemGV_LH(GV_LH LH)
        {
            try
            {
                return new GV_LHDAO().ThemGV_LH(LH);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public int SuaGV_LH(GV_LH LH)
        {
            try
            {
                return new GV_LHDAO().SuaGV_LH(LH);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int XoaGV_LH(int magv, string malop)
        {
            try
            {
                return new GV_LHDAO().XoaGV_LH(magv, malop);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
