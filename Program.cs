using bt1.customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bt1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<KhachHang> danhSachHoaDon = new List<KhachHang>();

            // Thêm khách hàng Việt Nam vào danh sách hoá đơn
            KhachHangVietNam khachVietNam = new KhachHangVietNam
            {
                MaKhachHang = "VN001",
                HoTen = "Nguyen Van A",
                NgayRaHoaDon = new DateTime(2023, 8, 8),
                DoiTuong = KhachHangVietNam.DoiTuongKhachHang.SinhHoat,
                SoLuong = 90,
                DonGia = 1000                           
            };
            danhSachHoaDon.Add(khachVietNam);

            // Thêm khách hàng nước ngoài vào danh sách hoá đơn
            KhachHangNuocNgoai khachNuocNgoai = new KhachHangNuocNgoai
            {
                MaKhachHang = "NN001",
                HoTen = "John Smith",
                NgayRaHoaDon = new DateTime(2023, 8, 8),
                QuocTich = "USA",
                SoLuong = 80,
                DonGia = 2000
            };
            danhSachHoaDon.Add(khachNuocNgoai);

            // In thông tin và thành tiền của các khách hàng
            foreach (var khachHang in danhSachHoaDon)
            {
                Console.WriteLine($"Mã KH: {khachHang.MaKhachHang}");
                Console.WriteLine($"Họ tên: {khachHang.HoTen}");
                Console.WriteLine($"Ngày ra hoá đơn: {khachHang.NgayRaHoaDon.ToString("dd/MM/yyyy")}");

                if (khachHang is KhachHangVietNam)
                {
                    var khachHangVietNam = khachHang as KhachHangVietNam;
                    Console.WriteLine($"Đối tượng: {khachVietNam.DoiTuong}");
                    Console.WriteLine($"Số lượng: {khachVietNam.SoLuong}");
                    Console.WriteLine($"Đơn giá: {khachVietNam.DonGia}");
                    Console.WriteLine($"Thành tiền: {khachVietNam.TinhThanhTien()}");
                }
                else if (khachHang is KhachHangNuocNgoai)
                {
                    var khachHanNuocNgoai = khachHang as KhachHangNuocNgoai;
                    Console.WriteLine($"Quốc tịch: {khachNuocNgoai.QuocTich}");
                    Console.WriteLine($"Số lượng: {khachNuocNgoai.SoLuong}");
                    Console.WriteLine($"Đơn giá: {khachNuocNgoai.DonGia}");
                    Console.WriteLine($"Thành tiền: {khachNuocNgoai.TinhThanhTien()}");
                }
                Console.WriteLine();
            }
        }
    }
}
