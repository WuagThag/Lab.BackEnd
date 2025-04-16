using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    internal class Class2
    {
        public void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            try 
            {
                Console.Write("nhập tên của bạn ");
                string name = Console.ReadLine();
                Console.Write("nhập tuổi của bạn ");
                int age = int.Parse(Console.ReadLine()); 
                if(age<0)
                {
                    throw new ArgumentOutOfRangeException("Tuổi không thể âm.");
                }
                else
                {
                    Console.WriteLine($"Xin chào  {name}");
                    Console.WriteLine($"Tuổi của bạn là: {age}");
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
