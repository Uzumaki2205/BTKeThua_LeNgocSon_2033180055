using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKeThua_LeNgocSon_2033180055
{
    class SinhVien : Nguoi
    {
        string id;
        string heDT;
        int tongTC;

        public string Id 
        {
            get { return id; }
            set 
            {
                if (value == string.Empty)
                    id = "SV001";
                else id = value;
            }
        }
        public string HeDT 
        {
            get { return heDT; }
            set
            {
                string Lower = value.ToLower();
                if (Lower != "đại học" && Lower != "cao đẳng" && Lower != "cao đẳng nghề")
                    heDT = "đại học";
                else heDT = Lower;
            }
        }
        public int TongTC 
        { 
            get
            {
                if (HeDT == "đại học")
                    tongTC = 150;
                else if (HeDT == "cao đẳng")
                    tongTC = 100;
                else tongTC = 130;

                return tongTC;
            }
        }

        //Constructor
        public SinhVien(string Hoten, DateTime Ngaysinh, string Gioitinh, string Id, string HeDT) 
            : base(Hoten, Ngaysinh, Gioitinh)
        {
            this.Hoten = base.Hoten;
            this.Ngaysinh = base.Ngaysinh;
            this.Gioitinh = base.Gioitinh;
            this.Id = Id;
            this.HeDT = HeDT;
        }

        //kiểm tra học phí
        int ktHP()
        {
            if (HeDT == "đại học")
                return 200;
            else if (HeDT == "cao đẳng")
                    return 150;
            else return 120;
        }

        //tính tổng học phí
        float TongHP() { return TongTC * ktHP(); } 

        public new void xuat()
        {
            base.xuat();
            Console.WriteLine("ID = " + id);
            Console.WriteLine("Hệ đào tạo = " + heDT);
            Console.WriteLine("Tổng tín chỉ = " + TongTC);
            Console.WriteLine("Học phí mỗi tín chỉ = " + ktHP());
            Console.WriteLine("TỔng học phí = " + TongHP());
        }
    }
}
