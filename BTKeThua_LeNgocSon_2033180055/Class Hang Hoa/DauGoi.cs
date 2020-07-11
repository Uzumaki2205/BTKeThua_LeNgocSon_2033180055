using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKeThua_LeNgocSon_2033180055.All_Class_Cargo
{
    class DauGoi : HangHoa
    {
        string dvt;
        int soLuong;
        float donGia;
        string xuatXu;

        public string Dvt 
        {
            get { return dvt; }
            set
            {
                string Lower = value.ToLower();
                if (Lower != "chai" && Lower != "bịch" && Lower != "hộp")
                    dvt = "chai";
                else dvt = value;
            }
        }
        public int SoLuong 
        {
            get { return soLuong; }
            set
            {
                if (value < 0)
                    soLuong = 0;
                else soLuong = value;
            }
        }
        public string XuatXu 
        {
            get { return xuatXu; }
            set
            {
                string Lower = value.ToLower();
                if (Lower != "trong nước" && Lower != "nước ngoài")
                    xuatXu = "trong nước";
                else xuatXu = value;
            }
        }

        public float DonGia 
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public DauGoi(string Id, string TenHang, string Dvt, int SoLuong, float DonGia, string XuatXu)
            : base(Id, TenHang)
        {
            this.Dvt = Dvt;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
            this.XuatXu = XuatXu;
        }

        float checkTien()
        {
            if (dvt == "chai" || dvt == "hộp")
                return soLuong * donGia;
            else return soLuong * donGia / 50;
        }

        public override double ThanhTien()
        {
            if (xuatXu == "trong nước")
                return checkTien();
            else return checkTien() + 0.5f * checkTien();
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Đơn vị tính = " + dvt);
            Console.WriteLine("Số Luọng = " + soLuong);
            Console.WriteLine("Đơn giá = " + donGia);
            Console.WriteLine("Xuất xứ = " + xuatXu);
            Console.WriteLine("Tiền = " + ThanhTien());
        }
    }
}
