using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKeThua_LeNgocSon_2033180055.Class_Phong
{
    class Phong
    {
        string maPhong;
        int soNguoi;
        int soDien;
        int soNuoc;

        protected Phong(string maPhong, int soNguoi, int soDien, int soNuoc)
        {
            this.maPhong = maPhong;
            this.soNguoi = soNguoi;
            this.soDien = soDien;
            this.soNuoc = soNuoc;
        }

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public int SoNguoi 
        { 
            get => soNguoi; 
            set
            {
                if (value < 0)
                    soNguoi = 0;
                else soNguoi = value;
            }
        }
        public int SoDien 
        { 
            get => soDien; 
            set
            {
                if (soDien < 0)
                    soDien = 0;
                else soDien = value;
            }
        }
        public int SoNuoc 
        { 
            get => soNuoc; 
            set
            {
                if (soNuoc < 0)
                    soNuoc = 0;
                else soNuoc = value;
            }
        }

        public virtual float TienPhong()
        {
            return 1500 + soDien * 3 + soNuoc * 10;
        }

        public virtual void Xuat()
        {
            Console.WriteLine("\n---------------------");
            Console.WriteLine("Mã Phòng = " + maPhong);
            Console.WriteLine("Số người = " + soNguoi);
            Console.WriteLine("Số điện = " + soDien);
            Console.WriteLine("Số nước = " + soNuoc);
            Console.WriteLine("Tiền phòng = " + TienPhong());
        }
    }
}
