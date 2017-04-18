using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class SV_LH2BUS
    {
        public List<SV_LH2> GetSV_LH2(string sql)
        {
            try
            {
                return new SV_LH2DAO().getSV_LH2(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
