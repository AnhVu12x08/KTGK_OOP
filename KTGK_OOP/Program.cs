using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTGK_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //NhaTro nhaTro = new NhaTro();
            //nhaTro.Xuat();
            KhuTro khuTro = new KhuTro();
            khuTro.DocXml("C:\\Users\\admin\\source\\repos\\KTGK_OOP\\KTGK_OOP\\khutro.xml");
            khuTro.Xuat();
            Console.WriteLine("======================================================");
            Console.WriteLine("Tong tien: " + khuTro.TinhTongTien());
            //khuTro.SapXep();
            Console.ReadKey();  
        }
    }
}





