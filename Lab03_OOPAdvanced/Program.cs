using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Hỗ trợ hiển thị tiếng Việt có dấu trong Console
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("--- HỆ THỐNG NHÂN VIÊN - TÍNH LƯƠNG ĐA HÌNH ---");

        List<NhanVien> danhSachNV = new List<NhanVien>
        {
            new NhanVienVanPhong { MaNV = "VP01", HoTen = "Nguyễn Văn An", LuongCoBan = 5000000, TroCap = 1500000 },
            new NhanVienKinhDoanh { MaNV = "KD01", HoTen = "Trần Thị Bình", LuongCoBan = 4500000, DoanhThu = 60000000 },
            new GiangVien { MaNV = "GV01", HoTen = "Nguyễn Duy Hưng", LuongCoBan = 6000000, SoTietDay = 45 }
        };

        foreach (var nv in danhSachNV)
        {
            // Tính lương đa hình tùy thuộc vào kiểu thực tế của đối tượng
            Console.WriteLine($"Mã: {nv.MaNV} | Họ tên: {nv.HoTen} | Loại: {nv.GetType().Name} | Lương thực lĩnh: {nv.TinhLuong():N0} VNĐ");
        }

        Console.ReadKey();
    }
}