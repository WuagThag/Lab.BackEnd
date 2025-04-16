using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    internal class Class9
    {
        public void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 9: viết chương trình in ra bảng cửu chương từ 1 đến 10");
            try
            {
                Console.WriteLine("Nhập số cần in bảng cửu chương:");
                int so = int.Parse(Console.ReadLine());
                if (so < 1 || so > 10)
                {
                    throw new Exception("Số phải nằm trong khoảng từ 1 đến 10.");
                }
                else
                {
                    Console.WriteLine($"Bảng cửu chương của {so}:");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{so} x {i} = {so * i}");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Lỗi: Vui lòng nhập số nguyên hợp lệ!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi không xác định: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Kết thúc chương trình.");
            }
        }
    }
}
