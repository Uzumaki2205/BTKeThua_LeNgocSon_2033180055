using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKeThua_LeNgocSon_2033180055
{
    abstract class GiangVien : Nguoi
    {
        string id;
        string chucVu;
        float heSo;
        static float luongcb;

        public string Id 
        { 
            get { return id; }
            set 
            {
                if (value == string.Empty)
                    id = "GV001";
                else id = value;
            }
        }
        public string ChucVu 
        { 
            get { return chucVu; }
            set
            {
                string Lower = value.ToLower();
                if (Lower != "trưởng khoa" && Lower != "phó khoa" && Lower != "giảng viên")
                    chucVu = "giảng viên";
                else chucVu = Lower;
            }
        }
        public float HeSo 
        {
            get { return heSo; }
            set
            {
                if (value != 2.34f && value != 2.67f && value != 3.0f && value != 3.3f)
                    heSo = 2.34f;
                else heSo = value;
            }
        }
        public static float Luongcb 
        { 
            get { return luongcb; }
            set { luongcb = value; }
        }
        public float Luong { get { return Luongcb * heSo + PCCV(); } }

        public abstract float TienVuotGio();

        float PCCV()
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

        public GiangVien(GiangVien a)
        {
            this.Hoten = a.Hoten;
            this.Ngaysinh = a.Ngaysinh;
            this.Gioitinh = a.Gioitinh;
            this.Id = a.Id;
            this.ChucVu = a.ChucVu;
            this.HeSo = a.HeSo;
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("ID = " + id);
            Console.WriteLine("Chức Vụ = " + chucVu);
            Console.WriteLine("Hệ Số = {0}", HeSo);
            Console.WriteLine("Lương cơ bản = " + Luongcb);
            Console.WriteLine("PCCV = " + PCCV());
            Console.WriteLine("Lương = " + Luong);
        }
    }
}
