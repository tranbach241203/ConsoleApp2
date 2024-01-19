using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvn
{

    public class SanPham //MaSanPham, TenSanPham, DonGia, SoLuong

    {
        // bài 1
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }

        // bài 2
        public SanPham()
        {

        }

        public SanPham(int maSanPham, string tenSanPham, double donGia, int soLuong)
        {
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            DonGia = donGia;
            SoLuong = soLuong;
        }
        // bài 3
        public void NhapThongTin()
        {
            Console.Write("Nhập đơn giá: ");
            double donGia = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập số lượng: ");
            int soLuong = Convert.ToInt32(Console.ReadLine());


        }
        public double TinhTien()
        {

            var tien = DonGia * SoLuong;
            //Console.WriteLine("Thành tiền" + tien);
            return TinhTien();
        }

        public void XuatThongTin()
        {

            Console.WriteLine("Mã sản phẩm: " + MaSanPham);
            Console.WriteLine("Tên sản phẩm: " + TenSanPham);
            Console.WriteLine("Đơn giá: " + DonGia);
            Console.WriteLine("Số lượng: " + SoLuong);
            Console.WriteLine("Thành tiền: " + TinhTien());
        }
    }


}
