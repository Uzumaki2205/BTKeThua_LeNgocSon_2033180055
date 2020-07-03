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

        internal List<GiangVien> ListGV { get => listGV; set => listGV = value; }
        internal List<GVCH> ListGVCH { get => listGVCH; set => listGVCH = value; }
        internal List<GVTG> ListGVTG { get => listGVTG; set => listGVTG = value; }

        string fileName = "D:\\CODE\\C#\\C# Tutorial\\BTKeThua_LeNgocSon_2033180055\\BTKeThua_LeNgocSon_2033180055\\All Class People\\ThongTinGV.xml";
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
                // first node is the url ... have to go to nexted loc node 
                //foreach (XmlNode locNode in node)
                //{
                //    // there are a couple child nodes here so only take data from node named loc 
                //    if (locNode.Name == "Name")
                //    {
                //        // get the content of the loc node 
                //        string loc = locNode.InnerText;
                //    } 
                //}

                GiangVien a = new GiangVien();
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
                    GVCH g = new GVCH();

                    g.TrinhDo = node["Level"].InnerText;
                    g.DiHoc = node["IsGoScholl"].InnerText;
                    g.SoGio = int.Parse(node["Hours"].InnerText);
                    ListGVCH.Add(g);
                    Console.WriteLine("\nTiền Vượt Giờ (GVCH) = " + g.TienVuotGio(a));
                }  
                else if (type == "giảng viên thỉnh giảng")
                {
                    demtg++;
                    GVTG g = new GVTG();

                    g.TrinhDo = node["Level"].InnerText;
                    ListGVTG.Add(g);
                    Console.WriteLine("\nTiền Vượt Giờ (GVTG) = " + g.TienVuotGio(a));
                }

                ListGV.Add(a);
                a.xuat();
            }
        }

        public void xuatDemGV()
        {
            Console.WriteLine("Giáo viên thỉnh giảng: " + demtg);
            Console.WriteLine("Giáo viên cơ hữu: " + demch);
        }

        public GiangVien Tim_GVCH_DayVuotGio_NhieuNhat()
        {
            
            int max = 0;
            GiangVien temp = new GiangVien();
           
            XmlDocument reader = new XmlDocument();
            reader.Load(fileName);
            foreach (XmlNode node in reader.DocumentElement.ChildNodes)
            {
                GiangVien a = new GiangVien();
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

                GVCH g = new GVCH();

                if (node["Type"].InnerText == "giảng viên cơ hữu")
                {
                    g.SoGio = int.Parse(node["Hours"].InnerText);

                    if (max <= g.SoGio)
                    {
                        max = g.SoGio;
                        temp = a;
                    }
                }
            }
            return temp;
        }
    }
}
