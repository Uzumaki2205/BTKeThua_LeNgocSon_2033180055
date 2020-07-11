using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKeThua_LeNgocSon_2033180055
{
    class NVTV : NhanVien
    {
        int soSP;

        public int SoSP 
        {
            get { return soSP; }
            set 
            {
                if (value <=0)
                    soSP = 1;
                else soSP = value; 
            }
        }

        #region Constructor
        public NVTV() : base()
        {
            soSP = 1;
        }
        public NVTV(string Hoten, DateTime Ngaysinh, string Gioitinh, String Id, String ChucVu, int SoSP)
            : base (Hoten, Ngaysinh, Gioitinh, Id, ChucVu)
        {
            this.SoSP = SoSP;
        }
        public NVTV(NVTV a) : base(a)
        {
            SoSP = a.SoSP;
        }
        public NVTV(NhanVien a) : base(a)
        {
            SoSP = 1;
        }
        #endregion

        public override float LuongNV() { return SoSP * 100; }

        public override void xuat()
        {
            //Console.WriteLine("\n---------------Nhân Viên Thời Vụ---------------\n");
            base.xuat();
            Console.WriteLine("Số sản phẩm = " + soSP);
            Console.WriteLine("Lương = " + LuongNV());
        }
    }
}
