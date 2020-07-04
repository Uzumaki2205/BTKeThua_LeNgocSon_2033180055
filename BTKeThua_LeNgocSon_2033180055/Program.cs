using BTKeThua_LeNgocSon_2033180055.All_Class_Cargo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKeThua_LeNgocSon_2033180055
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //---------------B1--------------//
            //NhanVien a = new NhanVien("Lê Ngọc Sơn", new DateTime(2000, 12, 10), "nAM", "nv123", "NHÂN VIÊN");
            //a.xuat();

            //---------------B2--------------//
            //SinhVien s = new SinhVien("ND", new DateTime(2012, 11, 23), "Nữ", "2033180055", "s");
            //s.xuat();

            //---------------B3--------------//
            //GiangVien g = new GiangVien("Nguyễn", new DateTime(1999, 4, 12), "Nam", "12312", "phó khoa", 3.3f);
            //g.xuat();

            //GVCH g1 = new GVCH("Giảng viên cơ hữu", new DateTime(1999, 4, 12),
            //    "Nam", "12312", "phó khoa", 3.3f, "thạc sĩ", "không đi học", 301);
            //g1.xuat();

            //GVTG g2 = new GVTG("Giảng viên thỉnh giảng", new DateTime(1999, 4, 12), 
            //    "Nam", "12312", "phó khoa", 3.3f, "thạc sĩ", "không đi học", 301);
            //g2.xuat();

            LstGV lstGV = new LstGV();
            lstGV.ReadXML();

            lstGV.xuatDemGV();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nGiảng viên dạy vượt giờ nhiều nhất");
            lstGV.Tim_GVCH_DayVuotGio_NhieuNhat().xuat();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nTổng tiền vượt giờ (GVCH): " + lstGV.TongTienVuotGio_GVCH());
            Console.WriteLine("\nTổng tiền vượt giờ (GVTG): " + lstGV.TongTienVuotGio_GVTG());


            //---------------B4--------------//
            //NuocGiaiKhat a = new NuocGiaiKhat("H123", "CPU", "s", 2, 12000);
            //a.xuat();

            //---------------B5--------------//
            //DauGoi d = new DauGoi("213", "Clear", "chai", 4, 45000, "nước ngoài");
            //d.xuat();

            Console.ReadKey();
        }
    }
}
