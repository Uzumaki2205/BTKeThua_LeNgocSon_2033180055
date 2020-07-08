using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKeThua_LeNgocSon_2033180055
{
    class NVTC : NhanVien
    {
        int soCa;

        public int SoCa { get => soCa; set => soCa = value; }

        public NVTC() : base()
        {
            soCa = 0;
        }
        public NVTC(string Hoten, DateTime Ngaysinh, string Gioitinh, String Id, String ChucVu, int SoCa)
            : base (Hoten, Ngaysinh, Gioitinh, Id, ChucVu)
        {
            this.SoCa = SoCa;
        }

        public NVTC(NVTC a) : base(a)
        {
            this.SoCa = SoCa;
        }

        public override float LuongNV()
        {
            float tien = 1000 + soCa * 200;
            if (soCa <= 24)
                return tien;
            else return tien * 2;
        }

        public override void xuat()
        {
            Console.WriteLine("\n---------------Nhân Viên Theo Ca---------------\n");
            base.xuat();
            Console.WriteLine("Số ca = " + soCa);
            Console.WriteLine("Lương = " + LuongNV());
        }
    }
}
