using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Khởi tạo đối tượng SinhVien (kế thừa thuộc tính của Nguoi thông qua base)
        SinhVien sv = new SinhVien("24001296", "Nguyễn Duy Hưng", new DateTime(2006, 1, 1), 8.8);

        Console.WriteLine("--- KIỂM TRA KẾ THỪA NGUOI - SINHVIEN ---");
        sv.HienThi();

        Console.ReadKey();
    }
}