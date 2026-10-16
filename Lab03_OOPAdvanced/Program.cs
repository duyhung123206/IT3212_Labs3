using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("--- KIỂM TRA INTERFACE VALIDATABLE & PRINTABLE ---");

        // Tạo sinh viên thử nghiệm với dữ liệu hợp lệ
        SinhVien sv1 = new SinhVien("24001296", "Nguyễn Duy Hưng", 8.5);

        if (sv1.IsValid(out string msg))
        {
            Console.WriteLine("Dữ liệu hợp lệ! Thông tin:");
            Console.WriteLine(sv1.ToDisplayText());
        }
        else
        {
            Console.WriteLine($"Lỗi dữ liệu: {msg}");
        }

        // Tạo sinh viên thử nghiệm với điểm sai để test validation
        SinhVien sv2 = new SinhVien("24001297", "Lỗi Điểm", 12.0);

        Console.WriteLine("\nKiểm tra sinh viên dữ liệu lỗi:");
        if (!sv2.IsValid(out string err))
        {
            Console.WriteLine($"Phát hiện lỗi: {err}");
        }

        Console.ReadKey();
    }
}