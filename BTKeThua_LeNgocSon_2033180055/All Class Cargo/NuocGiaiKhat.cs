using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKeThua_LeNgocSon_2033180055.All_Class_Cargo
{
    class NuocGiaiKhat : HangHoa
    {
        string dvt;
        int soLuong;
        float donGia;

        public string Dvt 
        { 
            get => dvt; 
            set
            {
                string Lower = value.ToLower();
                if (Lower != "thùng" && Lower != "kết" && Lower != "chai" && Lower != "lon")
                    dvt = "kết";
                else dvt = value; 
            }
        }

        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float DonGia { get => donGia; set => donGia = value; }

        public NuocGiaiKhat(string Id, string TenHang, string Dvt, int SoLuong, float DonGia)
            : base(Id, TenHang)
        {
            base.Id = Id;
            base.TenHang = TenHang;
            this.Dvt = Dvt;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
        }

        public new void xuat()
        {
            base.xuat();
            Console.WriteLine("Đơn vị tính = " + dvt);
            Console.WriteLine("Số luọng = " + soLuong);
            Console.WriteLine("Đơn giá = " + donGia);
        }
    }
}
