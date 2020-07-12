using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKeThua_LeNgocSon_2033180055.Class_Phong
{
    class Room_B : Phong
    {
        int giatui;
        int somay;

        public int Giatui 
        { 
            get => giatui;
            set 
            {
                if (value < 0)
                    giatui = 0;
                else giatui = value;
            }
        }
        public int Somay 
        { 
            get => somay; 
            set
            {
                if (somay < 0)
                    somay = 0;
                else somay = value;
            }
        }

        public Room_B(string MaPhong, int SoNguoi, int SoDien, int SoNuoc, int Giatui, int Somay)
            : base (MaPhong, SoNguoi, SoDien, SoNuoc)
        {
            this.Giatui = Giatui;
            this.Somay = Somay;
        }

        public override float TienPhong()
        {
            return 2000 + 2 * SoDien + 8 * SoNuoc + giatui * 5 + somay * 100;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Số máy = " + somay);
            Console.WriteLine("Giặt ủi = " + giatui + " kg");
        }
    }
}
