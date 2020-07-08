using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKeThua_LeNgocSon_2033180055
{ 
    class NVHC : NhanVien
    {
        float heSoLuong;
        int soNgay;
        float heSoTD;

        public float HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public int SoNgay { get => soNgay; set => soNgay = value; }
        public float HeSoTD { get => heSoTD; set => heSoTD = TinhHSTD(); }

        float TinhHSTD()
        {
            if (soNgay > 25)
                heSoTD = 1.0f;
            else if (soNgay > 20)
                heSoTD = 0.75f;
            else if (soNgay > 15)
                heSoTD = 0.5f;
            else heSoTD = 0;

            return heSoTD;
        }

        public NVHC() : base()
        {
            HeSoLuong = 0;
            SoNgay = 1;
        }
        public NVHC(string Hoten, DateTime Ngaysinh, string Gioitinh, String Id, String ChucVu, float HeSoLuong, int SoNgay)
            : base(Hoten, Ngaysinh, Gioitinh, Id, ChucVu)
        {
            this.HeSoLuong = HeSoLuong;
            this.SoNgay = SoNgay;
            HeSoTD = TinhHSTD();
        }

        public NVHC (NVHC a) : base(a)
        {
            this.HeSoLuong = a.HeSoLuong;
            this.SoNgay = a.SoNgay;
            this.HeSoTD = TinhHSTD();
        }

        public override float LuongNV()
        {
            return 1000 + heSoLuong * HeSoTD * 1150;
        }

        public override void xuat()
        {
            Console.WriteLine("\n---------------Nhân Viên Hành Chính---------------\n");
            base.xuat();
            Console.WriteLine("Hệ số lương = " + heSoLuong);
            Console.WriteLine("Số ngày làm = " + soNgay);
            Console.WriteLine("Hệ số thi đua = " + HeSoTD);
            Console.WriteLine("Lương  = " + LuongNV());
        }
    }
}
