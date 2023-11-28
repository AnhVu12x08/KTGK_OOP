using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTGK_OOP
{
    internal class NhaTro
    {
        string maPhong;
        int soLuongKhach;
        double giaThue;
        int soDien;
        int mayLanh;
        static double giaDien = 3500;


        public string MaPhong
        {
            get => maPhong;
            set
            {
                if(value.Length == 4 && value.StartsWith("PT"))
                {
                    maPhong = value;
                }
                else
                {
                    Console.WriteLine("Ma phong khong hop le gan bang PT00");
                    maPhong = "PT00";
                }
            }
        }
        public int SoLuongKhach
        {
            get => soLuongKhach;
            set
            {
                if(value >= 0)
                {
                    soLuongKhach = value;
                }
                else
                {
                    Console.WriteLine("So luong khach khong hop le gan bang 0");
                    soLuongKhach = 0;
                }
            }
        }
        public double GiaThue
        {
            get => giaThue;
            set
            {
                if(value >= 0)
                {
                    giaThue = value;
                }
                else
                {
                    Console.WriteLine("Gia thue khong hop le gan bang 0");
                    giaThue = 0;
                }
            }
        }
        public int SoDien
        {
            get => soDien;
            set
            {
                if(value >= 0)
                {
                    soDien = value;
                }
                else
                {
                    Console.WriteLine("So dien khong hop le gan bang 0");
                    soDien = 0;
                }
            }
        }
        public int MayLanh
        {
            get => mayLanh;
            set
            {
                if(value == 1 || value == 0)
                {
                    mayLanh = value;
                }
                else
                {
                    Console.WriteLine("May lanh khong hop le gan bang 0");
                    mayLanh = 0;
                }
            }
        }
        public NhaTro()
        {
            maPhong = "PT01";
            soLuongKhach = 3;
            giaThue = 1.5;
            soDien = 0;
            mayLanh = 1;
        }
        public NhaTro(string maPhong, int soLuongKhach, double giaThue, int soDien, int mayLanh)
        {
            MaPhong = maPhong;
            SoLuongKhach = soLuongKhach;
            GiaThue = giaThue;
            SoDien = soDien;
            MayLanh = mayLanh;
        }
        public NhaTro(NhaTro nt)
        {
            nt.MaPhong = MaPhong;
            nt.SoLuongKhach = SoLuongKhach;
            nt.GiaThue = GiaThue;
            nt.SoDien = SoDien;
            nt.MayLanh = MayLanh;
        }
        public double PhiMayLanh()
        {
            if(MayLanh == 1)
            {
                return soLuongKhach * 50000;
            }
            else
            {
                return 0;
            }
        }
        public double TinhTienPhong()
        {
            return NhaTro.giaDien * SoDien + GiaThue + PhiMayLanh();
        }
        public void Xuat()
        {
            Console.WriteLine("Ma phong: {0}", MaPhong);
            Console.WriteLine("So luong khach: {0}", SoLuongKhach);
            Console.WriteLine("Gia thue: {0}", GiaThue);
            Console.WriteLine("So dien: {0}", SoDien);
            Console.WriteLine("May lanh: {0}", MayLanh);
            Console.WriteLine("Phi may lanh: {0}", PhiMayLanh());
            Console.WriteLine("Tien phong: {0}", TinhTienPhong());
        }


    }
}
