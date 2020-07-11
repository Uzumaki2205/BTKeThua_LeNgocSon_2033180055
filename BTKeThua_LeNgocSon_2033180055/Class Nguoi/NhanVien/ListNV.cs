using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BTKeThua_LeNgocSon_2033180055
{
    class ListNV
    {
        List<NhanVien> lstNV = new List<NhanVien>();

        public List<NhanVien> LstNV { get => lstNV; set => lstNV = value; }

        string fileName = "D:\\CODE\\C#\\C# Tutorial\\BTKeThua_LeNgocSon_2033180055\\BTKeThua_LeNgocSon_2033180055\\Class Nguoi\\NhanVien\\ThongTinNV.xml";

        public void ReadXML()
        {
            Console.Write("\n--------------READ XML FILE------------\n");

            XmlDocument reader = new XmlDocument();
            reader.Load(fileName);

            foreach (XmlNode node in reader.DocumentElement.ChildNodes)
            {
                NhanVien a = new NVHC();

                a.Hoten = node["Name"].InnerText;
                XmlNodeList lstBirthday = node["Birthday"].ChildNodes;
                a.Ngaysinh = new DateTime(
                    int.Parse(lstBirthday[2].InnerText),
                    int.Parse(lstBirthday[1].InnerText),
                    int.Parse(lstBirthday[0].InnerText)
                    );
                a.Gioitinh = node["Sex"].InnerText;
                a.Id = node["ID"].InnerText;
                a.ChucVu = node["Role"].InnerText;

                string type = node["Type"].InnerText;

                if (type.ToLower() == "nhân viên theo ca")
                {
                    NVTC b = new NVTC((NhanVien)a);
                    b.SoCa = int.Parse(node["Num_Shift"].InnerText);

                    LstNV.Add(b);
                    b.xuat();
                }
                else if (type.ToLower() == "nhân viên thời vụ")
                {
                    NVTV b = new NVTV((NhanVien)a);
                    b.SoSP = int.Parse(node["Num_Product"].InnerText);

                    LstNV.Add(b);
                    b.xuat();
                }
                else
                {
                    NVHC b = new NVHC((NVHC)a);
                    b.HeSoLuong = float.Parse(node["Num_Salary"].InnerText);
                    b.SoNgay = int.Parse(node["Num_Day"].InnerText);
                    b.HeSoTD = b.HeSoTD;

                    LstNV.Add(b);
                    b.xuat();
                }
                Console.WriteLine("Loại Nhân Viên = " + type);
            }
        }

        public void DemNV()
        {
            int hc = 0; 
            int tc = 0; 
            int tv = 0;
            foreach (NhanVien item in LstNV)
            {
                if (item is NVHC)
                    hc++;
                else if (item is NVTC)
                    tc++;
                else tv++;
            }
            Console.WriteLine("\nNhân viên hành chính = " + hc);
            Console.WriteLine("Nhân viên theo ca = " + tc);
            Console.WriteLine("Nhân viên thời vụ = " + tv);
        }

        public void Xuat_NVHC_HeSo_1()
        {
            Console.WriteLine("\n------------Xuất nhân viên hành chính có hệ số 1------------");
            foreach (NhanVien item in lstNV)
            {
                if (item is NVHC)
                {
                    NVHC temp = new NVHC((NVHC)item);
                    if (temp.HeSoTD == 1.0f)
                        item.xuat();
                }    
            }
        }
        public NhanVien Xuat_Luong_Max()
        {
            Console.WriteLine("\n------------Xuất nhân viên lương cao nhất------------");
            NhanVien a = new NVHC();

            for (int i = 0; i < LstNV.Count; i++)
            {
                if (LstNV[i].LuongNV() >= a.LuongNV())
                {
                    if (LstNV[i] is NVHC)
                        a = LstNV[i];
                    else if (LstNV[i] is NVTC)
                        a = (NVTC)LstNV[i];
                    else a = (NVTV)LstNV[i];
                }
            }
            return a;
        }
        public NhanVien Xuat_Luong_Min()
        {
            Console.WriteLine("\n------------Xuất nhân viên lương thấp nhất------------");
            NhanVien a = new NVHC();

            for (int i = 0; i < LstNV.Count; i++)
            {
                if (LstNV[i].LuongNV() <= a.LuongNV())
                {
                    if (LstNV[i] is NVHC)
                        a = LstNV[i];
                    else if (LstNV[i] is NVTC)
                        a = (NVTC)LstNV[i];
                    else a = (NVTV)LstNV[i];
                }
            }
            return a;
        }
    }
}
