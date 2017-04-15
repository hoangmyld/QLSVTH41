using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class LoginBUS
    {
        public int Login(string id, string pass, int choose)
        {
            //return new LoginDAO().Login(id, pass, choose);
            LoginDAO ld = new LoginDAO();
            int i = ld.Login(id, pass, choose);
            return i;
        }
    }
}
