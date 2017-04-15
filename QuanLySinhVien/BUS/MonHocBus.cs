using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class MonHocBus
    {
        public List<MonHoc> GetMH(string sql)
        {
            try
            {
                return new MonHocDao().GetMH(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int ThemMH(MonHoc MH)
        {
            try
            {
                return new MonHocDao().ThemMH(MH);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public int XoaMH(string mamh)
        {
            try
            {
                return new MonHocDao().XoaMH(mamh);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int SuaMH(MonHoc MH)
        {
            try
            {
                return new MonHocDao().SuaMH(MH);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
