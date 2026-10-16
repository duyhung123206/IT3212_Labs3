using System;

public abstract class TaiLieu
{
    public string MaTaiLieu { get; set; }
    public string TenTaiLieu { get; set; }

    // Phương thức trừu tượng bắt buộc các lớp con phải override
    public abstract void HienThiThongTin();
}

public class Sach : TaiLieu
{
    public string TacGia { get; set; }
    public int SoTrang { get; set; }

    public override void HienThiThongTin()
    {
        Console.WriteLine($"[Sách] Mã: {MaTaiLieu} | Tên: {TenTaiLieu} | Tác giả: {TacGia} | Số trang: {SoTrang}");
    }
}

public class TapChi : TaiLieu
{
    public int SoPhatHanh { get; set; }
    public int ThangPhatHanh { get; set; }

    public override void HienThiThongTin()
    {
        Console.WriteLine($"[Tạp chí] Mã: {MaTaiLieu} | Tên: {TenTaiLieu} | Số PH: {SoPhatHanh} | Tháng: {ThangPhatHanh}");
    }
}

public class LuanVan : TaiLieu
{
    public string NguoiNghienCuu { get; set; }
    public string ChuyenNganh { get; set; }

    public override void HienThiThongTin()
    {
        Console.WriteLine($"[Luận văn] Mã: {MaTaiLieu} | Tên: {TenTaiLieu} | Tác giả: {NguoiNghienCuu} | Ngành: {ChuyenNganh}");
    }
}