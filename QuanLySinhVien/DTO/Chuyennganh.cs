using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DTO
{
    public class Chuyennganh
    {
        public string MaNganh { get; set; }
        public string TenNganh { get; set; }

    
   
    public Chuyennganh( string manganh , string tennganh)
    {
    MaNganh=manganh;
    TenNganh = tennganh;

    }
}
}
