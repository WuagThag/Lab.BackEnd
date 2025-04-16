using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    internal class Class7
    {
        public void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("bài tập 7:kiểm tra xem là số dương , số âm , số 0");
            try
            {
                Console.Write("nhập số nguyên: ");
                int soNguyen = int.Parse(Console.ReadLine());
                if (soNguyen > 0)
                {
                    Console.WriteLine($"{soNguyen} là số dương");
                }
                else if (soNguyen < 0)
                {
                    Console.WriteLine($"{soNguyen} là số âm");
                }
                else
                {
                    Console.WriteLine($"{soNguyen} là số 0");
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
