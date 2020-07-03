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

        public string Id { get => id; set => id = value; }
        public string HeDT 
        {
            get
            {
                string Lower = heDT.ToLower();
                if (Lower != "đại học" && Lower != "cao đẳng" && Lower != "cao đẳng nghề")
                    heDT = "đại học";
                else heDT = Lower;

                return heDT;
            }
            set { heDT = value; }
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

        //hàm kiểm tra tiền
        int ktHP()
        {
            if (HeDT == "đại học")
                return 200;
            else if (HeDT == "cao đẳng")
                    return 150;
            else return 120;
        }

        //hàm tính tổng học phí
        public double TongHP { get{ return TongTC * ktHP(); } }

        public new void xuat()
        {
            base.xuat();
            Console.Write("\n-------------\n");
            Console.WriteLine("ID = " + id);
            Console.WriteLine("He Dao Tao = " + heDT);
            Console.WriteLine("Tong TC = " + TongTC);
            Console.WriteLine("Hoc Phi moi tin chi = " + ktHP());
            Console.WriteLine("Tong Hoc Phi = " + TongHP);
        }
    }
}
