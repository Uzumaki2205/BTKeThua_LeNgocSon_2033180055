using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKeThua_LeNgocSon_2033180055
{
    class GVTG : GVCH
    {
        public new double TienVuotGio(GiangVien a)
        {
            if (TrinhDo == "cử nhân")
                return SoTiet * 60;
            else if (TrinhDo == "thạc sĩ")
                return SoTiet * 100;
            else return SoTiet * 250;
        }
    }
}
