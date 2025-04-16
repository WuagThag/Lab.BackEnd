using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    internal class Class4
    {
        public void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            try 
            {
                Console.WriteLine("Bài tập 4: Chuyển đổi nhiệt độ");    
                Console.WriteLine("Nhập nhiệt độ (độ C):");
                double nhietDoC = double.Parse(Console.ReadLine());
                if(nhietDoC< 0)
                {
                    throw new Exception("Nhiệt độ không thể âm.");
                }
                else
                {
                    double nhietDoF = (nhietDoC * 9 / 5) + 32;
                    Console.WriteLine($"Nhiệt độ {nhietDoC} độ C tương đương với {nhietDoF} độ F.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Lỗi: Vui lòng nhập số thực hợp lệ!");
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
