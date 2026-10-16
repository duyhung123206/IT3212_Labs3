using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=== BÀI 9: HỆ THỐNG THANH TOÁN ===");

        // Khởi tạo danh sách thanh toán đa hình thông qua interface IPayment
        List<IPayment> dsThanhToan = new List<IPayment>
        {
            new ThanhToanTienMat(),
            new ChuyenKhoan { SoTaiKhoanNganHang = "1903123456789" },
            new ViDienTu { SoDienThoaiVi = "0987654321" }
        };

        decimal soTienGiaoDich = 750000;

        foreach (var tt in dsThanhToan)
        {
            tt.ProcessPayment(soTienGiaoDich);
        }

        Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục bài 10...");
        Console.ReadKey();
    }
}