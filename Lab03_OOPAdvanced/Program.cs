using System;

class Program
{
    static void Main(string[] args)
    {
        // Hỗ trợ hiển thị tiếng Việt có dấu trong Console
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("--- KIỂM TRA LỚP TRỪU TƯỢNG HỌC PHÍ ---");

        NguoiHoc sv1 = new SinhVienChinhQuy();
        sv1.HoTen = "Nguyễn Duy Hưng";
        sv1.SoTinChi = 15;
        Console.WriteLine($"Sinh viên Chính quy: {sv1.HoTen} - Số tín: {sv1.SoTinChi} - Học phí: {sv1.TinhHocPhi():N0} VNĐ");

        NguoiHoc sv2 = new SinhVienLienThong();
        sv2.HoTen = "Trần Văn A";
        sv2.SoTinChi = 12;
        Console.WriteLine($"Sinh viên Liên thông: {sv2.HoTen} - Số tín: {sv2.SoTinChi} - Học phí: {sv2.TinhHocPhi():N0} VNĐ");

        Console.ReadKey();
    }
}