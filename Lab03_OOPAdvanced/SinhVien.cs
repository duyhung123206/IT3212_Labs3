using System;

public class SinhVien : IValidatable, IPrintable
{
    public string MaSV { get; set; }
    public string HoTen { get; set; }
    public double DiemTB { get; set; }

    public SinhVien(string ma, string hoTen, double diem)
    {
        MaSV = ma;
        HoTen = hoTen;
        DiemTB = diem;
    }

    // Hiện thực hóa interface IValidatable
    public bool IsValid(out string message)
    {
        if (string.IsNullOrWhiteSpace(MaSV))
        {
            message = "Thiếu mã sinh viên";
            return false;
        }
        if (DiemTB < 0 || DiemTB > 10)
        {
            message = "Điểm trung bình không hợp lệ (phải từ 0 đến 10)";
            return false;
        }
        message = "Hợp lệ";
        return true;
    }

    // Hiện thực hóa interface IPrintable
    public string ToDisplayText()
    {
        return $"Mã: {MaSV} - Họ tên: {HoTen} - Điểm TB: {DiemTB:N2}";
    }
}