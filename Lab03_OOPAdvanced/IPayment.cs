using System;

public interface IPayment
{
    bool ProcessPayment(decimal amount);
}

public class ThanhToanTienMat : IPayment
{
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"[Tiền mặt] Thanh toán thành công {amount:N0} VNĐ trực tiếp tại quầy.");
        return true;
    }
}

public class ChuyenKhoan : IPayment
{
    public string SoTaiKhoanNganHang { get; set; }

    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"[Chuyển khoản] Thanh toán thành công {amount:N0} VNĐ qua số tài khoản: {SoTaiKhoanNganHang}.");
        return true;
    }
}

public class ViDienTu : IPayment
{
    public string SoDienThoaiVi { get; set; }

    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"[Ví điện tử] Thanh toán thành công {amount:N0} VNĐ qua số điện thoại ví: {SoDienThoaiVi}.");
        return true;
    }
}