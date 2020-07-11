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
            get { return dvt; }
            set
            {
                string Lower = value.ToLower();
                if (Lower != "thùng" && Lower != "kết" && Lower != "chai" && Lower != "lon")
                    dvt = "kết";
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
        public float DonGia 
        {
            get { return donGia; }
            set { donGia = value; }
        }


        #region Cosntructor
        public NuocGiaiKhat()
        {
            Dvt = "";
            SoLuong = 0;
            DonGia = 0;
        }
        public NuocGiaiKhat(string Id, string TenHang, string Dvt, int SoLuong, float DonGia)
            : base(Id, TenHang)
        {
            this.Dvt = Dvt;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
        }
        #endregion

        public override double ThanhTien()
        {
            if (Dvt == "kết" || Dvt == "thùng")
                return SoLuong * DonGia;
            else if (Dvt == "chai")
                return SoLuong * DonGia / 20;
            else return SoLuong * DonGia / 24;
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Đơn vị tính = " + dvt);
            Console.WriteLine("Số luọng = " + soLuong);
            Console.WriteLine("Đơn giá = " + donGia);
            Console.WriteLine("Thành Tiền = " + ThanhTien());
        }
    }

    class HH_CoGas : NuocGiaiKhat
    {
        //constructor
        public HH_CoGas(string Id, string TenHang, string Dvt, int SoLuong, float DonGia) 
            : base(Id, TenHang, Dvt, SoLuong, DonGia) { }

        public override double ThanhTien()
        {
            return base.ThanhTien() + base.ThanhTien() * 0.07;
        }
    }

    class HH_KhongGas : NuocGiaiKhat
    {
        //constructor
        public HH_KhongGas(string Id, string TenHang, string Dvt, int SoLuong, float DonGia)
            : base(Id, TenHang, Dvt, SoLuong, DonGia) { }

        public override double ThanhTien()
        {
            return base.ThanhTien() + base.ThanhTien() * 0.02;
        }
    }
}
