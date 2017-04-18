using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace BUS
{
    public class LoginBUS
    {
        public int Login(string id, string pass, int choose)
        {
            return new LoginDAO().Login(id, pass, choose);
        }
    }
}
