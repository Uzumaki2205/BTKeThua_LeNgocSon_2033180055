using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKeThua_LeNgocSon_2033180055
{
    class Nguoi
    {
        string hoten;
        DateTime ngaysinh;
        string gioitinh;

        public string Hoten { get => hoten; set => hoten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh 
        { 
            get => gioitinh; 
            set
            {
                string Lower = value.ToLower();
                if (Lower != "nam" && Lower != "nữ")
                    gioitinh = "nam";
                else gioitinh = value;
            }
        }

        public Nguoi()
        {
            Hoten = "No Name";
            Ngaysinh = DateTime.Today;
            Gioitinh = "Nam";
        }

        public Nguoi(string Hoten, DateTime Ngaysinh, string Gioitinh)
        {
            this.Hoten = Hoten;
            this.Ngaysinh = Ngaysinh;
            this.Gioitinh = Gioitinh;
        }

        public void nhap()
        {
            Hoten = "Le Ngoc Son";
            Gioitinh = "Nam";
        }

        public void xuat()
        {
            Console.WriteLine("Họ tên = " + hoten);
            Console.WriteLine("Ngày sinh = {0}/{1}/{2}", ngaysinh.Day, ngaysinh.Month, ngaysinh.Year);
            Console.WriteLine("Giới tính = " + gioitinh);
        }
    }
}
