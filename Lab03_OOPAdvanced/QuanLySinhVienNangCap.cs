using System;
using System.Collections.Generic;

namespace Lab03_OOPAdvanced
{
    // 1. Khai báo Interface IPrintable
    public interface IPrintable
    {
        string ToDisplayText();
    }

    // 2. Lớp cơ sở trừu tượng NguoiHoc
    public abstract class NguoiHoc
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public double DiemTB { get; set; }

        public abstract string LoaiSinhVien();
    }

    // 3. Lớp SinhVienChinhQuy kế thừa NguoiHoc và thực thi IPrintable
    public class SinhVienChinhQuy : NguoiHoc, IPrintable
    {
        public override string LoaiSinhVien() => "Chính quy";

        public string ToDisplayText()
        {
            return $"[Chính quy] Mã: {MaSV} - Họ tên: {HoTen} - Điểm TB: {DiemTB:N2}";
        }
    }

    // 4. Lớp SinhVienLienThong kế thừa NguoiHoc và thực thi IPrintable
    public class SinhVienLienThong : NguoiHoc, IPrintable
    {
        public override string LoaiSinhVien() => "Liên thông";

        public string ToDisplayText()
        {
            return $"[Liên thông] Mã: {MaSV} - Họ tên: {HoTen} - Điểm TB: {DiemTB:N2}";
        }
    }
}