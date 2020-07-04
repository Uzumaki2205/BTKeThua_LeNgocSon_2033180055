using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BTKeThua_LeNgocSon_2033180055
{
    class LstGV
    {
        List<GiangVien> listGV = new List<GiangVien>();
        List<GVCH> listGVCH = new List<GVCH>();
        List<GVTG> listGVTG = new List<GVTG>();

        GiangVien a = new GiangVien();

        internal List<GiangVien> ListGV { get => listGV; set => listGV = value; }
        internal List<GVCH> ListGVCH { get => listGVCH; set => listGVCH = value; }
        internal List<GVTG> ListGVTG { get => listGVTG; set => listGVTG = value; }

        string fileName = "D:\\CODE\\C#\\C# Tutorial\\BTKeThua_LeNgocSon_2033180055\\BTKeThua_LeNgocSon_2033180055\\Class Nguoi\\GV\\ThongTinGV.xml";
        string type;
        int demtg = 0;
        int demch = 0;
        public void ReadXML()
        {
            Console.Write("\n--------------READ XML FILE------------\n");
            
            XmlDocument reader = new XmlDocument();
            reader.Load(fileName);
            
            foreach (XmlNode node in reader.DocumentElement.ChildNodes)
            {
                
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

                
                if (type == "giảng viên cơ hữu")
                {
                    demch++;
                    GVCH g = new GVCH(a);

                    g.TrinhDo = node["Level"].InnerText;
                    g.DiHoc = node["IsGoScholl"].InnerText;
                    g.SoGio = int.Parse(node["Hours"].InnerText);

                    Console.WriteLine("\nTiền Vượt Giờ (GVCH) = " + g.TienVuotGio());

                    listGVCH.Add(g);
                }  
                else if (type == "giảng viên thỉnh giảng")
                {
                    demtg++;
                    GVTG g = new GVTG(a);
                    

                    g.TrinhDo = node["Level"].InnerText;
                    g.DiHoc = node["IsGoScholl"].InnerText;
                    Console.WriteLine("\nTiền Vượt Giờ (GVTG) = " + g.TienVuotGio());

                    listGVTG.Add(g);
                }

                ListGV.Add(a);
                //a.xuat();
            }
        }

        public void xuatDemGV()
        {
            Console.WriteLine("Giáo viên thỉnh giảng: " + demtg);
            Console.WriteLine("Giáo viên cơ hữu: " + demch);
        }

        public double TongTienVuotGio_GVCH()
        {
            double temp = 0;

            XmlDocument reader = new XmlDocument();
            reader.Load(fileName);

            //foreach (XmlNode node in reader.DocumentElement.ChildNodes)
            //{
            //    if (node["Type"].InnerText == "giảng viên cơ hữu")
            //    {
                    foreach (GVCH item in listGVCH)
                    {
                        temp = temp + item.TienVuotGio();
                    }
            //    }
            //}
            return temp;
        }

        public double TongTienVuotGio_GVTG()
        {
            double temp = 0;
                
            //XmlDocument reader = new XmlDocument();
            //reader.Load(fileName);

            //foreach (XmlNode node in reader.DocumentElement.ChildNodes)
            //{
            //    if (node["Type"].InnerText == "giảng viên thỉnh giảng")
            //    {
                    foreach (GVTG item in listGVTG)
                    {
                        temp = temp + item.TienVuotGio();
                    }
            //    }   
            //}
            return temp;
        }

        public GVCH Tim_GVCH_DayVuotGio_NhieuNhat()
        {
            //ReadXML();
            GVCH g = new GVCH(a);
            foreach (GVCH item in listGVCH)
            {
                if (g.SoGio <= item.SoGio)
                    g = item;
            }
            return g;
        }
    }
}
