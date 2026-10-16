using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=== BÀI 7: QUẢN LÝ PHƯƠNG TIỆN ===");

        // Sử dụng danh sách đa hình thông qua interface IMove
        List<IMove> dsPhuongTien = new List<IMove>
        {
            new XeMay { TenXe = "Honda Vision" },
            new OTO { TenXe = "Mazda CX-5" },
            new XeDap { TenXe = "Thống Nhất" }
        };

        foreach (var pt in dsPhuongTien)
        {
            Console.WriteLine($"Loại xe: {pt.GetType().Name,-10} | Tốc độ: {pt.GetSpeed(),5} km/h | Chi phí: {pt.GetOperatingCost(),5:N0} VNĐ/km");
        }

        Console.ReadKey();
    }
}