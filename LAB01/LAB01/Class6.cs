using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    internal class Class6
    {
        public void Run()
        {
            try
            {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 6: tính tổng và tích  của hai số ");
            Console.WriteLine("Nhập số thứ nhất:");
            int so1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số thứ hai:");
            int so2 = int.Parse(Console.ReadLine());
            double tong = so1 + so2;
            double tich = so1 * so2;
            Console.WriteLine($"Tổng của {so1} và {so2} là: {tong}");
            Console.WriteLine($"Tích của {so1} và {so2} là: {tich}");
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
