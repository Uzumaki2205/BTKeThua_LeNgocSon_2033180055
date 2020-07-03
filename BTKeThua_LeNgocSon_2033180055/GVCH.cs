using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKeThua_LeNgocSon_2033180055
{
    class GVCH 
    {
        string trinhDo;
        string diHoc;
        int soGio;

        public string TrinhDo 
        { 
            get => trinhDo; 
            set
            {
                string Lower = value.ToLower();
                if (Lower == "cử nhân" || Lower == "thạc sĩ" || Lower == "tiến sĩ")
                    trinhDo = value;
                else trinhDo = "cử nhân";
            }
        }
        public string DiHoc 
        { 
            get => diHoc; 
            set
            {
                if (value == "đi học" || value == "không đi học")
                    diHoc = value;
                else diHoc = "không đi học";
            }
        }
        public int SoGio
        {
            get => soGio;
            set
            {
                if (value < 0)
                    soGio = 0;
                else soGio = value;
            }
        }

        public int SoTiet 
        { 
            get
            {
                if (trinhDo == "cử nhân" && diHoc == "không đi học")
                    return 300;
                else if (trinhDo == "cử nhân" && diHoc == "đi học")
                    return 210;
                else if (trinhDo == "thạc sĩ" && diHoc == "không đi học")
                    return 300;
                else if (trinhDo == "thạc sĩ" && diHoc == "đi học")
                    return 150;
                else return 300;
            }
        }

        public GVCH()
        {
            TrinhDo = "cử nhân";
            DiHoc = "không đi học";
            SoGio = 301;
        }

        public GVCH(string TrinhDo, string DiHoc, int SoGio)
        {
            this.TrinhDo = TrinhDo;
            this.DiHoc = DiHoc;
            this.SoGio = SoGio;
        }

        public double TienVuotGio(GiangVien a)
        {
            return (soGio - SoTiet) * a.HeSo * 60;
        }
    }
}
