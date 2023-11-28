using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace KTGK_OOP
{
    internal class KhuTro
    {
        string tenKhuTro;
        string diaChi;

        List<NhaTro> dsNhaTro;
        public KhuTro()
        {
            dsNhaTro = new List<NhaTro>();
        }
        public List<NhaTro> DsNhaTro
        {
            get => dsNhaTro;
            set => dsNhaTro = value;
        }
        public string TenKhuTro
        {
            get => tenKhuTro;
            set => tenKhuTro = value;
        }
        public string DiaChi
        {
            get => diaChi;
            set => diaChi = value;
        }
        public void DocXml(string filepath)
        {
            XmlDocument read = new XmlDocument();
            read.Load(filepath);

            ///////////////BUG HERE/////////////////////

            //XmlNodeList nod = read.SelectSingleNode("/khutro");
            //string tenKhuTro = nod.["ten"];
            //string diaChi = nod.SelectSingleNode[0]("diachi").InnerText;

            XmlNodeList dsTro = read.SelectNodes("/khutro/phongs/phong");
            foreach (XmlNode node in dsTro)
            {
                int MayLanh = int.Parse(node["loai"].InnerText);
                string MaPhong = node["map"].InnerText;
                int SoLuongKhach = int.Parse(node["soluong"].InnerText);
                int SoDien = int.Parse(node["sodien"].InnerText);
                double GiaThue = double.Parse(node["gia"].InnerText);
                NhaTro nhaTro = new NhaTro(MaPhong, SoLuongKhach, GiaThue, SoDien, MayLanh);
                this.dsNhaTro.Add(nhaTro);
            }
        }
        public void Xuat()
        {
            Console.WriteLine("Ten khu tro: " + tenKhuTro);
            Console.WriteLine("Dia chi: " + diaChi);
            foreach (NhaTro nhaTro in dsNhaTro)
            {
                nhaTro.Xuat();
            }
        }
        public double TinhTongTien()
        {
            double tongTien = 0;
            foreach (NhaTro nhaTro in dsNhaTro)
            {
                tongTien += nhaTro.TinhTienPhong();
            }
            return tongTien;
        }
        public void SapXep()
        {
            dsNhaTro.Sort((x, y) => x.TinhTienPhong().CompareTo(y.TinhTienPhong()));
        }






    }



}
