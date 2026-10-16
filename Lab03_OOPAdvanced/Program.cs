using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=== BÀI 8: QUẢN LÝ TÀI LIỆU THƯ VIỆN ===");

        // Khởi tạo danh sách tài liệu sử dụng tính đa hình của lớp cha TaiLieu
        List<TaiLieu> dsTaiLieu = new List<TaiLieu>
        {
            new Sach { MaTaiLieu = "S01", TenTaiLieu = "Lập trình C# Nâng cao", TacGia = "Đại học Công nghệ Đông Á", SoTrang = 350 },
            new TapChi { MaTaiLieu = "TC01", TenTaiLieu = "Khoa học Công nghệ Thông tin", SoPhatHanh = 15, ThangPhatHanh = 10 },
            new LuanVan { MaTaiLieu = "LV01", TenTaiLieu = "Ứng dụng AI trong nông nghiệp", NguoiNghienCuu = "Nguyễn Duy Hưng", ChuyenNganh = "Công nghệ Thông tin" }
        };

        foreach (var tl in dsTaiLieu)
        {
            tl.HienThiThongTin();
        }

        Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
        Console.ReadKey();
    }
}