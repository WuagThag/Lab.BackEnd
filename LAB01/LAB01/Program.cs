using System;
using System.Text;

namespace LAB01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Chọn bài tập:");
                Console.WriteLine("1. Tính khoảng cách giữa 2 điểm");
                Console.WriteLine("2. Nhập và hiển thị tên, tuổi");
                Console.WriteLine("3. Tính diện tích hình chữ nhật");
                Console.WriteLine("4. Chuyển đổi nhiệt độ ");
                Console.WriteLine("5. kiểm tra số nguyên ");
                Console.WriteLine("6. Tính tổng và tích của 2 số");
                Console.WriteLine("7. kiểm tra số dương , số âm, số không");
                Console.WriteLine("8. kiểm tra năm nhuận ");
                Console.WriteLine("9.in bảng cửu chương ");
                Console.WriteLine("10. Tính giai thừa của 1 số nguyên dương n");
                Console.WriteLine("11. kiểm tra số nguyên tố ");
                Console.WriteLine("0. Thoát");
                Console.Write("Lựa chọn của bạn: ");

                string luaChon = Console.ReadLine();

                if (luaChon == "1")
                {
                    Console.WriteLine("=== BÀI TẬP 1 ===");
                    Class1 class1 = new Class1();
                    class1.Run();
                }
                else if (luaChon == "2")
                {
                    Console.WriteLine("=== BÀI TẬP 2 ===");
                    Class2 class2 = new Class2();
                    class2.Run();
                }
                else if (luaChon == "3")
                {
                    Console.WriteLine("=== BÀI TẬP 3 ===");
                    Class3 class3 = new Class3();
                    class3.Run();
                }
                else if (luaChon == "4")
                {
                    Console.WriteLine("=== BÀI TẬP 4 ===");
                    Class4 class4 = new Class4();
                    class4.Run();
                }
                else if (luaChon == "5")
                {
                    Console.WriteLine("=== BÀI TẬP 5 ===");
                    Class5 class5 = new Class5();
                    class5.Run();
                }
                else if (luaChon == "6")
                {
                    Console.WriteLine("=== BÀI TẬP 6 ===");
                    Class6 class6 = new Class6();
                    class6.Run();
                }
                else if (luaChon == "7")
                {
                    Console.WriteLine("=== BÀI TẬP 7 ===");
                    Class7 class7 = new Class7();
                    class7.Run();
                }
                else if (luaChon == "8")
                {
                    Console.WriteLine("=== BÀI TẬP 8 ===");
                    Class8 class8 = new Class8();
                    class8.Run();
                }
                else if (luaChon == "9")
                {
                    Console.WriteLine("=== BÀI TẬP 9 ===");
                    Class9 class9 = new Class9();
                    class9.Run();
                }
                else if (luaChon == "10")
                {
                    Console.WriteLine("=== BÀI TẬP 10 ===");
                    Class10 class10 = new Class10();
                    class10.Run();
                }
                else if (luaChon == "11")
                {
                    Console.WriteLine("=== BÀI TẬP 11 ===");
                    Class11 class11 = new Class11();
                    class11.Run();
                }
                else if (luaChon == "0")
                {
                    Console.WriteLine("Tạm biệt!");
                    break;
                }
                else
                {
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                }
                Console.WriteLine("\n====================\n");
            }
        }
    }
}