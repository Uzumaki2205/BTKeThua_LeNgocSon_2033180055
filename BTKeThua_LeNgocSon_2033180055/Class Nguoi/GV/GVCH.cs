using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKeThua_LeNgocSon_2033180055
{
    class GVCH : GiangVien
    {
        string trinhDo;
        string diHoc;
        int soGio;

        public string TrinhDo 
        {
            get { return trinhDo; }
            set
            {
                string Lower = value.ToLower();
                if (Lower == "cử nhân" || Lower == "thạc sĩ" || Lower == "tiến sĩ")
                    trinhDo = Lower;
                else trinhDo = "cử nhân";
            }
        }
        public string DiHoc 
        { 
            get { return diHoc; }
            set
            {
                string Lower = value.ToLower();
                if (Lower == "đi học" || Lower == "không đi học")
                    diHoc = Lower;
                else diHoc = "không đi học";
            }
        }
        public int SoGio
        {
            get { return soGio; }
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
                if (trinhDo == "cử nhân")
                {
                    if (diHoc == "không đi học")
                    {
                        HeSo = 1;
                        return 300;
                    }
                    else
                    {
                        HeSo = 1;
                        return 210;
                    }
                }
                else if (trinhDo == "thạc sĩ")
                {
                    if (diHoc == "không đi học")
                    {
                        HeSo = 1.5f;
                        return 300;
                    }
                    else
                    {
                        HeSo = 1.5f;
                        return 150;
                    }
                }
                else
                {
                    HeSo = 2.5f;
                    return 300;
                }
            }
        }

        public GVCH()
        {
            TrinhDo = "cử nhân";
            DiHoc = "không đi học";
            SoGio = 301;
        }

        public GVCH(string Hoten, DateTime Ngaysinh, string Gioitinh, string Id, string ChucVu, float HeSo, 
            string TrinhDo, string DiHoc, int SoGio) : base(Hoten, Ngaysinh, Gioitinh, Id, ChucVu, HeSo)
        {
            this.TrinhDo = TrinhDo;
            this.DiHoc = DiHoc;
            this.SoGio = SoGio;
        }

        public GVCH(GVCH a) : base(a)
        {
            this.TrinhDo = a.TrinhDo;
            this.DiHoc = a.DiHoc;
            this.SoGio = a.SoGio;
        }

        //public GVCH (GiangVien a)
        //{
        //    this.Hoten = a.Hoten;
        //    this.Ngaysinh = a.Ngaysinh;
        //    this.Gioitinh = a.Gioitinh;
        //    this.Id = a.Id;
        //    this.ChucVu = a.ChucVu;
        //    this.HeSo = a.HeSo;
        //}

        //test List in readXAML
        //public GVCH(GVCH a)
        //{
        //    this.Hoten = a.Hoten;
        //    this.Ngaysinh = a.Ngaysinh;
        //    this.Gioitinh = a.Gioitinh;
        //    this.Id = a.Id;
        //    this.ChucVu = a.ChucVu;
        //    this.HeSo = a.HeSo;
        //    this.TrinhDo = a.TrinhDo;
        //    this.DiHoc = a.DiHoc;
        //    this.SoGio = a.SoGio;
            
        //}

        //public void xuat1p()
        //{
        //    base.xuat();
        //    Console.WriteLine("Trình độ = " + trinhDo);
        //    Console.WriteLine("Đi học = " + diHoc);
        //    Console.WriteLine("Số giờ = " + soGio);
        //}

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Trình độ = " + trinhDo);
            Console.WriteLine("Đi học = " + diHoc);
            Console.WriteLine("Số giờ = " + soGio);
            Console.WriteLine("Tiền vượt giờ = " + TienVuotGio());
        }

        public override float TienVuotGio()
        {
            float tien = (soGio - SoTiet) * HeSo * 60;
            if (tien < 0)
            {
                tien = 0;
            }
            return tien;
        }
    }
}
