using System;

public class SinhVien : Nguoi
{
    public string MaSV { get; set; }
    public double DiemTB { get; set; }

    public SinhVien(string ma, string ten, DateTime ngaySinh, double diem)
        : base(ten, ngaySinh)
    {
        MaSV = ma;
        DiemTB = diem;
    }

    public void HienThi()
    {
        Console.WriteLine($"Mã SV: {MaSV} - Họ tên: {HoTen} - Ngày sinh: {NgaySinh:dd/MM/yyyy} - Điểm TB: {DiemTB}");
    }
}
