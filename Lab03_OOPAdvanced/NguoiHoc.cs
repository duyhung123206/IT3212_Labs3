using System;

public abstract class NguoiHoc
{
    public string HoTen { get; set; }
    public int SoTinChi { get; set; }

    // Phương thức trừu tượng buộc các lớp con phải override lại
    public abstract decimal TinhHocPhi();
}

public class SinhVienChinhQuy : NguoiHoc
{
    public override decimal TinhHocPhi()
    {
        return SoTinChi * 450000m;
    }
}

public class SinhVienLienThong : NguoiHoc
{
    public override decimal TinhHocPhi()
    {
        return SoTinChi * 520000m;
    }
}