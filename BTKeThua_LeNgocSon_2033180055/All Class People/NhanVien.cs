using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKeThua_LeNgocSon_2033180055
{
    class NhanVien : Nguoi
    {
        string id;
        string chucVu;
        float heSo;
        static double luongcb;

        public string Id { get => id; set => id = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public float HeSo 
        {
            get 
            {
                if (ChucVu == "giám đốc")
                    heSo = 2.0f; 
                else if (ChucVu == "trưởng phòng")
                    heSo = 1.5f;
                else { heSo = 1.0f; }

                return heSo;
            }
        }

        public static double Luongcb { get => luongcb; set => luongcb = value; }

        static NhanVien()
        {
            Luongcb = 1200;
        }
        public NhanVien() : base()
        {
            Id = "001";
            ChucVu = "trưởng phòng";
        }

        public NhanVien(string Hoten, DateTime Ngaysinh, string Gioitinh, String Id, String ChucVu) 
            : base(Hoten, Ngaysinh, Gioitinh)
        {
            this.Hoten = Hoten;
            this.Ngaysinh = Ngaysinh;
            this.Gioitinh = Gioitinh;
            this.Id = Id;
            this.ChucVu = ChucVu;
        }

        double Luong() 
        { 
            return (Gioitinh == "Nữ") ? Luongcb * HeSo * Luongcb + 0.5f : Luongcb * HeSo * Luongcb; 
        }

        public new void nhap()
        {
            base.nhap();
        }

        public new void xuat()
        {
            Console.Write("\n--------------\n");
            base.xuat();
            Console.WriteLine("ID = " + id);
            Console.WriteLine("Chuc Vu = " + chucVu);
            Console.WriteLine("He So = {0}", HeSo);
            Console.WriteLine("Luong co ban = " + Luongcb);
            Console.WriteLine("Luong = " + Luong());
        }

    }
}
