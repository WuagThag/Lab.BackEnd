using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    internal class Class3
    {
        public void Run()
        {
            try
            {
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("Bài tập 3: Tính diện tích hình chữ nhật");
            Console.WriteLine("nhập chiều dài :");
            double cdai=double.Parse(Console.ReadLine());
            Console.WriteLine("nhập chiều rộng :");
            double crong = double.Parse(Console.ReadLine());
                if(cdai<=0 || crong <= 0)
                {
                    throw new Exception("chiều dài và chiều rộng phải lớn hơn 0");

                }
                else
                {
                    double dtich = cdai * crong;
                    Console.WriteLine($"Diện tích hình chữ nhật có chiều dài {cdai} và chiều rộng {crong} là: {dtich}");
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
