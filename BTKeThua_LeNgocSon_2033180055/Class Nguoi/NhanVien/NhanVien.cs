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
        static float luongcb;

        public string Id 
        {
            get { return id; }
            set
            {
                if (value == string.Empty)
                    id = "NV001";
                else id = value;
            }
        }
        public string ChucVu 
        {
            get { return chucVu; }
            set { chucVu = value.ToLower(); }
        }
        public float HeSo 
        {
            get 
            {
                if (ChucVu == "giám đốc")
                    heSo = 2.0f; 
                else if (ChucVu == "trưởng phòng")
                    heSo = 1.5f;
                else heSo = 1.0f;

                return heSo;
            }
        }

        public static float Luongcb 
        {
            get { return luongcb; }
            set { luongcb = value; }
        }

        static NhanVien()
        {
            Luongcb = 1200;
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

        float Luong() 
        { 
            return (Gioitinh == "Nữ") ? (Luongcb * HeSo * Luongcb) + (0.5f * Luongcb) : Luongcb * HeSo * Luongcb; 
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
