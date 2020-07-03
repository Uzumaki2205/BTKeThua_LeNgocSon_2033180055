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
            //NhanVien a = new NhanVien();
            //a.xuat();

            //NhanVien b = new NhanVien("Le", new DateTime(2000, 4, 12), "Nam", "231312", "S");
            //b.xuat();

            //---------------B2--------------//
            //SinhVien s = new SinhVien("ND", new DateTime(2012, 11, 23), "Nữ" ,"2033180055", "đại học");
            //s.xuat();

            //---------------B3--------------//
            //GiangVien g = new GiangVien("Nguyen", new DateTime(1999, 4, 12), "Nam", "12312", "phó khoa", 3.3f);
            //g.xuat();

            //GVCH g1 = new GVCH();
            //GVTG g2 = new GVTG("s");
            //Console.WriteLine("Tien Vuot Gio = " + g2.TienVuotGio(g));

            LstGV lstGV = new LstGV();
            lstGV.ReadXML();
            lstGV.xuatDemGV();

            Console.ReadKey();
        }
    }
}
