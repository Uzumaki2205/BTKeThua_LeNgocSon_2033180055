using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKeThua_LeNgocSon_2033180055
{
    class GiangVien : Nguoi
    {
        string id;
        string chucVu;
        float heSo;
        static double luongcb;

        public string Id { get => id; set => id = value; }
        public string ChucVu 
        { 
            get => chucVu; 
            set
            {
                if (value != "trưởng khoa" && value != "phó khoa" && value != "giảng viên")
                    chucVu = "giảng viên";
                else chucVu = value;
            }
        }
        public float HeSo 
        { 
            get => heSo; 
            set
            {
                if (value != 2.34f && value != 2.67f && value != 3.0f && value != 3.3f)
                    heSo = 2.34f;
                else heSo = value;
            }
        }
        public static double Luongcb { get => luongcb; set => luongcb = value; }
        public double Luong { get { return Luongcb * heSo + PCCV(); } }

        double PCCV()
        {
            if (chucVu == "trưởng khoa")
                return 5 * Luongcb;
            else if (chucVu == "phó khoa")
                return 4 * Luongcb;
            else return 0;
        }

        static GiangVien()
        {
            Luongcb = 1200;
        }

        public GiangVien()
        {
            Hoten = "";
            Ngaysinh = new DateTime(1, 1, 1);
            Gioitinh = "Nam";
            Id = "001";
            ChucVu = "giảng viên";
            HeSo = 1;
        }

        public GiangVien(string Hoten, DateTime Ngaysinh, string Gioitinh, string Id, string ChucVu, float HeSo)
            : base(Hoten, Ngaysinh, Gioitinh)
        {
            this.Hoten = Hoten;
            this.Ngaysinh = Ngaysinh;
            this.Gioitinh = Gioitinh;
            this.Id = Id;
            this.ChucVu = ChucVu;
            this.HeSo = HeSo;
        }

        public new void xuat()
        {
            Console.Write("\n------------------\n");
            base.xuat();
            Console.WriteLine("ID = " + id);
            Console.WriteLine("Chức Vụ = " + chucVu);
            Console.WriteLine("Hệ Số = {0}", HeSo);
            Console.WriteLine("Lương cơ bản = " + Luongcb);
            Console.WriteLine("PCCV = " + PCCV());
            Console.WriteLine("Lương = " + Luong);
            Console.Write("\n------------------\n");
        }
    }
}
