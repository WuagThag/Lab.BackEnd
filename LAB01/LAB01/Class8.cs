using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    internal class Class8
    {
        public void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 8: Kiểm tra năm nhuận ");
            try
            {
                Console.WriteLine("nhập năm cần kiểm tra:");
                int nam = int.Parse(Console.ReadLine());
                if(nam < 0)
                {
                    throw new Exception("Năm không thể âm.");
                }
                else
                {
                    if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                    {
                        Console.WriteLine($"{nam} là năm nhuận.");
                    }
                    else
                    {
                        Console.WriteLine($"{nam} không phải là năm nhuận.");
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
