﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKeThua_LeNgocSon_2033180055
{
    class GVTG : GVCH
    {
        public GVTG() : base()
        {
            TrinhDo = "cử nhân";
            DiHoc = "không đi học";
            SoGio = 301;
        }

        public GVTG(string Hoten, DateTime Ngaysinh, string Gioitinh, string Id, string ChucVu, float HeSo,
            string TrinhDo, string DiHoc, int SoGio)
            : base(Hoten, Ngaysinh, Gioitinh, Id, ChucVu, HeSo, TrinhDo, DiHoc, SoGio)
        {
            //this.Hoten = Hoten;
            //this.Ngaysinh = Ngaysinh;
            //this.Gioitinh = Gioitinh;
            //this.Id = Id;
            //this.ChucVu = ChucVu;
            //this.HeSo = HeSo;
            this.TrinhDo = TrinhDo;
            this.DiHoc = DiHoc;
            this.SoGio = SoGio;
        }

        public GVTG(GVTG a) : base(a)
        {
            this.TrinhDo = a.TrinhDo;
            this.DiHoc = a.DiHoc;
            this.SoGio = a.SoGio;
        }

        //public GVTG(GiangVien a)
        //{
        //    this.Hoten = a.Hoten;
        //    this.Ngaysinh = a.Ngaysinh;
        //    this.Gioitinh = a.Gioitinh;
        //    this.Id = a.Id;
        //    this.ChucVu = a.ChucVu;
        //    this.HeSo = a.HeSo;
        //}

        public override void xuat()
        {
            base.xuat();
        }

        public override float TienVuotGio()
        {
            if (TrinhDo == "cử nhân")
                return SoTiet * 60;
            else if (TrinhDo == "thạc sĩ")
                return SoTiet * 100;
            else return SoTiet * 250;
        }
    }
}
