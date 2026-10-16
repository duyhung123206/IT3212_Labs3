using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        SinhVien sv = new SinhVien("24001296", "Nguyễn Duy Hưng", new DateTime(2006, 1, 1), 8.8);

        Console.WriteLine("--- KIỂM TRA GHI ĐÈ PHƯƠNG THỨC (OVERRIDE) ---");
        sv.HienThi();

        Console.ReadKey();
    }
}