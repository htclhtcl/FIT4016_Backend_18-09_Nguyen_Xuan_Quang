using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            // In số lẻ từ 1 đến 20
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                    continue;

                Console.Write(i + " ");
            }

            Console.WriteLine();

            // Tìm số 7
            int[] arr = { 2, 5, 7, 1, 9, 7, 3 };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 7)
                {
                    Console.WriteLine("Tìm thấy số 7 tại vị trí " + i);
                    break;
                }
            }
        }
    }
}
