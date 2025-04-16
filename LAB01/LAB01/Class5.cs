using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    internal class Class5
    {
        public void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            try 
            {
                Console.WriteLine("bài tập 5: nhập số nguyên xem có phải số chẵn không ");
                Console.Write("nhập số nguyên: ");
                int soNguyen = int.Parse(Console.ReadLine());
                if (soNguyen %2 ==0)
                {
                    Console.WriteLine($"{soNguyen} là số chẵn");
                }
                else 
                {
                    Console.WriteLine($"{soNguyen} ko phải số lẻ");
                }
            }
            catch(FormatException)
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
