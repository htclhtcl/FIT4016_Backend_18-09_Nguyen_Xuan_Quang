using System;

class baitap2
{
    static void Main()
    {
        Console.WriteLine("=== Chương trình Xếp loại Sinh viên ===\n");

        // TODO 1: Khai báo biến thông tin sinh viên
        string hoVaTen = "Nguyễn Văn A";   // Thay bằng tên của bạn
        double diem = 7.5;                 // Thay bằng điểm của bạn

        // TODO 2: In ra thông tin sinh viên
        Console.WriteLine($"Họ tên: {hoVaTen}");
        Console.WriteLine($"Điểm: {diem}\n");

        // TODO 3: Viết cấu trúc if/else if/else để xếp loại
        string xepLoai;

        if (diem >= 8.5)
            xepLoai = "Giỏi";
        else if (diem >= 7.0)
            xepLoai = "Khá";
        else if (diem >= 5.5)
            xepLoai = "Trung bình";
        else
            xepLoai = "Yếu";

        Console.WriteLine($"Xếp loại: {xepLoai}\n");

        // TODO 4: Bảng điểm 3 sinh viên
        string[] tenSV = { "Nguyễn Văn nam", "Trần Thị hoa", "Lê Văn liêm" };
        double[] diemSV = { 8.5, 7.2, 5.8 };

        Console.WriteLine("=== Bảng Điểm ===");

        for (int i = 0; i < tenSV.Length; i++)
        {
            // TODO 5: In ra tên, điểm và xếp loại
            string loai;

            if (diemSV[i] >= 8.5)
                loai = "Giỏi";
            else if (diemSV[i] >= 7.0)
                loai = "Khá";
            else if (diemSV[i] >= 5.5)
                loai = "Trung bình";
            else
                loai = "Yếu";

            Console.WriteLine($"{tenSV[i]} - Điểm: {diemSV[i]} - Xếp loại: {loai}");
        }

        // TODO 6: While loop tính tổng điểm
        double tongDiem = 0;
        int j = 0;

        while (j < diemSV.Length)
        {
            tongDiem += diemSV[j];
            j++; ;decimal;
        }

        Console.WriteLine($"\nTổng điểm: {tongDiem}");
        Console.WriteLine($"Điểm trung bình: {tongDiem / diemSV.Length:F2}");
    }
}