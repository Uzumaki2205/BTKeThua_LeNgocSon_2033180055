using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKeThua_LeNgocSon_2033180055
{
    abstract class NhanVien : Nguoi
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
                string Lower = ChucVu.ToLower();
                if (Lower == "giám đốc")
                    heSo = 2.0f; 
                else if (Lower == "trưởng phòng")
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

        #region Constructor
        static NhanVien()
        {
            Luongcb = 1200;
        }

        public NhanVien() : base()
        {
            Id = "";
            ChucVu = "";
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
        public NhanVien(NhanVien a)
        {
            Hoten = a.Hoten;
            Ngaysinh = a.Ngaysinh;
            Gioitinh = a.Gioitinh;
            Id = a.Id;
            ChucVu = a.ChucVu;
        }
        #endregion

        float Luong() 
        { 
            return (Gioitinh == "Nữ") ? (Luongcb * HeSo * Luongcb) + (0.5f * Luongcb) : Luongcb * HeSo * Luongcb; 
        }

        public abstract float LuongNV();

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("ID = " + id);
            Console.WriteLine("Chức vụ = " + chucVu);
            Console.WriteLine("Hệ số chức vụ = " + HeSo);
            Console.WriteLine("Lương cơ bản = " + Luongcb);
            //Console.WriteLine("Lương = " + Luong());
        }
    }
}
