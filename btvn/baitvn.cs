using btvn;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ArrayList arraylist  = new ArrayList();
            for(int i = 1; i <=3 ; i++)
            {
                SanPham sanPham = new SanPham();
                Console.WriteLine("Nhập mã sản phẩm" + i + ": ");
                sanPham.MaSanPham = int.Parse(Console.ReadLine()); 
                Console.WriteLine("Nhập mã sản phẩm" + i + ": ");
                sanPham.TenSanPham = Console.ReadLine();
                Console.WriteLine("Nhập mã sản phẩm" + i + ": ");
                sanPham.DonGia = Double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập mã sản phẩm" + i + ": ");
                sanPham.SoLuong = int.Parse(Console.ReadLine());
            }
            foreach(SanPham sp in arraylist)
            {
                sp.XuatThongTin();
                Console.WriteLine();
            }

            Console.ReadKey();
        }

       
    }
}
