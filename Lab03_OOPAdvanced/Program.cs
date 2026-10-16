using System;
using System.Collections.Generic;

namespace Lab03_OOPAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hỗ trợ hiển thị tiếng Việt có dấu trong Console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== BÀI 10: NÂNG CẤP QUẢN LÝ SINH VIÊN ===");

            // Khởi tạo danh sách sinh viên đa dạng
            List<NguoiHoc> danhSachSV = new List<NguoiHoc>
            {
                new SinhVienChinhQuy { MaSV = "24001296", HoTen = "Nguyễn Duy Hưng", DiemTB = 8.8 },
                new SinhVienChinhQuy { MaSV = "24001297", HoTen = "Trần Văn An", DiemTB = 6.5 },
                new SinhVienLienThong { MaSV = "24001298", HoTen = "Lê Thị Bình", DiemTB = 7.9 },
                new SinhVienLienThong { MaSV = "24001299", HoTen = "Phạm Hoàng Long", DiemTB = 4.8 }
            };

            // 1. Hiển thị toàn bộ danh sách sinh viên
            Console.WriteLine("\n--- DANH SÁCH TOÀN BỘ SINH VIÊN ---");
            foreach (var sv in danhSachSV)
            {
                if (sv is IPrintable printable)
                {
                    Console.WriteLine(printable.ToDisplayText());
                }
            }

            // 2. Tìm kiếm sinh viên theo Mã SV
            Console.WriteLine("\n--- TÌM KIẾM SINH VIÊN (Mã: 24001296) ---");
            string maCanTim = "24001296";
            var svTimKiem = danhSachSV.Find(s => s.MaSV == maCanTim);
            if (svTimKiem != null && svTimKiem is IPrintable p)
            {
                Console.WriteLine($"Đã tìm thấy: {p.ToDisplayText()}");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên!");
            }

            // 3. Thống kê theo loại hình đào tạo
            Console.WriteLine("\n--- THỐNG KÊ SỐ LƯỢNG THEO LOẠI ---");
            int countChinhQuy = 0;
            int countLienThong = 0;
            foreach (var sv in danhSachSV)
            {
                if (sv is SinhVienChinhQuy) countChinhQuy++;
                else if (sv is SinhVienLienThong) countLienThong++;
            }
            Console.WriteLine($"- Số lượng Sinh viên Chính quy: {countChinhQuy}");
            Console.WriteLine($"- Số lượng Sinh viên Liên thông: {countLienThong}");

            // 4. Thống kê học lực (Đạt >= 5.0 và Chưa đạt < 5.0)
            Console.WriteLine("\n--- THỐNG KÊ KẾT QUẢ HỌC TẬP ---");
            int dat = 0, chuaDat = 0;
            foreach (var sv in danhSachSV)
            {
                if (sv.DiemTB >= 5.0) dat++;
                else chuaDat++;
            }
            Console.WriteLine($"- Số sinh viên đạt yêu cầu (>= 5.0): {dat}");
            Console.WriteLine($"- Số sinh viên chưa đạt (< 5.0): {chuaDat}");

            Console.WriteLine("\n=== HOÀN THÀNH TẤT CẢ CÁC BÀI CỦA LAB 3 ===");
            Console.ReadKey();
        }
    }
}