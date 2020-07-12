using BTKeThua_LeNgocSon_2033180055.All_Class_Cargo;
using BTKeThua_LeNgocSon_2033180055.Class_Phong;
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
            //NVHC a = new NVHC("Lê Ngọc Sơn", new DateTime(2000, 12, 10), "naM", "nv123", "NHÂN VIÊN", 2, 17);
            //NVTC a = new NVTC("Lê Ngọc Sơn", new DateTime(2000, 12, 10), "naM", "nv123", "NHÂN VIÊN", 5);
            //NVTV a = new NVTV("Lê Ngọc Sơn", new DateTime(2000, 12, 10), "naM", "nv123", "NHÂN VIÊN", 12);
            //a.xuat();

            //ListNV a = new ListNV();
            //a.ReadXML();

            //a.DemNV();
            //a.Xuat_NVHC_HeSo_1();
            //a.Xuat_Luong_Max().xuat();
            //a.Xuat_Luong_Min().xuat();


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

            //LstGV a = new LstGV();
            //a.ReadXML();
            //Console.ForegroundColor = ConsoleColor.Green;

            //Console.WriteLine("\nTổng tiền vượt giờ GVCH = " + a.TongTienVuotGio_GVCH());
            //Console.WriteLine("\nTổng tiền vượt giờ GVTG = " + a.TongTienVuotGio_GVTG());
            //Console.WriteLine("\n------------------GVCH tiền nhiều nhất--------------------\n");
            //a.Tim_GVCH_DayVuotGio_NhieuNhat().xuat();

            //Console.WriteLine("\n------------------Danh sách giảng viên cơ hữu dạy thiếu giờ quy định--------------------\n");
            //a.Tim_GVCH_DayThieuGio();
            //Console.WriteLine("\n------------------Đếm mỗi loại chức vụ của giảng viên--------------------\n");
            //a.DemGV();

            //Console.WriteLine("\n------------------Đếm giảng viên mỗi loại--------------------\n");
            //a.xuatDemGV();


            //---------------B4--------------//
            //NuocGiaiKhat a = new NuocGiaiKhat("H123", "CPU", "s", 2, 12000);
            //a.xuat();

            //---------------B5--------------//
            //DauGoi d = new DauGoi("213", "Clear", "chai", 4, 45000, "nước ngoài");
            //d.xuat();

            //NuocGiaiKhat n = new NuocGiaiKhat("3123", "Sting", "chai", 5, 40000);
            //n.xuat();
            //NuocGiaiKhat cg = new HH_CoGas("123", "C", "chai", 4, 12000);
            //cg.xuat();
            //NuocGiaiKhat kg = new HH_KhongGas("123", "C", "chai", 4, 12000);
            //kg.xuat();

            //---------------B6--------------//
            Room_A ra = new Room_A("123", 2, 12, 15, 2);
            ra.Xuat();
            Room_B rb = new Room_B("123", 2, 12, 15, 4, 5);
            rb.Xuat();

            Console.ReadKey();
        }
    }
}
