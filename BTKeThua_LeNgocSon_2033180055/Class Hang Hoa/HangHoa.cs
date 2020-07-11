using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKeThua_LeNgocSon_2033180055.All_Class_Cargo
{
    abstract class HangHoa
    {
        string id;
        string tenHang;

        public string Id 
        {
            get { return id; } 
            set
            {
                if (checkMahang(value) == true) 
                    id = value; 
                else id = "HH001";   
            }
        }
        public string TenHang 
        {
            get { return tenHang; }
            set 
            {
                if (value == string.Empty)
                    tenHang = "Chưa đặt tên";
                else tenHang = value;
            }
        }

        #region Constructor
        public HangHoa()
        {
            Id = "";
            TenHang = "";
        }

        public HangHoa(string Id, string TenHang)
        {
            this.Id = Id;
            this.TenHang = TenHang;
        }
        #endregion

        public virtual void xuat()
        {
            Console.Write("\n---------------\n");
            Console.WriteLine("ID = " + id);
            Console.WriteLine("Tên hàng = " + tenHang);
        }

        bool checkMahang(string s)
        {
            if (s.Length > 5 || s.Length < 5)
            {
                return false;
            }
            else
            {
                if (s.Substring(0, 2) == "HH")
                {
                    try
                    {
                        int.Parse(id.Substring(2, 3));
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                else return false;  
            }
        }

        public abstract double ThanhTien();
    }
}
