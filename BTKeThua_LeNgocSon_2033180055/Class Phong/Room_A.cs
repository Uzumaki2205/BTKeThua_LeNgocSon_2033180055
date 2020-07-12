using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKeThua_LeNgocSon_2033180055.Class_Phong
{
    class Room_A : Phong
    {
        int nguoiThan;

        public int NguoiThan 
        { 
            get => nguoiThan; 
            set
            {
                if (nguoiThan < 0)
                    nguoiThan = 0;
                else nguoiThan = value;
            }
        }

        public Room_A(string MaPhong, int SoNguoi, int SoDien, int SoNuoc, int NguoiThan) 
            : base(MaPhong, SoNguoi, SoDien, SoNuoc)
        {
            this.NguoiThan = NguoiThan;
        }

        public override float TienPhong()
        {
            return 1400 + 2 * SoDien + 8 * SoNuoc + 50 * NguoiThan;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Số người thân = " + nguoiThan);
        }
    }
}
