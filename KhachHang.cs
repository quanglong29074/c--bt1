using bt1.customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1.customer
{
    public class KhachHang
    {
        public string MaKhachHang { get; set; }
        public string HoTen { get; set; }
        public DateTime NgayRaHoaDon { get; set; }
    }

    public class KhachHangVietNam : KhachHang
    {
        public enum DoiTuongKhachHang
        {
            SinhHoat,
            KinhDoanh,
            SanXuat
        }

        public DoiTuongKhachHang DoiTuong { get; set; }
        public double SoLuong { get; set; }
        public double DonGia { get; set; }

        public double TinhThanhTien()
        {
            double thanhTien = 0;
            double donGiaMoi = 0;
           

            if (SoLuong <= 50)
            {
                
                donGiaMoi = 1000;
                thanhTien = SoLuong * donGiaMoi;
            }
            else if (SoLuong <= 100)
            {
                
                donGiaMoi = 1200;
                thanhTien =50000 + (SoLuong - 50) * donGiaMoi;
            }
            else if (SoLuong <= 200)
            {
                
                donGiaMoi = 1500;
                thanhTien = 110000 + (SoLuong - 100) * donGiaMoi;
            }
            else
            {
               
                donGiaMoi = 2000;
                thanhTien = 260000 + (SoLuong - 200) * donGiaMoi;
            }


            return thanhTien;
        }
    }

    public class KhachHangNuocNgoai : KhachHang
    {
        public string QuocTich { get; set; }
        public double SoLuong { get; set; }
        public double DonGia { get; set; }

        public double TinhThanhTien()
        {
            return SoLuong * DonGia;
        }
    }
}

 


