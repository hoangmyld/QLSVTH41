using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GV_LH
    {
        public int MaGV { get; set; }
        public string MaLop { get; set; }
        
        public GV_LH(int magv, string lophoc)
        {
            MaGV = magv;
            MaLop = lophoc;
        }
    }
}
