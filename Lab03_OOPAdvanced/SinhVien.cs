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

    // Ghi đè phương thức MoTa và tận dụng base.MoTa()
    public override string MoTa()
    {
        return base.MoTa() + " - " + MaSV + " - " + DiemTB.ToString("N2");
    }

    public void HienThi()
    {
        Console.WriteLine(MoTa());
    }
}