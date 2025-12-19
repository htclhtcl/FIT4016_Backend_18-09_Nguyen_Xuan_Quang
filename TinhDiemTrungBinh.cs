using System;

public class TinhDiemTrungBinh
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Chương trình Tính Điểm Trung Bình ---");
        Console.WriteLine("Nhập điểm theo hệ số 10 (từ 0 đến 10).");
        Console.WriteLine("--------------------------------------");

        // Khai báo các biến để lưu trữ điểm
     
        double diemToan = 0;
        double diemLy = 0;
        double diemHoa = 0;

        // 1. Nhập và kiểm tra Điểm Toán
        diemToan = NhapVaKiemTraDiem("Toán");

        // 2. Nhập và kiểm tra Điểm Lý
        diemLy = NhapVaKiemTraDiem("Lý");

        // 3. Nhập và kiểm tra Điểm Hóa
        diemHoa = NhapVaKiemTraDiem("Hóa");
        
        // 4. Tính Điểm Trung Bình (DTB) - giả sử tất cả các môn đều có hệ số 1
        double diemTrungBinh = (diemToan + diemLy + diemHoa) / 3.0;

        // 5. Hiển thị kết quả
        Console.WriteLine("\n--- KẾT QUẢ TÍNH TOÁN ---");
        Console.WriteLine($"Điểm Toán: {diemToan:F2}");
        Console.WriteLine($"Điểm Lý:   {diemLy:F2}");
        Console.WriteLine($"Điểm Hóa:  {diemHoa:F2}");
        Console.WriteLine("--------------------------");
        
        // Hiển thị điểm trung bình với 2 chữ số thập phân
        Console.WriteLine($"ĐIỂM TRUNG BÌNH: {diemTrungBinh:F2}");

        // 6. Xếp loại
        XepLoaiHocSinh(diemTrungBinh);

        Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }

    /// <summary>
    /// Phương thức hỗ trợ nhập điểm và kiểm tra tính hợp lệ (từ 0 đến 10).
    /// </summary>
    /// <param name="tenMonHoc">Tên môn học cần nhập điểm.</param>
    /// <returns>Điểm hợp lệ của môn học.</returns>
    public static double NhapVaKiemTraDiem(string tenMonHoc)
    {
        double diem;
        bool nhapHopLe = false;

        // Vòng lặp while sẽ tiếp tục chạy cho đến khi người dùng nhập điểm hợp lệ
        while (!nhapHopLe)
        {
            Console.Write($"Nhập điểm môn {tenMonHoc}: ");
            string input = Console.ReadLine();

            // Thử chuyển đổi input sang double và kiểm tra điều kiện
            if (double.TryParse(input, out diem))
            {
                if (diem >= 0 && diem <= 10)
                {
                    nhapHopLe = true; // Thoát vòng lặp nếu điểm hợp lệ
                }
                else
                {
                    Console.WriteLine("[LỖI] Điểm phải nằm trong khoảng từ 0 đến 10. Vui lòng nhập lại.");
                }
            }
            else
            {
                Console.WriteLine("[LỖI] Dữ liệu nhập không phải là số. Vui lòng nhập lại.");
            }
        }
        return diem;
    }

    /// <summary>
    /// Phương thức xếp loại học sinh dựa trên điểm trung bình.
    /// </summary>
    /// <param name="dtb">Điểm trung bình.</param>
    public static void XepLoaiHocSinh(double dtb)
    {
        string xepLoai;

        if (dtb >= 9.0)
        {
            xepLoai = "Xuất sắc";
        }
        else if (dtb >= 8.0)
        {
            xepLoai = "Giỏi";
        }
        else if (dtb >= 6.5)
        {
            xepLoai = "Khá";
        }
        else if (dtb >= 5.0)
        {
            xepLoai = "Trung Bình";
        }
        else
        {
            xepLoai = "Yếu";
        }

        Console.WriteLine($"Xếp loại: **{xepLoai}**");
    }
}