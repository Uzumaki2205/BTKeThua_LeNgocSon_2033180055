using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BTKeThua_LeNgocSon_2033180055
{
    class LstGV
    {
        ArrayList listGV = new ArrayList();
        ArrayList listGVCH = new ArrayList();
        ArrayList listGVTG = new ArrayList();

        string fileName = "D:\\CODE\\C#\\C# Tutorial\\BTKeThua_LeNgocSon_2033180055\\BTKeThua_LeNgocSon_2033180055\\Class Nguoi\\GV\\ThongTinGV.xml";
        string type;

        public ArrayList ListGV { get => listGV; set => listGV = value; }
        public ArrayList ListGVCH { get => listGVCH; set => listGVCH = value; }
        public ArrayList ListGVTG { get => listGVTG; set => listGVTG = value; }

        public void ReadXML()
        {
            Console.Write("\n--------------READ XML FILE------------\n");
            
            XmlDocument reader = new XmlDocument();
            reader.Load(fileName);
            
            foreach (XmlNode node in reader.DocumentElement.ChildNodes)
            {
                GVTG a = new GVTG();
                
                a.Hoten = node["Name"].InnerText;
                XmlNodeList lstBirthday = node["BirthDay"].ChildNodes;
                a.Ngaysinh = new DateTime(
                    int.Parse(lstBirthday[2].InnerText),
                    int.Parse(lstBirthday[1].InnerText),
                    int.Parse(lstBirthday[0].InnerText)
                    );
                a.Gioitinh = node["Sex"].InnerText;
                a.Id = node["ID"].InnerText;
                a.ChucVu = node["Role"].InnerText;
                a.HeSo = float.Parse(node["Figure"].InnerText);

                type = node["Type"].InnerText;

                a.TrinhDo = node["Level"].InnerText;
                a.DiHoc = node["IsGoScholl"].InnerText;
                a.SoGio = int.Parse(node["Hours"].InnerText);

                if (type == "giảng viên cơ hữu")
                {
                    GVCH b = new GVCH(a);

                    ListGVCH.Add(b);
                    ListGV.Add(b);
                    b.xuat();
                }
                else
                {
                    ListGVTG.Add(a);
                    ListGV.Add(a);
                    a.xuat();
                }
                Console.WriteLine(type);
            }
        }

        public void xuatDemGV()
        {
            Console.WriteLine("Giáo viên cơ hữu: " + listGVCH.Count);
            Console.WriteLine("Giáo viên thỉnh giảng: " + listGVTG.Count);
        }

        public float TongTienVuotGio_GVCH()
        {
            float temp = 0;

            foreach (GiangVien item in ListGVCH)
            {
                temp = temp + item.TienVuotGio();
            }
            return temp;
        }

        public float TongTienVuotGio_GVTG()
        {
            float temp = 0;

            foreach (GVTG item in ListGVTG)
            {
                temp = temp + item.TienVuotGio();
            }
            return temp;
        }

        public GVCH Tim_GVCH_DayVuotGio_NhieuNhat()
        {
            GVCH g = new GVCH();
            foreach (GVCH item in listGVCH)
            {
                if (g.SoGio <= item.SoGio)
                    g = item;
            }
            return g;
        }

        public void Tim_GVCH_DayThieuGio()
        {
            foreach (GVCH item in listGVCH)
            {
                if (item.TienVuotGio() == 0)
                    item.xuat();
            }
        }

        public void DemGV()
        {
            int cn = 0;
            int ths = 0;
            int ts = 0;
            foreach (GVCH item in listGV)
            {
                if (item.TrinhDo == "cử nhân")
                    cn++;
                else if (item.TrinhDo == "thạc sĩ")
                    ths++;
                else ts++;
            }
            Console.WriteLine("Cử nhân = " + cn);
            Console.WriteLine("Thạc sĩ = " + ths);
            Console.WriteLine("Tiến sĩ = " + ts);
        }

        //public void Tim_GVCH_TienVuotGio_MAX_MIN()
        //{
        //    GVTG g = new GVTG(a);
        //    GVTG g1 = new GVTG(a);
        //    foreach (GVTG item in listGV)
        //    {
        //        if (g.TienVuotGio() <= item.TienVuotGio())
        //            g = item;
        //        if (g.TienVuotGio() > item.TienVuotGio())
        //            g1 = item;
        //    }
        //    Console.WriteLine("/n--------Tien Vuot Gio Nhieu Nhat-----------\n");
        //    g.xuat();
        //    Console.WriteLine("/n--------Tien Vuot Gio It Nhat-----------\n");
        //    g1.xuat();
        //}
    }
}
