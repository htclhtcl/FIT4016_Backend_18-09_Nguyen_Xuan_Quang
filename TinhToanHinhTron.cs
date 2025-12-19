using System;

public class TinhToanHinhTron
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Chương trình Tính Diện tích và Chu vi Hình tròn ---");

        // 1. Khai báo hằng số PI (sử dụng Math.PI có sẵn trong thư viện System)
        // const double PI = 3.14159; 

        // 2. Yêu cầu người dùng nhập bán kính
        Console.Write("Vui lòng nhập bán kính hình tròn (r): ");

        // 3. Đọc dữ liệu nhập vào và chuyển đổi sang kiểu số thực (double)
        // Sử dụng double để có độ chính xác cao hơn
        if (double.TryParse(Console.ReadLine(), out double banKinh))
        {
            // 4. Kiểm tra bán kính phải là số dương
            if (banKinh > 0)
            {
                // 5. Thực hiện tính toán
                // Diện tích (A) = PI * r^2
                double dienTich = Math.PI * banKinh * banKinh;

                // Chu vi (C) = 2 * PI * r
                double chuVi = 2 * Math.PI * banKinh;

                // 6. Hiển thị kết quả
                Console.WriteLine("\n--- Kết quả Tính toán ---");
                Console.WriteLine($"Bán kính (r) đã nhập: {banKinh}");
                Console.WriteLine($"Hằng số PI sử dụng:   {Math.PI}");

                // Sử dụng định dạng ":F2" để hiển thị chỉ 2 chữ số thập phân
                Console.WriteLine($"Diện tích hình tròn (A): {dienTich:F2}");
                Console.WriteLine($"Chu vi hình tròn (C):    {chuVi:F2}");
            }
            else
            {
                Console.WriteLine("\n[LỖI] Bán kính phải là một số dương!");
            }
        }
        else
        {
            Console.WriteLine("\n[LỖI] Dữ liệu nhập vào không hợp lệ. Vui lòng nhập một số.");
        }

        Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
        Console.ReadKey();
    }
}