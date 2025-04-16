using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    internal class Class11
    {
        public void Run()
        {
            Console.OutputEncoding =Encoding.UTF8;
            Console.WriteLine("Bài tập 11: kiểm tra n có phải số nguyên tố ?");
            try
            {
                Console.WriteLine("Nhập số nguyên dương  n:");
                int n = int.Parse(Console.ReadLine());  
                if (n < 2)
                {
                    throw new Exception("Số nguyên tố phải lớn hơn 1.");
                }
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine($"{n} là số nguyên tố.");
                }
                else
                {
                    Console.WriteLine($"{n} không phải là số nguyên tố.");
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
