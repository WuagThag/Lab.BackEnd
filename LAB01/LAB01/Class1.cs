using System;
using System.Text;

namespace LAB01
{
    class Class1
    {
        public void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                Console.WriteLine("Bài tập 1: Tính khoảng cách giữa 2 điểm");
                Console.WriteLine("Nhập điểm A(x1, y1):");
                Console.Write("- x1: ");
                int x1 = int.Parse(Console.ReadLine());
                Console.Write("- y1: ");
                int y1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Nhập điểm B(x2, y2):");
                Console.Write("- x2: ");
                int x2 = int.Parse(Console.ReadLine());
                Console.Write("- y2: ");
                int y2 = int.Parse(Console.ReadLine());

                double khoangCach = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                Console.WriteLine($"Khoảng cách giữa điểm A({x1}, {y1}) với điểm B({x2}, {y2}) = {khoangCach:F2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Lỗi: Vui lòng nhập số nguyên hợp lệ!");
            }
        }
    }
}