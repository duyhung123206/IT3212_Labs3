using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Hỗ trợ hiển thị tiếng Việt có dấu trong Console
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("--- KIỂM TRA DANH SÁCH ĐA HÌNH (POLYMORPHISM) ---");

        // Khởi tạo danh sách chứa các đối tượng kiểu lớp cha NguoiHoc
        List<NguoiHoc> ds = new List<NguoiHoc>();
        ds.Add(new SinhVienChinhQuy { HoTen = "Nguyễn Duy Hưng", SoTinChi = 18 });
        ds.Add(new SinhVienLienThong { HoTen = "Trần Văn Bình", SoTinChi = 15 });

        decimal tong = 0;
        foreach (NguoiHoc item in ds)
        {
            decimal hocPhi = item.TinhHocPhi(); // Tính đa hình tùy thuộc vào loại đối tượng thực tế
            tong += hocPhi;
            Console.WriteLine($"{item.HoTen}: {hocPhi:N0} VNĐ");
        }

        Console.WriteLine($"-----------------------------------");
        Console.WriteLine($"Tổng học phí toàn bộ danh sách: {tong:N0} VNĐ");

        Console.ReadKey();
    }
}