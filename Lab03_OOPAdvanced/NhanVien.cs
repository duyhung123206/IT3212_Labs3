using System;

public abstract class NhanVien
{
    public string MaNV { get; set; }
    public string HoTen { get; set; }
    public double LuongCoBan { get; set; }

    // Phương thức trừu tượng tính lương
    public abstract double TinhLuong();
}

// Nhân viên văn phòng
public class NhanVienVanPhong : NhanVien
{
    public double TroCap { get; set; }

    public override double TinhLuong()
    {
        return LuongCoBan + TroCap;
    }
}

// Nhân viên kinh doanh
public class NhanVienKinhDoanh : NhanVien
{
    public double DoanhThu { get; set; }

    public override double TinhLuong()
    {
        return LuongCoBan + DoanhThu * 0.1; // Thêm 10% hoa hồng doanh thu
    }
}

// Giảng viên
public class GiangVien : NhanVien
{
    public int SoTietDay { get; set; }

    public override double TinhLuong()
    {
        return LuongCoBan + SoTietDay * 100000; // 100,000 VNĐ cho mỗi tiết dạy
    }
}